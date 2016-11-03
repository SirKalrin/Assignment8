using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BE;
using Interfaces;
using Moq;

namespace UnitTestProject1
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void CreateCustomer()
        {
            IList<Customer> customers = new List<Customer>();
            Mock<ICRUD<Customer>> mock = new Mock<ICRUD<Customer>>();
            int id = 1;
            string SSN = "0808921499";
            int yearBorn = 1992;
            string name = "Gert Skovmand";
            DateTime birthDate = DateTime.ParseExact(SSN.Remove(4)+yearBorn, "ddMMyyyy", null);
            Customer customer = new Customer(id, name) {SSN = SSN, BirthDate = birthDate};
            
            Assert.AreEqual(customer.Id, id);
            Assert.AreEqual(customer.Name, name);
            Assert.AreEqual(customer.BirthDate, birthDate);
            Assert.IsTrue(!customer.BankAccounts.Any());
        }
    }
}
