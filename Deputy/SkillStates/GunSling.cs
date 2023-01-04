﻿using UnityEngine;
using RoR2;
using EntityStates;
using EntityStates.Bandit2.Weapon;
using EntityStates.Engi.EngiWeapon;
using Deputy.Components;
using Deputy.Modules;
using RoR2.Projectile;
using System;

namespace Skillstates.Deputy
{
    internal class GunSling : BaseState
    {
        public static float baseDuration = 1.1f;
        public static float basePrepTime = 0.45f;
        public static float rotationAngle = 10f;

        private GameObject gunsMesh;

        private DeputyAnimatorController DAC;
        private Animator modelAnimator;

        private Ray aimRay;

        private float duration;
        private float prepTime;
        private bool hasFired;

        public override void OnEnter()
        {
            base.OnEnter();
            DAC = base.GetComponent<DeputyAnimatorController>();

            duration = baseDuration / attackSpeedStat;
            prepTime = duration * basePrepTime;

            

            gunsMesh = base.FindModelChild("GunsMesh").gameObject;

            modelAnimator = base.GetModelAnimator();
            modelAnimator.SetLayerWeight(modelAnimator.GetLayerIndex("AimYaw"), 0f);

            DAC.SetCombatState(DeputyAnimatorController.combatState.LeavingCombat);

            if (!characterMotor.isGrounded)
            {
                characterMotor.velocity.y = 0f;
                base.SmallHop(characterMotor, 10f);
            }

            Util.PlaySound("Play_bandit2_R_load", base.gameObject);

            base.PlayCrossfade("FullBody, Override", "Gun Sling", "Hand.playbackRate", duration, 0.1f * duration);
        }

        public override void FixedUpdate()
        {
            base.FixedUpdate();

            base.StartAimMode(Time.fixedDeltaTime, false);

            if (base.fixedAge >= prepTime && !hasFired)
            {
                ThrowGuns();
            }

            if (base.fixedAge >= duration)
            {
                this.outer.SetNextStateToMain();
            }
        }

        public void ThrowGuns()
        {
            hasFired = true;
            gunsMesh.SetActive(false);

            aimRay = base.GetAimRay();
            Vector3 rhs = Vector3.Cross(Vector3.up, aimRay.direction);
            Vector3 axis = Vector3.Cross(rhs, aimRay.direction);

            Vector3 leftRevolver = Quaternion.AngleAxis(-rotationAngle, axis) * aimRay.direction;
            Vector3 rightRevolver = Quaternion.AngleAxis(rotationAngle, axis) * aimRay.direction;

            Util.PlaySound(FireMines.throwMineSoundString, base.gameObject);
            FireProjectileInfo fireProjectileInfo = new FireProjectileInfo();
            fireProjectileInfo.crit = base.RollCrit();
            fireProjectileInfo.damage = RevolverProjectileBehavior.blastDamage * base.damageStat;
            fireProjectileInfo.force = 100f;
            fireProjectileInfo.owner = base.gameObject;
            fireProjectileInfo.position = aimRay.origin; //leftHand.position;
            fireProjectileInfo.rotation = Util.QuaternionSafeLookRotation(leftRevolver);
            fireProjectileInfo.projectilePrefab = Projectiles.revolverProjectile;
            ProjectileManager.instance.FireProjectile(fireProjectileInfo);

            fireProjectileInfo.rotation = Util.QuaternionSafeLookRotation(rightRevolver);
            ProjectileManager.instance.FireProjectile(fireProjectileInfo);
        }

        public override void OnExit()
        {
            gunsMesh.SetActive(true);
            modelAnimator.SetLayerWeight(modelAnimator.GetLayerIndex("AimYaw"), 1f);
            base.OnExit();
        }

        public override InterruptPriority GetMinimumInterruptPriority()
        {
            return InterruptPriority.PrioritySkill;
        }
    }
}
