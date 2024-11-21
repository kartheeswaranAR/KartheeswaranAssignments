using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    //Tightly Coupled 
    public class IDChecker
    {
        public static bool EmpIDCheck(int Value,int EmpID)
        {
            return Value==EmpID;
        }
    }
    public class ClientID
    {
        public static void ClientMethod()
        {
            Console.WriteLine("\nEnter the EmpID :");
            int Value1 = Convert.ToInt32(Console.ReadLine());
            bool Equal = IDChecker.EmpIDCheck(Value1,1001);
            if (Equal)
            {
                Console.WriteLine("Hi , kartheeswaran");
            }
            else
            {
                Console.WriteLine("This is bad ID, Enter correct ID !!");
            }
        }
    }

    //Loosly Coupled
    public class CompareName
    {
        public static bool CheckEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
    }

    public class ClientName
    {
        public static void ClientNameMethod()
        {
            Console.WriteLine("Enter the EmpID :");
            int Val1 = Convert.ToInt32(Console.ReadLine());
            bool Equal1 = CompareName.CheckEqual<int>(Val1, 1001);
            Console.WriteLine("Enter the EmpName :");
            string Val2 = Console.ReadLine();
            bool Equal2 = CompareName.CheckEqual<string>(Val2, "Kartheeswaran");

            Console.WriteLine(!Equal1 ? "ID's are Not Equal" : "ID's are Equal");
            Console.WriteLine(!Equal2 ? "Name's are Not Equal" : "Name's are Equal");
        }
    }
}
