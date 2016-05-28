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
    /// Форма, отображающая список путешествий.
    /// </summary>
    public partial class TravelAgencyForm : Form
    {
        private BindingList<Tour> tours;
        private BindingSource source;
        
        /// <summary>
        /// </summary>
        /// <param name="travelAgency"> Туристическое агентство, путешествия которого необходимо показать. </param>
        public TravelAgencyForm(TravelAgency travelAgency) : this(travelAgency.Tours.ToList())
        {
            Text = travelAgency.Name;

            ToolStripItemCollection fileMenu = (menuStrip1.Items[0] as ToolStripMenuItem).DropDownItems;
            fileMenu.Clear();
            fileMenu.Add("Add travel");
            fileMenu[0].Click += addTravelToolStripMenuItem_Click;
            fileMenu.Add("Exit");
            fileMenu[1].Click += exitToolStripMenuItem_Click;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tours"> Список путешествий. </param>
        public TravelAgencyForm(List<Tour> tours)
        {
            source = new BindingSource();
            InitializeComponent();
            //travelAgencyGridView.DataSource = travels;
            Text = "List of travels";
            this.tours = new BindingList<Tour>(tours);
            source.DataSource = this.tours;
            travelAgencyGridView.DataSource = source;

            ToolStripItemCollection fileMenu = (menuStrip1.Items[0] as ToolStripMenuItem).DropDownItems;
            fileMenu.Add("Exit");
            fileMenu[0].Click += exitToolStripMenuItem_Click;
        }

        /// <summary>
        /// Запрет выделения фона ячейки.
        /// </summary>
        private void travelAgencyGridView_SelectionChanged(object sender, EventArgs e)
        {
            travelAgencyGridView.ClearSelection();
        }

        /// <summary>
        /// Обработка закрытия приложения.
        /// </summary>
        private void TravelAgencyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
                Application.Exit();
        }

        /// <summary>
        /// Фильтрация путешествий по нажатию кнопки.
        /// </summary>
        private void filterButton_Click(object sender, EventArgs e)
        {
            string[] filters = filterTextBox.Text.Split(' ');
            source.DataSource = TravelAgencyCollection.Filter<Tour>(tours.ToList(), filters);
        }

        /// <summary>
        /// Фильтрация путешествий по нажатию Enter.
        /// </summary>
        private void filterTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                filterButton_Click(this, new EventArgs());
            }
        }

        private void addTravelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTravelAgencyForm form = new AddTravelAgencyForm();
            form.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
