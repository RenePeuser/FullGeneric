using System;
using FullGeneric.Data.Models;
using FullGeneric.Data.Provider.LinqToSQL;
using FullGeneric.Data.Provider.XML;

namespace FullGeneric.Mapper
{
    public static class TypeProviderMapper
    {
        public static Type GetProvider<T>(this Type type)
        {

            //Beispiel das anhand des Typen der Provider gewählt wird
            if(type == typeof(Person))
            {
                return typeof(XmlDataProvider<T>);      
            }            
            return typeof (LinqToSqlProvider<T>);
        }        
    }
}
