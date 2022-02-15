using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
     public class Address
    {
        public string Country { set; get; }
        public string City { set; get; }
        public string Street { set; get; }
        public int HouseNumber { set; get; }
        public int Index { set; get; }


        public Address(string county, string city, string street, int houseNumber, int index)
        {
            Country = county;
            City = city;
            Street = street;
            HouseNumber = houseNumber;
            Index = index;

        }
        public Address(Address address)
        {
            Country = address.Country;
            City = address.City;
            Street = address.Street;
            HouseNumber = address.HouseNumber;
            Index = address.Index;
        }
        public string GetAddress()
        {
            return $"{Country}, {City}, {Street}\n House number : {HouseNumber}  Index : {Index}";
        }
    }
}
