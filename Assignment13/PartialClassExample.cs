using System;

namespace CsharpTraining
{
    public partial class PartialClassExample
    {
        public static void PartialMethod()
        {
            Console.WriteLine("\nThe Best Laptops with price range...");
            Console.WriteLine("Choose Price Range...");
            Console.WriteLine("\n1.25000 to 35000,\n2.40000 to 60000,\n3.70000 to 80000,\n4.90000 to 120000\n");
            int inputrange = Convert.ToInt32(Console.ReadLine());
            if (inputrange == 1)
            {
                Console.WriteLine("\n1.HP 14,\n2.ASUS Vivobook 14,\n3.Dell Vostro 3491,\n4.Acer Aspire 5,\n5. Dell Inspiron 15 3505\n");
            }
            else if (inputrange == 2)
            {
                Console.WriteLine("\n1.Acer Aspire 7 A715-41G,\n2.HP Omen 16-b0351TX,\n3.Asus VivoBook Gaming F571LH-BQ,\n4.Lenovo Ideapad Slim 3i,\n5.Asus VivoBook 15\n");
            }
            else if (inputrange == 3)
            {
                Console.WriteLine("\n1.Lenovo ThinkPad E14 ,\n2.ASUS VivoBook 15 ,\n3.Dell Inspiron 7570,\n4.HP Envy 13-ah0044TX,\n5.ASUS ZenBook 13\n");
            }
            else if (inputrange == 4)
            {
                Console.WriteLine("\n1.Apple Macbook Air M1,\n2.ASUS ZenBook Duo UX481,\n3.Lenovo Legion Y540,\n4.Dell Gaming-G3 3590,\n5.MSI PS63 Modern 8M-067IN\n");
            }
        }
    }
}
