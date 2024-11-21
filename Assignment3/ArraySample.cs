using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining
{
    class ArraySample
    {
        /// <summary>
        /// ARRAY EXAMPLE
        /// </summary>
        public static void  Arrayexample()
        {
            //int[] array1 = { 1, 2, 2, 3, 4, 5, 6, 7, 7, 8, 8 };  
            //array values right away and omitting the new keyword and without specifying sizes
            
            //object[] array1 = new object[] {"volvo",1,2,3,4,"cars",45.3,"cars1",496.25895}; // array without specifying size
            
            //object[] array1 = new object[5];
            //array1[0]="cars"
            //array1[1]="cars"      //array values later
            //array1[2]="cars"
            //array1[3]="cars"
            //array1[4]="cars"


            //Console.WriteLine(array1[i]);
            //foreach (object obj1 in array1)
            //{
            //    Console.WriteLine("\nThe Array input is : [{0}]\n",obj1);
            //}
            //object obj1 = array1[i];
            //Console.WriteLine("\nThe Array input is : [{0}]\n", string.Join(", ", obj1));

            
            //user defined array
            Console.WriteLine("Enter the Size of an Array :\n");
            int n = Convert.ToInt32(Console.ReadLine());
            object[] array1 = new object[n];
            Console.WriteLine("\nEnter the Elements to an Array :\n");
           // int i;
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = Console.ReadLine();
            }
            Array.Sort(array1);
            string allContents = string.Join(", ", array1);
            //for (int i = 0; i < array1.Length; i++)
            //{
            //     Console.WriteLine(array1[i]);
            //}
            Console.WriteLine("\nThe Array input in ascending order is : [{0}]\n", allContents);
            Array.Reverse(array1);
            string allContentsdes = string.Join(", ", array1);
            Console.WriteLine("\nThe Array input in descending order is : [{0}]\n", allContentsdes);
        }
    }
}
