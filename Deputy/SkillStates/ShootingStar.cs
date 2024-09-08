using UnityEngine;
using RoR2;
using EntityStates;
using EntityStates.Commando.CommandoWeapon;
using Deputy.Components;
using Deputy.Modules;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Bindings;
using Deputy;
using R2API;

namespace Skillstates.Deputy
{
    internal class ShootingStar : BaseState
    {
        public static float maxDuration = 2f;
        public static float minDuration = 1f;
        public static float damageCoefficient = Config.shootingStarDamage.Value;
        public static int maxShots = 4;
        public static float baseFireInterval = 0.18f;
        public static float prepTime = 0.2f;
        public static float jumpPower = 40f;
        public static float minYPower = 0.7f;

        private Animator modelAnimator;

        private BullseyeSearch search = new BullseyeSearch();
        private HurtBox bestCandidate;

        private bool isCrit;
        private float currentShots;
        private float fireIndex;
        private float fireTimer;
        private float yPower;
        private Vector3 jumpVector;
        private Vector3 jumpAngle;
        private Vector3 shootVector = Vector3.down;

        private string shootLayer;
        private string shootAnimName;
        private string muzzleIndex;

        public override void OnEnter()
        {
            base.OnEnter();

            isCrit = base.RollCrit();

            modelAnimator = base.GetModelAnimator();
            modelAnimator.SetLayerWeight(modelAnimator.GetLayerIndex("AimYaw"), 0f);

            base.PlayAnimation("FullBody, Override", "Shooting Star", "Flip.playbackRate", maxDuration);

            jumpVector = base.inputBank.moveVector == Vector3.zero ? base.characterDirection.forward : base.inputBank.moveVector;
            base.characterDirection.forward = jumpVector;

            EffectData effectData = new EffectData();
            effectData.rotation = Util.QuaternionSafeLookRotation(jumpVector);
            effectData.origin = characterBody.footPosition;
            EffectManager.SpawnEffect(DeputyAssets.shootingStarEffect, effectData, false);

            Ray aimRay = base.GetAimRay();
            yPower = Mathf.Max(minYPower, aimRay.direction.y);
            jumpAngle = new Vector3(0f, yPower, 0f);

            jumpVector += jumpAngle;

            if (base.isAuthority)
            {
                base.characterDirection.forward = jumpVector;
                base.characterBody.isSprinting = true;
            }

            base.characterMotor.Motor.ForceUnground();
            base.characterMotor.velocity.y = 0f;
            base.characterMotor.velocity += jumpVector * jumpPower;
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();

            fireTimer += Time.fixedDeltaTime;

            if (base.fixedAge >= prepTime && fireTimer >= baseFireInterval && currentShots < maxShots)
            {
                fireTimer = 0f;
                this.SearchForTarget();
                this.FireAttack();
            }

            if(base.isAuthority)
            {
                if (base.fixedAge >= maxDuration ||
                (base.fixedAge >= minDuration && base.characterMotor.Motor.GroundingStatus.IsStableOnGround))// && !base.characterMotor.Motor.LastGroundingStatus.IsStableOnGround)))
                {
                    this.outer.SetNextStateToMain();
                }
            }
        }
        private void SearchForTarget()
        {
            this.search.teamMaskFilter = TeamMask.GetEnemyTeams(this.teamComponent.teamIndex);
            this.search.filterByLoS = true;
            this.search.searchOrigin = base.characterBody.corePosition;
            this.search.searchDirection = Vector3.down;
            this.search.sortMode = BullseyeSearch.SortMode.Distance;
            this.search.maxDistanceFilter = 50f;
            this.search.maxAngleFilter = 80f;
            this.search.RefreshCandidates();
            this.search.FilterOutGameObject(base.gameObject);
            this.bestCandidate = this.search.GetResults().FirstOrDefault<HurtBox>();
        }

        private void FireAttack()
        {
            currentShots++;
            

            if (bestCandidate)
            {
                if(bestCandidate.healthComponent.alive)
                    shootVector = (bestCandidate.transform.position - characterBody.corePosition).normalized;
            }

            if(fireIndex % 2 == 0)
            {
                shootLayer = "Left Arm, Additive";
                shootAnimName = "ShootL";
                muzzleIndex = "MuzzleL";
            }
            else
            {
                shootLayer = "Right Arm, Additive";
                shootAnimName = "ShootR";
                muzzleIndex = "MuzzleR";
            }

            Util.PlaySound(FireBarrage.fireBarrageSoundString, base.gameObject);
            base.PlayAnimation(shootLayer, shootAnimName, "Hand.playbackRate", baseFireInterval);
            EffectManager.SimpleMuzzleFlash(FireBarrage.effectPrefab, base.gameObject, muzzleIndex, false);

            BulletAttack bulletAttack = new BulletAttack
            {
                owner = base.gameObject,
                weapon = base.gameObject,
                origin = base.characterBody.corePosition,
                aimVector = shootVector,
                minSpread = 0f,
                maxSpread = base.characterBody.spreadBloomAngle,
                damage = damageCoefficient * this.damageStat,
                force = FirePistol2.force,
                tracerEffectPrefab = FireBarrage.tracerEffectPrefab,
                muzzleName = muzzleIndex,
                hitEffectPrefab = FireBarrage.hitEffectPrefab,
                isCrit = isCrit,
                radius = 2f,
                smartCollision = true,
                damageType = DamageType.Stun1s,
                maxDistance = 80f,
                falloffModel = BulletAttack.FalloffModel.None
            };

            bulletAttack.AddModdedDamageType(DeputyPlugin.grantDeputyBuff);

            if (base.isAuthority)
                bulletAttack.Fire();

            fireIndex++;
        }

        public override void OnExit()
        {
            base.PlayAnimation("Fullbody, Override", "BufferEmpty");
            modelAnimator.SetLayerWeight(modelAnimator.GetLayerIndex("AimYaw"), 1f);
            base.OnExit();
        }

        public override InterruptPriority GetMinimumInterruptPriority()
        {
            return InterruptPriority.Skill;
        }
    }
}
