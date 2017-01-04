using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllResNet.Assignment.Interfaces
{
    //This interface is for Implementing Repository of Enterprise App. Architecture Patterns
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
