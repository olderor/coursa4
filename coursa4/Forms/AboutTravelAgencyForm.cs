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

        public AboutTravelAgencyForm()
        {
            InitializeComponent();

            isNew = true;

            travelAgency = new TravelAgency();
            nameTextBox.DataBindings.Add(new Binding("Text", travelAgency, "Name", true, DataSourceUpdateMode.OnPropertyChanged));
            addressTextBox.DataBindings.Add(new Binding("Text", travelAgency, "Address", true, DataSourceUpdateMode.OnPropertyChanged));
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
        private bool isClosing = false;

        private void saveButton_Click(object sender, EventArgs e)
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
            this.Close();
        }

        private void AddTravelAgencyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saved)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to proceed? All unsaved changes will be lost.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            if (Application.OpenForms.Count == 1 && !isClosing)
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
