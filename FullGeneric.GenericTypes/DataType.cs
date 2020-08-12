using FullGeneric.Repository;

namespace FullGeneric.GenericTypes
{
    public class DataType<T>
    {
        private Repository<T> _data;
        public Repository<T> Data
        {
            get
            {
                if (_data == null) _data = new Repository<T>();
                return _data;
            }
        }

        private Repository<T> _settings;
        public Repository<T> Settings
        {
            get
            {
                if (_settings == null) _settings = new Repository<T>();
                return _settings;
            }
        }
    }
}
