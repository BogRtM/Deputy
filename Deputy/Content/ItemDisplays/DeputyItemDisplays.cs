using RoR2;
using System.Collections.Generic;
using UnityEngine;

namespace Deputy.Modules.Characters
{
    internal class DeputyItemDisplays : ItemDisplaysBase
    {

        protected override void SetItemDisplayRules(List<ItemDisplayRuleSet.KeyAssetRuleGroup> itemDisplayRules)
        {
            /*
            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.Hoof,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayHoof"),
childName = "Chest",
localPos = new Vector3(-0.00002F, 0.52257F, -0.00726F),
localAngles = new Vector3(89.30003F, 180F, 0F),
localScale = new Vector3(0.08509F, 0.08509F, 0.07624F),
                            limbMask = LimbFlags.RightCalf
                        }
                    }
                }
            });
            */
            //paste all your displays here
            //sotv item displays not added yet. you can add them yourself from DLC1Content if you like. I believe in ya
            
            #region Vanilla Item Displays
            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Equipment.Jetpack,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayBugWings"),
                            childName = "Stomach1",
localPos = new Vector3(0F, -0.03468F, -0.03589F),
localAngles = new Vector3(0F, 0F, 0F),
localScale = new Vector3(0.10818F, 0.10818F, 0.10818F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Equipment.GoldGat,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayGoldGat"),
childName = "Chest",
localPos = new Vector3(0.11527F, 0.32952F, -0.0718F),
localAngles = new Vector3(26.0584F, 121.5478F, 319.0585F),
localScale = new Vector3(0.07811F, 0.07811F, 0.07811F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Equipment.BFG,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayBFG"),
childName = "Chest",
localPos = new Vector3(0F, 0.13516F, -0.00616F),
localAngles = new Vector3(340.6923F, 16.52236F, 294.04F),
localScale = new Vector3(0.3F, 0.3F, 0.3F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.CritGlasses,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayGlasses"),
childName = "Hat",
localPos = new Vector3(0.00001F, -0.03057F, 0.13352F),
localAngles = new Vector3(16.44563F, 0F, 0F),
localScale = new Vector3(0.22762F, 0.20819F, 0.20819F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.Syringe,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplaySyringeCluster"),
childName = "Pelvis",
localPos = new Vector3(-0.07086F, 0.12893F, 0.13718F),
localAngles = new Vector3(85.04323F, 180F, 180F),
localScale = new Vector3(0.13814F, 0.13814F, 0.13814F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.Behemoth,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayBehemoth"),
childName = "RevolverL",
localPos = new Vector3(0.00628F, 0.35085F, -0.00122F),
localAngles = new Vector3(0F, 180F, 180F),
localScale = new Vector3(0.05899F, 0.05899F, 0.05899F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.Missile,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayMissileLauncher"),
childName = "Hat",
localPos = new Vector3(0F, 0.25517F, -0.13554F),
localAngles = new Vector3(337.2867F, 0F, 0F),
localScale = new Vector3(0.05327F, 0.05327F, 0.05327F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.Dagger,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayDagger"),
childName = "ShoulderR",
localPos = new Vector3(0.04892F, -0.05952F, 0.00658F),
localAngles = new Vector3(356.491F, 15.94448F, 138.9872F),
localScale = new Vector3(0.62653F, 0.62653F, 0.62002F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.ChainLightning,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayUkulele"),
childName = "Chest",
localPos = new Vector3(-0.00835F, 0.08003F, -0.05444F),
localAngles = new Vector3(350.0998F, 187.9801F, 65.08994F),
localScale = new Vector3(0.4749F, 0.4749F, 0.4749F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.GhostOnKill,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayMask"),
childName = "Hat",
localPos = new Vector3(0F, 0.0625F, 0.11779F),
localAngles = new Vector3(347.9618F, 0F, 0F),
localScale = new Vector3(0.32205F, 0.32205F, 0.32205F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.Mushroom,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayMushroom"),
childName = "Scarf5",
localPos = new Vector3(0F, 0F, 0F),
localAngles = new Vector3(90F, 0F, 0F),
localScale = new Vector3(0.0501F, 0.0501F, 0.0501F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.AttackSpeedOnCrit,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayWolfPelt"),
childName = "CalfL",
localPos = new Vector3(-0.02711F, 0.03444F, 0.08615F),
localAngles = new Vector3(284.3801F, 54.69025F, 120.8882F),
localScale = new Vector3(0.22438F, 0.22438F, 0.22438F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.BleedOnHit,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayTriTip"),
childName = "FootL",
localPos = new Vector3(0F, -0.17719F, -0.11586F),
localAngles = new Vector3(69.64299F, 180F, 180F),
localScale = new Vector3(0.31498F, 0.31498F, 0.31498F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.WardOnLevel,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayWarbanner"),
childName = "Hat",
localPos = new Vector3(0.01918F, 0.0319F, -0.10661F),
localAngles = new Vector3(278.4025F, 0F, 90F),
localScale = new Vector3(0.3162F, 0.3162F, 0.3162F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.HealOnCrit,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayScythe"),
childName = "ThighR",
localPos = new Vector3(-0.09929F, 0.18501F, 0.02258F),
localAngles = new Vector3(74.5414F, 338.7426F, 248.0196F),
localScale = new Vector3(0.11562F, 0.11562F, 0.11562F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.HealWhileSafe,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplaySnail"),
childName = "Scarf12",
localPos = new Vector3(0F, 0.12282F, 0F),
localAngles = new Vector3(0F, 0F, 0F),
localScale = new Vector3(0.04802F, 0.04802F, 0.04802F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.Clover,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayClover"),
childName = "Hat",
localPos = new Vector3(-0.10365F, 0.06156F, -0.0534F),
localAngles = new Vector3(358.8618F, 352.718F, 62.89376F),
localScale = new Vector3(0.2749F, 0.2749F, 0.2749F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.BarrierOnOverHeal,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayAegis"),
childName = "UpperArmL",
localPos = new Vector3(0.00587F, 0.11116F, 0.04849F),
localAngles = new Vector3(90F, 180F, 0F),
localScale = new Vector3(0.10262F, 0.10262F, 0.10262F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.GoldOnHit,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayBoneCrown"),
childName = "Hat",
localPos = new Vector3(0F, 0.07491F, -0.00615F),
localAngles = new Vector3(7.42985F, 0F, 0F),
localScale = new Vector3(0.6544F, 0.6544F, 0.6544F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.WarCryOnMultiKill,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayPauldron"),
childName = "ShoulderR",
localPos = new Vector3(0F, 0.12703F, 0.04708F),
localAngles = new Vector3(44.80981F, 0F, 0F),
localScale = new Vector3(0.44233F, 0.44233F, 0.44233F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.SprintArmor,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayBuckler"),
childName = "ForeArmR",
localPos = new Vector3(0F, 0.18286F, 0.01758F),
localAngles = new Vector3(357.9146F, 0.43026F, 258.3396F),
localScale = new Vector3(0.23903F, 0.23903F, 0.23903F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.IceRing,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayIceRing"),
childName = "CalfR",
localPos = new Vector3(0F, 0.43058F, -0.00262F),
localAngles = new Vector3(90F, 0F, 0F),
localScale = new Vector3(0.49437F, 0.49437F, 0.49437F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.FireRing,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayFireRing"),
childName = "CalfL",
localPos = new Vector3(0F, 0.43058F, -0.00262F),
localAngles = new Vector3(90F, 0F, 0F),
localScale = new Vector3(0.49437F, 0.49437F, 0.49437F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.UtilitySkillMagazine,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayAfterburnerShoulderRing"),
                            childName = "ShoulderR",
localPos = new Vector3(-0.02036F, 0.08833F, -0.05268F),
localAngles = new Vector3(303.7435F, 218.8789F, 146.1599F),
localScale = new Vector3(0.4F, 0.4F, 0.4F),
                            limbMask = LimbFlags.None
                        },
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayAfterburnerShoulderRing"),
                            childName = "ShoulderL",
localPos = new Vector3(-0.02036F, 0.08833F, -0.05268F),
localAngles = new Vector3(303.7435F, 218.8789F, 146.1599F),
localScale = new Vector3(0.4F, 0.4F, 0.4F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.JumpBoost,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayWaxBird"),
childName = "Hat",
localPos = new Vector3(0F, -0.22808F, -0.01783F),
localAngles = new Vector3(0F, 0F, 0F),
localScale = new Vector3(0.5253F, 0.5253F, 0.5253F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.ArmorReductionOnHit,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayWarhammer"),
childName = "ThighL",
localPos = new Vector3(0.10751F, 0.07677F, -0.00419F),
localAngles = new Vector3(83.68093F, 37.74179F, 125.298F),
localScale = new Vector3(0.10354F, 0.10354F, 0.10354F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.NearbyDamageBonus,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayDiamond"),
childName = "Hat",
localPos = new Vector3(0F, -0.04155F, 0.1694F),
localAngles = new Vector3(351.927F, 0F, 0F),
localScale = new Vector3(0.02957F, 0.02957F, 0.02957F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.ArmorPlate,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayRepulsionArmorPlate"),
childName = "CalfL",
localPos = new Vector3(0.01565F, 0.23544F, 0.03193F),
localAngles = new Vector3(89.11974F, 180F, 0F),
localScale = new Vector3(0.1971F, 0.1971F, 0.1971F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Equipment.CommandMissile,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayMissileRack"),
childName = "Chest",
localPos = new Vector3(0F, 0.28977F, -0.11346F),
localAngles = new Vector3(59.72916F, 180F, 0F),
localScale = new Vector3(0.24602F, 0.24602F, 0.24602F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.Feather,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayFeather"),
childName = "Hat",
localPos = new Vector3(0.06719F, 0.0103F, 0.07484F),
localAngles = new Vector3(352.0244F, 354.2103F, 313.7527F),
localScale = new Vector3(0.0186F, 0.0186F, 0.0186F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.Crowbar,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayCrowbar"),
childName = "CalfR",
localPos = new Vector3(-0.06424F, 0.25689F, -0.02483F),
localAngles = new Vector3(0F, 180F, 3.85283F),
localScale = new Vector3(0.35237F, 0.35237F, 0.35237F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.FallBoots,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayGravBoots"),
childName = "CalfL",
localPos = new Vector3(-0.0038F, 0.47948F, 0.00088F),
localAngles = new Vector3(5.97399F, 0F, 180F),
localScale = new Vector3(0.10662F, 0.10662F, 0.10662F),
                            limbMask = LimbFlags.None
                        },
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayGravBoots"),
childName = "CalfR",
localPos = new Vector3(-0.0038F, 0.47948F, 0.00088F),
localAngles = new Vector3(5.97399F, 0F, 180F),
localScale = new Vector3(0.10662F, 0.10662F, 0.10662F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.ExecuteLowHealthElite,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayGuillotine"),
childName = "CalfL",
localPos = new Vector3(0.06342F, 0.37099F, 0.01172F),
localAngles = new Vector3(88.10267F, 89.99985F, -0.00015F),
localScale = new Vector3(0.1843F, 0.1843F, 0.1843F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.EquipmentMagazine,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayBattery"),
childName = "ThighR",
localPos = new Vector3(0.03526F, 0.3202F, 0.105F),
localAngles = new Vector3(76.3994F, 51.8548F, 220.4264F),
localScale = new Vector3(0.0773F, 0.0773F, 0.0773F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.NovaOnHeal,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayDevilHorns"),
childName = "Head",
localPos = new Vector3(0.06225F, 0.09044F, 0.01466F),
localAngles = new Vector3(0F, 0F, 21.6694F),
localScale = new Vector3(0.49083F, 0.49083F, 0.49083F),
                            limbMask = LimbFlags.None
                        },
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayDevilHorns"),
childName = "Head",
localPos = new Vector3(-0.06225F, 0.09044F, 0.01466F),
localAngles = new Vector3(0F, 0F, 338.3306F),
localScale = new Vector3(-0.49083F, 0.49083F, 0.49083F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.Infusion,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayInfusion"),
childName = "ThighL",
localPos = new Vector3(0.12603F, 0.22658F, -0.00591F),
localAngles = new Vector3(9.10795F, 279.2624F, 183.3022F),
localScale = new Vector3(0.30707F, 0.30707F, 0.30707F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.Medkit,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayMedkit"),
childName = "Pelvis",
localPos = new Vector3(-0.13442F, 0.05515F, 0.09758F),
localAngles = new Vector3(61.50897F, 149.387F, 6.78687F),
localScale = new Vector3(0.4907F, 0.4907F, 0.4907F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.Bandolier,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayBandolier"),
childName = "Stomach",
localPos = new Vector3(0.00486F, 0.08051F, 0.00738F),
localAngles = new Vector3(289.4498F, 39.5269F, 321.7041F),
localScale = new Vector3(0.2092F, 0.30063F, 0.30063F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.BounceNearby,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayHook"),
childName = "ShoulderL",
localPos = new Vector3(0.04244F, 0.10731F, 0.08239F),
localAngles = new Vector3(317.7864F, 173.5876F, 29.15942F),
localScale = new Vector3(0.214F, 0.214F, 0.214F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.IgniteOnKill,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayGasoline"),
childName = "Pelvis",
localPos = new Vector3(0.04428F, 0.06836F, 0.17972F),
localAngles = new Vector3(64.39038F, 185.6091F, 255.3098F),
localScale = new Vector3(0.38856F, 0.38856F, 0.38856F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.StunChanceOnHit,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayStunGrenade"),
childName = "ThighL",
localPos = new Vector3(-0.05293F, 0.26234F, 0.09918F),
localAngles = new Vector3(82.22206F, 338.252F, 0.00001F),
localScale = new Vector3(0.5672F, 0.5672F, 0.5672F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.Firework,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayFirework"),
childName = "ThighL",
localPos = new Vector3(0.04456F, 0.09827F, 0.08276F),
localAngles = new Vector3(75.65928F, 87.81368F, 93.04655F),
localScale = new Vector3(0.16961F, 0.16961F, 0.16961F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.LunarDagger,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayLunarDagger"),
childName = "ThighR",
localPos = new Vector3(0.04585F, 0.28665F, 0.08862F),
localAngles = new Vector3(32.96812F, 95.36113F, 88.23761F),
localScale = new Vector3(0.19536F, 0.19536F, 0.19536F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.Knurl,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayKnurl"),
childName = "Pelvis",
localPos = new Vector3(-0.03984F, -0.04504F, 0.13044F),
localAngles = new Vector3(87.62603F, 180F, 180F),
localScale = new Vector3(0.03214F, 0.03214F, 0.03214F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.BeetleGland,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayBeetleGland"),
childName = "Pelvis",
localPos = new Vector3(-0.14792F, 0.00324F, 0.05944F),
localAngles = new Vector3(3.36018F, 18.82915F, 186.1783F),
localScale = new Vector3(0.03999F, 0.03999F, 0.03999F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.SprintBonus,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplaySoda"),
childName = "Pelvis",
localPos = new Vector3(-0.11547F, 0.04881F, -0.09435F),
localAngles = new Vector3(79.38181F, 89.63472F, -0.00005F),
localScale = new Vector3(0.22267F, 0.22267F, 0.22267F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.SecondarySkillMagazine,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayDoubleMag"),
childName = "Pelvis",
localPos = new Vector3(0.14089F, -0.03881F, 0.05729F),
localAngles = new Vector3(0F, 0F, 344.8835F),
localScale = new Vector3(0.02884F, 0.02884F, 0.02884F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.StickyBomb,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayStickyBomb"),
childName = "CalfR",
localPos = new Vector3(-0.09453F, 0.14074F, 0.02166F),
localAngles = new Vector3(4.26205F, 9.23519F, 315.7299F),
localScale = new Vector3(0.25841F, 0.25841F, 0.25841F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.TreasureCache,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayKey"),
childName = "ThighR",
localPos = new Vector3(0.09145F, 0.22909F, 0.00663F),
localAngles = new Vector3(1.11911F, 357.1378F, 275.9227F),
localScale = new Vector3(0.71302F, 0.71302F, 0.71302F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.BossDamageBonus,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayAPRound"),
childName = "ThighR",
localPos = new Vector3(-0.12984F, 0.19728F, 0.01816F),
localAngles = new Vector3(277.6334F, 119.0307F, 155.8787F),
localScale = new Vector3(0.3382F, 0.3382F, 0.3382F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.SlowOnHit,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayBauble"),
childName = "Pelvis",
localPos = new Vector3(-0.1422F, 0.17905F, -0.17235F),
localAngles = new Vector3(359.9116F, 359.1554F, 181.7254F),
localScale = new Vector3(0.22389F, 0.22389F, 0.22389F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.ExtraLife,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayHippo"),
childName = "Chest",
localPos = new Vector3(-0.00957F, 0.29254F, -0.11613F),
localAngles = new Vector3(353.6216F, 167.3508F, 355.5629F),
localScale = new Vector3(0.14167F, 0.14167F, 0.14167F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.KillEliteFrenzy,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayBrainstalk"),
childName = "Head",
localPos = new Vector3(0F, 0.12062F, 0F),
localAngles = new Vector3(0F, 0F, 0F),
localScale = new Vector3(0.19748F, 0.19748F, 0.19748F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.RepeatHeal,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayCorpseFlower"),
childName = "Head",
localPos = new Vector3(0.08749F, 0.22864F, -0.05102F),
localAngles = new Vector3(81.12965F, 89.99994F, 342.2757F),
localScale = new Vector3(0.1511F, 0.1511F, 0.1511F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.AutoCastEquipment,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayFossil"),
childName = "Chest",
localPos = new Vector3(-0.03166F, 0.09089F, 0.16337F),
localAngles = new Vector3(51.56982F, 93.43587F, 23.09453F),
localScale = new Vector3(0.20226F, 0.20226F, 0.20226F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.IncreaseHealing,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayAntler"),
childName = "Hat",
localPos = new Vector3(0.07352F, 0.05769F, 0.02666F),
localAngles = new Vector3(0F, 90F, 0F),
localScale = new Vector3(0.2026F, 0.2026F, 0.2026F),
                            limbMask = LimbFlags.None
                        },
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayAntler"),
childName = "Hat",
localPos = new Vector3(-0.07352F, 0.05769F, 0.03011F),
localAngles = new Vector3(0F, 90F, 0F),
localScale = new Vector3(0.2026F, 0.2026F, -0.2026F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.TitanGoldDuringTP,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayGoldHeart"),
childName = "CalfR",
localPos = new Vector3(-0.00001F, 0.14482F, 0.08236F),
localAngles = new Vector3(0F, 0F, 0F),
localScale = new Vector3(0.1191F, 0.1191F, 0.1191F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.SprintWisp,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayBrokenMask"),
childName = "Hat",
localPos = new Vector3(-0.09815F, 0.05316F, 0.0888F),
localAngles = new Vector3(349.7362F, 305.5203F, 0.07843F),
localScale = new Vector3(0.08261F, 0.08261F, 0.08261F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.BarrierOnKill,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayBrooch"),
childName = "Chest",
localPos = new Vector3(0.08743F, 0.1005F, 0.12045F),
localAngles = new Vector3(84.30254F, 26.48929F, 0F),
localScale = new Vector3(0.26912F, 0.26912F, 0.26912F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.TPHealingNova,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayGlowFlower"),
childName = "Hat",
localPos = new Vector3(0.09267F, 0.04843F, 0.11722F),
localAngles = new Vector3(335.0409F, 35.02518F, 3.88912F),
localScale = new Vector3(0.2731F, 0.2731F, 0.0273F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.LunarUtilityReplacement,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayBirdFoot"),
childName = "ShoulderR",
localPos = new Vector3(0F, 0.1528F, 0.0859F),
localAngles = new Vector3(0F, 270F, 240.0813F),
localScale = new Vector3(0.3469F, 0.3469F, 0.3469F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.Thorns,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayRazorwireLeft"),
childName = "UpperArmR",
localPos = new Vector3(-0.01774F, 0F, 0F),
localAngles = new Vector3(270F, 0F, 0F),
localScale = new Vector3(0.36846F, 0.36846F, 0.36846F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.LunarPrimaryReplacement,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayBirdEye"),
childName = "Star",
localPos = new Vector3(0F, 0.01363F, 0F),
localAngles = new Vector3(0F, 0F, 180F),
localScale = new Vector3(0.09774F, 0.09774F, 0.09774F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.NovaOnLowHealth,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayJellyGuts"),
childName = "ThighL",
localPos = new Vector3(-0.01986F, 0.4457F, -0.05285F),
localAngles = new Vector3(333.0461F, 0F, 0F),
localScale = new Vector3(0.06382F, 0.06382F, 0.06382F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.LunarTrinket,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayBeads"),
childName = "Pelvis",
localPos = new Vector3(0.05009F, -0.00779F, -0.08761F),
localAngles = new Vector3(0F, 0F, 78.76961F),
localScale = new Vector3(0.45036F, 0.45036F, 0.45036F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.Plant,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayInterstellarDeskPlant"),
childName = "ThighL",
localPos = new Vector3(0.04254F, 0.28912F, 0.09811F),
localAngles = new Vector3(75.51723F, 34.30521F, 0.00001F),
localScale = new Vector3(0.0429F, 0.0429F, 0.0429F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.Bear,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayBear"),
childName = "Chest",
localPos = new Vector3(-0.06893F, 0.31729F, -0.01275F),
localAngles = new Vector3(350.1292F, 227.233F, 354.5159F),
localScale = new Vector3(0.11724F, 0.11724F, 0.11724F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.DeathMark,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayDeathMark"),
childName = "Chest",
localPos = new Vector3(0.03907F, 0.10596F, 0.15935F),
localAngles = new Vector3(77.91385F, 204.0578F, 182.7039F),
localScale = new Vector3(-0.01487F, -0.01352F, -0.0184F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.ExplodeOnDeath,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayWilloWisp"),
childName = "Pelvis",
localPos = new Vector3(0.06772F, 0.01529F, -0.12684F),
localAngles = new Vector3(0F, 0F, 163.0104F),
localScale = new Vector3(0.0283F, 0.0283F, 0.0283F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.Seed,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplaySeed"),
childName = "Chest",
localPos = new Vector3(-0.08481F, 0.16983F, 0.05853F),
localAngles = new Vector3(346.8543F, 59.54195F, 356.3676F),
localScale = new Vector3(0.0275F, 0.0275F, 0.0275F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.SprintOutOfCombat,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayWhip"),
childName = "Pelvis",
localPos = new Vector3(0.18882F, 0.08079F, 0F),
localAngles = new Vector3(0F, 0F, 152.7885F),
localScale = new Vector3(0.2845F, 0.2845F, 0.2845F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.Phasing,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayStealthkit"),
childName = "ThighR",
localPos = new Vector3(0.01633F, 0.40481F, 0.07507F),
localAngles = new Vector3(271.7917F, 0F, 0F),
localScale = new Vector3(0.16865F, 0.33268F, 0.16865F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.PersonalShield,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayShieldGenerator"),
childName = "Chest",
localPos = new Vector3(0.00254F, 0.15399F, 0.17768F),
localAngles = new Vector3(277.1372F, 0F, 0F),
localScale = new Vector3(0.1057F, 0.1057F, 0.1057F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.ShockNearby,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayTeslaCoil"),
childName = "Hat",
localPos = new Vector3(0F, 0.10599F, -0.02659F),
localAngles = new Vector3(0F, 0F, 0F),
localScale = new Vector3(0.16613F, 0.16613F, 0.16613F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.ShieldOnly,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayShieldBug"),
childName = "Hat",
localPos = new Vector3(0.09045F, 0.09232F, 0.00157F),
localAngles = new Vector3(348.1819F, 268.0985F, 0.3896F),
localScale = new Vector3(0.3521F, 0.3521F, 0.3521F),
                            limbMask = LimbFlags.None
                        },
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayShieldBug"),
childName = "Hat",
localPos = new Vector3(-0.09045F, 0.09232F, -0.00157F),
localAngles = new Vector3(11.8181F, 268.0985F, 359.6104F),
localScale = new Vector3(0.3521F, 0.3521F, -0.3521F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.AlienHead,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayAlienHead"),
childName = "Pelvis",
localPos = new Vector3(-0.12562F, -0.01674F, -0.03906F),
localAngles = new Vector3(84.16857F, 76.01627F, 19.5593F),
localScale = new Vector3(0.49877F, 0.49877F, 0.49877F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.HeadHunter,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplaySkullCrown"),
childName = "Stomach1",
localPos = new Vector3(-0.00631F, 0.03902F, 0.03008F),
localAngles = new Vector3(0F, 0F, 0F),
localScale = new Vector3(0.27452F, 0.09151F, 0.09151F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.EnergizedOnEquipmentUse,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayWarHorn"),
childName = "ThighR",
localPos = new Vector3(-0.10127F, 0.10276F, -0.06897F),
localAngles = new Vector3(0.87788F, 85.89476F, 292.5478F),
localScale = new Vector3(0.2732F, 0.2732F, 0.2732F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.FlatHealth,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplaySteakCurved"),
childName = "CalfR",
localPos = new Vector3(-0.00001F, 0.0817F, 0.13517F),
localAngles = new Vector3(343.559F, 0F, 0F),
localScale = new Vector3(0.07083F, 0.06571F, 0.06571F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.Tooth,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayToothMeshLarge"),
childName = "Star",
localPos = new Vector3(0F, 0.01452F, 0.05613F),
localAngles = new Vector3(90F, 0F, 0F),
localScale = new Vector3(1F, 1F, 1F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.Pearl,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayPearl"),
childName = "Hat",
localPos = new Vector3(0F, 0.19366F, 0F),
localAngles = new Vector3(90F, 0F, 0F),
localScale = new Vector3(0.13636F, 0.13636F, 0.13636F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.ShinyPearl,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayShinyPearl"),
childName = "Hat",
localPos = new Vector3(0F, 0.19366F, 0F),
localAngles = new Vector3(90F, 0F, 0F),
localScale = new Vector3(0.13636F, 0.13636F, 0.13636F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.BonusGoldPackOnKill,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayTome"),
childName = "Pelvis",
localPos = new Vector3(0.1391F, 0.00068F, -0.04818F),
localAngles = new Vector3(20.41581F, 113.8574F, 189.638F),
localScale = new Vector3(0.0475F, 0.0475F, 0.0475F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.Squid,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplaySquidTurret"),
childName = "ThighL",
localPos = new Vector3(0.01904F, 0.21751F, -0.11128F),
localAngles = new Vector3(352.3202F, 70.40843F, 274.9331F),
localScale = new Vector3(0.03071F, 0.03071F, 0.03071F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.Icicle,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayFrostRelic"),
childName = "RootBone",
localPos = new Vector3(-0.61935F, 0.40617F, 1.78568F),
localAngles = new Vector3(0F, 0F, 326.7428F),
localScale = new Vector3(1F, 1F, 1F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.Talisman,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayTalisman"),
childName = "RootBone",
localPos = new Vector3(0.68294F, 0F, 1.73311F),
localAngles = new Vector3(90F, 0F, 0F),
localScale = new Vector3(1F, 1F, 1F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.LaserTurbine,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayLaserTurbine"),
childName = "Scarf0",
localPos = new Vector3(0F, 0.09172F, 0.0284F),
localAngles = new Vector3(14.44876F, 0F, 0F),
localScale = new Vector3(0.2159F, 0.2159F, 0.2159F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.FocusConvergence,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayFocusedConvergence"),
childName = "RootBone",
localPos = new Vector3(0.37029F, 0.05379F, 1.61911F),
localAngles = new Vector3(0F, 0F, 0F),
localScale = new Vector3(0.1F, 0.1F, 0.1F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.FireballsOnHit,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayFireballsOnHit"),
childName = "FootR",
localPos = new Vector3(-0.00002F, -0.1061F, -0.1012F),
localAngles = new Vector3(75.37057F, 180F, 180F),
localScale = new Vector3(0.04947F, 0.04947F, 0.04947F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.LightningStrikeOnHit,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayChargedPerforator"),
childName = "FootL",
localPos = new Vector3(0.00547F, -0.05526F, -0.12548F),
localAngles = new Vector3(30.31897F, 0F, 0F),
localScale = new Vector3(0.86265F, 0.86265F, 0.86265F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.SiphonOnLowHealth,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplaySiphonOnLowHealth"),
childName = "ThighR",
localPos = new Vector3(-0.05628F, 0.28629F, -0.11169F),
localAngles = new Vector3(355.6384F, 215.0841F, 195.0861F),
localScale = new Vector3(0.04897F, 0.04897F, 0.04897F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.BleedOnHitAndExplode,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayBleedOnHitAndExplode"),
childName = "Pelvis",
localPos = new Vector3(-0.11563F, -0.02293F, 0.09854F),
localAngles = new Vector3(7.34814F, 322.3449F, 176.9714F),
localScale = new Vector3(0.02629F, 0.02629F, 0.02629F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.MonstersOnShrineUse,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayMonstersOnShrineUse"),
childName = "Chest",
localPos = new Vector3(-0.05511F, 0.02563F, 0.14457F),
localAngles = new Vector3(349.5936F, 251.6863F, 334.511F),
localScale = new Vector3(0.0246F, 0.0246F, 0.0246F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Items.RandomDamageZone,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayRandomDamageZone"),
childName = "Pelvis",
localPos = new Vector3(0.00714F, -0.01383F, 0.19605F),
localAngles = new Vector3(288.8324F, 180F, 180F),
localScale = new Vector3(0.0465F, 0.0465F, 0.0465F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Equipment.Fruit,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayFruit"),
childName = "Scarf12",
localPos = new Vector3(-0.10949F, -0.03783F, 0.23939F),
localAngles = new Vector3(0.00001F, 83.91572F, 317.9902F),
localScale = new Vector3(0.2118F, 0.2118F, 0.2118F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Equipment.AffixRed,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayEliteHorn"),
childName = "Hat",
localPos = new Vector3(0.06115F, -0.02087F, 0.04175F),
localAngles = new Vector3(21.18033F, 338.5765F, 351.0826F),
localScale = new Vector3(0.07789F, 0.07789F, 0.07789F),
                            limbMask = LimbFlags.None
                        },
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayEliteHorn"),
childName = "Hat",
localPos = new Vector3(-0.06115F, -0.02087F, 0.04175F),
localAngles = new Vector3(21.18034F, 21.42351F, 8.9174F),
localScale = new Vector3(-0.07789F, 0.07789F, 0.07789F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Equipment.AffixBlue,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayEliteRhinoHorn"),
childName = "Hat",
localPos = new Vector3(-0.00006F, 0.03797F, 0.1611F),
localAngles = new Vector3(326.6387F, 1.26244F, 359.8214F),
localScale = new Vector3(0.2F, 0.2F, 0.2F),
                            limbMask = LimbFlags.None
                        },
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayEliteRhinoHorn"),
childName = "Hat",
localPos = new Vector3(0F, 0.10929F, 0.10815F),
localAngles = new Vector3(280.3281F, 180F, 180F),
localScale = new Vector3(0.14324F, 0.14324F, 0.14324F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Equipment.AffixWhite,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayEliteIceCrown"),
childName = "Hat",
localPos = new Vector3(0F, 0.17802F, 0F),
localAngles = new Vector3(270F, 0F, 0F),
localScale = new Vector3(0.03028F, 0.03028F, 0.03028F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Equipment.AffixPoison,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayEliteUrchinCrown"),
childName = "Hat",
localPos = new Vector3(0F, 0.0686F, 0F),
localAngles = new Vector3(270F, 0F, 0F),
localScale = new Vector3(0.05272F, 0.05272F, 0.05272F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Equipment.AffixHaunted,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayEliteStealthCrown"),
childName = "Hat",
localPos = new Vector3(0F, 0.18788F, -0.01093F),
localAngles = new Vector3(270F, 0F, 0F),
localScale = new Vector3(0.05039F, 0.05039F, 0.05039F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Equipment.CritOnUse,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayNeuralImplant"),
childName = "Head",
localPos = new Vector3(0F, 0.00022F, 0.39928F),
localAngles = new Vector3(0F, 0F, 0F),
localScale = new Vector3(0.2326F, 0.2326F, 0.2326F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Equipment.DroneBackup,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayRadio"),
childName = "ThighR",
localPos = new Vector3(-0.03364F, 0.21504F, 0.10896F),
localAngles = new Vector3(0F, 338.8339F, 180F),
localScale = new Vector3(0.2641F, 0.2641F, 0.2641F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            /*
            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Equipment.Lightning,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayLightningArmRight"),
childName = "Chest",
localPos = new Vector3(0F, 0F, 0F),
localAngles = new Vector3(0F, 0F, 264.1649F),
localScale = new Vector3(0.50885F, 0.50885F, 0.50885F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            */
            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Equipment.BurnNearby,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayPotion"),
childName = "Pelvis",
localPos = new Vector3(-0.05914F, 0.0121F, -0.11107F),
localAngles = new Vector3(351.1586F, 197.4168F, 138.5386F),
localScale = new Vector3(0.0181F, 0.0181F, 0.0181F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Equipment.CrippleWard,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayEffigy"),
childName = "Chest",
localPos = new Vector3(0.11013F, 0.18055F, -0.07161F),
localAngles = new Vector3(0F, 333.3241F, 0F),
localScale = new Vector3(0.2812F, 0.2812F, 0.2812F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Equipment.QuestVolatileBattery,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayBatteryArray"),
childName = "Chest",
localPos = new Vector3(-0.04896F, 0.27663F, -0.13311F),
localAngles = new Vector3(12.08571F, 15.53786F, 3.33164F),
localScale = new Vector3(0.11871F, 0.11871F, 0.11871F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Equipment.GainArmor,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayElephantFigure"),
childName = "Hat",
localPos = new Vector3(0F, 0.14517F, -0.03722F),
localAngles = new Vector3(349.6F, 180F, 0F),
localScale = new Vector3(0.33764F, 0.33764F, 0.33764F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Equipment.Recycle,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayRecycler"),
childName = "Pelvis",
localPos = new Vector3(-0.05874F, 0.01075F, -0.12421F),
localAngles = new Vector3(2.48252F, 286.9008F, 173.5495F),
localScale = new Vector3(0.02562F, 0.02562F, 0.02562F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Equipment.FireBallDash,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayEgg"),
childName = "Pelvis",
localPos = new Vector3(-0.06212F, 0.02679F, -0.11455F),
localAngles = new Vector3(90F, 0F, 0F),
localScale = new Vector3(0.10305F, 0.10305F, 0.10305F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Equipment.Cleanse,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayWaterPack"),
childName = "Chest",
localPos = new Vector3(0F, 0.01002F, -0.05247F),
localAngles = new Vector3(0F, 180F, 0F),
localScale = new Vector3(0.06481F, 0.06481F, 0.06481F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Equipment.Tonic,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayTonic"),
childName = "Pelvis",
localPos = new Vector3(-0.05157F, 0.01452F, -0.11424F),
localAngles = new Vector3(0F, 191.4533F, 180F),
localScale = new Vector3(0.1252F, 0.1252F, 0.1252F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Equipment.Gateway,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayVase"),
childName = "Pelvis",
localPos = new Vector3(-0.06434F, 0.00003F, -0.13391F),
localAngles = new Vector3(331.7284F, 208.5639F, 180F),
localScale = new Vector3(0.0982F, 0.0982F, 0.0982F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Equipment.Meteor,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayMeteor"),
childName = "RootBone",
localPos = new Vector3(0.52299F, -0.51813F, 1.73713F),
localAngles = new Vector3(0F, 0F, 0F),
localScale = new Vector3(1F, 1F, 1F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Equipment.Saw,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplaySawmerangFollower"),
childName = "RootBone",
localPos = new Vector3(-0.78393F, 0.78781F, 2.12936F),
localAngles = new Vector3(0F, 0F, 0F),
localScale = new Vector3(0.15F, 0.15F, 0.15F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Equipment.Blackhole,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayGravCube"),
childName = "RootBone",
localPos = new Vector3(-0.78393F, 0.28059F, 1.57782F),
localAngles = new Vector3(0F, 0F, 0F),
localScale = new Vector3(0.5F, 0.5F, 0.5F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Equipment.Scanner,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayScanner"),
childName = "Hat",
localPos = new Vector3(0.07942F, 0.09402F, 0.0523F),
localAngles = new Vector3(303.0909F, 80.02352F, 180.1908F),
localScale = new Vector3(0.0861F, 0.0861F, 0.0861F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Equipment.DeathProjectile,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayDeathProjectile"),
childName = "Pelvis",
localPos = new Vector3(-0.0599F, 0.00007F, -0.14111F),
localAngles = new Vector3(0F, 197.4056F, 180F),
localScale = new Vector3(0.03496F, 0.03496F, 0.03496F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Equipment.LifestealOnHit,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayLifestealOnHit"),
childName = "Pelvis",
localPos = new Vector3(0.068F, 0.14908F, 0.24243F),
localAngles = new Vector3(0F, 180F, 0F),
localScale = new Vector3(0.06313F, 0.06313F, 0.06313F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = RoR2Content.Equipment.TeamWarCry,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayTeamWarCry"),
childName = "Pelvis",
localPos = new Vector3(-0.04351F, -0.00288F, -0.13774F),
localAngles = new Vector3(344.7224F, 197.1864F, 168.7325F),
localScale = new Vector3(0.02453F, 0.02453F, 0.02453F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            #endregion

            #region DLC Item Displays
            
            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Items.MoveSpeedOnKill,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayGrappleHook"),
                            childName = "RevolverL",
localPos = new Vector3(0F, 0.43459F, -0.02054F),
localAngles = new Vector3(-0.00001F, 180F, 180F),
localScale = new Vector3(0.12461F, 0.11397F, 0.11397F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Items.HealingPotion,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayHealingPotion"),
                            childName = "Pelvis",
localPos = new Vector3(0.0936F, -0.00731F, -0.0922F),
localAngles = new Vector3(20.91455F, 156.7868F, 191.4578F),
localScale = new Vector3(0.02375F, 0.02172F, 0.02172F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Items.PermanentDebuffOnHit,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayScorpion"),
                            childName = "Scarf12",
localPos = new Vector3(0F, 0.05057F, -0.01671F),
localAngles = new Vector3(326.584F, 0F, 0F),
localScale = new Vector3(0.43731F, 0.39998F, 0.39998F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Items.AttackSpeedAndMoveSpeed,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayCoffee"),
                            childName = "Pelvis",
localPos = new Vector3(-0.05564F, -0.01205F, -0.14543F),
localAngles = new Vector3(5.14064F, 145.9793F, 178.996F),
localScale = new Vector3(0.12366F, 0.11311F, 0.11311F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Items.CritDamage,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayLaserSight"),
                            childName = "RevolverR",
localPos = new Vector3(-0.00081F, 0.21482F, -0.03257F),
localAngles = new Vector3(0F, 90F, 270F),
localScale = new Vector3(0.04251F, 0.03888F, 0.03888F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Items.BearVoid,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayBearVoid"),
childName = "Chest",
localPos = new Vector3(-0.06893F, 0.31729F, -0.01275F),
localAngles = new Vector3(350.1292F, 227.233F, 354.5159F),
localScale = new Vector3(0.11724F, 0.11724F, 0.11724F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Items.MushroomVoid,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayMushroomVoid"),
                            childName = "Scarf5",
localPos = new Vector3(0F, 0F, 0F),
localAngles = new Vector3(90F, 0F, 0F),
localScale = new Vector3(0.0501F, 0.0501F, 0.0501F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Items.CloverVoid,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayCloverVoid"),
                            childName = "Hat",
localPos = new Vector3(-0.10365F, 0.06156F, -0.0534F),
localAngles = new Vector3(358.8618F, 352.718F, 62.89376F),
localScale = new Vector3(0.2749F, 0.2749F, 0.2749F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Items.StrengthenBurn,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayGasTank"),
                            childName = "Stomach",
localPos = new Vector3(-0.02818F, 0.1139F, -0.08451F),
localAngles = new Vector3(331.5273F, 188.3566F, 316.0361F),
localScale = new Vector3(0.13549F, 0.12392F, 0.12392F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Items.RegeneratingScrap,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayRegeneratingScrap"),
                            childName = "ThighL",
localPos = new Vector3(0.00595F, 0.21379F, -0.11692F),
localAngles = new Vector3(0F, 0F, 180F),
localScale = new Vector3(0.10828F, 0.09903F, 0.09903F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Items.BleedOnHitVoid,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayTriTipVoid"),
                            childName = "FootL",
localPos = new Vector3(0F, -0.05778F, -0.1025F),
localAngles = new Vector3(27.47504F, 180F, 0F),
localScale = new Vector3(0.30363F, 0.30363F, 0.30363F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Items.CritGlassesVoid,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayGlassesVoid"),
                            childName = "Hat",
localPos = new Vector3(0.00001F, -0.00068F, 0.14234F),
localAngles = new Vector3(16.44563F, 0F, 0F),
localScale = new Vector3(0.22762F, 0.20819F, 0.20819F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Items.TreasureCacheVoid,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayKeyVoid"),
                            childName = "ThighR",
localPos = new Vector3(0.09145F, 0.22909F, 0.00663F),
localAngles = new Vector3(1.11911F, 357.1378F, 275.9227F),
localScale = new Vector3(0.71302F, 0.71302F, 0.71302F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Items.SlowOnHitVoid,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayBaubleVoid"),
                            childName = "Pelvis",
localPos = new Vector3(-0.1422F, 0.17905F, -0.17235F),
localAngles = new Vector3(359.9116F, 359.1554F, 181.7254F),
localScale = new Vector3(0.22389F, 0.22389F, 0.22389F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Items.MissileVoid,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayMissileLauncherVoid"),
                            childName = "Hat",
localPos = new Vector3(0F, 0.25517F, -0.13554F),
localAngles = new Vector3(337.2867F, 0F, 0F),
localScale = new Vector3(0.05327F, 0.05327F, 0.05327F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Items.ChainLightningVoid,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayUkuleleVoid"),
                            childName = "Chest",
localPos = new Vector3(-0.00835F, 0.08003F, -0.05444F),
localAngles = new Vector3(350.0998F, 187.9801F, 65.08994F),
localScale = new Vector3(0.4749F, 0.4749F, 0.4749F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Items.ExtraLifeVoid,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayHippoVoid"),
                            childName = "Chest",
localPos = new Vector3(-0.00957F, 0.29254F, -0.11613F),
localAngles = new Vector3(356.4678F, 195.501F, 353.0808F),
localScale = new Vector3(0.14167F, 0.14167F, 0.14167F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Items.EquipmentMagazineVoid,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayFuelCellVoid"),
                            childName = "ThighR",
localPos = new Vector3(0.04477F, 0.30213F, 0.09289F),
localAngles = new Vector3(353.8899F, 46.62275F, 185.5503F),
localScale = new Vector3(0.0773F, 0.0773F, 0.0773F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Items.ExplodeOnDeathVoid,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayWillowWispVoid"),
                            childName = "Pelvis",
localPos = new Vector3(0.06772F, 0.01529F, -0.12684F),
localAngles = new Vector3(0F, 0F, 163.0104F),
localScale = new Vector3(0.0283F, 0.0283F, 0.0283F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Items.FragileDamageBonus,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayDelicateWatch"),
                            childName = "ForeArmL",
localPos = new Vector3(-0.00794F, 0.1913F, 0.01548F),
localAngles = new Vector3(270F, 167.78F, 0F),
localScale = new Vector3(0.38782F, 0.78346F, 0.38782F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Items.OutOfCombatArmor,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayOddlyShapedOpal"),
                            childName = "ForeArmR",
localPos = new Vector3(0.00001F, 0.19065F, 0.06361F),
localAngles = new Vector3(353.3494F, 359.1677F, 7.15004F),
localScale = new Vector3(0.22762F, 0.20819F, 0.20819F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Items.MoreMissile,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayICBM"),
                            childName = "RevolverR",
localPos = new Vector3(-0.00001F, 0.42965F, -0.02114F),
localAngles = new Vector3(0F, 0F, 0F),
localScale = new Vector3(0.08466F, 0.07744F, 0.07744F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Items.ImmuneToDebuff,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayRainCoatBelt"),
                            childName = "Pelvis",
localPos = new Vector3(0F, -0.02656F, 0.02734F),
localAngles = new Vector3(354.8123F, 180F, 180F),
localScale = new Vector3(0.72055F, 0.72055F, 0.72055F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Items.RandomEquipmentTrigger,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayBottledChaos"),
                            childName = "ThighL",
localPos = new Vector3(0.10242F, 0.25688F, 0.0516F),
localAngles = new Vector3(6.07193F, 192.559F, 183.0248F),
localScale = new Vector3(0.08271F, 0.07565F, 0.07565F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Items.PrimarySkillShuriken,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayShuriken"),
                            childName = "Star",
localPos = new Vector3(0F, 0.01771F, 0F),
localAngles = new Vector3(90F, 0F, 0F),
localScale = new Vector3(0.22762F, 0.20819F, 0.20819F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Items.RandomlyLunar,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayDomino"),
                            childName = "RootBone",
localPos = new Vector3(-0.52642F, 0.37872F, 1.2297F),
localAngles = new Vector3(0F, 0F, 0F),
localScale = new Vector3(1F, 1F, 1F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Items.GoldOnHurt,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayRollOfPennies"),
                            childName = "ThighL",
localPos = new Vector3(0.06762F, 0.16476F, -0.08073F),
localAngles = new Vector3(-0.00001F, 180F, 180F),
localScale = new Vector3(0.38981F, 0.35654F, 0.35654F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Items.HalfAttackSpeedHalfCooldowns,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayLunarShoulderNature"),
                            childName = "ShoulderL",
localPos = new Vector3(0F, 0.11374F, 0.01986F),
localAngles = new Vector3(0F, 270F, 262.9897F),
localScale = new Vector3(0.56985F, 0.56985F, 0.56985F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Items.HalfSpeedDoubleHealth,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayLunarShoulderStone"),
                            childName = "ShoulderR",
localPos = new Vector3(0F, 0.11374F, 0.01986F),
localAngles = new Vector3(0F, 270F, 262.9897F),
localScale = new Vector3(0.56985F, 0.56985F, 0.56985F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Items.FreeChest,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayShippingRequestForm"),
                            childName = "Scarf10",
localPos = new Vector3(0.00003F, 0F, -0.01023F),
localAngles = new Vector3(90F, 179.8342F, 0F),
localScale = new Vector3(0.32653F, 0.29866F, 0.29866F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Items.ElementalRingVoid,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayVoidRing"),
                            childName = "CalfL",
localPos = new Vector3(0F, 0.43058F, -0.00262F),
localAngles = new Vector3(90F, 0F, 0F),
localScale = new Vector3(0.49437F, 0.49437F, 0.49437F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Items.LunarSun,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            childName = "Head",
localPos = new Vector3(0F, 0.12774F, 0F),
localAngles = new Vector3(0F, 0F, 0F),
localScale = new Vector3(0.39193F, 0.35848F, 0.35848F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            
            /*
            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Items.DroneWeapons,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayDroneWeaponRobotArm"),
                            childName = "Chest",
                            localPos = new Vector3(0F, 0f, 0f),
                            localAngles = new Vector3(0f, 0F, 0F),
                            localScale = new Vector3(0.22762F, 0.20819F, 0.20819F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            */

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Items.MinorConstructOnKill,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            childName = "RootBone",
localPos = new Vector3(0.61369F, 0.40094F, 1.94402F),
localAngles = new Vector3(291.2306F, 71.91819F, 305.4885F),
localScale = new Vector3(0.3F, 0.3F, 0.3F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            
            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Equipment.BossHunter,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayTricornGhost"),
                            childName = "Hat",
localPos = new Vector3(0.00084F, 0.16239F, -0.02365F),
localAngles = new Vector3(35.3707F, 0.2041F, 0.6995F),
localScale = new Vector3(0.55017F, 0.55017F, 0.55017F),
                            limbMask = LimbFlags.None
                        },

                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayBlunderbuss"),
                            childName = "RootBone",
localPos = new Vector3(0.7868F, 0.23809F, 1.89449F),
localAngles = new Vector3(-0.00001F, 180F, 180F),
localScale = new Vector3(1F, 1F, 1F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Equipment.BossHunterConsumed,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayTricornUsed"),
                            childName = "Hat",
localPos = new Vector3(0.00084F, 0.16239F, -0.02365F),
localAngles = new Vector3(35.3707F, 0.2041F, 0.6995F),
localScale = new Vector3(0.55017F, 0.55017F, 0.55017F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Equipment.Molotov,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayMolotov"),
                            childName = "ThighL",
localPos = new Vector3(0.09748F, 0.14943F, 0.00012F),
localAngles = new Vector3(351.4001F, 94.7253F, 180F),
localScale = new Vector3(0.18004F, 0.16468F, 0.16468F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Equipment.VendingMachine,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayVendingMachine"),
                            childName = "Pelvis",
localPos = new Vector3(-0.06989F, 0.00437F, -0.08273F),
localAngles = new Vector3(0F, 231.5774F, 180F),
localScale = new Vector3(0.12052F, 0.11023F, 0.11023F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Equipment.GummyClone,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayGummyClone"),
                            childName = "Head",
localPos = new Vector3(-0.08503F, 0.05818F, -0.0202F),
localAngles = new Vector3(353.053F, 93.47964F, 276.0069F),
localScale = new Vector3(0.22762F, 0.20819F, 0.20819F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Equipment.MultiShopCard,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayExecutiveCard"),
                            childName = "ThighR",
localPos = new Vector3(0.05592F, 0.2701F, 0.07366F),
localAngles = new Vector3(6.09761F, 311.6005F, 278.8432F),
localScale = new Vector3(0.58165F, 0.532F, 0.532F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });

            itemDisplayRules.Add(new ItemDisplayRuleSet.KeyAssetRuleGroup
            {
                keyAsset = DLC1Content.Equipment.EliteVoidEquipment,
                displayRuleGroup = new DisplayRuleGroup
                {
                    rules = new ItemDisplayRule[]
                    {
                        new ItemDisplayRule
                        {
                            ruleType = ItemDisplayRuleType.ParentedPrefab,
                            followerPrefab = ItemDisplays.LoadDisplay("DisplayAffixVoid"),
                            childName = "Head",
localPos = new Vector3(0F, 0.02309F, 0.09125F),
localAngles = new Vector3(90F, 0F, 0F),
localScale = new Vector3(0.14324F, 0.13101F, 0.13101F),
                            limbMask = LimbFlags.None
                        }
                    }
                }
            });
            #endregion
        }
    }
}