using R2API;
using RoR2;
using RoR2.Projectile;
using Deputy.Components;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Networking;
using System;

namespace Deputy.Modules
{
    internal static class Projectiles
    {
        //internal static GameObject bombPrefab;
        //internal static GameObject javelinPrefab;
        internal static GameObject revolverProjectile;
        internal static void RegisterProjectiles()
        {
            CreateRevolverProjectile();
            AddProjectile(revolverProjectile);
        }

        private static void CreateRevolverProjectile()
        {
            GameObject baseProjectile = Addressables.LoadAsset<GameObject>("RoR2/Base/Toolbot/ToolbotGrenadeLauncherProjectile.prefab").WaitForCompletion();
            revolverProjectile = PrefabAPI.InstantiateClone(baseProjectile, "RevolverProjectile");

            revolverProjectile.AddComponent<RevolverProjectileBehavior>();

            revolverProjectile.AddComponent<DamageAPI.ModdedDamageTypeHolderComponent>().Add(DeputyPlugin.grantDeputyBuff);

            RotateObject rotateObject = revolverProjectile.AddComponent<RotateObject>();
            rotateObject.rotationSpeed = new Vector3(0f, -1440f, 0f);

            ProjectileController projectileController = revolverProjectile.GetComponent<ProjectileController>();
            GameObject revolverGhost = CreateGhostPrefab("RevolverGhost");
            projectileController.ghostPrefab = revolverGhost;

            ProjectileSimple projectileSimple = revolverProjectile.GetComponent<ProjectileSimple>();
            projectileSimple.lifetime = 10f;
            projectileSimple.desiredForwardSpeed = 150f;

            UnityEngine.Object.Destroy(revolverProjectile.GetComponent<ProjectileImpactExplosion>());

            Rigidbody rigidBody = revolverProjectile.GetComponent<Rigidbody>();
            rigidBody.drag = 4.5f;

            ProjectileExplosion projectileExplosion = revolverProjectile.AddComponent<ProjectileExplosion>();
            projectileExplosion.blastDamageCoefficient = 1f;
            projectileExplosion.blastRadius = 10f;
            projectileExplosion.falloffModel = BlastAttack.FalloffModel.None;
            projectileExplosion.explosionEffect = baseProjectile.GetComponent<ProjectileImpactExplosion>().impactEffect;
        }

        internal static void AddProjectile(GameObject projectileToAdd)
        {
            Modules.Content.AddProjectilePrefab(projectileToAdd);
        }

        private static GameObject CreateGhostPrefab(string ghostName)
        {
            GameObject ghostPrefab = Modules.DeputyAssets.mainAssetBundle.LoadAsset<GameObject>(ghostName);

            if(!ghostPrefab)
            {
                Log.Warning("Revolver ghost prefab is null");
            }

            if (!ghostPrefab.GetComponent<NetworkIdentity>()) ghostPrefab.AddComponent<NetworkIdentity>();
            if (!ghostPrefab.GetComponent<ProjectileGhostController>()) ghostPrefab.AddComponent<ProjectileGhostController>();
            if (!ghostPrefab.GetComponent<VFXAttributes>())
            {
                var vfx = ghostPrefab.AddComponent<VFXAttributes>();
                vfx.DoNotPool = true;
            }
            //Modules.Assets.ConvertAllRenderersToHopooShader(ghostPrefab);

            return ghostPrefab;
        }

        private static GameObject CloneProjectilePrefab(string prefabName, string newPrefabName)
        {
            GameObject newPrefab = PrefabAPI.InstantiateClone(RoR2.LegacyResourcesAPI.Load<GameObject>("Prefabs/Projectiles/" + prefabName), newPrefabName);
            return newPrefab;
        }
    }
}