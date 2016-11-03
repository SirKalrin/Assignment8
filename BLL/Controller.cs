using Interfaces;

namespace BLL
{
    public class Controller<T> where T : IEntity
    {
        protected ICRUD<T> Repository;

        public Controller(ICRUD<T> repository)
        {
            this.Repository = repository;
        }
    }
}
