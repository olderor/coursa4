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
    public partial class AboutTravelForm : Form
    {
        private Travel travel;
        private Travel originalTravel;
        private TravelAgency travelAgency;
        private bool saved = false;
        private bool isNew = false;

        public AboutTravelForm(TravelAgency travelAgency)
        {
            InitializeComponent();

            isNew = true;
            this.travelAgency = travelAgency;
            travel = new Travel();

            travelTypeComboBox.DataSource = Enum.GetValues(typeof(TravelType));
            activenessComboBox.DataSource = Enum.GetValues(typeof(Activeness));
            ((ListBox)transportCheckedListBox).DataSource = Enum.GetValues(typeof(Transport));
            ((ListBox)transportCheckedListBox).DisplayMember = "Name";
            transportCheckedListBox.SetItemCheckState(0, CheckState.Checked);
            ((ListBox)inclusionCheckedListBox).DataSource = Enum.GetValues(typeof(Inclusion));
            ((ListBox)inclusionCheckedListBox).DisplayMember = "Name";
            inclusionCheckedListBox.SetItemCheckState(0, CheckState.Checked);

            titleTextBox.DataBindings.Add(new Binding("Text", travel, "Title"));
            costNumericUpDown.DataBindings.Add(new Binding("Value", travel, "Cost"));
            daysNumericUpDown.DataBindings.Add(new Binding("Value", travel, "DayLength"));
            descriptionTextBox.DataBindings.Add(new Binding("Text", travel, "Description"));
            deleteButton.Visible = false;
        }

        public AboutTravelForm(TravelAgency travelAgency, Travel travel)
        {
            InitializeComponent();

            originalTravel = travel;
            this.travelAgency = travelAgency;
            this.travel = new Travel(travel);

            travelTypeComboBox.DataSource = Enum.GetValues(typeof(TravelType));
            travelTypeComboBox.SelectedItem = this.travel.Type;
            activenessComboBox.DataSource = Enum.GetValues(typeof(Activeness));
            activenessComboBox.SelectedItem = this.travel.Activeness;

            ((ListBox)transportCheckedListBox).DataSource = Enum.GetValues(typeof(Transport));
            ((ListBox)transportCheckedListBox).DisplayMember = "Name";
            setEnumToCheckedListBox(transportCheckedListBox, Enum.GetValues(typeof(Transport)), (int)travel.Transport);
            ((ListBox)inclusionCheckedListBox).DataSource = Enum.GetValues(typeof(Inclusion));
            ((ListBox)inclusionCheckedListBox).DisplayMember = "Name";
            setEnumToCheckedListBox(inclusionCheckedListBox, Enum.GetValues(typeof(Inclusion)), (int)travel.Inclusion);

            titleTextBox.DataBindings.Add(new Binding("Text", this.travel, "Title"));
            costNumericUpDown.DataBindings.Add(new Binding("Value", this.travel, "Cost"));
            daysNumericUpDown.DataBindings.Add(new Binding("Value", this.travel, "DayLength"));
            descriptionTextBox.DataBindings.Add(new Binding("Text", this.travel, "Description"));
        }

        private void setEnumToCheckedListBox(CheckedListBox listBox, Array enumValues, int value)
        {
            for (int i = 0; i < enumValues.Length; i++)
            {
                int enumValue = (int)enumValues.GetValue(i);
                if ((value & enumValue) == enumValue)
                {
                    listBox.SetItemCheckState(i, CheckState.Checked);
                }
            }
        }

        private void transportCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index == 0)
            {
                if (travel.Transport == Transport.None)
                {
                    e.NewValue = CheckState.Checked;
                    return;
                }

                if (e.NewValue == CheckState.Checked)
                {
                    foreach (int i in transportCheckedListBox.CheckedIndices)
                        transportCheckedListBox.SetItemCheckState(i, CheckState.Unchecked);
                }
                return;
            }

            if (e.NewValue == CheckState.Checked)
            {
                travel.Transport |= (Transport)Enum.GetValues(typeof(Transport)).GetValue(e.Index);
                transportCheckedListBox.SetItemCheckState(0, CheckState.Unchecked);
            }
            else
            {
                travel.Transport &= ~(Transport)Enum.GetValues(typeof(Transport)).GetValue(e.Index);
                if (travel.Transport == Transport.None)
                {
                    transportCheckedListBox.SetItemCheckState(0, CheckState.Checked);
                }
            }
        }

        private void inclusionCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index == 0)
            {
                if (travel.Inclusion == Inclusion.None)
                {
                    e.NewValue = CheckState.Checked;
                    return;
                }

                if (e.NewValue == CheckState.Checked)
                {
                    foreach (int i in inclusionCheckedListBox.CheckedIndices)
                        inclusionCheckedListBox.SetItemCheckState(i, CheckState.Unchecked);
                }
                return;
            }

            if (e.NewValue == CheckState.Checked)
            {
                travel.Inclusion |= (Inclusion)Enum.GetValues(typeof(Inclusion)).GetValue(e.Index);
                inclusionCheckedListBox.SetItemCheckState(0, CheckState.Unchecked);
            }
            else
            {
                travel.Inclusion &= ~(Inclusion)Enum.GetValues(typeof(Inclusion)).GetValue(e.Index);
                if (travel.Inclusion == Inclusion.None)
                {
                    inclusionCheckedListBox.SetItemCheckState(0, CheckState.Checked);
                }
            }
        }

        private void travelTypeComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            travel.Type = (TravelType)travelTypeComboBox.SelectedValue;
        }

        private void activenessComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            travel.Activeness = (Activeness)activenessComboBox.SelectedValue;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            TravelAgencyCollection tac = TravelAgencyCollection.GetDefaultInstance();

            if (isNew)
            {
                travelAgency.Travels.Add(travel);
                travelAgency.Name = travelAgency.Name + " ";
            }
            else
            {
                originalTravel.Copy(travel);
            }


            tac.Save();
            saved = true;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AboutTravelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saved)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to proceed? All unsaved changes will be lost.", "Warning", MessageBoxButtons.YesNo);
                if (dr == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            if (Application.OpenForms.Count == 1)
                Application.Exit();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to proceed? This data will be lost.", "Warning", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                travelAgency.Remove(originalTravel);
                TravelAgencyCollection.GetDefaultInstance().Save();
                saved = true;
                this.Close();
            }
        }
    }
}
