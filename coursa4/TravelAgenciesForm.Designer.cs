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
            this.travelAgenciesGridView = new System.Windows.Forms.DataGridView();
            this.ToursCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAgencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.browseAllToursButton = new System.Windows.Forms.Button();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.filterButton = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.travelAgencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.travelAgenciesGridView)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.travelAgencyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // travelAgenciesGridView
            // 
            this.travelAgenciesGridView.AllowUserToAddRows = false;
            this.travelAgenciesGridView.AllowUserToDeleteRows = false;
            this.travelAgenciesGridView.AllowUserToResizeRows = false;
            this.travelAgenciesGridView.AutoGenerateColumns = false;
            this.travelAgenciesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.travelAgenciesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.ToursCount});
            this.travelAgenciesGridView.DataSource = this.travelAgencyBindingSource;
            this.travelAgenciesGridView.Location = new System.Drawing.Point(12, 102);
            this.travelAgenciesGridView.Name = "travelAgenciesGridView";
            this.travelAgenciesGridView.ReadOnly = true;
            this.travelAgenciesGridView.RowHeadersVisible = false;
            this.travelAgenciesGridView.RowTemplate.Height = 24;
            this.travelAgenciesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.travelAgenciesGridView.Size = new System.Drawing.Size(994, 519);
            this.travelAgenciesGridView.TabIndex = 0;
            this.travelAgenciesGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.travelAgenciesGridView_CellMouseDoubleClick);
            this.travelAgenciesGridView.SelectionChanged += new System.EventHandler(this.travelAgenciesGridView_SelectionChanged);
            // 
            // ToursCount
            // 
            this.ToursCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ToursCount.DataPropertyName = "ToursCount";
            this.ToursCount.HeaderText = "Tours Count";
            this.ToursCount.Name = "ToursCount";
            this.ToursCount.ReadOnly = true;
            this.ToursCount.Width = 115;
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
            this.addAgencyToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addAgencyToolStripMenuItem
            // 
            this.addAgencyToolStripMenuItem.Name = "addAgencyToolStripMenuItem";
            this.addAgencyToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.addAgencyToolStripMenuItem.Text = "Add agency";
            this.addAgencyToolStripMenuItem.Click += new System.EventHandler(this.addAgencyToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose travel agency to browse their tours or";
            // 
            // browseAllToursButton
            // 
            this.browseAllToursButton.Location = new System.Drawing.Point(574, 32);
            this.browseAllToursButton.Name = "browseAllToursButton";
            this.browseAllToursButton.Size = new System.Drawing.Size(135, 23);
            this.browseAllToursButton.TabIndex = 3;
            this.browseAllToursButton.Text = "browse all tours";
            this.browseAllToursButton.UseVisualStyleBackColor = true;
            this.browseAllToursButton.Click += new System.EventHandler(this.browseAllToursButton_Click);
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(276, 74);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(365, 22);
            this.filterTextBox.TabIndex = 4;
            this.filterTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.filterTextBox_KeyDown);
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(648, 74);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(75, 23);
            this.filterButton.TabIndex = 5;
            this.filterButton.Text = "filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
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
            // travelAgencyBindingSource
            // 
            this.travelAgencyBindingSource.DataSource = typeof(coursa4.TravelAgency);
            // 
            // TravelAgenciesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 633);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.filterTextBox);
            this.Controls.Add(this.browseAllToursButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.travelAgenciesGridView);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "TravelAgenciesForm";
            this.Text = "coursa4";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TravelAgenciesForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.travelAgenciesGridView)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.travelAgencyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView travelAgenciesGridView;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browseAllToursButton;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn tripsCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource travelAgencyBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToursCount;
        private System.Windows.Forms.ToolStripMenuItem addAgencyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}