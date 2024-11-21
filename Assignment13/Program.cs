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
            string value = string.Empty;  //string method
            value += "This";
            value += "is";
            value += "Normal";
            value += "string";
            value += "Created by Kartheeswaran";

            StringBuilder value1 = new StringBuilder(); //String Builder Function
            value1.Append("This");
            value1.Append("is");
            value1.Append("String Builder");
            value1.Append("Function");
            value1.Append("Created by Kartheeswaran");

            //Partial Class Method
            PartialClassExample.PartialMethod();

            ClientApp.ClientMethod();


        }
    }
}
