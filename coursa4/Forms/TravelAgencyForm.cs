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
        public TravelAgencyForm(BindingList<Travel> travels) : this(travels.ToList()) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="travels"> Список путешествий. </param>
        public TravelAgencyForm(List<Travel> travels)
        {

            InitializeComponent();
            source = new BindingSource();
            
            menuStrip1.Items[1].Visible = false;
            //travelAgencyGridView.DataSource = travels;
            Text = "List of travels";
            this.travels = new BindingList<Travel>(travels);
            source.DataSource = this.travels;
            travelAgencyGridView.DataSource = source;
        }

        private TravelAgency travelAgency;
        private BindingList<Travel> travels;
        private BindingSource source;
        private bool isClosing = false;

        /// <summary>
        /// Фильтрация данных.
        /// </summary>
        private void filter()
        {
            string[] filters = filterTextBox.Text.Split(' ');
            source.DataSource = new BindingList<Travel>(TravelAgencyCollection.Filter<Travel>(travels.ToList(), filters));
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
        private void TravelAgencyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count == 0 && !isClosing)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    isClosing = true;
                    Application.Exit();
                }
                else
                    e.Cancel = true;
            }
        }

        /// <summary>
        /// Фильтрация путешествий по нажатию кнопки.
        /// </summary>
        private void filterButton_Click(object sender, EventArgs e)
        {
            filter();
        }

        /// <summary>
        /// Фильтрация путешествий по нажатию Enter.
        /// </summary>
        private void filterTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                filter();
            }
        }

        /// <summary>
        /// Обновление данных.
        /// </summary>
        private void updateGridView(object sender, FormClosedEventArgs e)
        {
            filter();
            if (travelAgency != null)
                Text = travelAgency.Name;
        }

        /// <summary>
        /// Добавление нового путешествия в список путешествий текущего агентства.
        /// </summary>
        private void addTravelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutTravelForm form = new AboutTravelForm(travelAgency);
            form.Show();
            form.FormClosed += updateGridView;
        }

        /// <summary>
        /// Редактирование текущего агентства.
        /// </summary>
        private void editTravelAgencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutTravelAgencyForm form = new AboutTravelAgencyForm(travelAgency);
            form.Show();
            form.FormClosed += updateGridView;
        }

        /// <summary>
        /// Удаление текущего агентства.
        /// </summary>
        private void deleteTravelAgencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to proceed? This data will be lost.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                TravelAgencyCollection tac = TravelAgencyCollection.GetDefaultInstance();
                tac.Remove(travelAgency);
                tac.Save();
                this.Close();
            }
        }

        /// <summary>
        /// Выход из программы.
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                isClosing = true;
                Application.Exit();
            }
        }

        /// <summary>
        /// Выбор путешествия из списка.
        /// </summary>
        private void travelAgencyGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Проверка на выбор заголовка столбца.
            if (e.RowIndex == -1)
                return;

            int index = travelAgencyGridView.CurrentRow.Index;
            Travel travel = (source.DataSource as BindingList<Travel>)[index];
            AboutTravelForm form = new AboutTravelForm(travelAgency, travel);
            form.Show();
            form.FormClosed += updateGridView;
        }

        /// <summary>
        /// Возвращение к предыдущей форме.
        /// </summary>
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Сортировка путешествий по полю.
        /// </summary>
        private void travelAgencyGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<Travel> data = (source.DataSource as BindingList<Travel>).ToList();
            string property = travelAgencyGridView.Columns[e.ColumnIndex].DataPropertyName;

            List<Travel> sortedData = TravelAgencyCollection.SortBy<Travel>(data, property);

            // Если списки одинаковы, меняем порядок
            if (TravelAgencyCollection.Compare<Travel>(sortedData, data))
                sortedData.Reverse();

            source.DataSource = new BindingList<Travel>(sortedData);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Double click on travel to browse and edit travel information.\nClick on column header to order column.\nEnter search filters separated by space and click search button to filter travels.\nClick on 'Agency' in menu to make actions on the agency.\nClick 'Back' button to return to list of travel agencies.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("coursa4 - the best travel guide!\nCreated by Bohdan Yevchenko.\nCopyright © 2016, All Rights Reserved.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
