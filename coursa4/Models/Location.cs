using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursa4
{
    [Serializable]
    public class Location
    {
        public string Country { get; set; }
        public string Place { get; set; }

        public Location(string place, string country)
        {
            Country = country;
            Place = place;
        }
        
        public override string ToString()
        {
            return Place + ", " + Country;
        }
    }
}
