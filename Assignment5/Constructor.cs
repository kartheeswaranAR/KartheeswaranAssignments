using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class ConstructorProgram
    {
        public string firstname;
        public string lastname;
        public int employee_salary;

        //parameterized constructor
        public ConstructorProgram(string Fname, string Lname, int emp_sal)
        {
            firstname = Fname;
            lastname = Lname;
            employee_salary = emp_sal;
        }

        //parameterless constructor
        public ConstructorProgram() : this("no employee firstname is exist in company", "no employee lastname is exist in company", 0)
        {
            Console.WriteLine("There is no data for employee");
        }
        ~ConstructorProgram() //destructor
        {
            Console.WriteLine("The Destructor was called");
        }
        public void ConstructorExample()
        {
            Console.WriteLine("\nEnter the Firstname :\n");
            firstname = Console.ReadLine();
            Console.WriteLine("\nEnter the Lastname :\n");
            lastname = Console.ReadLine();
            Console.WriteLine("\nEnter the Employee Salary :\n");
            employee_salary = Convert.ToInt32(Console.ReadLine());

            ConstructorProgram cons_obj = new ConstructorProgram();
            Console.WriteLine("The Employee Details is : [{0} {1} {2}]", firstname, lastname, employee_salary);
        }

    }
}
