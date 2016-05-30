using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace coursa4
{
    public enum TravelType
    {
        Tour,
        Cruise
    }

    public enum Activeness
    {
        Calm,        // = "Calm travelism",
        Pleasure,    // = "Travelism for pleasure",
        Active,      // = "Active travelism",
        Sport,       // = "Sport travelism",
        Educational, // = "Educational travelism",
        Adventure,   // = "Adventure travelism".
    }

    [Flags]
    public enum Transport
    {
        None =  0x000,
        Plane = 0x001,
        Train = 0x002,
        Bus =   0x004,
        Taxi =  0x008,
        Ship =  0x010
    }

    [Flags]
    public enum Inclusion
    {
        None           = 0x000,
        Hotel          = 0x001,
        Transport      = 0x002,
        Excursions     = 0x004,
        Insurance      = 0x008,
        AllInclusive   = 0x010 // Food and Drinks
    }

    [Serializable]
    public class Travel
    {

        public Travel()
        {
            Route = new BindingList<Location>();
        }

        public Travel(Travel travel)
        {
            Copy(travel);
        }

        public Travel(
            TravelType type,
            string title,
            Activeness activeness,
            Transport transport,
            Inclusion inclusion,
            double cost,
            int dayLength,
            string description,
            params Location[] locations) :
            this(type, title, activeness, transport, inclusion, cost, dayLength, description, locations.ToList())
        { }

        public Travel(TravelType type, 
            string title, 
            Activeness activeness, 
            Transport transport, 
            Inclusion inclusion, 
            double cost, 
            int dayLength, 
            string description, 
            List<Location> locations)
        {
            Type = type;
            Title = title;
            Activeness = activeness;
            Transport = transport;
            Inclusion = inclusion;
            DayLength = dayLength;
            Cost = cost;
            Description = description;
            Route = new BindingList<Location>(locations);
        }

        public TravelAgency Owner { get; set; }
        public TravelType Type { get; set; }
        public string Title { get; set; }
        public Activeness Activeness { get; set; }
        public Transport Transport { get; set; }
        public Inclusion Inclusion { get; set; }
        public double Cost { get; set; }
        public int DayLength { get; set; }
        public string Description { get; set; }

        public BindingList<Location> Route { get; set; }

        public string Path
        {
            get
            {
                if (Route.Count == 0)
                    return "";

                string result = Route[0].ToString();
                for (int i = 1; i < Route.Count; i++)
                    result += " -> " + Route[i].ToString();
                return result;
            }
        }

        /// <summary>
        /// Проверка на корректность данных.
        /// </summary>
        public bool IsCorrect
        {
            get
            {
                if (Route.Count == 0)
                    return false;

                if (Title == "")
                    return false;

                foreach (Location l in Route)
                    if (!l.IsCorrect)
                        return false;

                return true;
            }
        }

        public void Copy(Travel travel)
        {
            Owner = travel.Owner;
            Type = travel.Type;
            Title = travel.Title;
            Activeness = travel.Activeness;
            Transport = travel.Transport;
            Inclusion = travel.Inclusion;
            DayLength = travel.DayLength;
            Cost = travel.Cost;
            Description = travel.Description;
            Route = new BindingList<Location>(travel.Route.ToList());
        }

        public void RemoveLocation(Location location)
        {
            Route.Remove(location);
        }

        public void RemoveLocationAt(int index)
        {
            Route.RemoveAt(index);
        }

        public void AddLocation(string place, string country)
        {
            Route.Add(new Location(place, country));
        }

        public void AddLocation()
        {
            Route.Add(new Location());
        }
    }
}
