using BepInEx.Configuration;
using HarmonyLib;
using System.Collections.Generic;
using UnityEngine;

namespace Deputy.Modules
{
    public static class Config
    {
        #region Deputy General
        public static ConfigEntry<bool> bulletRicochet;
        #endregion

        public static string passiveTitle = "Passive";
        public static ConfigEntry<int> maxStacks;
        public static ConfigEntry<float> msPerStack;
        public static ConfigEntry<float> msBuffDuration;

        public static string primaryTitle = "Primary";
        public static ConfigEntry<float> primaryDamage;

        public static string secondaryTitle = "Secondary";
        public static ConfigEntry<float> gunSlingBulletDamage;
        public static ConfigEntry<float> gunSlingProcCoefficient;
        public static ConfigEntry<float> gunSlingBlastDamage;

        public static string utilityTitle = "Utility";
        public static ConfigEntry<float> shootingStarDamage;

        public static string specialTitle = "Special";
        public static ConfigEntry<float> cometDamageCoefficient;
        public static ConfigEntry<float> bulletHeavenDamage;
        public static ConfigEntry<float> bulletHeavenProcCoefficient;

        public static void ReadConfig(DeputyPlugin plugin)
        {
            #region Deputy
            bulletRicochet = plugin.Config.Bind<bool>("General", "Enable Bullet Ricochet SFX", false, "Enable this for wacky cartoony bullet ricochet SFX");

            maxStacks = plugin.Config.Bind<int>(passiveTitle, "Hot Pursuit Max Stacks", 50, "Maximum stacks of Hot Pursuit");
            msPerStack = plugin.Config.Bind<float>(passiveTitle, "Hot Pursuit MS per stack", 0.01f, "Bonus movement speed multiplier per stack of Hot Pursuit");
            msBuffDuration = plugin.Config.Bind<float>(passiveTitle, "Hot Pursuit Stack Duration", 5f, "Duration of Hot Pursuit buff in seconds");

            primaryDamage = plugin.Config.Bind<float>(primaryTitle, "Trigger Tap Damage Coefficient", 1.5f, "Damage coefficient of Trigger Tap");

            gunSlingBulletDamage = plugin.Config.Bind<float>(secondaryTitle, "Gun Sling Gunshot Damage Coefficient", 1f, "Damage coefficient of Gun Sling's gunshots");
            gunSlingProcCoefficient = plugin.Config.Bind<float>(secondaryTitle, "Gun Sling Gunshot Proc Coefficient", 0.7f, "Proc coefficient of Gun Sling's gunshots");
            gunSlingBlastDamage = plugin.Config.Bind<float>(secondaryTitle, "Gun Sling Explosion Damage Coefficient", 3f, "Damage coefficient of Gun Sling's explosion");

            shootingStarDamage = plugin.Config.Bind<float>(utilityTitle, "Shooting Star Damage Coefficient", 1.5f, "Damage coefficient of Shooting Star");

            cometDamageCoefficient = plugin.Config.Bind<float>(specialTitle, "Crashing Comet Damage Coefficient", 8f, "Damage coefficient of Crashing Comet");
            bulletHeavenDamage = plugin.Config.Bind<float>(specialTitle, "Bullet Heaven Damage Coefficient", 1.5f, "Damage coefficient of Bullet Heaven");
            bulletHeavenProcCoefficient = plugin.Config.Bind<float>(specialTitle, "Bullet Heaven Proc Coefficient", 0.7f, "Damage coefficient of Bullet Heaven");
            #endregion
        }

        // this helper automatically makes config entries for disabling survivors
        public static ConfigEntry<bool> CharacterEnableConfig(string characterName, string description = "Set to false to disable this character", bool enabledDefault = true)
        {
            return DeputyPlugin.instance.Config.Bind<bool>("General",
                                                          "Enable " + characterName,
                                                          enabledDefault,
                                                          description);
        }
    }
}