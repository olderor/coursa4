using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursa4
{
    public enum TravelType
    {
        Travel,
        Tour,
        Cruise
    }

    public enum Activeness
    {
        Calm,        // = "Calm tourism",
        Pleasure,    // = "Tourism for pleasure",
        Active,      // = "Active tourism",
        Sport,       // = "Sport tourism",
        Educational, // = "Educational tourism",
        Adventure,   // = "Adventure tourism"
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
        HotelPrice     = 0x001,
        TransportPrice = 0x002,
        Visa           = 0x004,
        Insurance      = 0x008,
        AllInclusive   = 0x010 // Food and Drinks
    }

    [Serializable]
    public abstract class AbstractTravel
    {
        public TravelType Type { get; set; }
        public string Title { get; set; }
        public Activeness Activeness { get; set; }
        public Transport Transport { get; set; }
        public Inclusion Inclusion { get; set; }
        public double Cost { get; set; }
        public int DayLength { get; set; }
        public string Description { get; set; }

        abstract public string Path { get; }

        public AbstractTravel(TravelType type, string title, Activeness activeness, Transport transport, Inclusion inclusion, double cost, int dayLength, string description)
        {
            Type = type;
            Title = title;
            Activeness = activeness;
            Transport = transport;
            Inclusion = inclusion;
            DayLength = dayLength;
            Cost = cost;
            Description = description;
        }
    }

    [Serializable]
    public class Travel : AbstractTravel
    {
        public Location Location { get; set; }

        public override string Path
        {
            get
            {
                return Location.ToString();
            }
        }

        public Travel(string title, Activeness activeness, Transport transport, Inclusion inclusion, double cost, int dayLength, string description, Location location) : 
            base(TravelType.Travel, title, activeness, transport, inclusion, cost, dayLength, description)
        {
            Location = location;
        }
    }

    [Serializable]
    public class Tour : AbstractTravel
    {
        public List<Location> Route { get; set; }

        public override string Path
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

        public Tour(TravelType type, string title, Activeness activeness, Transport transport, Inclusion inclusion, double cost, int dayLength, string description, params Location[] locations) :
            base(type, title, activeness, transport, inclusion, cost, dayLength, description)
        {
            Route = locations.ToList();
        }

        public Tour(TravelType type, string title, Activeness activeness, Transport transport, Inclusion inclusion, double cost, int dayLength, string description, List<Location> locations) :
            base(type, title, activeness, transport, inclusion, cost, dayLength, description)
        {
            Route = locations;
        }
    }
}
