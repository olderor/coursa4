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
            ((System.ComponentModel.ISupportInitialize)(this.costNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // travelTypeComboBox
            // 
            this.travelTypeComboBox.DisplayMember = "Type";
            this.travelTypeComboBox.FormattingEnabled = true;
            this.travelTypeComboBox.Location = new System.Drawing.Point(308, 110);
            this.travelTypeComboBox.Name = "travelTypeComboBox";
            this.travelTypeComboBox.Size = new System.Drawing.Size(121, 24);
            this.travelTypeComboBox.TabIndex = 0;
            this.travelTypeComboBox.ValueMember = "Type";
            this.travelTypeComboBox.SelectionChangeCommitted += new System.EventHandler(this.travelTypeComboBox_SelectionChangeCommitted);
            // 
            // activenessComboBox
            // 
            this.activenessComboBox.DisplayMember = "Type";
            this.activenessComboBox.FormattingEnabled = true;
            this.activenessComboBox.Location = new System.Drawing.Point(308, 172);
            this.activenessComboBox.Name = "activenessComboBox";
            this.activenessComboBox.Size = new System.Drawing.Size(121, 24);
            this.activenessComboBox.TabIndex = 1;
            this.activenessComboBox.ValueMember = "Type";
            this.activenessComboBox.SelectionChangeCommitted += new System.EventHandler(this.activenessComboBox_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Activeness";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Transport";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Inclusion";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(23, 36);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(406, 22);
            this.titleTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Title";
            // 
            // transportCheckedListBox
            // 
            this.transportCheckedListBox.CheckOnClick = true;
            this.transportCheckedListBox.FormattingEnabled = true;
            this.transportCheckedListBox.Location = new System.Drawing.Point(23, 90);
            this.transportCheckedListBox.Name = "transportCheckedListBox";
            this.transportCheckedListBox.Size = new System.Drawing.Size(120, 123);
            this.transportCheckedListBox.TabIndex = 10;
            this.transportCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.transportCheckedListBox_ItemCheck);
            // 
            // inclusionCheckedListBox
            // 
            this.inclusionCheckedListBox.CheckOnClick = true;
            this.inclusionCheckedListBox.FormattingEnabled = true;
            this.inclusionCheckedListBox.Location = new System.Drawing.Point(149, 90);
            this.inclusionCheckedListBox.Name = "inclusionCheckedListBox";
            this.inclusionCheckedListBox.Size = new System.Drawing.Size(120, 123);
            this.inclusionCheckedListBox.TabIndex = 11;
            this.inclusionCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.inclusionCheckedListBox_ItemCheck);
            // 
            // costNumericUpDown
            // 
            this.costNumericUpDown.DecimalPlaces = 2;
            this.costNumericUpDown.Location = new System.Drawing.Point(23, 250);
            this.costNumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.costNumericUpDown.Name = "costNumericUpDown";
            this.costNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.costNumericUpDown.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cost";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(188, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Days";
            // 
            // daysNumericUpDown
            // 
            this.daysNumericUpDown.Location = new System.Drawing.Point(149, 250);
            this.daysNumericUpDown.Name = "daysNumericUpDown";
            this.daysNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.daysNumericUpDown.TabIndex = 14;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(475, 36);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(344, 236);
            this.descriptionTextBox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(613, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Description";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(262, 316);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(115, 33);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(465, 316);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(115, 33);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(12, 316);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(115, 33);
            this.deleteButton.TabIndex = 20;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // AboutTravelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 361);
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
            this.Name = "AboutTravelForm";
            this.Text = "Add Travel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AboutTravelForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.costNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daysNumericUpDown)).EndInit();
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
    }
}