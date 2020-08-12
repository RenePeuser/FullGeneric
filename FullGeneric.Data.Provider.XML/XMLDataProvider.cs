using System.Collections.Generic;
using FullGeneric.Interfaces;

namespace FullGeneric.Data.Provider.XML
{
    public class XmlDataProvider<T> :IDataProvider<T>
    {

        public XmlDataProvider()
        {
            _items = new List<T>();
        }

        public void Add(T item)
        {
            _items.Add(item);
        }

        public void Delete(T item)
        {
            _items.Remove(item);
        }

        public void Update()
        {
            //Do Somethind
        }

        private List<T> _items; 
        public List<T> Items()
        {
            return _items;
        }

        public bool ItemExists(T item)
        {
            return _items.Contains(item);
        }
    }
}
