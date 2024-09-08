using RoR2;
using RoR2.Projectile;
using R2API;
using UnityEngine;
using UnityEngine.Networking;
using System;
using System.Collections.Generic;
using System.Text;
using HG;
using UnityEngine.UIElements;
using EntityStates.Commando.CommandoWeapon;
using EntityStates.EngiTurret.EngiTurretWeapon;
using System.Linq;
using Deputy.Modules;

namespace Deputy.Components
{
    [RequireComponent(typeof(ProjectileController))]
    public class RevolverProjectileBehavior : MonoBehaviour
    {
        public static int maxShots = 6;
        public static float bulletDamage = Config.gunSlingBulletDamage.Value;
        public static float procCoefficient = Config.gunSlingProcCoefficient.Value;
        public static float fireInterval = 0.3f;
        public static float blastDamage = Config.gunSlingBlastDamage.Value;
        public static float searchRadius = 30f;

        public static float lifeTime = 7f;

        private ProjectileController projectileController;
        private ProjectileDamage projectileDamage;
        private ProjectileExplosion projectileExplosion;
        private TeamFilter teamFilter;

        private GameObject owner;
        private CharacterBody ownerBody;

        private SphereSearch search;

        //internal List<HurtBox> candidates;
        internal HurtBox bestCandidate;

        private float lifeStopwatch;
        private float fireStopwatch;

        private int currentShots;
        private bool isCrit;

        public void Start()
        {
            projectileController = base.GetComponent<ProjectileController>();
            owner = projectileController.owner;
            ownerBody = owner.GetComponent<CharacterBody>();

            projectileDamage = base.GetComponent<ProjectileDamage>();
            isCrit = projectileDamage.crit;

            projectileDamage = base.GetComponent<ProjectileDamage>();
            projectileExplosion = base.GetComponent<ProjectileExplosion>();
            teamFilter = base.GetComponent<TeamFilter>();

            search = new SphereSearch();
        }

        public void FixedUpdate()
        {
            lifeStopwatch += Time.fixedDeltaTime;
            fireStopwatch += Time.fixedDeltaTime;

            if(fireStopwatch >= fireInterval && currentShots < maxShots)
            {
                fireStopwatch = 0f;

                DoSearch();

                if(bestCandidate && bestCandidate.healthComponent.alive)
                    FireBullet();
            }

            if(lifeStopwatch >= lifeTime || (currentShots >= maxShots && fireStopwatch >= fireInterval))
            {
                projectileExplosion.Detonate();
            }
        }

        public void FireBullet()
        {
            if (!owner || !ownerBody) return;
            if (!bestCandidate) return;

            Vector3 shootVector = (bestCandidate.transform.position - base.transform.position).normalized;

            if(Util.HasEffectiveAuthority(owner))
                Util.PlaySound(FireGauss.attackSoundString, base.gameObject);

            Vector3 effectOrigin = base.transform.position + (shootVector * 0.9f);
            EffectData effectData = new EffectData()
            {
                origin = effectOrigin
            };

            EffectManager.SpawnEffect(FirePistol2.muzzleEffectPrefab, effectData, false);

            if (NetworkServer.active)
            {
                currentShots++;

                BulletAttack bulletAttack = new BulletAttack
                {
                    owner = owner,
                    weapon = base.gameObject,
                    origin = base.transform.position,
                    procCoefficient = procCoefficient,
                    aimVector = shootVector,
                    minSpread = 0f,
                    maxSpread = 0f,
                    damage = bulletDamage * ownerBody.damage,
                    force = FirePistol2.force,
                    tracerEffectPrefab = FireBarrage.tracerEffectPrefab,
                    hitEffectPrefab = FirePistol2.hitEffectPrefab,
                    isCrit = isCrit,
                    radius = 2f,
                    smartCollision = true,
                    damageType = DamageType.Generic,
                    maxDistance = 80f,
                    falloffModel = BulletAttack.FalloffModel.None,
                    stopperMask = LayerIndex.entityPrecise.mask
                };

                bulletAttack.AddModdedDamageType(DeputyPlugin.grantDeputyBuff);

                bulletAttack.Fire();
            }
        }

        public void DoSearch()
        {
            search.origin = base.transform.position;
            search.mask = LayerIndex.entityPrecise.mask;
            search.radius = searchRadius;
            search.RefreshCandidates();
            search.FilterCandidatesByHurtBoxTeam(TeamMask.GetEnemyTeams(teamFilter.teamIndex));
            search.OrderCandidatesByDistance();
            search.FilterCandidatesByDistinctHurtBoxEntities();
            bestCandidate = search.GetHurtBoxes().FirstOrDefault<HurtBox>();
            search.ClearCandidates();
        }
    }
}
