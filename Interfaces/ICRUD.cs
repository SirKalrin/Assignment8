using System.Collections.Generic;

namespace Interfaces
{
    public interface ICRUD<T> where T : IEntity
    {
        T Create(T item);
        T Read(int id);
        IList<T> ReadAll();
        T Update(T item);
        bool Delete(int id);
    }
}
