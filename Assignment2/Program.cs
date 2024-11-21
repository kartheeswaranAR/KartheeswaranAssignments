using System;

namespace CsharpTraining
{ 
    class Program
    {
        static void Main()
        {
            StaticClass.PrintEvenNumbers(); //Static Method with class name and method name


            //Calling instance method
            InstanceMethod instanceclass = new InstanceMethod();
            instanceclass.PrintOddNumbers();

            //Calling static method passing arguments to parameters
            int Number = 50;
            StaticClass.PrintOddNumbersWithMax(Number);


            //Calling instance method passing arguments to parameters and getting return values from the method
            int result = 0;
            result = instanceclass.Calculate(10, 20, 'A');
            Console.WriteLine($"\nThe added result is  {result} ");

            result = instanceclass.Calculate(40, 20, 'S');
            Console.WriteLine($"The subtracted result is  {result} ");

            result = instanceclass.Calculate(10, 20, 'M');
            Console.WriteLine($"The multiplied result is  {result} ");

            result = instanceclass.Calculate(100, 20, 'D');
            Console.WriteLine($"The divided result is  {result} ");


            //Passing by value
            int SourceValue = 10;
            StaticClass.FinalValue(SourceValue);
            Console.WriteLine(SourceValue);

            //Passing by reference
            StaticClass.FinalValueByReference(ref SourceValue);
            Console.WriteLine(SourceValue);

            //Returning output value
            int Sum = 0;
            int Product = 0;
            Calculate1(5, 10, out Sum, out Product);

            Console.WriteLine("Sum = {0}", Sum);
            Console.WriteLine("Product = {0}\n", Product);

            //Passing param array
            string[] cars = new string[5];
            cars[0] = "Maruthi";
            cars[1] = "Nissan";
            cars[2] = "Tata";
            cars[3] = "Hyndai";
            cars[4] = "KIA";

            Vehicles(cars);
            //Vehicles("Maruthi", "Nissan", "Tata", "Hyndai", "KIA", "Citreon");

            program2.main2();
        }


        public static void Calculate1(int num1, int num2, out int Sum, out int Product) //Parameter
        {
            Sum = num1 + num2;
            Product = num1 * num2;
        }

        public static void Vehicles(params string[] vehicles) //Parameter
        {
            Console.WriteLine("The vehicles are");
            foreach (string s in vehicles)
            {
                Console.WriteLine(s);
            }

        }
        //int value = Convert.ToInt32(Console.ReadLine());
        class program2
        {
            public static void main2()
            {
                int value = Add(12, 15, 25, 45, 75);
                Console.WriteLine("The Added Value is :"+value);
            }
            public static int Add(params int[] listnum)
            {
                int total = 0;
                foreach (int i in listnum)
                {
                    total += i;
                }
                return total;
            }
        }
    }
}