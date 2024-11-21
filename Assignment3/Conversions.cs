using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining
{
    class Conversions
    {
        public static void Implicit_Conversion()
        {
            float num = 0.2147483647F;
            double bigNum = num;
            Console.WriteLine("The Implicit converted value is {0}\n", bigNum);
        }


        public static void Explicit_Conversion()
        {

            float x = 123.4342F;
            int a;
            // Cast double to int.
            a = (int)x;
            Console.WriteLine("The Explicit converted value is {0}\n", a);


        }
    }
}
