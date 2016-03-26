using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursa4.classes
{
    enum TourType
    {
        Visit, Cruise
    }

    class Tour
    {
        private List<Location> cruiseRoute;
        private Location location;
        private TourType type;

        public TourType Type { get { return type; } }
        public List<Location> CruiseRoute { get { return cruiseRoute; } }
        public Location Location { get { return location; } }

        public Tour(params Location[] locations)
        {
            if (locations == null || locations.Length == 0)
            {
                //show error
                return;
            }
            cruiseRoute = locations.ToList();
            location = locations[0];
            if (locations.Length == 1)
                type = TourType.Visit;
            else
                type = TourType.Cruise;
        }

        public override string ToString()
        {
            string result = location.ToString();

            for (int i = 1; i < cruiseRoute.Count; i++)
                result += " -> " + cruiseRoute[i];

            return result;
        }
    }
}
