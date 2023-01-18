using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class ConcreteFactory_1 : IAbstractFactory
    {
        public IProduct CreateProductA()
        {
            return new ProductA_1();
        }

        public IProduct CreateProductB()
        {
            return new ProductB_1();
        }
    }

    public class ConcreteFactory_2 : IAbstractFactory
    {
        public IProduct CreateProductA()
        {
            return new ProductA_2();
        }

        public IProduct CreateProductB()
        {
            return new ProductB_2();
        }
    }
}
