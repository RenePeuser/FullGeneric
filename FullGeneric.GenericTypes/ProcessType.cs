using FullGeneric.Repository;

namespace FullGeneric.GenericTypes
{
    public class ProcessType<T>
    {
        private Repository<T> _processData;
        public Repository<T> ProcessData
        {
            get
            {
                if (_processData == null) _processData = new Repository<T>();
                return _processData;
            }
        }
    }
}
