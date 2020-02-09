using System;
using System.Collections.Generic;

namespace BestBank
{
  class Program
  {
    static void Main(string[] args)
    {

      PrintWelcomeMessage();

      var account = new BankAccount("Daniel", 1800);
      var account2 = new BankAccount("Nancy", 1500030);

      account.MakeDeposit(500, DateTime.Now, "Savings for Xbox Series X");
      account.MakeWithdrawal(950, DateTime.Now, "Fancy Gaming PC");

      account2.MakeWithdrawal(50, DateTime.Now, "New pens.");

      Console.WriteLine($"Name: {account.Owner}");
      Console.WriteLine($"Account Number: {account.AccountNumber}");
      Console.WriteLine($"Current Balance: {account.Balance}\n");

      Console.WriteLine($"Name: {account2.Owner}");
      Console.WriteLine($"Account Number: {account2.AccountNumber}");
      Console.WriteLine($"Current Balance: {account2.Balance}");
    }

    static void PrintWelcomeMessage()
    {
      Console.WriteLine("====================================");
      Console.WriteLine("\tWelcome to Best Bank");
      Console.WriteLine("====================================\n");
    }
  }
}
