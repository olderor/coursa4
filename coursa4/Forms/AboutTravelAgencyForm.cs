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
    public partial class AboutTravelAgencyForm : Form
    {

        public AboutTravelAgencyForm() : this(new TravelAgency())
        {
            isNew = true;
            Text = "Add travel agency";
        }

        public AboutTravelAgencyForm(TravelAgency travelAgency)
        {
            InitializeComponent();

            Text = "Edit";

            originalTravelAgency = travelAgency;
            this.travelAgency = new TravelAgency(originalTravelAgency);

            nameTextBox.DataBindings.Add(new Binding("Text", this.travelAgency, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            addressTextBox.DataBindings.Add(new Binding("Text", this.travelAgency, "Address", true, DataSourceUpdateMode.OnPropertyChanged));
        }

        private TravelAgency originalTravelAgency;
        private TravelAgency travelAgency;
        private bool saved = false;
        private bool isNew = false;


        private void saveData()
        {
            // Проверка на пустые поля.
            if (!travelAgency.IsCorrect)
            {
                MessageBox.Show("Travel agency should have a name and address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TravelAgencyCollection tac = TravelAgencyCollection.GetDefaultInstance();

            if (isNew)
            {
                tac.Add(travelAgency);
            }
            else
            {
                originalTravelAgency.Copy(travelAgency);
            }

            tac.Save();
            saved = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            saveData();
            if (saved)
                this.Close();
        }

        private void AddTravelAgencyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saved)
            {
                // Запрос подтверждения выхода из формы.
                DialogResult dr = MessageBox.Show("You have unsaved data. Do you want to save it?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    saveData();
                    if (!saved)
                        e.Cancel = true;
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
