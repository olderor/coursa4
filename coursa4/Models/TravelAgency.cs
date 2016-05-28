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

        public BindingList<Travel> Travels { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int TravelsCount
        {
            get
            {
                return Travels.Count;
            }
        }

        public TravelAgency()
        {
            Name = "";
            Address = "";
            Travels = new BindingList<Travel>();
        }

        public TravelAgency(TravelAgency travelAgency)
        {
            Copy(travelAgency);
        }

        public TravelAgency(string name, string address, params Travel[] travels)
        {
            Name = name;
            Address = address;
            Travels = new BindingList<Travel>(travels);
        }

        public TravelAgency(string name, string address, IEnumerable<Travel> travels)
        {
            Name = name;
            Address = address;
            Travels = new BindingList<Travel>(travels.ToList());
        }

        public void Copy(TravelAgency travelAgency)
        {
            Name = travelAgency.Name;
            Address = travelAgency.Address;
            Travels = new BindingList<Travel>(travelAgency.Travels);
        }

        public void Remove(Travel travel)
        {
            Travels.Remove(travel);
        }
    }
}
