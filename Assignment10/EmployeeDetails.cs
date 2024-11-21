using System;

namespace CSharpTraining
{
    class EmployeeDetails:Details
    {
       public void EmpDetExample(long EmpCount,long DevCount,long TestCount)
        {
            Console.WriteLine("The total count of employee in your company : {0}",EmpCount);
            Console.WriteLine("The total developers count is : {0}", DevCount);
            Console.WriteLine("The total testers count is : {0}", TestCount);
        }
        
    }
   
}
