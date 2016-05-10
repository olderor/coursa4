using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursa4.classes
{
    class TourAgency
    {

        public List<Tour> Tours { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public TourAgency(string name, string address, params Tour[] tours)
        {
            Name = name;
            Address = address;
            Tours = tours.ToList();
        }
    }
}
