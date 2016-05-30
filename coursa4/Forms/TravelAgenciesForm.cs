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
        /// <summary>
        /// Инициализация формы с глобальным списком агентств.
        /// </summary>
        public TravelAgenciesForm()
        {
            InitializeComponent();


            TravelAgencyCollection tac = TravelAgencyCollection.GetDefaultInstance();

            //generateData();

            source = new BindingSource();
            source.DataSource = tac.TravelAgencies;
            //travelAgenciesGridView.DataBindings.Add(new Binding("DataSource", this, "Agencies"));
            travelAgenciesGridView.DataSource = source;
        }

        private BindingSource source;

        private void generateData()
        {
            TravelAgencyCollection tac = TravelAgencyCollection.GetDefaultInstance();
            tac.Clear();

            for (int i = 0; i < 2; i++)
            {
                Travel t = new Travel(TravelType.Tour, "Jewels of Italy 2016", Activeness.Educational, Transport.Plane | Transport.Bus, Inclusion.Transport | Inclusion.Excursions, 1250, 7, "Enjoy all the Jewels of Italy on this adventure of a lifetime. A Local Specialist will take you on a travel from the Vatican City to glorious Ancient Rome to view the Forum and mighty Colosseum. Push the Leaning Tower of Pisa over in a photo to send home to the family, stand on Juliet's balcony in Verona and watch Venetian craftsmen at work at a glass-blowing workshop in Venice.", new Location("Rome", "Italy"), new Location("Florence", "Italy"), new Location("Venice", "Italy"), new Location("Rome", "Italy"));
                Travel t2 = new Travel(TravelType.Cruise, "EASTERN CARIBBEAN FROM MIAMI", Activeness.Adventure, Transport.Ship, Inclusion.AllInclusive | Inclusion.Transport | Inclusion.Insurance, 419, 8, "An Interior stateroom is the most affordable way to cruise, and Carnival Glory's interiors are not just cozy, but are full of things you’d expect from any Carnival stateroom: a full private bathroom, Carnival Comfort Collection linens and just-a-call-away 24-hour room service.", new Location("Miami", "Florida"), new Location("Little San Salvador Island", "The Bahamas"), new Location("Saint Thomas", "Virgin Islands"), new Location("San Juan", "Puerto Rico"), new Location("Miami", "Florida"));
                Travel t3 = new Travel(TravelType.Tour, "Discovering Germany", Activeness.Pleasure, Transport.Train | Transport.Bus, Inclusion.Transport, 149, 1, "Germany is synonymous with beer gardens, fairytale castles, medieval towns, and scenic rivers.", new Location("Munich", "Germany"));

                TravelAgency ta = new TravelAgency("Carnival" + i.ToString(), "Kharkiv, Vidumanaya street, 24a", t2, t3);
                tac.Add(ta);
            }

            for (int i = 0; i < 2; i++)
            {
                Travel t = new Travel(TravelType.Tour, "Jewels of Italy 2016", Activeness.Educational, Transport.Plane | Transport.Bus, Inclusion.Transport | Inclusion.Excursions, 1250, 7, "Enjoy all the Jewels of Italy on this adventure of a lifetime. A Local Specialist will take you on a travel from the Vatican City to glorious Ancient Rome to view the Forum and mighty Colosseum. Push the Leaning Tower of Pisa over in a photo to send home to the family, stand on Juliet's balcony in Verona and watch Venetian craftsmen at work at a glass-blowing workshop in Venice.", new Location("Rome", "Italy"), new Location("Florence", "Italy"), new Location("Venice", "Italy"), new Location("Rome", "Italy"));
                Travel t4 = new Travel(TravelType.Tour, "Jewels of Italy 2016", Activeness.Educational, Transport.Plane | Transport.Bus, Inclusion.Transport | Inclusion.Excursions, 1250, 7, "Enjoy all the Jewels of Italy on this adventure of a lifetime. A Local Specialist will take you on a travel from the Vatican City to glorious Ancient Rome to view the Forum and mighty Colosseum. Push the Leaning Tower of Pisa over in a photo to send home to the family, stand on Juliet's balcony in Verona and watch Venetian craftsmen at work at a glass-blowing workshop in Venice.", new Location("Rome", "Italy"), new Location("Florence", "Italy"), new Location("Venice", "Italy"), new Location("Rome", "Italy"));
                Travel t5 = new Travel(TravelType.Tour, "Jewels of Italy 2016", Activeness.Educational, Transport.Plane | Transport.Bus, Inclusion.Transport | Inclusion.Excursions, 1250, 7, "Enjoy all the Jewels of Italy on this adventure of a lifetime. A Local Specialist will take you on a travel from the Vatican City to glorious Ancient Rome to view the Forum and mighty Colosseum. Push the Leaning Tower of Pisa over in a photo to send home to the family, stand on Juliet's balcony in Verona and watch Venetian craftsmen at work at a glass-blowing workshop in Venice.", new Location("Rome", "Italy"), new Location("Florence", "Italy"), new Location("Venice", "Italy"), new Location("Rome", "Italy"));
                Travel t2 = new Travel(TravelType.Cruise, "EASTERN CARIBBEAN FROM MIAMI", Activeness.Adventure, Transport.Ship, Inclusion.AllInclusive | Inclusion.Transport | Inclusion.Insurance, 419, 8, "An Interior stateroom is the most affordable way to cruise, and Carnival Glory's interiors are not just cozy, but are full of things you’d expect from any Carnival stateroom: a full private bathroom, Carnival Comfort Collection linens and just-a-call-away 24-hour room service.", new Location("Miami", "Florida"), new Location("Little San Salvador Island", "The Bahamas"), new Location("Saint Thomas", "Virgin Islands"), new Location("San Juan", "Puerto Rico"), new Location("Miami", "Florida"));
                Travel t3 = new Travel(TravelType.Tour, "Discovering Germany", Activeness.Pleasure, Transport.Train | Transport.Bus, Inclusion.Transport, 149, 1, "Germany is synonymous with beer gardens, fairytale castles, medieval towns, and scenic rivers.", new Location("Munich", "Germany"));
                Travel t6 = new Travel(TravelType.Cruise, "EASTERN CARIBBEAN FROM MIAMI", Activeness.Adventure, Transport.Ship, Inclusion.AllInclusive | Inclusion.Transport | Inclusion.Insurance, 419, 8, "An Interior stateroom is the most affordable way to cruise, and Carnival Glory's interiors are not just cozy, but are full of things you’d expect from any Carnival stateroom: a full private bathroom, Carnival Comfort Collection linens and just-a-call-away 24-hour room service.", new Location("Miami", "Florida"), new Location("Little San Salvador Island", "The Bahamas"), new Location("Saint Thomas", "Virgin Islands"), new Location("San Juan", "Puerto Rico"), new Location("Miami", "Florida"));
                Travel t7 = new Travel(TravelType.Tour, "Discovering Germany", Activeness.Pleasure, Transport.Train | Transport.Bus, Inclusion.Transport, 149, 1, "Germany is synonymous with beer gardens, fairytale castles, medieval towns, and scenic rivers.", new Location("Munich", "Germany"));

                TravelAgency ta2 = new TravelAgency("Globus" + i.ToString(), "Kharkiv, Travelizm street, 129", t, t3, t4, t5, t2, t6, t7);
                tac.Add(ta2);
            }
            tac.Save();
        }

        /// <summary>
        /// Обновление данных.
        /// </summary>
        private void updateGridView(object sender, FormClosedEventArgs e)
        {
            filter();
        }

        /// <summary>
        /// Фильтрация данных.
        /// </summary>
        private void filter()
        {
            TravelAgencyCollection tac = TravelAgencyCollection.GetDefaultInstance();
            string[] filters = filterTextBox.Text.Split(' ');
            source.DataSource = new BindingList<TravelAgency>(MyList.Filter<TravelAgency>(tac.GetAllTravelAgencies(), filters));
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
            taf.FormClosed += updateGridView;
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
        private void browseAllTravelsButton_Click(object sender, EventArgs e)
        {
            TravelAgencyForm form = new TravelAgencyForm(TravelAgencyCollection.GetDefaultInstance().GetAllTravels());
            form.Show();
            form.FormClosed += updateGridView;
        }

        /// <summary>
        /// Фильтрация туристических агентств по нажатию кнопки.
        /// </summary>
        private void filterButton_Click(object sender, EventArgs e)
        {
            filter();
        }

        /// <summary>
        /// Фильтрация туристических агентств по нажатию Enter.
        /// </summary>
        private void filterTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                filter();
            }
        }

        /// <summary>
        /// Выход из программы.
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Добавление агентства.
        /// </summary>
        private void addAgencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutTravelAgencyForm form = new AboutTravelAgencyForm();
            form.Show();
            form.FormClosed += updateGridView;
        }

        /// <summary>
        /// Выбор агентства.
        /// </summary>
        private void travelAgenciesGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<TravelAgency> data = (source.DataSource as BindingList<TravelAgency>).ToList();
            string property = travelAgenciesGridView.Columns[e.ColumnIndex].DataPropertyName;

            List<TravelAgency> sortedData = MyList.SortBy<TravelAgency>(data, property);

            // Если списки одинаковы, меняем порядок
            if (MyList.Compare<TravelAgency>(sortedData, data))
                sortedData.Reverse();

            source.DataSource = new BindingList<TravelAgency>(sortedData);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("coursa4 - the best travel guide!\nCreated by Bohdan Yevchenko.\nCopyright © 2016, All Rights Reserved.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Double click on travel agency to browse and edit travel agency.\nClick on column header to order column.\nEnter search filters separated by space and click search button to filter agencies.\nClick on 'browse all' button to see all travels we have.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
