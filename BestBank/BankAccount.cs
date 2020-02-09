using System;
using System.Collections.Generic;

namespace BestBank
{
  public class BankAccount
  {
    public string AccountNumber { get; }
    public string Owner { get; set; }
    public decimal Balance
    {
      get
      {
        decimal balance = 0;
        foreach (var transaction in allTransactions)
        {
          balance += transaction.Amount;
        }
        return balance;
      }
    }

    private readonly string AccountHash = "BBAC";
    private static int NumberOfAccounts = 0;

    private List<Transaction> allTransactions = new List<Transaction>();

    // Constructor
    public BankAccount(string owner, decimal initialBalance)
    {
      this.Owner = owner;
      this.AccountNumber = AccountHash + NumberOfAccounts;

      MakeDeposit(initialBalance, DateTime.Now, "Initial deposit.");

      NumberOfAccounts++;
    }

    public void MakeDeposit(decimal amount, DateTime date, string note)
    {
      if (amount > 0)
      {
        Transaction deposit = new Transaction(amount, date, note);
        allTransactions.Add(deposit);
      }
      else
      {
        throw new ArgumentOutOfRangeException(nameof(amount), "Transaction Error! Your deposit must be positive.");
      }
    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note)
    {
      if (amount <= 0)
      {
        throw new ArgumentOutOfRangeException(nameof(amount), "Transaction Error! Please enter an amount greater than zero.");
      }
      if (Balance - amount <= 0)
      {
        throw new InvalidOperationException("Transaction Error! There are not enough funds to cover this withdrawal.");
      }
      Transaction withdrawal = new Transaction(amount, date, note);
      allTransactions.Add(withdrawal);
    }
  }
}
