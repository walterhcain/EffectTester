using Rocket.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace walterhcain.EffectTester
{
    public class EffectC : IRocketPluginConfiguration
    {
        public string DontNeed;
        public void LoadDefaults()
        {
            DontNeed = "Nothing";
        }
    }
}
