using System;
using System.Collections.Generic;
using System.Linq;
using BE;
using Interfaces;

namespace Repositories
{
    public class Repository<T> : ICRUD<T> where T : Entity
    {
        private readonly List<T> _items = new List<T>();

        public T Create(T item)
        {
            _items.Add(item);
            return Read(item.Id);
        }

        public T Read(int id)
        {
            return _items.FirstOrDefault(x => x.Id == id);
        }

        public IList<T> ReadAll()
        {
            return new List<T>(_items);
        }

        public T Update(T item)
        {
            var toBeUpdated = _items.FirstOrDefault(x => x.Id == item.Id);
            if (toBeUpdated != null)
            {
                toBeUpdated = item;
                return toBeUpdated;
            }
            throw new Exception($"No item with id:{item.Id} has been found!");
        }

        public bool Delete(int id)
        {
            return _items.RemoveAll(x => x.Id == id) > 0;
        }
    }
}
