using System;

namespace CsharpTraining
{
    public class InstanceMethod
    {
        //Instance method
        public void PrintOddNumbers()
        {
            Console.WriteLine("\n");
            int Counter = 1;
            while (Counter <= 19)
            {
                Console.WriteLine("The value of Counter is {0} ", Counter);
                Counter += 2;
            }
        }
        public int Calculate(int num1, int num2, char action) //Parameter
        {
            int CalculatedValue = 0;
            switch (action)
            {
                case 'A':
                    CalculatedValue = num1 + num2;
                    break;
                case 'S':
                    CalculatedValue = num1 - num2;
                    break;
                case 'M':
                    CalculatedValue = num1 * num2;
                    break;
                case 'D':
                    CalculatedValue = num1 / num2;
                    break;
            }
            return CalculatedValue;
        }



    }
}
