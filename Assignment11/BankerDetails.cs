using System;
using System.Collections.Generic;

namespace CSharpTraining
{
    delegate bool IsAccType(BankerDetails banker);
    class BankerDetails
    {
        public long AccNumber;
        public string BankerName;
        public string AccType;
        public string Branch;

        public static void BankingDetails(List<BankerDetails> Bankdetails, IsAccType IsAccTypeforopen)
        {
            Console.WriteLine("\n");
            foreach (BankerDetails bank in Bankdetails)
            {
                if (IsAccTypeforopen(bank))
                {
                    Console.WriteLine("The Bank Account of [{0},{1},{2}] is {3}", bank.AccNumber,bank.BankerName,bank.Branch,bank.AccType);
                }

            }
        }
    }
    class ClientApp
    {
        public static bool IsAccTypeB(BankerDetails banker)
        {
            if (banker.AccType == "Open")
            {
                return true;
            }
            else
            {
                return false;
                //return true  //---> for display all the accounts
            }
        }
        public static void BankClient()
        {
            List<BankerDetails> banklist = new List<BankerDetails>();
            banklist.Add(new BankerDetails() {AccNumber=112304877552,AccType="Open",BankerName="Kartheeswaran",Branch="Kovilpatti" });
            banklist.Add(new BankerDetails() {AccNumber=115897500058,AccType="Open",BankerName="Devan",Branch="Thanjavur" });
            banklist.Add(new BankerDetails() {AccNumber=889347858933,AccType="Closed",BankerName="Adithya",Branch="Kanchipuran" });
            banklist.Add(new BankerDetails() {AccNumber=778596334721,AccType="Open",BankerName="Narayanan",Branch="Palaiyarai" });
            banklist.Add(new BankerDetails() {AccNumber=111000085975,AccType="Closed",BankerName="Sundar",Branch="Maharastra" });
            banklist.Add(new BankerDetails() {AccNumber=555632874112,AccType="Open",BankerName="Rajendran",Branch="Andra Pradesh" });

            IsAccType isAccType = new IsAccType(IsAccTypeB);
            BankerDetails.BankingDetails(banklist, isAccType);
        }
    }
}
