using BE;
using Interfaces;

namespace BLL
{
    public class CustomerController : Controller<Customer>
    {
        public CustomerController(ICRUD<Customer> repository) : base(repository)
        {
            
        }
       
    }
}
