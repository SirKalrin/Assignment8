using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICustomer
    {
        string Name { get; set; }
        string SSN { get; set; }
        DateTime BirthDate { get; set; }
        IList<IBankAccount> BankAccounts { get; set; }
    }
}
