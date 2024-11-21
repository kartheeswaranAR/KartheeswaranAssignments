using System;

namespace CSharpTraining
{
    interface IEmpDetails  //it support instance and call the method from abstract class
    {
        void Developers();
    }

    abstract class Details : IEmpDetails  //it doesn't support for instance
    {
        public void Developers()
        {
            EmployeeDetails empdetails = new EmployeeDetails();
            Console.WriteLine("Enter your company name :");
            string CompName = Console.ReadLine();
            long EmpCount=0;
            long DevCount=0;
            long TestCount=0;

            if (CompName.ToUpper() == "TCS")
            {
                EmpCount = 1140;
                DevCount = EmpCount/2;
                TestCount = EmpCount/4;
            }
            else if (CompName.ToUpper() == "WIPRO")
            {
                EmpCount = 1198;
                DevCount = EmpCount / 2;
                TestCount = EmpCount / 4;
            }
            else if (CompName.ToUpper() == "ABSTRACT-TECH")
            {
                EmpCount = 250;
                DevCount = EmpCount / 2;
                TestCount = EmpCount / 4;
            }
            else
            {
                Console.WriteLine("There is no company registerd...");
            }

            empdetails.EmpDetExample(EmpCount,DevCount,TestCount);
        }

    }
}
