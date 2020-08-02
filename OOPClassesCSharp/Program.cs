using System;

namespace OOPClassesCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var account = new BankAccount("Ben Bryant", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
            Console.WriteLine();
            account.MakeDeposit(100, DateTime.Now, "Happy Birthday");
            account.MakeDeposit(733, DateTime.Now, "Payday");
            account.MakeWithdrawel(600, DateTime.Now, "Rent");
            account.MakeWithdrawel(100, DateTime.Now, "Utilities");

            Console.WriteLine(account.GetTransactions());
        }
    }
}
