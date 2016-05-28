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
        private TravelAgency travelAgency;
        private BindingList<Travel> travels;
        private BindingSource source;
        
        /// <summary>
        /// </summary>
        /// <param name="travelAgency"> Туристическое агентство, путешествия которого необходимо показать. </param>
        public TravelAgencyForm(TravelAgency travelAgency) : this(travelAgency.Travels)
        {
            this.travelAgency = travelAgency;

            DataBindings.Add(new Binding("Text", travelAgency, "Name"));

            ToolStripItemCollection fileMenu = (menuStrip1.Items[1] as ToolStripMenuItem).DropDownItems;
            menuStrip1.Items[1].Visible = true;
            fileMenu.Clear();
            fileMenu.Add("Add travel");
            fileMenu[0].Click += addTravelToolStripMenuItem_Click;
            fileMenu.Add("Edit");
            fileMenu[1].Click += editTravelAgencyToolStripMenuItem_Click;
            fileMenu.Add("Delete");
            fileMenu[2].Click += deleteTravelAgencyToolStripMenuItem_Click;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="travels"> Список путешествий. </param>
        public TravelAgencyForm(BindingList<Travel> travels)
        {
            source = new BindingSource();
            InitializeComponent();

            menuStrip1.Items[1].Visible = false;
            //travelAgencyGridView.DataSource = travels;
            Text = "List of travels";
            this.travels = travels;
            source.DataSource = this.travels;
            travelAgencyGridView.DataSource = source;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="travels"> Список путешествий. </param>
        public TravelAgencyForm(List<Travel> travels)
        {
            source = new BindingSource();
            InitializeComponent();

            menuStrip1.Items[1].Visible = false;
            //travelAgencyGridView.DataSource = travels;
            Text = "List of travels";
            this.travels = new BindingList<Travel>(travels);
            source.DataSource = this.travels;
            travelAgencyGridView.DataSource = source;
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
            source.DataSource = TravelAgencyCollection.Filter<Travel>(travels.ToList(), filters);
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
            AboutTravelForm form = new AboutTravelForm(travelAgency);
            form.Show();
        }

        private void editTravelAgencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutTravelAgencyForm form = new AboutTravelAgencyForm(travelAgency);
            form.Show();
        }

        private void deleteTravelAgencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to proceed? This data will be lost.", "Warning", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                TravelAgencyCollection tac = TravelAgencyCollection.GetDefaultInstance();
                tac.Remove(travelAgency);
                tac.Save();
                this.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void travelAgencyGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Проверка на выбор заголовка столбца.
            if (e.RowIndex == -1)
                return;

            int index = travelAgencyGridView.CurrentRow.Index;
            Travel travel = (source.DataSource as BindingList<Travel>)[index];
            AboutTravelForm form = new AboutTravelForm(travelAgency, travel);
            form.Show();
        }
    }
}
