using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining
{
    class Program
    {
        static void Main()
        {
            //Name Input
            Console.WriteLine("Enter the Name of employee : ");
            string[] name = new string[2];
            for (int i = 0; i < name.Length; i++)
            {
                name[i] = Console.ReadLine();
            }

            //ID Input
            Console.WriteLine("Enter the ID of employee : ");
            int[] id = new int[2];
            for (int i = 0; i < id.Length; i++)
            {
                id[i] = Convert.ToInt32(Console.ReadLine());
            }

            //switch case
            SwitchCase.Statement(name,id);

            //loops
            Loops.WhileloopExample();
            Loops.ForloopExample();
            Loops.DoloopExample();
            Loops.ForeachloopExample();

            //Exit Flag
            ExitFlag();
        }

        static void ExitFlag() //Exit Flag to Exit Program
        {
            bool exitflag = true;
            while (exitflag)
            {
                Console.WriteLine("Repeat the program? (Y/N)");
                string rep = Console.ReadLine();
                if (rep.ToUpper() == "Y")
                {
                    Main();
                }
                else
                {
                    exitflag = false;
                }
            }
        }

    }
}
