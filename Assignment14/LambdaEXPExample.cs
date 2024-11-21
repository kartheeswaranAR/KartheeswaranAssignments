using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpTraining
{
    class LambdaExpExample
    {
        public class Medical_Store
        {
            public int ProductID { get; set; }
            public string Name { get; set; }

            public int Price { set; get; }

            public string Description { get; set; }

        }

        public class Medical_Tablet
        {
            public void PrintTablet()
            {

                List<Medical_Store> Tablets = new List<Medical_Store>()
        {
           new Medical_Store {ProductID = 75896,Name = "Paracetomal",Price = 20,Description = "Fever Tablet" },
           new Medical_Store {ProductID = 75896,Name = "Paracetomal 650",Price = 20,Description = "Fever Tablet" },
           new Medical_Store {ProductID = 75897,Name = "NeuroKind",Price = 112,Description = "Neuron Tablet for healthy nerves"},
           new Medical_Store {ProductID = 75898,Name = "Viltar M",Price = 158,Description = "Diabetics Tablet" },
           new Medical_Store {ProductID = 75910,Name = "TelmiKind",Price = 210,Description = "Heart Tablet for protecting Heart" }

        };


                // METHOD1 TO FIND 
                Medical_Store product = Tablets.Find(p1 => p1.ProductID == 75910);
                Console.WriteLine("ProductName = {0},ID = {1},Price = {2},Category = {3}", product.Name, product.ProductID, product.Price, product.Description);
                Console.WriteLine();

                // METHOD 2 TO FIND

                Medical_Store product2 = Tablets.Find((Medical_Store p2) => p2.ProductID == 75896);
                Console.WriteLine("ProductName = {0},ID = {1},Price = {2},Category = {3}", product2.Name, product2.ProductID, product2.Price, product2.Description);
                Console.WriteLine("\n");

                Console.WriteLine("Enter letter to display count :");
                string value = Console.ReadLine();
                int count = Tablets.Count(pName => pName.Name.StartsWith(value.ToUpper()));
                Console.WriteLine("The [{0}] data's are have same name with [{1}]!!  ",count,value);
                Console.WriteLine("\n");
            }
        }
    }
}
