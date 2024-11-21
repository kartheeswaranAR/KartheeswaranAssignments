using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    class MethodOverriding
    {
        public class BaseClass
        {
            public virtual void Print()
            {
                Console.WriteLine("\nThis is base class");
            }
        }
        public class ChildClass : BaseClass
        {
            public override void Print()
            {
                Console.WriteLine("This is child class");
            }
        }
        public class OverClass : BaseClass
        {
            public new void Print()
            {
                Console.WriteLine("This is child class");
            }
        }


        public static void ExampleData()
            {
                BaseClass BCO = new BaseClass();
                BCO.Print();
                BaseClass BC = new ChildClass();
                BC.Print();
                OverClass OC = new OverClass();
                OC.Print();
            }
        

    }
}
