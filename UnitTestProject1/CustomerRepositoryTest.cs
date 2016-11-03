using System.Collections.Generic;
using System.Linq;
using BE;
using Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Repositories;

namespace UnitTestProject1
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        private List<Customer> customers;
        private Mock<ICRUD<Customer>> mock;

        [ClassInitialize]
        public void ClassInitializer()
        {
            mock = new Mock<ICRUD<Customer>>();
            mock.Setup(x => x.Create(It.IsAny<Customer>())).Callback<Customer>(x => { customers.Add(x); }).Returns((Customer c) => c);
            mock.Setup(x => x.Read(It.IsAny<int>())).Returns((int id) => customers.FirstOrDefault(x => x.Id == id));
        }

        [TestInitialize]
        public void TestInitializer()
        {
            customers = new List<Customer>();
        }

        [TestMethod]
        public void CreateCustomer()
        {
            int mId = 1;
            //List<Customer> customers = new List<Customer>();
            //Mock<ICRUD<Customer>> mock = new Mock<ICRUD<Customer>>();
            //mock.Setup(x => x.Create(It.IsAny<Customer>())).Callback<Customer>(x => { customers.Add(x); }).Returns((Customer c) => c);
            //mock.Setup(x => x.Read(It.IsAny<int>())).Returns((int id) => customers.FirstOrDefault(x => x.Id == id));
            var repository = mock.Object;
            var customer = new Customer(mId, "Gert Svansen");
            Assert.AreEqual(repository.Create(customer).Id, customer.Id);
            Assert.AreEqual(repository.Read(mId).Name, customer.Name);
        }

        [TestMethod]
        public void ReadAllCustomers()
        {
            int id = 1;
            var repository = new Repository<Customer>();
            repository.Create(new Customer(id, "Gert Svansen"));
            var customers = repository.ReadAll();
            Assert.IsTrue(customers.Any());
        }

        [TestMethod]
        public void ReadCustomer()
        {
            int id = 1;
            var repository = new Repository<Customer>();
            var customer = repository.Create(new Customer(id, "Gert Svansen"));
            Assert.AreEqual(repository.Read(id), customer);
        }

        [TestMethod]
        public void UpdateCustomer()
        {
            int id = 1;
            var repository = new Repository<Customer>();
            var customer = repository.Create(new Customer(id, "Gert Svansen") { SSN = "0808921499" });
            customer.SSN = "1307550853";
            customer.Name = "Lars Kallesen";
            repository.Update(customer);
            Assert.AreEqual(repository.Read(id).Id, customer.Id);
            Assert.AreEqual(repository.Read(id).SSN, customer.SSN);
            Assert.AreEqual(repository.Read(id).Name, customer.Name);
        }

        [TestMethod]
        public void DeleteCustomer()
        {
            int id = 1;
            var repository = new Repository<Customer>();
            var customer = repository.Create(new Customer(id, "Gert Svansen"));
            Assert.IsTrue(repository.Delete(customer.Id));
        }
    }
}
