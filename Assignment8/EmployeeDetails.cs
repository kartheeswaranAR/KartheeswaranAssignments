using System;

namespace CsharpTraining
{
    struct EmployeeDetails
    {
       
            public int EmpID { set; get; }
            public string EmpName { set; get; }
        

        public class Client
        {
            public static void SampleDetails()
            {
                Console.WriteLine("\nEnter the Employee ID :");
                int EmpID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Employee Name :");
                string EmpName = Console.ReadLine();

                EmployeeDetails ED = new EmployeeDetails();
                ED.EmpID = 4598732;
                ED.EmpName = "Kartheeswaran";


                Console.WriteLine("The Employee Details are : {0} ,{1}", EmpID, EmpName);
                Console.WriteLine("The Employee Details are : {0} ,{1}", ED.EmpID, ED.EmpName);

            }
        }
    }
}
