using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Adapter : ITarget
    {
        private Adaptee adapter;

        public Adapter(Adaptee adaptee)
        {
            adapter = adaptee;
        }

        public string GetRequest()
        {
            return $"This is '{adapter.GetSpecificRequest()}'";
        }
    }
}
