using Skillstates.Deputy;
using System.Collections.Generic;
using System;

namespace Deputy.Modules
{
    public static class States
    {
        internal static void RegisterStates()
        {
            #region Deputy
            Modules.Content.AddEntityState(typeof(DeputyMainState));
            Modules.Content.AddEntityState(typeof(TriggerTap));

            Modules.Content.AddEntityState(typeof(GunSling));
            
            Modules.Content.AddEntityState(typeof(ShootingStar));

            Modules.Content.AddEntityState(typeof(CometDash));
            Modules.Content.AddEntityState(typeof(CometBounce));

            Modules.Content.AddEntityState(typeof(BulletHeaven));
            Modules.Content.AddEntityState(typeof(BulletHeavenExit));
            Modules.Content.AddEntityState(typeof(BulletHeavenLoop));
            #endregion
        }
    }
}