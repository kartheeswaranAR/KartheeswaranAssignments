using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    class MethodHiding
    {
        public class Employee
        {
            public string FirstName;
            public string LastName;
            public void GetEmployeeDetails()
            {
                Console.WriteLine("The name of the employee is {0} {1}", FirstName, LastName);
            }
        }
        //Derived Class Base Class
        public class PermanentEmployee : Employee
        {
            public int MonthlySalary;
            public new void GetEmployeeDetails()
            {
                //base.GetEmployeeDetails();
                Console.WriteLine("The name of the employee is {0} {1} - {2}", FirstName, LastName, "Permanent");
                Console.WriteLine("The Employee Salary is :" + MonthlySalary);
            }
        }

       
        public class ContractEmployee : Employee
        {
            public int DailySalary;
            
        }
      
            public static void ExampleData()
            {
                PermanentEmployee PE = new PermanentEmployee();
                Console.WriteLine("Enter the firstname :");
                PE.FirstName = Console.ReadLine();
                Console.WriteLine("Enter the lastname :"); 
                PE.LastName = Console.ReadLine();
                PE.MonthlySalary = 100000;
                PE.GetEmployeeDetails();
                ContractEmployee CE = new ContractEmployee();
                Console.WriteLine("Enter the firstname :");
                CE.FirstName = Console.ReadLine();
                Console.WriteLine("Enter the lastname :");
                CE.LastName = Console.ReadLine();
                CE.DailySalary = 2500;
                Console.WriteLine("The salary for contracted employee is :"+ CE.DailySalary);
                CE.GetEmployeeDetails();
            }
        
    }
}
