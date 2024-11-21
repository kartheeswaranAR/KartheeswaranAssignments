using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class UserInput
    {
        public static void userinput()
        {
            //user input
            Console.WriteLine("Enter Your Firstname :");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter Your Lastname : ");
            string lastname = Console.ReadLine();

            Console.WriteLine("Your Name is : " + firstname + " " + lastname ); //conventional method 
            Console.WriteLine("Your Name is : {0} {1}", firstname, lastname); //placeholder method
        }
    }
}
