using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class ContractEmployee : Employee
    {
        public int DailySalary;
        public void GetEmployeeDetails()
        {
            Console.WriteLine("The name of the employee is {0} {1}", FirstName, LastName);
            Console.WriteLine("The email of the employee is {0}", Email);
            Console.WriteLine("The salary of the employee is {0}", DailySalary);
        }
    }
}
