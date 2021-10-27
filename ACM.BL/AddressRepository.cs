using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);
            
            if(addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Husului";
                address.StreetLine2 = "Vaslui";
                address.City = "Vaslui";
                address.Country = "Romania";
                address.State = "Vaslui";
                address.PostalCode = "730086";
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Husului",
                StreetLine2 = "Vaslui",
                City = "Vaslui",
                Country = "Romania",
                State = "Vaslui",
                PostalCode = "730086",
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Kogalniceanu",
                StreetLine2 = "156",
                City = "Tulcea",
                Country = "Romania",
                State = "Tulcea",
                PostalCode = "730986",
            };
            addressList.Add(address);

            return addressList;

        }

        public bool Save()
        {
            return true;
        }
    }
}
