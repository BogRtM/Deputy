using UnityEngine;
using RoR2;
using EntityStates;
using EntityStates.Loader;
using UnityEngine.Networking;

namespace Skillstates.Deputy
{
    public class CometBounce : BaseState
    {
        public static float baseDuration = 1f;

        internal Vector3 faceDirection;

        public override void OnEnter()
        {
            base.OnEnter();
            base.PlayAnimation("FullBody, Override", "Kick1", "Flip.playbackRate", baseDuration);

            //EffectManager.SimpleImpactEffect(SwingZapFist.overchargeImpactEffectPrefab, impactPoint, base.characterDirection.forward, false);

        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();

            if (base.isAuthority)
            {
                base.characterDirection.forward = faceDirection;
                base.characterBody.isSprinting = true;

                if (base.fixedAge >= baseDuration)
                {
                    this.outer.SetNextStateToMain();
                }
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
