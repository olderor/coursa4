namespace coursa4
{
    partial class AboutTravelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutTravelForm));
            this.travelTypeComboBox = new System.Windows.Forms.ComboBox();
            this.activenessComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.transportCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.inclusionCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.costNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.daysNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.routeGridView = new System.Windows.Forms.DataGridView();
            this.deletePlaceButton = new System.Windows.Forms.Button();
            this.addPlaceButton = new System.Windows.Forms.Button();
            this.placeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.costNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // travelTypeComboBox
            // 
            this.travelTypeComboBox.DisplayMember = "Type";
            this.travelTypeComboBox.Font = new System.Drawing.Font("Goudy Old Style", 10F);
            this.travelTypeComboBox.FormattingEnabled = true;
            this.travelTypeComboBox.Location = new System.Drawing.Point(328, 148);
            this.travelTypeComboBox.Name = "travelTypeComboBox";
            this.travelTypeComboBox.Size = new System.Drawing.Size(121, 29);
            this.travelTypeComboBox.TabIndex = 0;
            this.travelTypeComboBox.ValueMember = "Type";
            this.travelTypeComboBox.SelectionChangeCommitted += new System.EventHandler(this.travelTypeComboBox_SelectionChangeCommitted);
            // 
            // activenessComboBox
            // 
            this.activenessComboBox.DisplayMember = "Type";
            this.activenessComboBox.Font = new System.Drawing.Font("Goudy Old Style", 10F);
            this.activenessComboBox.FormattingEnabled = true;
            this.activenessComboBox.Location = new System.Drawing.Point(328, 224);
            this.activenessComboBox.Name = "activenessComboBox";
            this.activenessComboBox.Size = new System.Drawing.Size(121, 29);
            this.activenessComboBox.TabIndex = 1;
            this.activenessComboBox.ValueMember = "Type";
            this.activenessComboBox.SelectionChangeCommitted += new System.EventHandler(this.activenessComboBox_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 12F);
            this.label1.Location = new System.Drawing.Point(366, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Goudy Old Style", 12F);
            this.label2.Location = new System.Drawing.Point(347, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Activeness";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Goudy Old Style", 12F);
            this.label3.Location = new System.Drawing.Point(50, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Transport";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Goudy Old Style", 12F);
            this.label4.Location = new System.Drawing.Point(205, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Inclusion";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Goudy Old Style", 10F);
            this.titleTextBox.Location = new System.Drawing.Point(23, 80);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(426, 28);
            this.titleTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Goudy Old Style", 12F);
            this.label5.Location = new System.Drawing.Point(193, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Title";
            // 
            // transportCheckedListBox
            // 
            this.transportCheckedListBox.CheckOnClick = true;
            this.transportCheckedListBox.Font = new System.Drawing.Font("Goudy Old Style", 10F);
            this.transportCheckedListBox.FormattingEnabled = true;
            this.transportCheckedListBox.Location = new System.Drawing.Point(23, 148);
            this.transportCheckedListBox.Name = "transportCheckedListBox";
            this.transportCheckedListBox.Size = new System.Drawing.Size(137, 142);
            this.transportCheckedListBox.TabIndex = 10;
            this.transportCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.transportCheckedListBox_ItemCheck);
            // 
            // inclusionCheckedListBox
            // 
            this.inclusionCheckedListBox.CheckOnClick = true;
            this.inclusionCheckedListBox.Font = new System.Drawing.Font("Goudy Old Style", 10F);
            this.inclusionCheckedListBox.FormattingEnabled = true;
            this.inclusionCheckedListBox.Location = new System.Drawing.Point(178, 148);
            this.inclusionCheckedListBox.Name = "inclusionCheckedListBox";
            this.inclusionCheckedListBox.Size = new System.Drawing.Size(136, 142);
            this.inclusionCheckedListBox.TabIndex = 11;
            this.inclusionCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.inclusionCheckedListBox_ItemCheck);
            // 
            // costNumericUpDown
            // 
            this.costNumericUpDown.DecimalPlaces = 2;
            this.costNumericUpDown.Font = new System.Drawing.Font("Goudy Old Style", 10F);
            this.costNumericUpDown.Location = new System.Drawing.Point(23, 329);
            this.costNumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.costNumericUpDown.Name = "costNumericUpDown";
            this.costNumericUpDown.Size = new System.Drawing.Size(137, 28);
            this.costNumericUpDown.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Goudy Old Style", 12F);
            this.label6.Location = new System.Drawing.Point(50, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cost, $";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Goudy Old Style", 12F);
            this.label7.Location = new System.Drawing.Point(221, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Days";
            // 
            // daysNumericUpDown
            // 
            this.daysNumericUpDown.Font = new System.Drawing.Font("Goudy Old Style", 10F);
            this.daysNumericUpDown.Location = new System.Drawing.Point(178, 329);
            this.daysNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.daysNumericUpDown.Name = "daysNumericUpDown";
            this.daysNumericUpDown.Size = new System.Drawing.Size(136, 28);
            this.daysNumericUpDown.TabIndex = 14;
            this.daysNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Goudy Old Style", 10F);
            this.descriptionTextBox.Location = new System.Drawing.Point(477, 80);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(344, 236);
            this.descriptionTextBox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Goudy Old Style", 12F);
            this.label8.Location = new System.Drawing.Point(599, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Description";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.SkyBlue;
            this.cancelButton.Font = new System.Drawing.Font("Goudy Old Style", 12F);
            this.cancelButton.Location = new System.Drawing.Point(418, 404);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(115, 33);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.LightGreen;
            this.saveButton.Font = new System.Drawing.Font("Goudy Old Style", 12F);
            this.saveButton.Location = new System.Drawing.Point(637, 404);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(115, 33);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.LightSalmon;
            this.deleteButton.Font = new System.Drawing.Font("Goudy Old Style", 12F);
            this.deleteButton.Location = new System.Drawing.Point(12, 404);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(115, 33);
            this.deleteButton.TabIndex = 20;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // routeGridView
            // 
            this.routeGridView.AllowUserToAddRows = false;
            this.routeGridView.AllowUserToDeleteRows = false;
            this.routeGridView.AllowUserToResizeColumns = false;
            this.routeGridView.AllowUserToResizeRows = false;
            this.routeGridView.AutoGenerateColumns = false;
            this.routeGridView.BackgroundColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.routeGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.routeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.routeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.placeDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn});
            this.routeGridView.DataSource = this.locationBindingSource;
            this.routeGridView.Location = new System.Drawing.Point(847, 74);
            this.routeGridView.Name = "routeGridView";
            this.routeGridView.RowHeadersVisible = false;
            this.routeGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Goudy Old Style", 10F);
            this.routeGridView.RowTemplate.Height = 24;
            this.routeGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.routeGridView.Size = new System.Drawing.Size(287, 236);
            this.routeGridView.TabIndex = 21;
            // 
            // deletePlaceButton
            // 
            this.deletePlaceButton.BackColor = System.Drawing.Color.LightSalmon;
            this.deletePlaceButton.Enabled = false;
            this.deletePlaceButton.Font = new System.Drawing.Font("Goudy Old Style", 12F);
            this.deletePlaceButton.Location = new System.Drawing.Point(887, 316);
            this.deletePlaceButton.Name = "deletePlaceButton";
            this.deletePlaceButton.Size = new System.Drawing.Size(90, 55);
            this.deletePlaceButton.TabIndex = 22;
            this.deletePlaceButton.Text = "Delete Place";
            this.deletePlaceButton.UseVisualStyleBackColor = false;
            this.deletePlaceButton.Click += new System.EventHandler(this.deletePlaceButton_Click);
            // 
            // addPlaceButton
            // 
            this.addPlaceButton.BackColor = System.Drawing.Color.LightGreen;
            this.addPlaceButton.Font = new System.Drawing.Font("Goudy Old Style", 12F);
            this.addPlaceButton.Location = new System.Drawing.Point(1010, 316);
            this.addPlaceButton.Name = "addPlaceButton";
            this.addPlaceButton.Size = new System.Drawing.Size(90, 55);
            this.addPlaceButton.TabIndex = 23;
            this.addPlaceButton.Text = "Add Place";
            this.addPlaceButton.UseVisualStyleBackColor = false;
            this.addPlaceButton.Click += new System.EventHandler(this.addPlaceButton_Click);
            // 
            // placeDataGridViewTextBoxColumn
            // 
            this.placeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.placeDataGridViewTextBoxColumn.DataPropertyName = "Place";
            this.placeDataGridViewTextBoxColumn.HeaderText = "Place";
            this.placeDataGridViewTextBoxColumn.Name = "placeDataGridViewTextBoxColumn";
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataSource = typeof(coursa4.Location);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Goudy Old Style", 12F);
            this.infoLabel.Location = new System.Drawing.Point(12, 9);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(44, 23);
            this.infoLabel.TabIndex = 24;
            this.infoLabel.Text = "Info";
            // 
            // AboutTravelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(1162, 445);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.addPlaceButton);
            this.Controls.Add(this.deletePlaceButton);
            this.Controls.Add(this.routeGridView);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.daysNumericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.costNumericUpDown);
            this.Controls.Add(this.inclusionCheckedListBox);
            this.Controls.Add(this.transportCheckedListBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.activenessComboBox);
            this.Controls.Add(this.travelTypeComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutTravelForm";
            this.Text = "Add Travel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AboutTravelForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.costNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox travelTypeComboBox;
        private System.Windows.Forms.ComboBox activenessComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox transportCheckedListBox;
        private System.Windows.Forms.CheckedListBox inclusionCheckedListBox;
        private System.Windows.Forms.NumericUpDown costNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown daysNumericUpDown;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView routeGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private System.Windows.Forms.Button deletePlaceButton;
        private System.Windows.Forms.Button addPlaceButton;
        private System.Windows.Forms.Label infoLabel;
    }
}