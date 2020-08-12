using System;
using System.Collections.Generic;
using FullGeneric.Interfaces;
using FullGeneric.Mapper;

namespace FullGeneric.Repository
{
    public class Repository<T>
    {
        private readonly IDataProvider<T> _provider;
        public Repository()
        {
            //Mit Intelligenz aufgrund des Typen wird der passende(vorkonfigurierte) Provider gesucht und erzeugt
            _provider = (IDataProvider<T>) Activator.CreateInstance(typeof (T).GetProvider<T>());
        }

        public void Add(T item)
        {
            _provider.Add(item);
        }

        public void Delete(T item)
        {
            _provider.Delete(item);
        }

        public void Update()
        {
            //Do Something
        }
        
        public List<T> Items()
        {
            return _provider.Items();
        }

        public bool ItemExists(T item)
        {
            return _provider.ItemExists(item);
        }
    }
}
