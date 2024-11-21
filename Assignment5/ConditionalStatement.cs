using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class ConditionalStatement
    {
        public void CondnExample()
        {
            Console.WriteLine("Enter the Number to check the type :\n");
            int numtype=Convert.ToInt32(Console.ReadLine());
            if (numtype == 0 && numtype <=0)
            {
                Console.WriteLine("The Given number is 0 or it will be negative number !!");
            }
            else if (numtype >= 10)
            {
                Console.WriteLine("The Given number is above 10");
            }
            else if (numtype >= 100)
            {
                Console.WriteLine("The Given number is above 100");
            }
        }
    }
}
