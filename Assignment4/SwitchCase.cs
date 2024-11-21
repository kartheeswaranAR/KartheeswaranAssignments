using System;

namespace CsharpTraining
{
    class SwitchCase
    {
        public static void Statement(string[] name , int[] id)
        {
            Console.WriteLine("Enter the Number to print the Employee : ");
            int empno = int.Parse(Console.ReadLine());
            switch (empno)
            {
                case 1:
                    Console.WriteLine("The Employee Name and ID is [{0}] [{1}]", name[0], id[0]);
                    break;
                case 2:
                    Console.WriteLine("The Employee Name and ID is [{0}] [{1}]", name[1], id[1]);
                    break;
            }

        }
      
    }
}
