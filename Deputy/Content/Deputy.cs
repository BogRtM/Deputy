using BepInEx.Configuration;
using Deputy.Modules.Characters;
using Deputy.Components;
using Skillstates.Deputy;
using RoR2;
using RoR2.Skills;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using R2API;
using UnityEngine.UI;
using EntityStates;
using static RoR2.TeleporterInteraction;

namespace Deputy.Modules.Survivors
{
    internal class Deputy : SurvivorBase
    {
        public override string bodyName => "Deputy";

        public const string DEPUTY_PREFIX = DeputyPlugin.DEVELOPER_PREFIX + "_DEPUTY_BODY_";
        //used when registering your survivor's language tokens
        public override string survivorTokenPrefix => DEPUTY_PREFIX;

        public override BodyInfo bodyInfo { get; set; } = new BodyInfo
        {
            bodyName = "DeputyBody",
            bodyNameToken = DeputyPlugin.DEVELOPER_PREFIX + "_DEPUTY_BODY_NAME",
            subtitleNameToken = DeputyPlugin.DEVELOPER_PREFIX + "_DEPUTY_BODY_SUBTITLE",

            characterPortrait = DeputyAssets.mainAssetBundle.LoadAsset<Texture>("texDeputyIcon"),
            //bodyColor = new Color(62f / 255f, 162f / 255f, 82f / 255f),
            bodyColor = new Color32(225, 193, 0, 255),

            crosshair = Addressables.LoadAssetAsync<GameObject>("RoR2/Base/UI/StandardCrosshair.prefab").WaitForCompletion(),
            podPrefab = RoR2.LegacyResourcesAPI.Load<GameObject>("Prefabs/NetworkedObjects/SurvivorPod"),

            maxHealth = 90f,
            healthGrowth = 27f,
            sortPosition = 3.1f,
            //moveSpeed = 8f,
            cameraParamsDepth = -8.18f
        };

        public override CustomRendererInfo[] customRendererInfos { get; set; } = new CustomRendererInfo[]
        {
                new CustomRendererInfo
                {
                    childName = "BodyMesh"
                },
                new CustomRendererInfo
                {
                    childName = "BeltsMesh",
                },
                new CustomRendererInfo
                {
                    childName = "HatMesh",
                },
                new CustomRendererInfo
                {
                    childName = "ScarfMesh",
                },
                new CustomRendererInfo
                {
                    childName = "GunsMesh",
                },
                new CustomRendererInfo
                {
                    childName = "StarMesh",
                },
                new CustomRendererInfo
                {
                    childName = "VisorMesh",
                },
                new CustomRendererInfo
                {
                    childName = "ShoulderPadsMesh",
                },
                new CustomRendererInfo
                {
                    childName = "CuffsMesh",
                }
        };

        public override UnlockableDef characterUnlockableDef => null;

        public override Type characterMainState => typeof(Skillstates.Deputy.DeputyMainState);

        public override ItemDisplaysBase itemDisplays => new DeputyItemDisplays();

        //if you have more than one character, easily create a config to enable/disable them like this
        public override ConfigEntry<bool> characterEnabledConfig => Modules.Config.CharacterEnableConfig(bodyName);

        private static UnlockableDef masterySkinUnlockableDef;

        public override void InitializeCharacter()
        {
            base.InitializeCharacter();
            DeputyPlugin.deputyBodyPrefab = this.bodyPrefab;

            CharacterBody deputyBody = bodyPrefab.GetComponent<CharacterBody>();
            deputyBody.bodyFlags |= CharacterBody.BodyFlags.SprintAnyDirection;
            //SetCoreTransform();

            bodyPrefab.AddComponent<DeputyAnimatorController>();
            bodyPrefab.AddComponent<ResetUtilityOnKill>();
        }

        private void SetCoreTransform()
        {
            ChildLocator childLocator = bodyPrefab.GetComponentInChildren<ChildLocator>();
            GameObject model = childLocator.gameObject;
            CharacterBody characterBody = bodyPrefab.GetComponent<CharacterBody>();

            Transform baseTransform = childLocator.FindChild("BaseBone");
            model.GetComponent<CharacterModel>().coreTransform = baseTransform;
            characterBody.coreTransform = baseTransform;
        }

        public override void InitializeUnlockables()
        {
            //uncomment this when you have a mastery skin. when you do, make sure you have an icon too
            //masterySkinUnlockableDef = Modules.Unlockables.AddUnlockable<Modules.Achievements.MasteryAchievement>();
        }

        public override void InitializeHitboxes()
        {
            ChildLocator childLocator = bodyPrefab.GetComponentInChildren<ChildLocator>();
            GameObject model = childLocator.gameObject;
            
            Transform dashHitbox = childLocator.FindChild("DashHitbox");
            Modules.Prefabs.SetupHitbox(model, dashHitbox, "Dash");
        }

        public override void InitializeSkills()
        {
            Modules.Skills.CreateSkillFamilies(bodyPrefab);
            string prefix = DeputyPlugin.DEVELOPER_PREFIX;

            #region Primary
            /*
            SkillDef primarySkillDef = Modules.Skills.CreateSkillDef(new SkillDefInfo
            {
                skillName = prefix + "_DEPUTY_BODY_PRIMARY_SHOOT_NAME",
                skillNameToken = prefix + "_DEPUTY_BODY_PRIMARY_SHOOT_NAME",
                skillDescriptionToken = prefix + "_DEPUTY_BODY_PRIMARY_SHOOT_DESCRIPTION",
                skillIcon = Modules.Assets.mainAssetBundle.LoadAsset<Sprite>("texThrustIcon"),
                activationState = new EntityStates.SerializableEntityStateType(typeof(VigorValor)),
                activationStateMachineName = "Weapon",
                baseMaxStock = 1,
                baseRechargeInterval = 0f,
                beginSkillCooldownOnSkillEnd = false,
                canceledFromSprinting = false,
                forceSprintDuringState = false,
                fullRestockOnAssign = true,
                interruptPriority = EntityStates.InterruptPriority.Any,
                resetCooldownTimerOnUse = false,
                isCombatSkill = true,
                mustKeyPress = false,
                cancelSprintingOnActivation = false,
                rechargeStock = 1,
                requiredStock = 1,
                stockToConsume = 1,
                keywordTokens = new string[] {"KEYWORD_AGILE"}
            });
            */

            SteppedSkillDef deputyPrimarySkillDef = ScriptableObject.CreateInstance<SteppedSkillDef>();
            deputyPrimarySkillDef.skillName = prefix + "_DEPUTY_BODY_PRIMARY_SHOOT_NAME";
            deputyPrimarySkillDef.skillNameToken = prefix + "_DEPUTY_BODY_PRIMARY_SHOOT_NAME";
            deputyPrimarySkillDef.skillDescriptionToken = prefix + "_DEPUTY_BODY_PRIMARY_SHOOT_DESCRIPTION";
            deputyPrimarySkillDef.icon = Modules.DeputyAssets.mainAssetBundle.LoadAsset<Sprite>("QuickTriggerIcon");
            deputyPrimarySkillDef.activationState = new EntityStates.SerializableEntityStateType(typeof(TriggerTap));
            deputyPrimarySkillDef.activationStateMachineName = "Weapon";
            deputyPrimarySkillDef.baseMaxStock = 1;
            deputyPrimarySkillDef.baseRechargeInterval = 0f;
            deputyPrimarySkillDef.beginSkillCooldownOnSkillEnd = false;
            deputyPrimarySkillDef.canceledFromSprinting = false;
            deputyPrimarySkillDef.forceSprintDuringState = false;
            deputyPrimarySkillDef.fullRestockOnAssign = true;
            deputyPrimarySkillDef.interruptPriority = EntityStates.InterruptPriority.Any;
            deputyPrimarySkillDef.resetCooldownTimerOnUse = false;
            deputyPrimarySkillDef.isCombatSkill = true;
            deputyPrimarySkillDef.mustKeyPress = false;
            deputyPrimarySkillDef.cancelSprintingOnActivation = false;
            deputyPrimarySkillDef.rechargeStock = 1;
            deputyPrimarySkillDef.requiredStock = 1;
            deputyPrimarySkillDef.stockToConsume = 1;
            deputyPrimarySkillDef.keywordTokens = new string[] { "KEYWORD_AGILE" };


            Modules.Skills.AddPrimarySkills(bodyPrefab, deputyPrimarySkillDef);
            #endregion

            #region Secondary
            SkillDef secondarySkillDef = Modules.Skills.CreateSkillDef(new SkillDefInfo
            {
                skillName = prefix + "_DEPUTY_BODY_SECONDARY_SLING_NAME",
                skillNameToken = prefix + "_DEPUTY_BODY_SECONDARY_SLING_NAME",
                skillDescriptionToken = prefix + "_DEPUTY_BODY_SECONDARY_SLING_DESCRIPTION",
                skillIcon = Modules.DeputyAssets.mainAssetBundle.LoadAsset<Sprite>("GunSlingIcon"),
                activationState = new EntityStates.SerializableEntityStateType(typeof(GunSling)),
                activationStateMachineName = "Weapon",
                baseMaxStock = 1,
                baseRechargeInterval = 8f,
                beginSkillCooldownOnSkillEnd = false,
                canceledFromSprinting = false,
                forceSprintDuringState = false,
                fullRestockOnAssign = true,
                interruptPriority = EntityStates.InterruptPriority.Skill,
                resetCooldownTimerOnUse = false,
                isCombatSkill = true,
                mustKeyPress = false,
                cancelSprintingOnActivation = false,
                rechargeStock = 1,
                requiredStock = 1,
                stockToConsume = 1,
                keywordTokens = new string[] { "KEYWORD_AGILE" }
        });
            Modules.Skills.AddSecondarySkills(bodyPrefab, secondarySkillDef);
            #endregion

            #region Utility
            SkillDef utilitySkillDef = Modules.Skills.CreateSkillDef(new SkillDefInfo
            {
                skillName = prefix + "_DEPUTY_BODY_UTILITY_SHOOTINGSTAR_NAME",
                skillNameToken = prefix + "_DEPUTY_BODY_UTILITY_SHOOTINGSTAR_NAME",
                skillDescriptionToken = prefix + "_DEPUTY_BODY_UTILITY_SHOOTINGSTAR_DESCRIPTION",
                skillIcon = Modules.DeputyAssets.mainAssetBundle.LoadAsset<Sprite>("ShootingStarIcon"),
                activationState = new EntityStates.SerializableEntityStateType(typeof(ShootingStar)),
                activationStateMachineName = "Weapon",
                baseMaxStock = 1,
                baseRechargeInterval = 6f,
                beginSkillCooldownOnSkillEnd = false,
                canceledFromSprinting = false,
                forceSprintDuringState = false,
                fullRestockOnAssign = true,
                interruptPriority = EntityStates.InterruptPriority.PrioritySkill,
                resetCooldownTimerOnUse = false,
                isCombatSkill = true,
                mustKeyPress = true,
                cancelSprintingOnActivation = false,
                rechargeStock = 1,
                requiredStock = 1,
                stockToConsume = 1,
                keywordTokens = new string[] {"KEYWORD_STUNNING"}
            });

            Modules.Skills.AddUtilitySkills(bodyPrefab, utilitySkillDef);
            #endregion

            #region Special
            SkillDef skullCrackerSkillDef = Modules.Skills.CreateSkillDef(new SkillDefInfo
            {
                skillName = prefix + "_DEPUTY_BODY_SPECIAL_SKULLBREAKER_NAME",
                skillNameToken = prefix + "_DEPUTY_BODY_SPECIAL_SKULLBREAKER_NAME",
                skillDescriptionToken = prefix + "_DEPUTY_BODY_SPECIAL_SKULLBREAKER_DESCRIPTION",
                skillIcon = Modules.DeputyAssets.mainAssetBundle.LoadAsset<Sprite>("SkullBreakerIcon"),
                activationState = new EntityStates.SerializableEntityStateType(typeof(CometDash)),
                activationStateMachineName = "Weapon",
                baseMaxStock = 1,
                baseRechargeInterval = 8f,
                beginSkillCooldownOnSkillEnd = false,
                canceledFromSprinting = false,
                forceSprintDuringState = true,
                fullRestockOnAssign = true,
                interruptPriority = EntityStates.InterruptPriority.PrioritySkill,
                resetCooldownTimerOnUse = false,
                isCombatSkill = true,
                mustKeyPress = true,
                cancelSprintingOnActivation = false,
                rechargeStock = 1,
                requiredStock = 1,
                stockToConsume = 1,
                keywordTokens = new string[] { "KEYWORD_HEAVY" }
            });

            SkillDef bulletHeavenSkillDef = Modules.Skills.CreateSkillDef(new SkillDefInfo
            {
                skillName = prefix + "_DEPUTY_BODY_SPECIAL_BULLETHEAVEN_NAME",
                skillNameToken = prefix + "_DEPUTY_BODY_SPECIAL_BULLETHEAVEN_NAME",
                skillDescriptionToken = prefix + "_DEPUTY_BODY_SPECIAL_BULLETHEAVEN_DESCRIPTION",
                skillIcon = Modules.DeputyAssets.mainAssetBundle.LoadAsset<Sprite>("BulletHeavenIcon"),
                activationState = new EntityStates.SerializableEntityStateType(typeof(BulletHeaven)),
                activationStateMachineName = "Weapon",
                baseMaxStock = 1,
                baseRechargeInterval = 10f,
                beginSkillCooldownOnSkillEnd = true,
                canceledFromSprinting = false,
                forceSprintDuringState = false,
                fullRestockOnAssign = true,
                interruptPriority = EntityStates.InterruptPriority.PrioritySkill,
                resetCooldownTimerOnUse = false,
                isCombatSkill = true,
                mustKeyPress = true,
                cancelSprintingOnActivation = false,
                rechargeStock = 1,
                requiredStock = 1,
                stockToConsume = 1
            });
            Modules.Skills.AddSpecialSkills(bodyPrefab, skullCrackerSkillDef, bulletHeavenSkillDef);
            #endregion
        }

        public override void InitializeSkins()
        {
            GameObject model = bodyPrefab.GetComponentInChildren<ModelLocator>().modelTransform.gameObject;
            CharacterModel characterModel = model.GetComponent<CharacterModel>();

            ModelSkinController skinController = model.AddComponent<ModelSkinController>();
            ChildLocator childLocator = model.GetComponent<ChildLocator>();

            SkinnedMeshRenderer mainRenderer = characterModel.mainSkinnedMeshRenderer;

            CharacterModel.RendererInfo[] defaultRenderers = characterModel.baseRendererInfos;

            List<SkinDef> skins = new List<SkinDef>();

            #region DefaultSkin
            SkinDef defaultSkin = Modules.Skins.CreateSkinDef(DeputyPlugin.DEVELOPER_PREFIX + "_DEPUTY_BODY_DEFAULT_SKIN_NAME",
                DeputyAssets.mainAssetBundle.LoadAsset<Sprite>("texMainSkin"), 
                defaultRenderers,
                mainRenderer,
                model);

            skins.Add(defaultSkin);
            #endregion

            skinController.skins = skins.ToArray();
        }
    }
}