using System;
using System.Collections.Generic;
using System.Text;

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
      Transaction withdrawal = new Transaction(-amount, date, note);
      allTransactions.Add(withdrawal);
    }

    public void PrintAllTransactions()
    {
      StringBuilder transactionOutput = new StringBuilder();
      transactionOutput.Append("Date\t\tAmount\tNote\n");
      foreach (var transaction in allTransactions)
      {
        transactionOutput.Append($"{transaction.Date.ToShortDateString()}\t");
        transactionOutput.Append($"$ {transaction.Amount}\t");
        transactionOutput.Append($"{transaction.Note}\n");
      }
      Console.WriteLine(transactionOutput);
    }

    public void DisplayAccountInfo()
    {
      StringBuilder accountOutput = new StringBuilder();
      accountOutput.Append($"Name: {this.Owner}\n");
      accountOutput.Append($"Account Number: {this.AccountNumber}\n");
      accountOutput.Append($"Current Balance: {this.Balance}\n");
      Console.WriteLine(accountOutput);
      PrintAllTransactions();
    }
  }
}
