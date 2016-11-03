using System.Linq;
using BE;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repositories;

namespace UnitTestProject1
{
    [TestClass]
    public class BankAccountRepositoryTest
    {
        [TestMethod]
        public void CreateBankAccount()
        {
            int id = 1;
            var repository = new Repository<BankAccount>();
            var bankAccount = new BankAccount(id);
            Assert.AreEqual(bankAccount.Id, id);
            Assert.AreEqual(repository.Create(bankAccount), bankAccount);
        }

        [TestMethod]
        public void ReadAllBankAccounts()
        {
            int id = 1;
            var repository = new Repository<BankAccount>();
            repository.Create(new BankAccount(id));
            var bankAccounts = repository.ReadAll();
            Assert.IsTrue(bankAccounts.Any());
        }

        [TestMethod]
        public void ReadBankAccount()
        {
            int id = 1;
            var repository = new Repository<BankAccount>();
            var bankAccount = repository.Create(new BankAccount(id));
            Assert.AreEqual(repository.Read(id), bankAccount);
        }

        [TestMethod]
        public void UpdateBankAccount()
        {
            int id = 1;
            var repository = new Repository<BankAccount>();
            var bankAccount = repository.Create(new BankAccount(id) {Balance = 227});
            bankAccount.Balance = 335;
            bankAccount.InterestRate = 5.2;
            repository.Update(bankAccount);
            Assert.AreEqual(repository.Read(id).Id, bankAccount.Id);
            Assert.AreEqual(repository.Read(id).Balance, bankAccount.Balance);
            Assert.AreEqual(repository.Read(id).InterestRate, bankAccount.InterestRate);
        }

        [TestMethod]
        public void DeleteBankAccount()
        {
            var repository = new Repository<BankAccount>();
            var bankAccount = repository.Create(new BankAccount(1));
            Assert.IsTrue(repository.Delete(bankAccount.Id));
        }
    }
}
