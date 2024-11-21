using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    class Program
    {
        static void Main()
        {
            BestLaptop BLaptop = new BestLaptop();
            BLaptop.BestLaptopMethod();

            LambdaExpExample.Medical_Tablet med_Tab = new LambdaExpExample.Medical_Tablet();
            med_Tab.PrintTablet();

            ExceptionHandlingExample exceptionHandling = new ExceptionHandlingExample();
            exceptionHandling.Exc_HandlingMethod();
        }
    }
}
