using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BE;

namespace UnitTestProject1
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void CreateCustomer()
        {
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
