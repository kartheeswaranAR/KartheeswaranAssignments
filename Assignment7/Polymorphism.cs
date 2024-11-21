using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    class Polymorphism
    {
        public class Employee
        {
            public string FirstName = "kartheeswaran";
            public string LastName = "R";

            public virtual void GetEmployeeDetails()
            {
                Console.WriteLine("\nBase class employee details {0} {1}", FirstName, LastName);
            }
        }
        //Derived Class Base Class 
        public class PermanentEmployee : Employee
        {
            public override void GetEmployeeDetails()
            {
                Console.WriteLine("Derived class (Permanent) employee details {0} {1}", FirstName, LastName);
            }
        }
        public class ContractEmployee : Employee
        {
            public override void GetEmployeeDetails()
            {
                Console.WriteLine("Derived class (Contract) employee details {0} {1}", FirstName, LastName);
            }
        }
       
            public static void ExampleData()
            {
                Employee[] employees = new Employee[3];
                employees[0] = new Employee();
                employees[1] = new PermanentEmployee();
                employees[2] = new ContractEmployee();
                foreach (Employee emp in employees)
                {
                    emp.GetEmployeeDetails();
                }
            }
        


    }
}

