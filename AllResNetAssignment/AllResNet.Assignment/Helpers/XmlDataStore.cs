using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllResNet.Assignment.Interfaces;

namespace AllResNet.Assignment.Helpers
{
    //XML Data Store will handles Save data in XML Files and Retreive it using XMLHelper.
    public class XmlDataStore<T> : IDataStore<T>
        where T : new()
    {
        private readonly string _path;

        public XmlDataStore(string path)
        {
            _path = path;
        }

        public string Path
        {
            get { return _path; } 
        }

        public void Save(T obj)
        {
            XmlHelper.WriteToXmlFile(_path, obj);
        }

        public T Load()
        {
            return XmlHelper.ReadFromXmlFile<T>(_path);
        }
    }
}
