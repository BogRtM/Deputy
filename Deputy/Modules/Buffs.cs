using RoR2;
using R2API;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using System;

namespace Deputy.Modules
{
    public static class Buffs
    {
        internal static BuffDef deputyBuff;

        internal static void RegisterBuffs()
        {
            BuffDef whipBoost = Addressables.LoadAssetAsync<BuffDef>("RoR2/Base/SprintOutOfCombat/bdWhipBoost.asset").WaitForCompletion();
            deputyBuff = AddNewBuff("DeputyMS", whipBoost.iconSprite, Color.yellow, true, false);
        }

        // simple helper method
        internal static BuffDef AddNewBuff(string buffName, Sprite buffIcon, Color buffColor, bool canStack, bool isDebuff)
        {
            BuffDef buffDef = ScriptableObject.CreateInstance<BuffDef>();
            buffDef.name = buffName;
            buffDef.buffColor = buffColor;
            buffDef.canStack = canStack;
            buffDef.isDebuff = isDebuff;
            buffDef.eliteDef = null;
            buffDef.iconSprite = buffIcon;

            Modules.Content.AddBuffDef(buffDef);

            return buffDef;
        }
    }
}