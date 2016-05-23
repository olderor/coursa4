using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursa4
{
    [Serializable]
    class TourAgency
    {

        public List<AbstractTravel> Travels { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int ToursCount
        {
            get
            {
                return Travels.Count;
            }
        }

        public TourAgency(string name, string address, params AbstractTravel[] travels)
        {
            Name = name;
            Address = address;
            Travels = travels.ToList();
        }

        public TourAgency(string name, string address, List<AbstractTravel> travels)
        {
            Name = name;
            Address = address;
            Travels = travels;
        }
    }
}
