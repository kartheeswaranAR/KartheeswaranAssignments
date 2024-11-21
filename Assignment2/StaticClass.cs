using System;
namespace CsharpTraining
{
    public class StaticClass
    {
        //Static Method
        public static void PrintEvenNumbers()
        {
            int Counter = 0;
            while (Counter <= 20)
            {
                Console.WriteLine("The value of Counter is {0} ", Counter);
                Counter += 2;
            }
        }
        //Static Method with parameter
        public static void PrintOddNumbersWithMax(int MaxNumber)
        {
            Console.WriteLine("\n");
            int Counter = 1;
            while (Counter <= MaxNumber)
            {
                Console.WriteLine("The value of Counter is {0} ", Counter);
                Counter += 2;
            }
        }


        //Passing by value
        public static void FinalValue(int Value) //Parameter
        {
            Value = 20;
        }

        //Passing by reference
        public static void FinalValueByReference(ref int Value) //Parameter
        {
            Value = 20;
        }

        //Returning output values
        public static void Calculate1(int num1, int num2, out int Sum, out int Product) //Parameter
        {
            Sum = num1 + num2;
            Product = num1 * num2;
        }

        //Passing params
        public static void Vehicles(params string[] vehicles) //Parameter
        {
            Console.WriteLine("\nThe vehicles are");
            foreach (string s in vehicles)
            {
                Console.WriteLine(s);
            }
        }
    }
}
