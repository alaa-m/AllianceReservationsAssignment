using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllResNet.Assignment.Interfaces
{
    //This interface is needed to be implemented in the further DataStores: JSON, CSV, Text , SQLLite...
    //This interface is implemeting Bridge design pattern to change the behavior of Save , Load methods
    //based on DataStore type (XML, JSON, CSV...).
    public interface IDataStore<T>
    {
        //save in Storage.
        void Save(T obj);
        //load from Storage.
        T Load();
    }
}
