using System.Collections.Generic;

namespace FullGeneric.Interfaces
{
    public interface IRepository<T>
    {
        void Add(T item);
        void Delete(T item);
        void Update();
        List<T> Items();
        bool ItemExists(T item);
    }
}
