
using System;
using System.Collections.Generic;
using Interfaces;

namespace BE
{
    public class Customer : Entity, ICustomer
    {
        public string Name { get; set; }
        public string SSN { get; set; }
        public DateTime BirthDate { get; set; }
        public IList<IBankAccount> BankAccounts { get; set; }

        public Customer(int id, string name) : base(id)
        {
            Name = name;
            BankAccounts = new List<IBankAccount>();
        }

        
    }
}
