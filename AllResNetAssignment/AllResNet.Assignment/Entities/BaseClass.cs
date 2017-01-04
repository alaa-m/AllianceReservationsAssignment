using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using AllResNet.Assignment.Helpers;
using AllResNet.Assignment.Interfaces;
using AllResNet.Assignment.Repositories;

namespace AllResNet.Assignment.Entities
{
    
    [Serializable]
    public abstract class BaseClass<T> : IEntity<string>
        //only accept a genenric type of the derived classes
        where T : BaseClass<T>, new()
    {
        //The main repository which will handles data manipulating.
        private static readonly BaseClassRepository<T> BaseClassRepository = new BaseClassRepository<T>(typeof(T).Name+".xml");
        public BaseClass()
        {
            Id = "";
        }
        public string Id { get; set; }

        public void Save()
        {
            BaseClassRepository.Insert((T)this);
        }

        public void Delete()
        {
            BaseClassRepository.Delete((T)this);
        }

        public static T Find(string id)
        {
            return BaseClassRepository.GetById(id);
        }
    }
}
