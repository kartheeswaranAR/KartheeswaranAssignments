using System;

namespace CsharpTraining
{
    interface IBankDetails
    {
        void BankDetails();
    }
    interface IBankDetails1
    {
        void BankDetails();
    }
    class ExplicitInterface:IBankDetails, IBankDetails1
    {
        void IBankDetails.BankDetails()
        {
            Console.WriteLine("Enter the Bank Account Number :");
            long AccNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the Bank Account Holder Name :");
            string AccName = Console.ReadLine();

            Console.WriteLine("The Bank Account Holder Details : [{0},{1}]", AccNumber, AccName);
        }
        void IBankDetails1.BankDetails() //Explicit Interface
        {
            string AccIFSC = "TMB10036895";
            string AccBranch = "Kovilpatti";
            Console.WriteLine("Your Bank Branch IFSC Code and Name Is : [{0},{1}]",AccIFSC,AccBranch);
        }
        
    }
    
}
