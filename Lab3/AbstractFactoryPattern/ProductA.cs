using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class ProductA_1 : IProduct
    {
        public string GetName()
        {
            return "Product A.1";
        }
    }

    public class ProductA_2 : IProduct
    {
        public string GetName()
        {
            return "Product A.2";
        }
    }

    public class ProductB_1 : IProduct
    {
        public string GetName()
        {
            return "Product B.1";
        }
    }

    public class ProductB_2 : IProduct
    {
        public string GetName()
        {
            return "Product B.2";
        }
    }
}
