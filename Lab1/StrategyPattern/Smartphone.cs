using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Smartphone
    {
        private IUsable usable;
        public void SetUse(IUsable iUsable)
        {
            usable = iUsable;
        }

        public void StartUse()
        {
            usable.Use();
        }
    }
}
