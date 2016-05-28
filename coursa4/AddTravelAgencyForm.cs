﻿using System;
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
    public partial class AddTravelAgencyForm : Form
    {
        private TravelAgency travelAgency;
        private bool saved = false;

        public AddTravelAgencyForm()
        {
            InitializeComponent();

            travelAgency = new TravelAgency();
            nameTextBox.DataBindings.Add(new Binding("Text", travelAgency, "Name"));
            addressTextBox.DataBindings.Add(new Binding("Text", travelAgency, "Address"));
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Проверка на пустые поля.
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Please, enter name of travel agency.", "Warning", MessageBoxButtons.OK);
                return;
            }

            if (addressTextBox.Text == "")
            {
                MessageBox.Show("Please, enter address of travel agency.", "Warning", MessageBoxButtons.OK);
                return;
            }


            TravelAgencyCollection tac = TravelAgencyCollection.GetDefaultInstance();
            tac.Add(travelAgency);
            tac.Save();
            saved = true;
            this.Close();
        }

        private void AddTravelAgencyForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
