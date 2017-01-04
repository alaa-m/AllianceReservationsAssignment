using AllResNet.Assignment.Enums;
using AllResNet.Assignment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllResNet.Assignment.Helpers
{
    public class DataStoreFactory<T> where T : new()
    {
       
        public virtual IDataStore<T> CreateDataStore (DataStoreType storeType,string path)
        {
            IDataStore<T> dataStore = null;
            switch (storeType)
            {
                case DataStoreType.XML:
                    dataStore = new XmlDataStore<T>(path);
                    break;
                case DataStoreType.JSON:
                    throw new NotImplementedException("JSON data store is not implementd yet!");
                case DataStoreType.CSV:
                    throw new NotImplementedException("CSV data store is not implementd yet!");
                default:
                    break;
            }
            return dataStore;
        }
    }
}
