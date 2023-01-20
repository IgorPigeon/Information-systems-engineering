using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class SamsungGalaxy : Smartphone
    {
        public SamsungGalaxy()
        {
            this.SetUse(new AndroidUse());
        }
    }
}
