using UnityEngine;
using RoR2;
using EntityStates;
namespace Skillstates.Deputy
{
    public class BulletHeavenLoop : BaseState
    {
        public static float baseDuration = 2f;

        public override void OnEnter()
        {
            base.OnEnter();
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();

            if (base.isAuthority)
            {
                base.characterMotor.velocity.y *= 0.1f;
            }

            if (base.fixedAge >= baseDuration && base.isAuthority)
            {
                this.outer.SetNextState(new BulletHeavenExit());
            }
        }

        public override void OnExit()
        {
            base.PlayAnimation("FullBody, Override", "BufferEmpty");
            base.OnExit();
        }

        public override InterruptPriority GetMinimumInterruptPriority()
        {
            return InterruptPriority.PrioritySkill;
        }
    }
}
