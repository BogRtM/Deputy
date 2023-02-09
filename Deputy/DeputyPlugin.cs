using BepInEx;
using Deputy.Modules.Survivors;
using R2API.Utils;
using R2API;
using RoR2;
using RoR2.Skills;
using RoR2.UI;
using System.Collections.Generic;
using System.Security;
using System.Security.Permissions;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using System;
using EntityStates.Merc;
using Deputy.Modules;

[module: UnverifiableCode]
[assembly: SecurityPermission(SecurityAction.RequestMinimum, SkipVerification = true)]

namespace Deputy
{
    [BepInDependency("com.bepis.r2api", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("com.DestroyedClone.AncientScepter", BepInDependency.DependencyFlags.SoftDependency)]
    [NetworkCompatibility(CompatibilityLevel.EveryoneMustHaveMod, VersionStrictness.EveryoneNeedSameModVersion)]
    [BepInPlugin(MODUID, MODNAME, MODVERSION)]
    [R2APISubmoduleDependency(new string[]
    {
        "PrefabAPI",
        "LanguageAPI",
        "SoundAPI",
        "UnlockableAPI",
        "DamageAPI"
    })]

    public class DeputyPlugin : BaseUnityPlugin
    {
        // if you don't change these you're giving permission to deprecate the mod-
        //  please change the names to your own stuff, thanks
        //   this shouldn't even have to be said
        public const string MODUID = "com.Bog.Deputy";
        public const string MODNAME = "Deputy";

        public const string MODVERSION = "0.3.0";

        // a prefix for name tokens to prevent conflicts- please capitalize all name tokens for convention
        public const string DEVELOPER_PREFIX = "BOG";

        public static DeputyPlugin instance;

        public static GameObject deputyBodyPrefab;
        public static BodyIndex deputyBodyIndex;

        public static DamageAPI.ModdedDamageType grantDeputyBuff;
        public static DamageAPI.ModdedDamageType resetUtilityOnKill;

        private void Awake()
        {
            instance = this;

            Log.Init(Logger);
            Modules.Config.ReadConfig(this);
            Modules.Assets.Initialize(); // load assets and read config
            Modules.States.RegisterStates(); // register states for networking
            Modules.Buffs.RegisterBuffs(); // add and register custom buffs/debuffs
            Modules.Projectiles.RegisterProjectiles(); // add and register custom projectiles
            Modules.Tokens.AddTokens(); // register name tokens
            Modules.ItemDisplays.PopulateDisplays(); // collect item display prefabs for use in our display rules

            grantDeputyBuff = DamageAPI.ReserveDamageType();
            resetUtilityOnKill = DamageAPI.ReserveDamageType();

            // survivor initialization
            new Modules.Survivors.Deputy().Initialize();

            // now make a content pack and add it- this part will change with the next update
            new Modules.ContentPacks().Initialize();

            Subscriptions();
            Hook();
        }

        private void Subscriptions()
        {
        }

        private void Hook()
        {
            On.RoR2.BodyCatalog.SetBodyPrefabs += BodyCatalog_SetBodyPrefabs;
            On.RoR2.GlobalEventManager.OnHitEnemy += GlobalEventManager_OnHitEnemy;
            On.RoR2.CharacterBody.AddTimedBuff_BuffDef_float += CharacterBody_AddTimedBuff_BuffDef_float;
            On.RoR2.CharacterBody.RecalculateStats += CharacterBody_RecalculateStats;
        }

        private void CharacterBody_RecalculateStats(On.RoR2.CharacterBody.orig_RecalculateStats orig, CharacterBody self)
        {
            orig(self);

            self.moveSpeed *= 1 + (self.GetBuffCount(Modules.Buffs.deputyBuff) * StaticValues.msPerStack);
        }

        private void CharacterBody_AddTimedBuff_BuffDef_float(On.RoR2.CharacterBody.orig_AddTimedBuff_BuffDef_float orig, CharacterBody self, BuffDef buffDef, float duration)
        {
            if(buffDef.buffIndex == Modules.Buffs.deputyBuff.buffIndex)
            {
                if(self.GetBuffCount(buffDef) > 0)
                {
                    foreach(CharacterBody.TimedBuff timedBuff in self.timedBuffs)
                    {
                        if(timedBuff.buffIndex == buffDef.buffIndex)
                        {
                            timedBuff.timer = duration;
                        }
                    }
                }

                if(self.GetBuffCount(buffDef) >= Modules.StaticValues.maxBuffStacks)
                {
                    return;
                }
            }

            orig(self, buffDef, duration);
        }

        private void BodyCatalog_SetBodyPrefabs(On.RoR2.BodyCatalog.orig_SetBodyPrefabs orig, GameObject[] newBodyPrefabs)
        {
            orig(newBodyPrefabs);
            deputyBodyIndex = BodyCatalog.FindBodyIndex(deputyBodyPrefab);
            Log.Warning("Deputy's body index is: " + deputyBodyIndex);
        }

        private void GlobalEventManager_OnHitEnemy(On.RoR2.GlobalEventManager.orig_OnHitEnemy orig, GlobalEventManager self, DamageInfo damageInfo, GameObject victim)
        {
            orig(self, damageInfo, victim);

            if (damageInfo.HasModdedDamageType(grantDeputyBuff) && damageInfo.attacker && !damageInfo.rejected)
            {
                CharacterBody attackerBody = damageInfo.attacker.GetComponent<CharacterBody>();
                if (attackerBody)
                {
                    if (NetworkServer.active)
                    {
                        attackerBody.AddTimedBuff(Modules.Buffs.deputyBuff, Modules.StaticValues.msBuffDuration);
                    }
                }
            }

            /*
            if (damageInfo.attacker)
            {
                CharacterBody attackerBody = damageInfo.attacker.GetComponent<CharacterBody>();
                if (attackerBody)
                {
                    if(attackerBody.bodyIndex == deputyBodyIndex)
                    {
                        if (NetworkServer.active)
                        {
                            attackerBody.AddTimedBuff(Modules.Buffs.deputyBuff, Modules.StaticValues.msBuffDuration);
                        }
                    }
                }
            }
            */
        }
    }
}