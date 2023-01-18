using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class ConcreteBuilder : IBuilder
    {
        private Product product = new Product();

        public void BuildPartA()
        {
            product.Add("PartX");
        }

        public void BuildPartB()
        {
            product.Add("PartY");
        }

        public void BuildPartC()
        {
            product.Add("PartZ");
        }

        public Product GetResult()
        {
            return product;
        }
    }
}
