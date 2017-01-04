using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllResNet.Assignment.Entities
{
   
    public class Customer : BaseClass<Customer>
    {
        public Customer()
        {
            Id = "";
            FirstName = "";
            LastName = "";
            Address = new Address("","","","");
        }
        public Customer(string firstName, string lastName, Address address)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Address Address { get; set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            var casted = (Customer) obj;
            return string.Equals(Id,casted.Id) && string.Equals(FirstName, casted.FirstName) && string.Equals(LastName, casted.LastName) && Equals(Address, casted.Address);
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = (FirstName != null ? FirstName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (LastName != null ? LastName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Address != null ? Address.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}
