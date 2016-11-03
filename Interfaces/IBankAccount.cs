using System.Collections.Generic;

namespace Interfaces
{
    public interface IBankAccount
    {  
        double Balance { get; set; }
        double InterestRate { get; set; }
        IList<ITransaction> Transactions { get; set; }
    }
}
