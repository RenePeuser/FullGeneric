using System;

namespace FullGeneric.Factory
{
    public class FullGenericFactory<T> where T : class
    {      
        //Voll Generische Facctory       
        public static readonly FullGenericFactory<T> Instance = new FullGenericFactory<T>();

        private T _genricType;
        public T GenericType()
        {
            if (_genricType == null) _genricType = (T)Activator.CreateInstance(typeof(T));           
            return _genricType;
        }

        ////ObjektInstanz des gewünschten Generischen Typs
        //private object _syncobj = new object();
        //private T _genricType;
        //public T GenericType
        //{
        //    get
        //    {
        //        if (_genricType == null)
        //        {
        //            //Sperre Object wegen Thread Übergreifung
        //            lock (_syncobj)
        //            {
        //                if (_genricType == null)
        //                {
        //                    _genricType = (T)Activator.CreateInstance(typeof(T));
        //                }
        //            }
        //        }
        //        return _genricType;
        //    }
        //}
    }
}
