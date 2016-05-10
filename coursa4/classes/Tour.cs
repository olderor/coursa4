using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursa4.classes
{

    enum Activeness
    {
        Calm,
        Pleasure,
        Active,
        Sport,
        Knowledge,
        Adventure
    }

    [Flags]
    enum Transport
    {
        None =  0x000,
        Plane = 0x001,
        Train = 0x002,
        Bus =   0x004,
        Taxi =  0x008,
        Ship =  0x010
    }

    [Flags]
    enum Inclusion
    {
        None           = 0x000,
        HotelPrice     = 0x000,
        TransportPrice = 0x001,
        Visa           = 0x002,
        Insurance      = 0x004,
        AllInclusive   = 0x008 // Food and Drinks
    }

    abstract class AbstractTour
    {

        public string Title { get; set; }
        public Activeness Activeness { get; set; }
        public Transport Transport { get; set; }
        public Inclusion Inclusion { get; set; }
        public double Cost { get; set; }
        public string Description { get; set; }

        public AbstractTour(string title, Activeness activeness, Transport transport, Inclusion inclusion, double cost, string description)
        {
            Title = title;
            Activeness = activeness;
            Transport = transport;
            Inclusion = inclusion;
            Cost = cost;
            Description = description;
        }
    }

    class Tour : AbstractTour
    {
        public Location Location { get; set; }

        public Tour(string title, Activeness activeness, Transport transport, Inclusion inclusion, double cost, string description, Location location) : 
            base(title, activeness, transport, inclusion, cost, description)
        {
            Location = location;
        }
    }

    class Cruise : AbstractTour
    {
        public List<Location> Route { get; set; }

        public Cruise(string title, Activeness activeness, Transport transport, Inclusion inclusion, double cost, string description, params Location[] locations) :
            base(title, activeness, transport, inclusion, cost, description)
        {
            Route = locations.ToList();
        }

        public Cruise(string title, Activeness activeness, Transport transport, Inclusion inclusion, double cost, string description, List<Location> locations) :
            base(title, activeness, transport, inclusion, cost, description)
        {
            Route = locations.ToList();
        }
    }
}
