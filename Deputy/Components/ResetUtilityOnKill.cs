using RoR2;
using R2API;
using UnityEngine;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine.Networking;

namespace Deputy.Components
{
    internal class ResetUtilityOnKill : NetworkBehaviour, IOnKilledOtherServerReceiver
    {
        private SkillLocator skillLocator;

        private void Start()
        {
            skillLocator = base.GetComponent<SkillLocator>();
        }

        public void OnKilledOtherServer(DamageReport damageReport)
        {
            if (damageReport.damageInfo.HasModdedDamageType(DeputyPlugin.resetUtilityOnKill) && NetworkServer.active)
            {
                RpcAddUtilityStock();
            }
        }

        [ClientRpc]
        public void RpcAddUtilityStock()
        {
            if (base.hasAuthority)
            {
                if(skillLocator && skillLocator.utility.stock < skillLocator.utility.maxStock)
                {
                    skillLocator.utility.AddOneStock();
                }
            }
        }
    }
}
