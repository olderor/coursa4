namespace coursa4
{
    partial class TravelAgenciesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TravelAgenciesForm));
            this.travelAgenciesGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TravelsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.travelAgencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAgencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseAllTravelsButton = new System.Windows.Forms.Button();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.travelAgenciesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelAgencyBindingSource)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // travelAgenciesGridView
            // 
            this.travelAgenciesGridView.AllowUserToAddRows = false;
            this.travelAgenciesGridView.AllowUserToDeleteRows = false;
            this.travelAgenciesGridView.AllowUserToResizeRows = false;
            this.travelAgenciesGridView.AutoGenerateColumns = false;
            this.travelAgenciesGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.travelAgenciesGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.travelAgenciesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.travelAgenciesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.TravelsCount});
            this.travelAgenciesGridView.DataSource = this.travelAgencyBindingSource;
            this.travelAgenciesGridView.Location = new System.Drawing.Point(12, 107);
            this.travelAgenciesGridView.Name = "travelAgenciesGridView";
            this.travelAgenciesGridView.ReadOnly = true;
            this.travelAgenciesGridView.RowHeadersVisible = false;
            this.travelAgenciesGridView.RowTemplate.Height = 24;
            this.travelAgenciesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.travelAgenciesGridView.Size = new System.Drawing.Size(994, 440);
            this.travelAgenciesGridView.TabIndex = 0;
            this.travelAgenciesGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.travelAgenciesGridView_CellMouseDoubleClick);
            this.travelAgenciesGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.travelAgenciesGridView_ColumnHeaderMouseClick);
            this.travelAgenciesGridView.SelectionChanged += new System.EventHandler(this.travelAgenciesGridView_SelectionChanged);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 74;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TravelsCount
            // 
            this.TravelsCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TravelsCount.DataPropertyName = "TravelsCount";
            this.TravelsCount.HeaderText = "Travels Count";
            this.TravelsCount.Name = "TravelsCount";
            this.TravelsCount.ReadOnly = true;
            this.TravelsCount.Width = 115;
            // 
            // travelAgencyBindingSource
            // 
            this.travelAgencyBindingSource.DataSource = typeof(coursa4.TravelAgency);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1018, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAgencyToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // addAgencyToolStripMenuItem
            // 
            this.addAgencyToolStripMenuItem.Name = "addAgencyToolStripMenuItem";
            this.addAgencyToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.addAgencyToolStripMenuItem.Text = "Add Agency";
            this.addAgencyToolStripMenuItem.Click += new System.EventHandler(this.addAgencyToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.toolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.viewHelpToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // browseAllTravelsButton
            // 
            this.browseAllTravelsButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.browseAllTravelsButton.Location = new System.Drawing.Point(12, 553);
            this.browseAllTravelsButton.Name = "browseAllTravelsButton";
            this.browseAllTravelsButton.Size = new System.Drawing.Size(133, 35);
            this.browseAllTravelsButton.TabIndex = 3;
            this.browseAllTravelsButton.Text = "Browse all travels";
            this.browseAllTravelsButton.UseVisualStyleBackColor = false;
            this.browseAllTravelsButton.Click += new System.EventHandler(this.browseAllTravelsButton_Click);
            // 
            // filterTextBox
            // 
            this.filterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.filterTextBox.Location = new System.Drawing.Point(3, 32);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(423, 30);
            this.filterTextBox.TabIndex = 4;
            this.filterTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.filterTextBox_KeyDown);
            // 
            // filterButton
            // 
            this.filterButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.filterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.filterButton.Location = new System.Drawing.Point(432, 32);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(30, 30);
            this.filterButton.TabIndex = 5;
            this.filterButton.Text = "🔍";
            this.filterButton.UseVisualStyleBackColor = false;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.filterButton);
            this.panel1.Controls.Add(this.filterTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 70);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(2, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search throw agency";
            // 
            // TravelAgenciesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1018, 594);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.browseAllTravelsButton);
            this.Controls.Add(this.travelAgenciesGridView);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "TravelAgenciesForm";
            this.Text = "coursa4";
            ((System.ComponentModel.ISupportInitialize)(this.travelAgenciesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelAgencyBindingSource)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView travelAgenciesGridView;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button browseAllTravelsButton;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn tripsCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource travelAgencyBindingSource;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelsCount;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAgencyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}