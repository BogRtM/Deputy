using R2API;
using System;
using Deputy.Components;
using Skillstates.Deputy;

namespace Deputy.Modules
{
    internal static class Tokens
    {
        internal static void AddTokens()
        {
            #region Deputy
            string devPrefix = DeputyPlugin.DEVELOPER_PREFIX;
            string prefix = devPrefix + "_DEPUTY_BODY_";

            string modderNote = "<style=cShrine>Modder's Note:</style> <style=cUserSetting>Thank you for showing interest in <color=#e1c100>The Deputy</color>! " +
                "For feedback and bug reports, please contact <style=cIsUtility>Bog#4770</style> on Discord.</style>";

            string desc = "The Deputy is a high-octane, hyper-aggressive speed demon who dispenses justice via her twin revolvers and lethal kick attacks.<color=#CCD3E0>" + Environment.NewLine + Environment.NewLine;
            desc += "< ! > Trigger Tap has perfect accuracy and no damage falloff, but its maximum range is quite limited compared to most other gun-based attacks." + Environment.NewLine + Environment.NewLine;
            desc += "< ! > The revolvers thrown out by Gun Sling will always prioritize the enemy closest to them." + Environment.NewLine + Environment.NewLine;
            desc += "< ! > Shooting Star can be slightly angled upwards by looking up." + Environment.NewLine + Environment.NewLine;
            desc += "< ! > Crashing Comet can deal devastating burst damage at high movement speed values. Use your guns to build up stacks of Hot Pursuit, " +
                "then go in for the kill." + Environment.NewLine + Environment.NewLine + Environment.NewLine;

            desc += modderNote;

            string lore =
                "";

            string outro = "..and so she left, to the sound of roaring applause.";
            string outroFailure = "..and so she vanished, her performance finally put to an end.";

            LanguageAPI.Add(prefix + "NAME", "Deputy");
            LanguageAPI.Add(prefix + "DESCRIPTION", desc);
            LanguageAPI.Add(prefix + "SUBTITLE", "Dashing Beauty");
            LanguageAPI.Add(prefix + "LORE", lore);
            LanguageAPI.Add(prefix + "OUTRO_FLAVOR", outro);
            LanguageAPI.Add(prefix + "OUTRO_FAILURE", outroFailure);

            #region Skins
            LanguageAPI.Add(prefix + "DEFAULT_SKIN_NAME", "Default");
            LanguageAPI.Add(prefix + "MASTERY_SKIN_NAME", "");
            #endregion

            #region Passive
            LanguageAPI.Add(prefix + "PASSIVE_NAME", "Hot Pursuit");
            LanguageAPI.Add(prefix + "PASSIVE_DESCRIPTION", "The Deputy can sprint in any direction. Hitting enemies with your skills grants a stacking " +
                "<style=cIsUtility>movement speed</style> buff.");
            #endregion

            #region Keywords
            #endregion

            #region Primary
            LanguageAPI.Add(prefix + "PRIMARY_SHOOT_NAME", "Trigger Tap");
            LanguageAPI.Add(prefix + "PRIMARY_SHOOT_DESCRIPTION", $"<style=cIsUtility>Agile</style>. Fire mid-range revolvers for " +
                $"<style=cIsDamage>{TriggerTap.damageCoefficient * 100}% damage</style>.");
            #endregion

            #region Secondary
            LanguageAPI.Add(prefix + "SECONDARY_SLING_NAME", "Gun Sling");
            LanguageAPI.Add(prefix + "SECONDARY_SLING_DESCRIPTION", $"<style=cIsUtility>Agile</style>. Throw two revolvers. " +
                $"Each revolver will shoot a nearby enemy for <style=cIsDamage>6x{RevolverProjectileBehavior.bulletDamage * 100}%</style> damage</style>, " +
                $"then explode for <style=cIsDamage>{RevolverProjectileBehavior.blastDamage * 100}% damage</style>.");
            #endregion

            #region Utility
            LanguageAPI.Add(prefix + "UTILITY_SHOOTINGSTAR_NAME", "Shooting Star");
            LanguageAPI.Add(prefix + "UTILITY_SHOOTINGSTAR_DESCRIPTION", $"<style=cIsDamage>Stunning</style>. Leap forward and shoot an enemy below you for " +
                $"<style=cIsDamage>{ShootingStar.maxShots}x{ShootingStar.damageCoefficient * 100}% damage</style>.");
            #endregion

            #region Special
            LanguageAPI.Add(prefix + "SPECIAL_SKULLBREAKER_NAME", "Crashing Comet");
            LanguageAPI.Add(prefix + "SPECIAL_SKULLBREAKER_DESCRIPTION", $"<style=cIsUtility>Heavy</style>. " +
                $"<style=cIsUtility>Dash</style> forward and bounce off of an enemy, dealing " +
                $"<style=cIsDamage>{SkullBreakerDash.damageCoefficient * 100}% damage</style>. <style=cIsUtility>Kills reset the cooldown of your " +
                $"utility skill</style>.");

            LanguageAPI.Add(prefix + "SPECIAL_BULLETHEAVEN_NAME", "Bullet Heaven");
            LanguageAPI.Add(prefix + "SPECIAL_BULLETHEAVEN_DESCRIPTION", $"Jump high into the air, then wildly fire bullets downwards for " +
                $"<style=cIsDamage>{BulletHeaven.damageCoefficient * 100f}% damage</style> each. The number of shots scales with attack speed.");
            #endregion

            #region Achievements
            LanguageAPI.Add(prefix + "MASTERYUNLOCKABLE_ACHIEVEMENT_NAME", "Deputy: Mastery");
            LanguageAPI.Add(prefix + "MASTERYUNLOCKABLE_ACHIEVEMENT_DESC", "As Deputy, beat the game or obliterate on Monsoon.");
            LanguageAPI.Add(prefix + "MASTERYUNLOCKABLE_UNLOCKABLE_NAME", "Deputy: Mastery");
            #endregion
            #endregion

            #region Henry
            /*
            #region Henry
            string prefix = DeputyPlugin.DEVELOPER_PREFIX + "_HENRY_BODY_";

            string desc = "Henry is a skilled fighter who makes use of a wide arsenal of weaponry to take down his foes.<color=#CCD3E0>" + Environment.NewLine + Environment.NewLine;
            desc = desc + "< ! > Sword is a good all-rounder while Boxing Gloves are better for laying a beatdown on more powerful foes." + Environment.NewLine + Environment.NewLine;
            desc = desc + "< ! > Pistol is a powerful anti air, with its low cooldown and high damage." + Environment.NewLine + Environment.NewLine;
            desc = desc + "< ! > Roll has a lingering armor buff that helps to use it aggressively." + Environment.NewLine + Environment.NewLine;
            desc = desc + "< ! > Bomb can be used to wipe crowds with ease." + Environment.NewLine + Environment.NewLine;

            string outro = "..and so he left, searching for a new identity.";
            string outroFailure = "..and so he vanished, forever a blank slate.";

            LanguageAPI.Add(prefix + "NAME", "Henry");
            LanguageAPI.Add(prefix + "DESCRIPTION", desc);
            LanguageAPI.Add(prefix + "SUBTITLE", "The Chosen One");
            LanguageAPI.Add(prefix + "LORE", "sample lore");
            LanguageAPI.Add(prefix + "OUTRO_FLAVOR", outro);
            LanguageAPI.Add(prefix + "OUTRO_FAILURE", outroFailure);

            #region Skins
            LanguageAPI.Add(prefix + "DEFAULT_SKIN_NAME", "Default");
            LanguageAPI.Add(prefix + "MASTERY_SKIN_NAME", "Alternate");
            #endregion

            #region Passive
            LanguageAPI.Add(prefix + "PASSIVE_NAME", "Henry passive");
            LanguageAPI.Add(prefix + "PASSIVE_DESCRIPTION", "Sample text.");
            #endregion

            #region Primary
            LanguageAPI.Add(prefix + "PRIMARY_SLASH_NAME", "Sword");
            LanguageAPI.Add(prefix + "PRIMARY_SLASH_DESCRIPTION", Helpers.agilePrefix + $"Swing forward for <style=cIsDamage>{100f * StaticValues.swordDamageCoefficient}% damage</style>.");
            #endregion

            #region Secondary
            LanguageAPI.Add(prefix + "SECONDARY_GUN_NAME", "Handgun");
            LanguageAPI.Add(prefix + "SECONDARY_GUN_DESCRIPTION", Helpers.agilePrefix + $"Fire a handgun for <style=cIsDamage>{100f * StaticValues.gunDamageCoefficient}% damage</style>.");
            #endregion

            #region Utility
            LanguageAPI.Add(prefix + "UTILITY_ROLL_NAME", "Roll");
            LanguageAPI.Add(prefix + "UTILITY_ROLL_DESCRIPTION", "Roll a short distance, gaining <style=cIsUtility>300 armor</style>. <style=cIsUtility>You cannot be hit during the roll.</style>");
            #endregion

            #region Special
            LanguageAPI.Add(prefix + "SPECIAL_BOMB_NAME", "Bomb");
            LanguageAPI.Add(prefix + "SPECIAL_BOMB_DESCRIPTION", $"Throw a bomb for <style=cIsDamage>{100f * StaticValues.bombDamageCoefficient}% damage</style>.");
            #endregion

            #region Achievements
            LanguageAPI.Add(prefix + "MASTERYUNLOCKABLE_ACHIEVEMENT_NAME", "Henry: Mastery");
            LanguageAPI.Add(prefix + "MASTERYUNLOCKABLE_ACHIEVEMENT_DESC", "As Henry, beat the game or obliterate on Monsoon.");
            LanguageAPI.Add(prefix + "MASTERYUNLOCKABLE_UNLOCKABLE_NAME", "Henry: Mastery");
            #endregion
            #endregion
            */
            #endregion
        }
    }
}