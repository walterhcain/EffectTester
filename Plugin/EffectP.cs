using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using Rocket.Unturned.Player;
using SDG.Unturned;
using System;

namespace walterhcain.EffectTester
{
    public class EffectP : RocketPlugin<EffectC>
    {
        public static EffectP Instance;
        protected override void Load()
        {
            Instance = this;
            Logger.Log("Cain's Effect Tester has been successfully loaded");
        }

        protected override void Unload()
        {
            Logger.Log("Cain's Effect Tester has been successfully unloaded");
        }
    }
}
