using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\nEnter the Patient Name :");
            string name = Console.ReadLine();
            Console.WriteLine("\nEnter the Patient ID :");
            int ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the Patient Ward :");
            int Ward = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the Patient Disease :");
            string Disease = Console.ReadLine();

            HospitalDetails HD = new HospitalDetails(name,ID,Ward,Disease);
            HD.GetDetails();

            //Second Method
            HospitalDetails HD2 = new HospitalDetails()
            {
                Name = "Karthi",
                ID = 223456,
                Ward= 12,
                Disease= "Colera"
            };
            HD2.GetDetails();


            EmployeeDetails.Client.SampleDetails();
        }
    }
}
