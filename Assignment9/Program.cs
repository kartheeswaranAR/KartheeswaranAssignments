using System;


namespace CsharpTraining
{
    class Program
    {
        static void Main()
        {
            ExplicitInterface interfaceexample = new ExplicitInterface();
            ((IBankDetails)interfaceexample).BankDetails();
            ((IBankDetails1)interfaceexample).BankDetails();

            //interfaceexample.BankDetails(); //For explicit it shows error

            Interface interfaceexample1 = new Interface();
            interfaceexample1.EmployeeDetails();
            interfaceexample1.EmployeeDetails1(897511,"Kartheeswaran");
        }
    }
}
