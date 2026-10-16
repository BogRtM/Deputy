using UnityEngine;
using RoR2;
using EntityStates;
using EntityStates.Commando.CommandoWeapon;
using EntityStates.ClayBruiser.Weapon;
using Deputy.Components;
using RoR2.Skills;
using Deputy.Modules;
using Deputy;
using R2API;

namespace Skillstates.Deputy
{
    public class TriggerTap : BaseSkillState, SteppedSkillDef.IStepSetter
    {
        public static float damageCoefficient = Config.primaryDamage.Value;
        public static float baseDuration = 0.3f;

        private DeputyAnimatorController DAC;

        private BulletAttack bulletAttack;

        private string layerName;
        private string muzzleIndex;
        private string animationName = "Shoot";

        private int fireIndex;
        private float duration;
        private Ray aimRay;

        public override void OnEnter()
        {
            base.OnEnter();

            DAC = base.GetComponent<DeputyAnimatorController>();
            //DAC.SetCombatWeight(true, 0.1f);
            DAC.SetCombatState(DeputyAnimatorController.combatState.EnteringCombat);

            duration = baseDuration / base.attackSpeedStat;
            aimRay = base.GetAimRay();

            if (base.characterBody.isSprinting)
            {
                animationName = "Sprint" + animationName;
            }
            else
            {
                base.StartAimMode(1f, false);
            }

            if (fireIndex % 2 == 0)
            {
                layerName = "Left Arm, Additive";
                animationName += "L";
                muzzleIndex = "MuzzleL";
            }
            else
            {
                layerName = "Right Arm, Additive";
                animationName += "R";
                muzzleIndex = "MuzzleR";
            }

            base.PlayAnimation(layerName, animationName, "Hand.playbackRate", duration);
            Util.PlaySound("Play_bandit_M1_shot", base.gameObject);
            //Util.PlaySound(FireBarrage.fireBarrageSoundString, base.gameObject);
            EffectManager.SimpleMuzzleFlash(FirePistol2.muzzleEffectPrefab, base.gameObject, muzzleIndex, false);
            base.AddRecoil(-0.4f * FirePistol2.recoilAmplitude, -0.8f * FirePistol2.recoilAmplitude, -0.3f * FirePistol2.recoilAmplitude, 0.3f * FirePistol2.recoilAmplitude);

            bulletAttack = new BulletAttack
            {
                owner = base.gameObject,
                weapon = base.gameObject,
                origin = this.aimRay.origin,
                aimVector = this.aimRay.direction,
                minSpread = 0f,
                maxSpread = base.characterBody.spreadBloomAngle,
                damage = damageCoefficient * this.damageStat,
                force = FirePistol2.force,
                tracerEffectPrefab = DeputyAssets.deputyTracerEffect,
                muzzleName = muzzleIndex,
                hitEffectPrefab = FirePistol2.hitEffectPrefab,
                isCrit = base.RollCrit(),
                radius = FireBarrage.bulletRadius,
                smartCollision = true,
                maxDistance = 60f,
                falloffModel = BulletAttack.FalloffModel.None
            };

            bulletAttack.AddModdedDamageType(DeputyPlugin.grantHotPursuit);

            if (base.isAuthority)
                bulletAttack.Fire();
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();

            if(base.fixedAge >= duration && base.isAuthority)
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

        public void SetStep(int i)
        {
            fireIndex = i;
        }
    }
}
