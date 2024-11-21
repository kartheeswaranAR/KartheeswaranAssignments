using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    class ClientApp
    {
        public static void ExampleData()
        {
            PermanentEmployee PE = new PermanentEmployee();
            Console.WriteLine("\nEnter the FirstName : \t");
            PE.FirstName = Console.ReadLine();
            Console.WriteLine("\nEnter the lastName : \t");
            PE.LastName = Console.ReadLine();
            Console.WriteLine("\nEnter the Email ID : \t");
            PE.Email = Console.ReadLine();
            PE.MonthlySalary = 128900;
            PE.GetEmployeeDetails();

            ContractEmployee CE = new ContractEmployee();
            Console.WriteLine("\nEnter the FirstName : \t");
            CE.FirstName = Console.ReadLine();
            Console.WriteLine("\nEnter the lastName : \t");
            CE.LastName = Console.ReadLine();
            Console.WriteLine("\nEnter the Email ID : \t");
            CE.Email = Console.ReadLine();
            CE.DailySalary = 126000;
            CE.GetEmployeeDetails();
        }
    }
}
