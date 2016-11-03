using BE;
using Interfaces;

namespace BLL
{
    public class BankAccountController : Controller<BankAccount>
    {

        public BankAccountController(ICRUD<BankAccount> repository) : base(repository)
        {
            
        }

        public void hej()
        {
            
        }
    }
}
