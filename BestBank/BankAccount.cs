using System;
namespace BestBank
{
  public class BankAccount
  {
    public string AccountNumber { get; }
    public string Owner { get; set; }
    public decimal Balance { get; }

    private readonly string AccountHash = "BBAC";
    private static int NumberOfAccounts = 0;

    // Constructor
    public BankAccount(string owner, decimal initialBalance)
    {
      this.Owner = owner;
      this.Balance = initialBalance;
      this.AccountNumber = AccountHash + NumberOfAccounts;

      NumberOfAccounts++;
    }

    public void MakeDeposit(decimal amount, DateTime date, string note)
    {

    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {

    }
  }
}
