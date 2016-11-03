using System;
using BE;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class BankAccountTest
    {
        [TestMethod]
        public void CreateBankAccountWithZeroBalance()
        {
            int id = 1;
            BankAccount acc = new BankAccount(id);
            Assert.IsNotNull(acc);
            Assert.AreEqual(id, acc.Id);
            Assert.AreEqual(0.0, acc.Balance);
            Assert.AreEqual(BankAccount.DEFAULT_INTEREST_RATE, acc.InterestRate);
            Assert.IsNotNull(acc.Transactions);
            Assert.AreEqual(0, acc.Transactions.Count);
        }
    }
}
