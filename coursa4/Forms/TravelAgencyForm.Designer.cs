namespace coursa4
{
    partial class TravelAgencyForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TravelAgencyForm));
            this.travelAgencyGridView = new System.Windows.Forms.DataGridView();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayLengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.travelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelAgencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTravelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editTravelAgencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTravelAgencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterButton = new System.Windows.Forms.Button();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.travelAgencyGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelAgencyBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // travelAgencyGridView
            // 
            this.travelAgencyGridView.AllowUserToAddRows = false;
            this.travelAgencyGridView.AllowUserToDeleteRows = false;
            this.travelAgencyGridView.AllowUserToResizeRows = false;
            this.travelAgencyGridView.AutoGenerateColumns = false;
            this.travelAgencyGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.travelAgencyGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.travelAgencyGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.travelAgencyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.travelAgencyGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.pathDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.dayLengthDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.travelAgencyGridView.DataSource = this.travelsBindingSource;
            this.travelAgencyGridView.Location = new System.Drawing.Point(12, 105);
            this.travelAgencyGridView.Name = "travelAgencyGridView";
            this.travelAgencyGridView.ReadOnly = true;
            this.travelAgencyGridView.RowHeadersVisible = false;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.travelAgencyGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.travelAgencyGridView.RowTemplate.Height = 24;
            this.travelAgencyGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.travelAgencyGridView.Size = new System.Drawing.Size(1140, 490);
            this.travelAgencyGridView.TabIndex = 1;
            this.travelAgencyGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.travelAgencyGridView_CellMouseDoubleClick);
            this.travelAgencyGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.travelAgencyGridView_ColumnHeaderMouseClick);
            this.travelAgencyGridView.SelectionChanged += new System.EventHandler(this.travelAgencyGridView_SelectionChanged);
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 64;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Width = 69;
            // 
            // pathDataGridViewTextBoxColumn
            // 
            this.pathDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.pathDataGridViewTextBoxColumn.DataPropertyName = "Path";
            this.pathDataGridViewTextBoxColumn.HeaderText = "Path";
            this.pathDataGridViewTextBoxColumn.Name = "pathDataGridViewTextBoxColumn";
            this.pathDataGridViewTextBoxColumn.ReadOnly = true;
            this.pathDataGridViewTextBoxColumn.Width = 66;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dayLengthDataGridViewTextBoxColumn
            // 
            this.dayLengthDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dayLengthDataGridViewTextBoxColumn.DataPropertyName = "DayLength";
            this.dayLengthDataGridViewTextBoxColumn.HeaderText = "Days";
            this.dayLengthDataGridViewTextBoxColumn.Name = "dayLengthDataGridViewTextBoxColumn";
            this.dayLengthDataGridViewTextBoxColumn.ReadOnly = true;
            this.dayLengthDataGridViewTextBoxColumn.Width = 69;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost, $";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            this.costDataGridViewTextBoxColumn.Width = 81;
            // 
            // travelsBindingSource
            // 
            this.travelsBindingSource.DataMember = "Travels";
            this.travelsBindingSource.DataSource = this.travelAgencyBindingSource;
            // 
            // travelAgencyBindingSource
            // 
            this.travelAgencyBindingSource.DataSource = typeof(coursa4.TravelAgency);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1166, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agencyToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // agencyToolStripMenuItem
            // 
            this.agencyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTravelToolStripMenuItem,
            this.editTravelAgencyToolStripMenuItem,
            this.deleteTravelAgencyToolStripMenuItem});
            this.agencyToolStripMenuItem.Name = "agencyToolStripMenuItem";
            this.agencyToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.agencyToolStripMenuItem.Text = "Agency";
            // 
            // addTravelToolStripMenuItem
            // 
            this.addTravelToolStripMenuItem.Name = "addTravelToolStripMenuItem";
            this.addTravelToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.addTravelToolStripMenuItem.Text = "Add travel";
            this.addTravelToolStripMenuItem.Click += new System.EventHandler(this.addTravelToolStripMenuItem_Click);
            // 
            // editTravelAgencyToolStripMenuItem
            // 
            this.editTravelAgencyToolStripMenuItem.Name = "editTravelAgencyToolStripMenuItem";
            this.editTravelAgencyToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.editTravelAgencyToolStripMenuItem.Text = "Edit";
            this.editTravelAgencyToolStripMenuItem.Click += new System.EventHandler(this.editTravelAgencyToolStripMenuItem_Click);
            // 
            // deleteTravelAgencyToolStripMenuItem
            // 
            this.deleteTravelAgencyToolStripMenuItem.Name = "deleteTravelAgencyToolStripMenuItem";
            this.deleteTravelAgencyToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.deleteTravelAgencyToolStripMenuItem.Text = "Delete";
            this.deleteTravelAgencyToolStripMenuItem.Click += new System.EventHandler(this.deleteTravelAgencyToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.toolStripMenuItem2,
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
            this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // filterButton
            // 
            this.filterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.filterButton.Location = new System.Drawing.Point(423, 32);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(30, 30);
            this.filterButton.TabIndex = 7;
            this.filterButton.Text = "🔍";
            this.filterButton.UseVisualStyleBackColor = false;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // filterTextBox
            // 
            this.filterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.filterTextBox.Location = new System.Drawing.Point(3, 32);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(414, 30);
            this.filterTextBox.TabIndex = 6;
            this.filterTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.filterTextBox_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.filterButton);
            this.panel1.Controls.Add(this.filterTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 70);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Search throw travels";
            // 
            // TravelAgencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 601);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.travelAgencyGridView);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "TravelAgencyForm";
            this.Text = "TravelAgency";
            ((System.ComponentModel.ISupportInitialize)(this.travelAgencyGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelAgencyBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView travelAgencyGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.BindingSource travelsBindingSource;
        private System.Windows.Forms.BindingSource travelAgencyBindingSource;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agencyToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayLengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem addTravelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editTravelAgencyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTravelAgencyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}