using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllResNet.Assignment.Entities
{
    public class Company : BaseClass<Company>
    {

        public Company()
        {
            Id = "";
            Name = "";
            Address = new Address();
        }

        public Company(string name, Address address)
        {
            Name = name;
            Address = address;
        }
        public string Name { get; set; }

        public Address Address { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            var other = (Company) obj;
            return string.Equals(Id, other.Id) && string.Equals(Name, other.Name) &&
                   Address.Equals(Address, other.Address);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Name != null ? Name.GetHashCode() : 0) * 397) ^ (Address != null ? Address.GetHashCode() : 0);
            }
        }
    }
}
