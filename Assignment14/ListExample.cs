using System;
using System.Collections.Generic;

namespace CSharpTraining
{
    class BestLaptop
    {
        public void BestLaptopMethod()
        {
            string[] Laptop = new string[4];

            Laptop[0] = "Apple Laptop";
            Laptop[1] = "Asus Laptop";
            Laptop[2] = "Dell Laptop";
            Laptop[3] = "HP Laptop";

            // CONVERTING AN ARRAY TO LIST 
            List<string> Laptops = new List<string>(Laptop);
            foreach (string BL in Laptop)
            {
                Console.WriteLine(BL);
            }

            Console.WriteLine();


            // CONVERTING LIST TO AN ARRAY  

            string[] best_laptop = Laptops.ToArray();
            foreach (string BL in best_laptop)
            {
                Console.WriteLine(BL);
            }
            Console.WriteLine();

            // CCONVERTING LIST TO AN ARRAY WITH SPECIFIC RANGE 

            Console.WriteLine();
            string[] BestLaptop = Laptops.GetRange(0, 2).ToArray();
            foreach (string bl in BestLaptop)
            {
                Console.WriteLine(bl);
            }
            Console.WriteLine();
        }
    }
}
