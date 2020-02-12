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
      var account2 = new BankAccount("Nancy", 15030);

      // Transactions
      account.MakeDeposit(500, DateTime.Now, "Savings for Xbox Series X");
      account.MakeWithdrawal(950, DateTime.Now, "Fancy Gaming PC");
      account2.MakeWithdrawal(50, DateTime.Now, "New pens.");

      account.DisplayAccountInfo();
      account2.DisplayAccountInfo();
    }

    static void PrintWelcomeMessage()
    {
      Console.WriteLine("====================================");
      Console.WriteLine("\tWelcome to Best Bank");
      Console.WriteLine("====================================\n");
    }
  }
}
