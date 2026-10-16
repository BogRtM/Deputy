using UnityEngine;
using RoR2;
using EntityStates;
using Deputy.Components;

namespace Skillstates.Deputy
{
    public class DeputyMainState : GenericCharacterMain
    {
        private DeputyAnimatorController DAC;

        public override void OnEnter()
        {
            base.OnEnter();
            DAC = base.GetComponent<DeputyAnimatorController>();
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();
        }

        public override void OnExit()
        {
            base.OnExit();
        }

        public override void UpdateAnimationParameters()
        {
            base.UpdateAnimationParameters();

            DAC.UpdateAnimationParams();
        }

        public override InterruptPriority GetMinimumInterruptPriority()
        {
            return InterruptPriority.PrioritySkill;
        }
    }
}
