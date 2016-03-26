using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursa4.classes
{
    class Location
    {
        private string country;
        private string city;

        public string Country { get { return country; } }
        public string City { get { return city; } }

        public override string ToString()
        {
            return city + ", " + country;
        }
    }
}
