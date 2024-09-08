using UnityEngine;
using RoR2;
using EntityStates;
namespace Skillstates.Deputy
{
    public class BulletHeavenExit : BaseState
    {
        public static float baseDuration = 1f;

        public override void OnEnter()
        {
            base.OnEnter();

            base.PlayCrossfade("FullBody, Override", "BulletHeaven Exit", "Flip.playbackRate", baseDuration, 0.1f);
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();

            if((base.fixedAge >= baseDuration || base.characterMotor.isGrounded) && base.isAuthority)
            {
                this.outer.SetNextStateToMain();
            }
        }

        public override void OnExit()
        {
            base.OnExit();
        }

        public override InterruptPriority GetMinimumInterruptPriority()
        {
            return InterruptPriority.Skill;
        }
    }
}
