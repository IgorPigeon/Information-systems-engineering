using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class IosUse : IUsable
    {
        public void Use()
        {
            Console.WriteLine("IOS use");
        }
    }
}
