using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Obj1 obj1 = new Obj1();
            Obj2 obj2 = new Obj2();
    
            obj1.TemplateMethod();
            obj2.TemplateMethod();
    
            Console.Read();
        }
    }

    abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            Operation1();
            Operation2();
            OperationBoth();
        }

        public virtual void Operation1()
        {
            Console.WriteLine("Operation1");
        }

        public virtual void Operation2()
        {
            Console.WriteLine("Operation2");
        }

        public virtual void OperationBoth()
        {
            Console.WriteLine("OperationBoth");
        }

    }
        
    class Obj1 : AbstractClass
    {
        public override void Operation1()
        {
            Console.WriteLine("Override Operation1");
        }

        public override void OperationBoth()
        {
            Console.WriteLine("OperationBoth1");
        }
    }
    
    class Obj2 : AbstractClass
    {
        public override void Operation2()
        {
            Console.WriteLine("Override Operation2");
        }

        public override void OperationBoth()
        {
            Console.WriteLine("OperationBoth2");
        }
    }
}