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

        public AboutTravelForm(TravelAgency travelAgency) : this(travelAgency, new Travel())
        {            
            deleteButton.Visible = false;
            isNew = true;
        }

        public AboutTravelForm(TravelAgency travelAgency, Travel travel)
        {
            InitializeComponent();

            originalTravel = travel;
            this.travelAgency = travelAgency;
            this.travel = new Travel(travel);

            if (travelAgency != null)
                infoLabel.Text = "Travel by '" + travelAgency.Name + "'.";
            else
                infoLabel.Text = "Travel by '" + travel.Owner.Name + "'.";

            // Установка связей и источников данных для перечислений.

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

            titleTextBox.DataBindings.Add(new Binding("Text", this.travel, "Title", true, DataSourceUpdateMode.OnPropertyChanged));
            costNumericUpDown.DataBindings.Add(new Binding("Value", this.travel, "Cost", true, DataSourceUpdateMode.OnPropertyChanged));
            daysNumericUpDown.DataBindings.Add(new Binding("Value", this.travel, "DayLength", true, DataSourceUpdateMode.OnPropertyChanged));
            descriptionTextBox.DataBindings.Add(new Binding("Text", this.travel, "Description", true, DataSourceUpdateMode.OnPropertyChanged));

            routeGridView.DataBindings.Add(new Binding("DataSource", this.travel, "Route", true, DataSourceUpdateMode.OnPropertyChanged));

            DataBindings.Add(new Binding("Text", titleTextBox, "Text"));

            if (this.travel.Route.Count != 0)
                deletePlaceButton.Enabled = true;
            
        }


        private Travel travel;
        private Travel originalTravel;
        private TravelAgency travelAgency;
        private bool saved = false;
        private bool isNew = false;
        private bool isClosing = false;

        /// <summary>
        /// Устанавливает значения, которые указаны в объекте, в чекбокс.
        /// </summary>
        /// <param name="listBox"> Чекбокс, в который нужно установить значения. </param>
        /// <param name="enumValues"> Все возможные значения перечисления. </param>
        /// <param name="value"> Значение объекта. </param>
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
            transportCheckedListBox.ClearSelected();

            // Если был выбран None, нужно снять со всех остальных значений отметки.
            // С None нельзя снять отметку, разве что только если было выбрано другое значение. 
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
            inclusionCheckedListBox.ClearSelected();

            // Если был выбран None, нужно снять со всех остальных значений отметки.
            // С None нельзя снять отметку, разве что только если было выбрано другое значение. 

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
            // Проверка на корректность входных данных.
            if (!travel.IsCorrect)
            {
                MessageBox.Show("Travel should have a title and contain at least 1 place, all of them should have place name and country.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TravelAgencyCollection tac = TravelAgencyCollection.GetDefaultInstance();

            if (isNew)
            {
                travelAgency.Add(travel);
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
                // Запрос подтверждения выхода из формы.
                DialogResult dr = MessageBox.Show("Are you sure you want to proceed? All unsaved changes will be lost.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
                else
                {
                    saved = true;
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to proceed? This data will be lost.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                travelAgency.Remove(originalTravel);
                TravelAgencyCollection.GetDefaultInstance().Save();
                saved = true;
                this.Close();
            }
        }

        private void deletePlaceButton_Click(object sender, EventArgs e)
        {
            // Выбираем все отмеченные ячейки и удаляем их. После устанавливаем выделение на следующий элемент.
            int index = 0;
            DataGridViewSelectedRowCollection rows = routeGridView.SelectedRows;
            for (int i = 0; i < rows.Count; i++)
            {
                index = rows[i].Index;
                travel.RemoveLocationAt(index);
                if (travel.Route.Count == 0)
                    deletePlaceButton.Enabled = false;
            }
            routeGridView.ClearSelection();
            int count = routeGridView.Rows.Count;
            if (count != 0)
            {
                if (count <= index && count != 0)
                    routeGridView.Rows[count - 1].Selected = true;
                else
                    routeGridView.Rows[index].Selected = true;
            }

        }

        private void addPlaceButton_Click(object sender, EventArgs e)
        {
            travel.AddLocation();
            deletePlaceButton.Enabled = true;
        }
    }
}
