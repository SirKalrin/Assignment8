using System;
using BE;
using Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class TransactionTest
    {
        [TestMethod]
        public void CreateTransaction()
        {
            int id = 1;
            Transaction transaction = new Transaction(id);
            Assert.AreEqual(transaction.Id, id);
            Assert.IsNotNull(transaction.TransactionDate);
        }

        [TestMethod]
        public void CreateDelayedTransaction()
        {
            int id = 1;
            string message = "Her er de penge jeg skylder dig. Tak for lån!";
            DateTime dateToBeTransacted = DateTime.Now.AddDays(2);
            double amount = 2400;
            Transaction transaction = new Transaction(id, dateToBeTransacted, message, amount);
            Assert.AreEqual(transaction.Id, id);
            Assert.AreEqual(transaction.TransactionDate, dateToBeTransacted);
            Assert.AreEqual(transaction.Message, message);
            Assert.AreEqual(transaction.Amount, amount);
        }
    }
}
