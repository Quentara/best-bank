using System;
using System.Collections.Generic;

namespace BestBank
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Best Bank!");

      var account = new BankAccount("Daniel", 1800);
      var account2 = new BankAccount("Nancy", 1500030);

      Console.WriteLine($"Name: {account.Owner}");
      Console.WriteLine($"Account Number: {account.AccountNumber}");
      Console.WriteLine($"Current Balance: {account.Balance}");

      Console.WriteLine($"Name: {account2.Owner}");
      Console.WriteLine($"Account Number: {account2.AccountNumber}");
      Console.WriteLine($"Current Balance: {account2.Balance}");
    }
  }
}
