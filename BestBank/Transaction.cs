﻿using System;
namespace BestBank
{
  public class Transaction
  {
    public decimal Amount { get; }
    public DateTime Date { get; }
    public string Note { get; }

    public Transaction(decimal amount, DateTime date, string note)
    {

    }
  }
}
