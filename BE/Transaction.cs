using System;
using Interfaces;

namespace BE
{
    public class Transaction : Entity, ITransaction
    {

        public DateTime TransactionDate { get; }
        public string Message { get; }
        public double Amount { get; }

        public Transaction(int id) : base(id)
        {
            TransactionDate = DateTime.Now;
        }

        public Transaction(int id, DateTime transactionDate, string message, double amount) : base(id)
        {
            TransactionDate = transactionDate;
            Message = message;
            Amount = amount;
        }


    }
}