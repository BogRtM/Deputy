using UnityEngine;
using RoR2;
using EntityStates;
using EntityStates.Loader;
using UnityEngine.Networking;

namespace Skillstates.Deputy
{
    public class CometBounceShoot : BaseState
    {
        public static float baseDuration = 1f;
        public static float preptime = 0.5f;
        public static float fireInterval = 0.15f;

        internal Vector3 faceDirection;

        private float fireTimer;

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
