using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursa4.classes
{
    class TourAgency
    {
        private List<Tour> tours;
        private string name;

        public List<Tour> Tours { get { return tours; } }
        public string Name { get { return name; } }

        public TourAgency(params Tour[] tours)
        {
            this.tours = tours.ToList();
        }
    }
}
