using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using AllResNet.Assignment.Entities;
using AllResNet.Assignment.Helpers;
using AllResNet.Assignment.Interfaces;
using AllResNet.Assignment.Enums;

namespace AllResNet.Assignment.Repositories
{
    internal class BaseClassRepository<T> : IRepository<T>
        where T : BaseClass<T>,new()
    {
       //this field represents the current list of data in Repository
        private static List<T> _data = new List<T>();
        //this field will save _data in Storage based on data store type.
        private static  IDataStore<List<T>> _dataStore;

        public BaseClassRepository(string path)
        {
            //TODO: We should replace this code with Dependency Injection.In order to get rid of the tight coupling  between BaseClassRepository and DataStoreFactory
            var dataStoreFactory = new DataStoreFactory<List<T>>();
            //create XML data store.
            _dataStore = dataStoreFactory.CreateDataStore(DataStoreType.XML, path);
        }
           

        public void Insert(T entity)
        {
            T baseClass = entity;
            //give new ID before save.
            baseClass.Id = Guid.NewGuid().ToString();
            //add to current data.
            _data.Add(entity);
            //save current data.
            _dataStore.Save(_data);
        }

        public void Delete(T entity)
        {
            //remove from current data
            _data.Remove(_data.Find(b => b.Id == entity.Id));
            //save current data.
            _dataStore.Save(_data);
            //clear ID.
            entity.Id = "";
        }

        public  T GetById(string id)
        {
            //load current data from store
            _data = _dataStore.Load();
            //return by ID from current data.
            return _data.Find(b => b.Id == id);
        }
    }
}
