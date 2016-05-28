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
    /// <summary>
    /// Форма, отображающая список туристических агентств.
    /// </summary>
    public partial class TravelAgenciesForm : Form
    {
        private BindingSource source;

        /// <summary>
        /// Инициализация формы с глобальным списком агентств.
        /// </summary>
        public TravelAgenciesForm()
        {
            InitializeComponent();

            
            TravelAgencyCollection tac = TravelAgencyCollection.GetDefaultInstance();

            if (tac.TravelAgencies.Count == 0)
            {
                tac.Clear();
                Tour t = new Tour(TourType.Tour, "Jewels of Italy 2016", Activeness.Educational, Transport.Plane | Transport.Bus, Inclusion.TransportPrice | Inclusion.Visa, 1250, 7, "Enjoy all the Jewels of Italy on this adventure of a lifetime. A Local Specialist will take you on a tour from the Vatican City to glorious Ancient Rome to view the Forum and mighty Colosseum. Push the Leaning Tower of Pisa over in a photo to send home to the family, stand on Juliet's balcony in Verona and watch Venetian craftsmen at work at a glass-blowing workshop in Venice.", new Location("Rome", "Italy"), new Location("Florence", "Italy"), new Location("Venice", "Italy"), new Location("Rome", "Italy"));
                Tour t2 = new Tour(TourType.Cruise, "EASTERN CARIBBEAN FROM MIAMI", Activeness.Adventure, Transport.Ship, Inclusion.AllInclusive | Inclusion.TransportPrice | Inclusion.Insurance, 419, 8, "An Interior stateroom is the most affordable way to cruise, and Carnival Glory's interiors are not just cozy, but are full of things you’d expect from any Carnival stateroom: a full private bathroom, Carnival Comfort Collection linens and just-a-call-away 24-hour room service.", new Location("Miami", "Florida"), new Location("Little San Salvador Island", "The Bahamas"), new Location("Saint Thomas", "Virgin Islands"), new Location("San Juan", "Puerto Rico"), new Location("Miami", "Florida"));
                Tour t3 = new Tour(TourType.Tour, "Discovering Germany", Activeness.Pleasure, Transport.Train | Transport.Bus, Inclusion.TransportPrice, 149, 1, "Germany is synonymous with beer gardens, fairytale castles, medieval towns, and scenic rivers.", new Location("Munich", "Germany"));

                TravelAgency ta = new TravelAgency("Carnival", "Kharkiv, Vidumanaya street, 24a", t2, t3);
                TravelAgency ta2 = new TravelAgency("Globus", "Kharkiv, Tourizm street, 129", t, t3, t, t, t2);

                tac.Add(ta);
                tac.Add(ta2);

                tac.Save();
            }

            source = new BindingSource();
            source.DataSource = tac.TravelAgencies;
            //travelAgenciesGridView.DataBindings.Add(new Binding("DataSource", this, "Agencies"));
            travelAgenciesGridView.DataSource = source;
        }

        /// <summary>
        /// Обработка выбора туристического агентсва.
        /// </summary>
        private void travelAgenciesGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Проверка на выбор заголовка столбца.
            if (e.RowIndex == -1)
                return;

            int index = travelAgenciesGridView.CurrentRow.Index;
            TravelAgency ta = (source.DataSource as BindingList<TravelAgency>)[index];
            TravelAgencyForm taf = new TravelAgencyForm(ta);
            taf.Show();
            this.Close();
        }

        /// <summary>
        /// Запрет выделения фона ячейки.
        /// </summary>
        private void travelAgenciesGridView_SelectionChanged(object sender, EventArgs e)
        {
            travelAgenciesGridView.ClearSelection();
        }

        /// <summary>
        /// Открытие формы с просмотром всех путешествий.
        /// </summary>
        private void browseAllToursButton_Click(object sender, EventArgs e)
        {
            TravelAgencyForm form = new TravelAgencyForm(TravelAgencyCollection.GetDefaultInstance().GetAllTours());
            form.Show();
            this.Close();
        }

        /// <summary>
        /// Обработка закрытия приложения.
        /// </summary>
        private void TravelAgenciesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
                Application.Exit();
        }

        /// <summary>
        /// Фильтрация туристических агентств по нажатию кнопки.
        /// </summary>
        private void filterButton_Click(object sender, EventArgs e)
        {
            TravelAgencyCollection tac = TravelAgencyCollection.GetDefaultInstance();
            string[] filters = filterTextBox.Text.Split(' ');
            source.DataSource = TravelAgencyCollection.Filter<TravelAgency>(tac.GetAllTravelAgencies(), filters);
        }

        /// <summary>
        /// Фильтрация туристических агентств по нажатию Enter.
        /// </summary>
        private void filterTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                filterButton_Click(this, new EventArgs());
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addAgencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTravelAgencyForm form = new AddTravelAgencyForm();
            form.Show();
        }
    }
}
