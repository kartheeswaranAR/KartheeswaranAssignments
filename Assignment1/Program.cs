using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("CSharp Training Program");

            //call method from another file
            //UserInput user = new UserInput();
            //Operators opera = new Operators();
            UserInput.userinput();
            Operators.OperatorsExample();
            //Console.WriteLine(user);
            //Console.WriteLine(opera);

        }
    }
}
