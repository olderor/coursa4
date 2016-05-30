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
            this.infoLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.placeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.costNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // travelTypeComboBox
            // 
            this.travelTypeComboBox.DisplayMember = "Type";
            this.travelTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.travelTypeComboBox.FormattingEnabled = true;
            this.travelTypeComboBox.Location = new System.Drawing.Point(111, 198);
            this.travelTypeComboBox.Name = "travelTypeComboBox";
            this.travelTypeComboBox.Size = new System.Drawing.Size(139, 28);
            this.travelTypeComboBox.TabIndex = 0;
            this.travelTypeComboBox.ValueMember = "Type";
            this.travelTypeComboBox.SelectionChangeCommitted += new System.EventHandler(this.travelTypeComboBox_SelectionChangeCommitted);
            // 
            // activenessComboBox
            // 
            this.activenessComboBox.DisplayMember = "Type";
            this.activenessComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activenessComboBox.FormattingEnabled = true;
            this.activenessComboBox.Location = new System.Drawing.Point(111, 233);
            this.activenessComboBox.Name = "activenessComboBox";
            this.activenessComboBox.Size = new System.Drawing.Size(139, 28);
            this.activenessComboBox.TabIndex = 1;
            this.activenessComboBox.ValueMember = "Type";
            this.activenessComboBox.SelectionChangeCommitted += new System.EventHandler(this.activenessComboBox_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label1.Location = new System.Drawing.Point(3, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.Location = new System.Drawing.Point(3, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Activeness";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label3.Location = new System.Drawing.Point(3, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Transport";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label4.Location = new System.Drawing.Point(3, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Inclusion";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(111, 28);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(380, 27);
            this.titleTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label5.Location = new System.Drawing.Point(3, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Title";
            // 
            // transportCheckedListBox
            // 
            this.transportCheckedListBox.CheckOnClick = true;
            this.transportCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transportCheckedListBox.FormattingEnabled = true;
            this.transportCheckedListBox.Location = new System.Drawing.Point(111, 268);
            this.transportCheckedListBox.Name = "transportCheckedListBox";
            this.transportCheckedListBox.Size = new System.Drawing.Size(139, 136);
            this.transportCheckedListBox.TabIndex = 10;
            this.transportCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.transportCheckedListBox_ItemCheck);
            // 
            // inclusionCheckedListBox
            // 
            this.inclusionCheckedListBox.CheckOnClick = true;
            this.inclusionCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inclusionCheckedListBox.FormattingEnabled = true;
            this.inclusionCheckedListBox.Location = new System.Drawing.Point(111, 416);
            this.inclusionCheckedListBox.Name = "inclusionCheckedListBox";
            this.inclusionCheckedListBox.Size = new System.Drawing.Size(139, 136);
            this.inclusionCheckedListBox.TabIndex = 11;
            this.inclusionCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.inclusionCheckedListBox_ItemCheck);
            // 
            // costNumericUpDown
            // 
            this.costNumericUpDown.DecimalPlaces = 2;
            this.costNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costNumericUpDown.Location = new System.Drawing.Point(112, 564);
            this.costNumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.costNumericUpDown.Name = "costNumericUpDown";
            this.costNumericUpDown.Size = new System.Drawing.Size(138, 27);
            this.costNumericUpDown.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label6.Location = new System.Drawing.Point(3, 564);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cost, $";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label7.Location = new System.Drawing.Point(3, 598);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Days";
            // 
            // daysNumericUpDown
            // 
            this.daysNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysNumericUpDown.Location = new System.Drawing.Point(112, 596);
            this.daysNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.daysNumericUpDown.Name = "daysNumericUpDown";
            this.daysNumericUpDown.Size = new System.Drawing.Size(138, 27);
            this.daysNumericUpDown.TabIndex = 14;
            this.daysNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionTextBox.Location = new System.Drawing.Point(110, 62);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(381, 130);
            this.descriptionTextBox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label8.Location = new System.Drawing.Point(3, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Description";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(318, 932);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(93, 33);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(219, 932);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(93, 33);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(417, 932);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(93, 33);
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
            this.routeGridView.BackgroundColor = System.Drawing.SystemColors.Control;
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
            this.routeGridView.Location = new System.Drawing.Point(108, 632);
            this.routeGridView.Name = "routeGridView";
            this.routeGridView.RowHeadersVisible = false;
            this.routeGridView.RowTemplate.Height = 24;
            this.routeGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.routeGridView.Size = new System.Drawing.Size(382, 236);
            this.routeGridView.TabIndex = 21;
            // 
            // deletePlaceButton
            // 
            this.deletePlaceButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.deletePlaceButton.Enabled = false;
            this.deletePlaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deletePlaceButton.Location = new System.Drawing.Point(361, 874);
            this.deletePlaceButton.Name = "deletePlaceButton";
            this.deletePlaceButton.Size = new System.Drawing.Size(128, 33);
            this.deletePlaceButton.TabIndex = 22;
            this.deletePlaceButton.Text = "Delete Place";
            this.deletePlaceButton.UseVisualStyleBackColor = false;
            this.deletePlaceButton.Click += new System.EventHandler(this.deletePlaceButton_Click);
            // 
            // addPlaceButton
            // 
            this.addPlaceButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.addPlaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPlaceButton.Location = new System.Drawing.Point(227, 874);
            this.addPlaceButton.Name = "addPlaceButton";
            this.addPlaceButton.Size = new System.Drawing.Size(128, 33);
            this.addPlaceButton.TabIndex = 23;
            this.addPlaceButton.Text = "Add Place";
            this.addPlaceButton.UseVisualStyleBackColor = false;
            this.addPlaceButton.Click += new System.EventHandler(this.addPlaceButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.infoLabel.Location = new System.Drawing.Point(108, 2);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(36, 20);
            this.infoLabel.TabIndex = 24;
            this.infoLabel.Text = "Info";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.addPlaceButton);
            this.panel1.Controls.Add(this.deletePlaceButton);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.infoLabel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.titleTextBox);
            this.panel1.Controls.Add(this.routeGridView);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.transportCheckedListBox);
            this.panel1.Controls.Add(this.descriptionTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.inclusionCheckedListBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.travelTypeComboBox);
            this.panel1.Controls.Add(this.daysNumericUpDown);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.activenessComboBox);
            this.panel1.Controls.Add(this.costNumericUpDown);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 914);
            this.panel1.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label9.Location = new System.Drawing.Point(3, 632);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Route";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label10.Location = new System.Drawing.Point(3, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Travel by";
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
            // AboutTravelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(518, 969);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutTravelForm";
            this.Text = "Add Travel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AboutTravelForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.costNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}