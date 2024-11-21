using System;

namespace CsharpTraining
{
    class Loops
    {
        public static void WhileloopExample()  //while loop
        {
            int x = 1;
            while (x <= 4)
            {
                Console.WriteLine("@ -- While loop\n");
                x++;
            }
        }
        public static void ForloopExample()  // for loop
        {
            for (int x = 1; x <= 4; x++)
            {
                Console.WriteLine("*-- For Loop\n");
            }
        }
        public static void DoloopExample()  // do while loop
        {
            Console.WriteLine("Enter the number between 0,20 :");
            int x = Convert.ToInt32(Console.ReadLine()); 
            do
            {
                Console.WriteLine("# -- Do Loop\n");
                x++;
            }
            while (x < 20);
        }
        public static void ForeachloopExample()  // for-each loop
        {
            string[] authorList = new string[2];
            Console.WriteLine("Enter the data into array :");
            for (int i=0;i<authorList.Length;i++)
            {
                authorList[i]=Console.ReadLine();
            }
            // for each method
            foreach (string author in authorList)
            {
                Console.WriteLine("The array list is :"+author);
            }
            // join method
            string allContents = string.Join(", ", authorList);
            Console.WriteLine("The array list is : [{0}]" , allContents);
        }
    }
}
