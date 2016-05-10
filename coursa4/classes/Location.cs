using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursa4.classes
{
    class Location
    {
        public string Country { get; set; }
        public string City { get; set; }

        public Location(string city, string country)
        {
            Country = country;
            City = city;
        }
        
        public override string ToString()
        {
            return City + ", " + Country;
        }
    }
}
