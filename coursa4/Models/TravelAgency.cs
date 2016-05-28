using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursa4
{
    [Serializable]
    public class TravelAgency
    {

        public BindingList<Tour> Tours { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int ToursCount
        {
            get
            {
                return Tours.Count;
            }
        }

        public TravelAgency()
        {
            Name = "";
            Address = "";
            Tours = new BindingList<Tour>();
        }

        public TravelAgency(string name, string address, params Tour[] travels)
        {
            Name = name;
            Address = address;
            Tours = new BindingList<Tour>(travels);
        }

        public TravelAgency(string name, string address, IEnumerable<Tour> travels)
        {
            Name = name;
            Address = address;
            Tours = new BindingList<Tour>(travels.ToList());
        }
    }
}
