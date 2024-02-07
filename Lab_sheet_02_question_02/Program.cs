using System;

namespace Lab_sheet_02_question_02
{
    class BankAccount
    {
        public int AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myaccount = new BankAccount();
            myaccount.AccountNumber = 00000000;
            myaccount.Balance = 1000;

            Console.WriteLine("Initial balance: $" + myaccount.Balance);

            decimal depositAmount = 500;
            myaccount.Deposit(depositAmount);

            Console.WriteLine("Updated balance after deposit: $" + myaccount.Balance);
        }
    }
}