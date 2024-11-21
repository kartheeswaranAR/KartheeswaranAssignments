using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public  class Operators
    {
        public static void OperatorsExample()
        {
            Console.WriteLine("\n1.Arithmetic Operator\n");
            Console.WriteLine("2.Comparision Operator\n");
            Console.WriteLine("3.Logical Operator\n");
            Console.WriteLine("4.Assignment Operator\n");
            Console.WriteLine("Enter the Number to do Operations : ");
            string value = Console.ReadLine();
            Console.WriteLine("Enter the value 1 :");
            int value1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value 2 :");
            int value2 = Convert.ToInt32(Console.ReadLine());
            //Arithmetic
            if (value == "1")
            {
                int add= value1 + value2;
                Console.WriteLine("The Added Values is :"+add);
                int sub = value1 - value2;
                Console.WriteLine("The Subracted Value is :"+sub);
                int multiply = value1 * value2;
                Console.WriteLine("The Multiplied Value is :"+multiply);
                int divide = value1 / value2;
                Console.WriteLine("The Divided Value is :"+divide);
                int modulus = value1 % value2;
                Console.WriteLine("The Modulus Value are :"+modulus);
            }
            //Comparision
            else if (value == "2")
            {
                bool greater = value1 >= value2;
                Console.WriteLine("The Greater Value is :"+greater);
                bool Lesser = value1 <= value2;
                Console.WriteLine("The Lesser Value is :"+Lesser);
                bool Equality = value1 == value2;
                Console.WriteLine("The Values are equal :"+Equality);
                bool NonEquality = value1 != value2;
                Console.WriteLine("The Values are Not equal :" + NonEquality);;
            }
            //logical
            else if (value == "3")
            {
                bool andoperator = value1 > 5 && value2 < 10;
                Console.WriteLine(andoperator);
                bool oroperator = value1 > 5 || value2 < 10;
                Console.WriteLine(oroperator);
                bool notoperator = !(value1 > 5 && value2 < 10);
                Console.WriteLine(notoperator);
            }
            //Assignment
            else 
            {
                int assignadd = Convert.ToInt32(value1+=value2);
                Console.WriteLine("The Added Value is :" + assignadd);
                int assignsub = Convert.ToInt32(value1 -= value2);
                Console.WriteLine("The subracted Value is :" + assignsub);
                int assignmultiply = Convert.ToInt32(value1 *= value2);
                Console.WriteLine("The Multiply Value : " + assignmultiply);
                int assigndivide = Convert.ToInt32(value1 /= value2);
                Console.WriteLine("The Divided Value :" + assigndivide);
                int assignModulus = Convert.ToInt32(value1 %= value2);
                Console.WriteLine("The Modulus Values are :" + assigndivide); 
            }
        }
    }
}
