using System.Collections.Generic;
using Interfaces;

namespace BE
{
    public class BankAccount : Entity, IBankAccount
    {
        public const double DEFAULT_INTEREST_RATE = 0.01;
        public double Balance { get; set; }
        public double InterestRate { get; set; }
        public IList<ITransaction> Transactions { get; set; }

        public BankAccount(int id) : base(id)
        {
            InterestRate = DEFAULT_INTEREST_RATE;
            Transactions = new List<ITransaction>();
        }

        
    }
}
