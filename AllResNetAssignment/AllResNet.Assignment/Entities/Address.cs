using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllResNet.Assignment.Entities
{
   
    public class Address
    {
        public Address()
        {
            Street = "";
            City = "";
            State = "";
            Zip = "";
        }
        public Address(string street, string city, string state, string zip)
        {
            Street = street;
            City = city;
            State = state;
            Zip = zip;
        }
        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public override bool Equals(object ad)
        {
            var casted = ad as Address;
            return casted != null && (this.Street == casted.Street && this.City == casted.City && this.State == casted.State && this.Zip == casted.Zip);
        }
    }
}
