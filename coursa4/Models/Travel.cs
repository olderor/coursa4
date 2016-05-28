using System;
using System.Collections.Generic;
using System.Linq;
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
        HotelPrice     = 0x001,
        TransportPrice = 0x002,
        Visa           = 0x004,
        Insurance      = 0x008,
        AllInclusive   = 0x010 // Food and Drinks
    }

    [Serializable]
    public class Travel
    {
        public TravelType Type { get; set; }
        public string Title { get; set; }
        public Activeness Activeness { get; set; }
        public Transport Transport { get; set; }
        public Inclusion Inclusion { get; set; }
        public double Cost { get; set; }
        public int DayLength { get; set; }
        public string Description { get; set; }

        public List<Location> Route { get; set; }

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

        public Travel()
        {
            Type = TravelType.Tour;
            Title = "";
            Activeness = Activeness.Adventure;
            Transport = Transport.None;
            Inclusion = Inclusion.None;
            DayLength = 0;
            Cost = 0;
            Description = "";
            Route = new List<Location>();
        }

        public Travel(Travel travel)
        {
            Copy(travel);
        }

        public Travel(TravelType type, string title, Activeness activeness, Transport transport, Inclusion inclusion, double cost, int dayLength, string description, params Location[] locations)
        {
            Type = type;
            Title = title;
            Activeness = activeness;
            Transport = transport;
            Inclusion = inclusion;
            DayLength = dayLength;
            Cost = cost;
            Description = description;
            Route = locations.ToList();
        }

        public Travel(TravelType type, string title, Activeness activeness, Transport transport, Inclusion inclusion, double cost, int dayLength, string description, List<Location> locations)
        {
            Type = type;
            Title = title;
            Activeness = activeness;
            Transport = transport;
            Inclusion = inclusion;
            DayLength = dayLength;
            Cost = cost;
            Description = description;
            Route = locations;
        }

        public void Copy(Travel travel)
        {
            Type = travel.Type;
            Title = travel.Title;
            Activeness = travel.Activeness;
            Transport = travel.Transport;
            Inclusion = travel.Inclusion;
            DayLength = travel.DayLength;
            Cost = travel.Cost;
            Description = travel.Description;
            Route = new List<Location>(travel.Route);
        }
    }
}
