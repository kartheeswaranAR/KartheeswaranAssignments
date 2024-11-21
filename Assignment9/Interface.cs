using System;

namespace CsharpTraining
{
    interface IEmployee1Details
    {
        void EmployeeDetails();
        void EmployeeDetails1(int EmpNumber, string EmpName);
    }
    
    class Interface : IEmployee1Details
    {
        public void EmployeeDetails()
        {
            Console.WriteLine("\nEnter the Employee Number :");
            int EmpNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the  Employee Name :");
            string EmpName = Console.ReadLine();
            Console.WriteLine("The Employee Details are : [{0},{1}]", EmpNumber, EmpName);
            string EmpCompany = "Abstract Tech";
            string CompanyBranch = "Remote/WFH";
            Console.WriteLine("Your Current Company Name and Branch Is : [{0},{1}]",EmpCompany,CompanyBranch);

        }
        public void EmployeeDetails1(int EmpNumber, string EmpName)
        {
            Console.WriteLine("\nThe Employee Details are : [{0},{1}]", EmpNumber, EmpName);
            string EmpCompany = "Abstract Tech";
            string CompanyBranch = "Remote/WFH";
            Console.WriteLine("Your Current Company Name and Branch Is : [{0},{1}]", EmpCompany, CompanyBranch);

        }
    }
}
