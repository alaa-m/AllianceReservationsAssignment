using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AllResNet.Assignment.Interfaces
{
    //This interface is for Implementing The Repository Pattern of Enterprise App. Architecture Patterns
    public interface IRepository<T>
    {
        void Insert(T entity);
        void Delete(T entity);
        T GetById(string id);

    }
}
