using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining
{
    public class ProductDetails
    {
        public int PID;
        public string PName;
        public int PStockAvail;
        public double PStockPrice;
    }
    public class ClientApp
    {
        public static void ClientMethod()
        {
            ProductDetails PDet1 = new ProductDetails();
            PDet1.PID = 78963;
            PDet1.PName = "Curd";
            PDet1.PStockAvail = 125;
            PDet1.PStockPrice = 89.63;
            ProductDetails PDet2 = new ProductDetails();
            PDet2.PID = 78964;
            PDet2.PName = "Cheese";
            PDet2.PStockAvail = 150;
            PDet2.PStockPrice = 886.63;
            ProductDetails PDet3 = new ProductDetails();
            PDet3.PID = 78965;
            PDet3.PName = "Pasterouised Milk";
            PDet3.PStockAvail = 115;
            PDet3.PStockPrice = 99.25;



            Dictionary<int, ProductDetails> dictionaryProduct = new Dictionary<int, ProductDetails>();
            dictionaryProduct.Add(PDet1.PID, PDet1);
            dictionaryProduct.Add(PDet2.PID, PDet2);
            dictionaryProduct.Add(PDet3.PID, PDet3);

            foreach (KeyValuePair<int, ProductDetails> ekvp in dictionaryProduct)
            {
                Console.WriteLine("Product Details ID = {0}", ekvp.Key);
                ProductDetails pdetails = ekvp.Value;
                Console.WriteLine("\nID = {0}, \nName = {1}, \nStock Availablity = {2} , \nStock Price ={3}", pdetails.PID, pdetails.PName, pdetails.PStockAvail, pdetails.PStockPrice);
                Console.WriteLine("____________________________________________________________________");
            }


            //Try Get Method
            ProductDetails PDetails;
            if (dictionaryProduct.TryGetValue(78963, out PDetails))
            {
                Console.WriteLine("\nProductID = {0}, Name = {1}, Stock Availability = {2}, Stock Price ={3}", PDetails.PID, PDetails.PName, PDetails.PStockAvail, PDetails.PStockPrice);
            }
            else
            {
                Console.WriteLine("Key not found");
            }
            Console.WriteLine("\nThe Product's List Count : ");
            Console.WriteLine(dictionaryProduct.Count()); //giving count
            Console.WriteLine("\nWhat Product need to Remove : ");
            int ValueRemove = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(dictionaryProduct.Remove(ValueRemove)); //to clear a particular key from dictionary only

            Console.WriteLine("\nCan We Clear the Dictionary : ");
            string ValueClear = Console.ReadLine();
            if (ValueClear.ToUpper() == "Y")
            {
                dictionaryProduct.Clear(); //to clear everything from dictionary
            }
            else
            {
                Console.WriteLine("This Count Shows Removed Dictionary..");
                Console.WriteLine(dictionaryProduct.Count());
            }

            Console.WriteLine("This Count Shows After Clear the Dictionary");
            Console.WriteLine(dictionaryProduct.Count());
            //Converting array to Dictionary
            ProductDetails[] PDetails1 = new ProductDetails[3];
            PDetails1[0] = PDet1;
            PDetails1[1] = PDet2;
            PDetails1[2] = PDet3;

            Dictionary<int, ProductDetails> proddict = PDetails1.ToDictionary(Product => Product.PID, Product => Product);
            Console.WriteLine("\nArray to Dictionary\n");
            foreach (KeyValuePair<int, ProductDetails> ekvp in proddict)
            {
                Console.WriteLine("key = {0}", ekvp.Key);
                ProductDetails PValue = ekvp.Value;
                Console.WriteLine("ProductID = {0}, Name = {1}, Stock Availability = {2}, Stock Price = {3}", PValue.PID, PValue.PName, PValue.PStockAvail, PValue.PStockPrice);
                Console.WriteLine("____________________________________________________________________");
            }

            //Converting a list to dictionary
            List<ProductDetails> ProductList = new List<ProductDetails>(2); //initially capacity is declared as 2 but can increase the size during runtime
            ProductList.Add(PDet1);
            ProductList.Add(PDet2);
            ProductList.Add(PDet3);

            Dictionary<int, ProductDetails> ProdDict = ProductList.ToDictionary(Product => Product.PID, Product => Product);
            Console.WriteLine("\nList to Dictionary\n");
            foreach (KeyValuePair<int, ProductDetails> ekvp in ProdDict)
            {
                Console.WriteLine("key = {0}", ekvp.Key);
                ProductDetails PValue = ekvp.Value;
                Console.WriteLine("ProductID = {0}, Name = {1}, Stock Availability = {2}, Stock Price = {3}", PValue.PID, PValue.PName, PValue.PStockAvail, PValue.PStockPrice);
                Console.WriteLine("____________________________________________________________________");
            }
        }
    }
}
