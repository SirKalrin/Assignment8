
using Interfaces;

namespace BE
{
    public abstract class Entity : IEntity
    {
        public int Id { get; }

        protected Entity(int id)
        {
            Id = id;
        }
    }
}
