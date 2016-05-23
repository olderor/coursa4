using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursa4
{
    public partial class TourAgenciesForm : Form
    {
        public TourAgenciesForm()
        {
            InitializeComponent();

            TourAgencyCollection tac = TourAgencyCollection.GetDefaultInstance();

            /*
            Tour t = new Tour(TravelType.Tour, "Jewels of Italy 2016", Activeness.Educational, Transport.Plane | Transport.Bus, Inclusion.TransportPrice | Inclusion.Visa, 1250, 7, "Enjoy all the Jewels of Italy on this adventure of a lifetime. A Local Specialist will take you on a tour from the Vatican City to glorious Ancient Rome to view the Forum and mighty Colosseum. Push the Leaning Tower of Pisa over in a photo to send home to the family, stand on Juliet's balcony in Verona and watch Venetian craftsmen at work at a glass-blowing workshop in Venice.", new Location("Rome", "Italy"), new Location("Florence", "Italy"), new Location("Venice", "Italy"), new Location("Rome", "Italy"));
            Tour t2 = new Tour(TravelType.Cruise, "EASTERN CARIBBEAN FROM MIAMI", Activeness.Adventure, Transport.Ship, Inclusion.AllInclusive | Inclusion.TransportPrice | Inclusion.Insurance, 419, 8, "An Interior stateroom is the most affordable way to cruise, and Carnival Glory's interiors are not just cozy, but are full of things you’d expect from any Carnival stateroom: a full private bathroom, Carnival Comfort Collection linens and just-a-call-away 24-hour room service.", new Location("Miami", "Florida"), new Location("Little San Salvador Island", "The Bahamas"), new Location("Saint Thomas", "Virgin Islands"), new Location("San Juan", "Puerto Rico"), new Location("Miami", "Florida"));
            Travel t3 = new Travel("Discovering Germany", Activeness.Pleasure, Transport.Train | Transport.Bus, Inclusion.TransportPrice, 149, 1, "Germany is synonymous with beer gardens, fairytale castles, medieval towns, and scenic rivers.", new Location("Munich", "Germany"));

            TourAgency ta = new TourAgency("Carnival", "Kharkiv, Vidumanaya street, 24a", t2, t2);
            TourAgency ta2 = new TourAgency("Globus", "Kharkiv, Tourizm street, 129", t, t3, t, t, t2);
            
            tac.Add(ta);
            tac.Add(ta2);

            tac.Save();
            */

            dataGridView1.DataSource = tac;
        }
    }
}
