using UnityEngine;
using RoR2;
using EntityStates;
using EntityStates.Commando.CommandoWeapon;
using Deputy;
using Deputy.Modules;
using R2API;

namespace Skillstates.Deputy
{
    public class BulletHeaven : BaseState
    {
        public static float jumpDuration = 0.6f;
        public static float loopDuration = 3f;
        public static float jumpPower = 30f;
        public static float baseFireInterval = 0.1f;
        public static float damageCoefficient = Config.bulletHeavenDamage.Value;
        public static float minDampingStrength = 0.5f;
        public static float maxDampingStrength = 0.1f;
        public static float procCoefficient = Config.bulletHeavenProcCoefficient.Value;

        private Vector3 shootVector;
        private float previousAirControl;
        private int maxShots;
        private int currentShots;
        private float fireInterval;
        private float fireStopwatch;
        private float stopwatch;
        private bool isCrit;

        private float dampingStrength;
        private float dampingVelocity;

        private CameraTargetParams.AimRequest aimRequest;

        private string muzzleIndex;
        public override void OnEnter()
        {
            base.OnEnter();

            fireInterval = baseFireInterval / base.attackSpeedStat;
            maxShots = Mathf.FloorToInt(loopDuration / fireInterval);
            dampingStrength = minDampingStrength;

            isCrit = base.RollCrit();

            base.characterMotor.disableAirControlUntilCollision = false;

            base.PlayCrossfade("FullBody, Override", "BulletHeaven Jump", "Flip.playbackRate", jumpDuration, 0.1f);

            if (base.cameraTargetParams)
            {
                aimRequest = base.cameraTargetParams.RequestAimType(CameraTargetParams.AimType.Aura);
            }

            previousAirControl = base.characterMotor.airControl;
            base.characterMotor.airControl = 1f;
            base.characterMotor.velocity.y = 0f;
            base.characterMotor.Motor.ForceUnground();
            base.characterMotor.velocity += Vector3.up * jumpPower;
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();

            fireStopwatch += Time.fixedDeltaTime;

            if(base.fixedAge >= jumpDuration)
            {
                stopwatch += Time.fixedDeltaTime;
                if(base.characterMotor.velocity.y <= 0f)
                {
                    base.characterMotor.velocity.y *= 0.2f;
                }

                dampingStrength = Mathf.SmoothDamp(dampingStrength, maxDampingStrength, ref dampingVelocity, loopDuration);

                if(fireStopwatch >= fireInterval && currentShots < maxShots)
                {
                    fireStopwatch = 0f;
                    GetShootVector();
                    FireAttack();
                }
            }

            if (stopwatch>= loopDuration && base.isAuthority)
            {
                this.outer.SetNextState(new BulletHeavenExit());
            }
        }

        public void GetShootVector()
        {
            float randomX = Mathf.Sin(Random.Range(0, 2*Mathf.PI)) * dampingStrength;
            float randomZ = Mathf.Cos(Random.Range(0, 2*Mathf.PI)) * dampingStrength;

            shootVector = new Vector3(randomX, -1f, randomZ);
        }

        private void FireAttack()
        {
            if (currentShots % 2 == 0)
            {
                muzzleIndex = "MuzzleL";
            }
            else
            {
                muzzleIndex = "MuzzleR";
            }

            Util.PlaySound(FireBarrage.fireBarrageSoundString, base.gameObject);
            EffectManager.SimpleMuzzleFlash(FireBarrage.effectPrefab, base.gameObject, muzzleIndex, false);

            BulletAttack bulletAttack = new BulletAttack
            {
                owner = base.gameObject,
                weapon = base.gameObject,
                origin = base.characterBody.corePosition,
                aimVector = shootVector,
                minSpread = 0f,
                procCoefficient = procCoefficient,
                maxSpread = base.characterBody.spreadBloomAngle,
                damage = damageCoefficient * this.damageStat,
                force = FirePistol2.force,
                tracerEffectPrefab = FireBarrage.tracerEffectPrefab,
                muzzleName = muzzleIndex,
                hitEffectPrefab = FireBarrage.hitEffectPrefab,
                isCrit = isCrit,
                radius = 8f,
                smartCollision = true,
                damageType = DamageType.Generic,
                maxDistance = 120,
                falloffModel = BulletAttack.FalloffModel.None
            };
            bulletAttack.AddModdedDamageType(DeputyPlugin.grantHotPursuit);

            currentShots++;

            if (base.isAuthority)
                bulletAttack.Fire();
        }

        public override void OnExit()
        {
            if (aimRequest != null)
                aimRequest.Dispose();

            base.PlayAnimation("FullBody, Override", "BufferEmpty");

            base.characterMotor.airControl = previousAirControl;

            base.OnExit();
        }

        public override InterruptPriority GetMinimumInterruptPriority()
        {
            return InterruptPriority.Skill;
        }
    }
}
