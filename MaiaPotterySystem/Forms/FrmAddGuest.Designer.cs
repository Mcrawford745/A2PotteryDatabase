namespace PotteryDBA_V1._0.Forms
{
    partial class FrmAddGuest
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddGuest));
            this.dgvGuestsOut = new System.Windows.Forms.DataGridView();
            this.guestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homeAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guestDataSetForHalfTermTask = new PotteryDBA_V1._0.DataSets.GuestDataSetForHalfTermTask();
            this.guestTableAdapter = new PotteryDBA_V1._0.DataSets.GuestDataSetForHalfTermTaskTableAdapters.GuestTableAdapter();
            this.lblAddGuestDetails = new System.Windows.Forms.Label();
            this.lblForenameAddUpdate = new System.Windows.Forms.Label();
            this.txtForenameAddUpdate = new System.Windows.Forms.TextBox();
            this.txtSurnameAddUpdate = new System.Windows.Forms.TextBox();
            this.lblSurnameAddUpdate = new System.Windows.Forms.Label();
            this.txtContactNoAddUpdate = new System.Windows.Forms.TextBox();
            this.lblContactNoAddUpdate = new System.Windows.Forms.Label();
            this.txtAddressLine1AddUpdate = new System.Windows.Forms.TextBox();
            this.lblAddressLine1AddUpdate = new System.Windows.Forms.Label();
            this.txtAddressLine2AddUpdate = new System.Windows.Forms.TextBox();
            this.lblAddressLine2AddUpdate = new System.Windows.Forms.Label();
            this.txtAddressLine3AddUpdate = new System.Windows.Forms.TextBox();
            this.lblAddressLine3AddUpdate = new System.Windows.Forms.Label();
            this.lblSkillLevelAddUpdate = new System.Windows.Forms.Label();
            this.lblDialCodeAddUpdate = new System.Windows.Forms.Label();
            this.GuestMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortBySkillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByCityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logEquipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseMaagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeABookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getCourseReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exhibitionManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artworkManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddGuest = new System.Windows.Forms.Button();
            this.lblNoOfRecords = new System.Windows.Forms.Label();
            this.cbxSkillLevelAddUpdate = new System.Windows.Forms.ComboBox();
            this.btnUpdateGuest = new System.Windows.Forms.Button();
            this.btnCancelUpdate = new System.Windows.Forms.Button();
            this.btnEnterUpdate = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblNoResults = new System.Windows.Forms.Label();
            this.txtGuestIDsearch = new System.Windows.Forms.TextBox();
            this.txtForenamesearch = new System.Windows.Forms.TextBox();
            this.txtSurnamesearch = new System.Windows.Forms.TextBox();
            this.cbxSearchBy = new System.Windows.Forms.ComboBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.btnDeleteMode = new System.Windows.Forms.Button();
            this.btnDeleteGuest = new System.Windows.Forms.Button();
            this.txtGuestIDDelete = new System.Windows.Forms.TextBox();
            this.lblGuestIDDelete = new System.Windows.Forms.Label();
            this.lblexistingbooking = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestsOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestDataSetForHalfTermTask)).BeginInit();
            this.GuestMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGuestsOut
            // 
            this.dgvGuestsOut.AllowUserToAddRows = false;
            this.dgvGuestsOut.AllowUserToDeleteRows = false;
            this.dgvGuestsOut.AllowUserToResizeColumns = false;
            this.dgvGuestsOut.AllowUserToResizeRows = false;
            this.dgvGuestsOut.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGuestsOut.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGuestsOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuestsOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.guestIDDataGridViewTextBoxColumn,
            this.forenameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.contactNoDataGridViewTextBoxColumn,
            this.homeAddressDataGridViewTextBoxColumn,
            this.skillLevelDataGridViewTextBoxColumn});
            this.dgvGuestsOut.DataSource = this.guestBindingSource;
            this.dgvGuestsOut.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvGuestsOut.EnableHeadersVisualStyles = false;
            this.dgvGuestsOut.GridColor = System.Drawing.Color.Black;
            this.dgvGuestsOut.Location = new System.Drawing.Point(17, 51);
            this.dgvGuestsOut.MultiSelect = false;
            this.dgvGuestsOut.Name = "dgvGuestsOut";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGuestsOut.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvGuestsOut.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGuestsOut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGuestsOut.Size = new System.Drawing.Size(696, 427);
            this.dgvGuestsOut.TabIndex = 0;
            this.dgvGuestsOut.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGuestsOut_CellContentClick);
            this.dgvGuestsOut.SelectionChanged += new System.EventHandler(this.dgvGuestsOut_SelectionChanged);
            // 
            // guestIDDataGridViewTextBoxColumn
            // 
            this.guestIDDataGridViewTextBoxColumn.DataPropertyName = "GuestID";
            this.guestIDDataGridViewTextBoxColumn.HeaderText = "Guest ID";
            this.guestIDDataGridViewTextBoxColumn.Name = "guestIDDataGridViewTextBoxColumn";
            this.guestIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.guestIDDataGridViewTextBoxColumn.Width = 58;
            // 
            // forenameDataGridViewTextBoxColumn
            // 
            this.forenameDataGridViewTextBoxColumn.DataPropertyName = "Forename";
            this.forenameDataGridViewTextBoxColumn.HeaderText = "Forename";
            this.forenameDataGridViewTextBoxColumn.Name = "forenameDataGridViewTextBoxColumn";
            this.forenameDataGridViewTextBoxColumn.Width = 75;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.Width = 85;
            // 
            // contactNoDataGridViewTextBoxColumn
            // 
            this.contactNoDataGridViewTextBoxColumn.DataPropertyName = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.HeaderText = "Contact No";
            this.contactNoDataGridViewTextBoxColumn.Name = "contactNoDataGridViewTextBoxColumn";
            this.contactNoDataGridViewTextBoxColumn.Width = 95;
            // 
            // homeAddressDataGridViewTextBoxColumn
            // 
            this.homeAddressDataGridViewTextBoxColumn.DataPropertyName = "HomeAddress";
            this.homeAddressDataGridViewTextBoxColumn.HeaderText = "Home Address";
            this.homeAddressDataGridViewTextBoxColumn.Name = "homeAddressDataGridViewTextBoxColumn";
            this.homeAddressDataGridViewTextBoxColumn.Width = 240;
            // 
            // skillLevelDataGridViewTextBoxColumn
            // 
            this.skillLevelDataGridViewTextBoxColumn.DataPropertyName = "SkillLevel";
            this.skillLevelDataGridViewTextBoxColumn.HeaderText = "Skill Level";
            this.skillLevelDataGridViewTextBoxColumn.Name = "skillLevelDataGridViewTextBoxColumn";
            this.skillLevelDataGridViewTextBoxColumn.Width = 80;
            // 
            // guestBindingSource
            // 
            this.guestBindingSource.DataMember = "Guest";
            this.guestBindingSource.DataSource = this.guestDataSetForHalfTermTask;
            // 
            // guestDataSetForHalfTermTask
            // 
            this.guestDataSetForHalfTermTask.DataSetName = "GuestDataSetForHalfTermTask";
            this.guestDataSetForHalfTermTask.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guestTableAdapter
            // 
            this.guestTableAdapter.ClearBeforeFill = true;
            // 
            // lblAddGuestDetails
            // 
            this.lblAddGuestDetails.AutoSize = true;
            this.lblAddGuestDetails.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddGuestDetails.ForeColor = System.Drawing.Color.Black;
            this.lblAddGuestDetails.Location = new System.Drawing.Point(756, 23);
            this.lblAddGuestDetails.Name = "lblAddGuestDetails";
            this.lblAddGuestDetails.Size = new System.Drawing.Size(145, 27);
            this.lblAddGuestDetails.TabIndex = 1;
            this.lblAddGuestDetails.Text = "Guest Details";
            // 
            // lblForenameAddUpdate
            // 
            this.lblForenameAddUpdate.AutoSize = true;
            this.lblForenameAddUpdate.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForenameAddUpdate.ForeColor = System.Drawing.Color.Black;
            this.lblForenameAddUpdate.Location = new System.Drawing.Point(724, 61);
            this.lblForenameAddUpdate.Name = "lblForenameAddUpdate";
            this.lblForenameAddUpdate.Size = new System.Drawing.Size(62, 16);
            this.lblForenameAddUpdate.TabIndex = 2;
            this.lblForenameAddUpdate.Text = "Forename";
            // 
            // txtForenameAddUpdate
            // 
            this.txtForenameAddUpdate.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtForenameAddUpdate.ForeColor = System.Drawing.Color.Black;
            this.txtForenameAddUpdate.Location = new System.Drawing.Point(727, 80);
            this.txtForenameAddUpdate.Name = "txtForenameAddUpdate";
            this.txtForenameAddUpdate.Size = new System.Drawing.Size(200, 20);
            this.txtForenameAddUpdate.TabIndex = 3;
            // 
            // txtSurnameAddUpdate
            // 
            this.txtSurnameAddUpdate.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSurnameAddUpdate.ForeColor = System.Drawing.Color.Black;
            this.txtSurnameAddUpdate.Location = new System.Drawing.Point(727, 121);
            this.txtSurnameAddUpdate.Name = "txtSurnameAddUpdate";
            this.txtSurnameAddUpdate.Size = new System.Drawing.Size(200, 20);
            this.txtSurnameAddUpdate.TabIndex = 5;
            // 
            // lblSurnameAddUpdate
            // 
            this.lblSurnameAddUpdate.AutoSize = true;
            this.lblSurnameAddUpdate.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurnameAddUpdate.ForeColor = System.Drawing.Color.Black;
            this.lblSurnameAddUpdate.Location = new System.Drawing.Point(724, 102);
            this.lblSurnameAddUpdate.Name = "lblSurnameAddUpdate";
            this.lblSurnameAddUpdate.Size = new System.Drawing.Size(57, 16);
            this.lblSurnameAddUpdate.TabIndex = 4;
            this.lblSurnameAddUpdate.Text = "Surname";
            // 
            // txtContactNoAddUpdate
            // 
            this.txtContactNoAddUpdate.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtContactNoAddUpdate.ForeColor = System.Drawing.Color.Black;
            this.txtContactNoAddUpdate.Location = new System.Drawing.Point(727, 162);
            this.txtContactNoAddUpdate.Name = "txtContactNoAddUpdate";
            this.txtContactNoAddUpdate.Size = new System.Drawing.Size(200, 20);
            this.txtContactNoAddUpdate.TabIndex = 7;
            this.txtContactNoAddUpdate.TextChanged += new System.EventHandler(this.txtContactNo_TextChanged);
            // 
            // lblContactNoAddUpdate
            // 
            this.lblContactNoAddUpdate.AutoSize = true;
            this.lblContactNoAddUpdate.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNoAddUpdate.ForeColor = System.Drawing.Color.Black;
            this.lblContactNoAddUpdate.Location = new System.Drawing.Point(724, 143);
            this.lblContactNoAddUpdate.Name = "lblContactNoAddUpdate";
            this.lblContactNoAddUpdate.Size = new System.Drawing.Size(97, 16);
            this.lblContactNoAddUpdate.TabIndex = 6;
            this.lblContactNoAddUpdate.Text = "Contact Number";
            this.lblContactNoAddUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAddressLine1AddUpdate
            // 
            this.txtAddressLine1AddUpdate.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtAddressLine1AddUpdate.ForeColor = System.Drawing.Color.Black;
            this.txtAddressLine1AddUpdate.Location = new System.Drawing.Point(727, 204);
            this.txtAddressLine1AddUpdate.Name = "txtAddressLine1AddUpdate";
            this.txtAddressLine1AddUpdate.Size = new System.Drawing.Size(200, 20);
            this.txtAddressLine1AddUpdate.TabIndex = 9;
            this.txtAddressLine1AddUpdate.TextChanged += new System.EventHandler(this.txtAddressLine1AddUpdate_TextChanged);
            // 
            // lblAddressLine1AddUpdate
            // 
            this.lblAddressLine1AddUpdate.AutoSize = true;
            this.lblAddressLine1AddUpdate.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressLine1AddUpdate.ForeColor = System.Drawing.Color.Black;
            this.lblAddressLine1AddUpdate.Location = new System.Drawing.Point(724, 185);
            this.lblAddressLine1AddUpdate.Name = "lblAddressLine1AddUpdate";
            this.lblAddressLine1AddUpdate.Size = new System.Drawing.Size(52, 16);
            this.lblAddressLine1AddUpdate.TabIndex = 8;
            this.lblAddressLine1AddUpdate.Text = "Address";
            this.lblAddressLine1AddUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAddressLine2AddUpdate
            // 
            this.txtAddressLine2AddUpdate.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtAddressLine2AddUpdate.ForeColor = System.Drawing.Color.Black;
            this.txtAddressLine2AddUpdate.Location = new System.Drawing.Point(727, 247);
            this.txtAddressLine2AddUpdate.Name = "txtAddressLine2AddUpdate";
            this.txtAddressLine2AddUpdate.Size = new System.Drawing.Size(200, 20);
            this.txtAddressLine2AddUpdate.TabIndex = 11;
            this.txtAddressLine2AddUpdate.TextChanged += new System.EventHandler(this.txtAddressLine2AddUpdate_TextChanged);
            // 
            // lblAddressLine2AddUpdate
            // 
            this.lblAddressLine2AddUpdate.AutoSize = true;
            this.lblAddressLine2AddUpdate.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressLine2AddUpdate.ForeColor = System.Drawing.Color.Black;
            this.lblAddressLine2AddUpdate.Location = new System.Drawing.Point(724, 228);
            this.lblAddressLine2AddUpdate.Name = "lblAddressLine2AddUpdate";
            this.lblAddressLine2AddUpdate.Size = new System.Drawing.Size(28, 16);
            this.lblAddressLine2AddUpdate.TabIndex = 10;
            this.lblAddressLine2AddUpdate.Text = "City";
            this.lblAddressLine2AddUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAddressLine3AddUpdate
            // 
            this.txtAddressLine3AddUpdate.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtAddressLine3AddUpdate.ForeColor = System.Drawing.Color.Black;
            this.txtAddressLine3AddUpdate.Location = new System.Drawing.Point(727, 287);
            this.txtAddressLine3AddUpdate.Name = "txtAddressLine3AddUpdate";
            this.txtAddressLine3AddUpdate.Size = new System.Drawing.Size(200, 20);
            this.txtAddressLine3AddUpdate.TabIndex = 13;
            this.txtAddressLine3AddUpdate.TextChanged += new System.EventHandler(this.txtAddressLine3AddUpdate_TextChanged);
            // 
            // lblAddressLine3AddUpdate
            // 
            this.lblAddressLine3AddUpdate.AutoSize = true;
            this.lblAddressLine3AddUpdate.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressLine3AddUpdate.ForeColor = System.Drawing.Color.Black;
            this.lblAddressLine3AddUpdate.Location = new System.Drawing.Point(724, 268);
            this.lblAddressLine3AddUpdate.Name = "lblAddressLine3AddUpdate";
            this.lblAddressLine3AddUpdate.Size = new System.Drawing.Size(50, 16);
            this.lblAddressLine3AddUpdate.TabIndex = 12;
            this.lblAddressLine3AddUpdate.Text = "Country";
            this.lblAddressLine3AddUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSkillLevelAddUpdate
            // 
            this.lblSkillLevelAddUpdate.AutoSize = true;
            this.lblSkillLevelAddUpdate.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkillLevelAddUpdate.ForeColor = System.Drawing.Color.Black;
            this.lblSkillLevelAddUpdate.Location = new System.Drawing.Point(724, 308);
            this.lblSkillLevelAddUpdate.Name = "lblSkillLevelAddUpdate";
            this.lblSkillLevelAddUpdate.Size = new System.Drawing.Size(63, 16);
            this.lblSkillLevelAddUpdate.TabIndex = 14;
            this.lblSkillLevelAddUpdate.Text = "Skill Level";
            this.lblSkillLevelAddUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDialCodeAddUpdate
            // 
            this.lblDialCodeAddUpdate.AutoSize = true;
            this.lblDialCodeAddUpdate.Font = new System.Drawing.Font("Yu Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDialCodeAddUpdate.ForeColor = System.Drawing.Color.Black;
            this.lblDialCodeAddUpdate.Location = new System.Drawing.Point(821, 145);
            this.lblDialCodeAddUpdate.Name = "lblDialCodeAddUpdate";
            this.lblDialCodeAddUpdate.Size = new System.Drawing.Size(105, 14);
            this.lblDialCodeAddUpdate.TabIndex = 19;
            this.lblDialCodeAddUpdate.Text = ":   including dial code";
            this.lblDialCodeAddUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GuestMenuStrip
            // 
            this.GuestMenuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.GuestMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.openToolStripMenuItem});
            this.GuestMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.GuestMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.GuestMenuStrip.Name = "GuestMenuStrip";
            this.GuestMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.GuestMenuStrip.Size = new System.Drawing.Size(944, 23);
            this.GuestMenuStrip.TabIndex = 20;
            this.GuestMenuStrip.Text = "stpMainMenu";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
            this.mainMenuToolStripMenuItem.Text = "Back";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 19);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortBySkillToolStripMenuItem,
            this.sortByCityToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // sortBySkillToolStripMenuItem
            // 
            this.sortBySkillToolStripMenuItem.Name = "sortBySkillToolStripMenuItem";
            this.sortBySkillToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.sortBySkillToolStripMenuItem.Text = "Sort By Skill";
            this.sortBySkillToolStripMenuItem.Click += new System.EventHandler(this.sortBySkillToolStripMenuItem_Click);
            // 
            // sortByCityToolStripMenuItem
            // 
            this.sortByCityToolStripMenuItem.Name = "sortByCityToolStripMenuItem";
            this.sortByCityToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.sortByCityToolStripMenuItem.Text = "Sort By Country";
            this.sortByCityToolStripMenuItem.Click += new System.EventHandler(this.sortByCityToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guestManagementToolStripMenuItem,
            this.courseMaagementToolStripMenuItem,
            this.exhibitionManagementToolStripMenuItem,
            this.artworkManagementToolStripMenuItem,
            this.mainMenuToolStripMenuItem1});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(48, 19);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // guestManagementToolStripMenuItem
            // 
            this.guestManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logEquipmentToolStripMenuItem,
            this.guestInvoiceToolStripMenuItem});
            this.guestManagementToolStripMenuItem.Name = "guestManagementToolStripMenuItem";
            this.guestManagementToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.guestManagementToolStripMenuItem.Text = "Guest Management";
            this.guestManagementToolStripMenuItem.Click += new System.EventHandler(this.guestManagementToolStripMenuItem_Click);
            // 
            // logEquipmentToolStripMenuItem
            // 
            this.logEquipmentToolStripMenuItem.Name = "logEquipmentToolStripMenuItem";
            this.logEquipmentToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.logEquipmentToolStripMenuItem.Text = "Log Equipment";
            this.logEquipmentToolStripMenuItem.Click += new System.EventHandler(this.logEquipmentToolStripMenuItem_Click);
            // 
            // guestInvoiceToolStripMenuItem
            // 
            this.guestInvoiceToolStripMenuItem.Name = "guestInvoiceToolStripMenuItem";
            this.guestInvoiceToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.guestInvoiceToolStripMenuItem.Text = "Guest Invoice";
            this.guestInvoiceToolStripMenuItem.Click += new System.EventHandler(this.guestInvoiceToolStripMenuItem_Click);
            // 
            // courseMaagementToolStripMenuItem
            // 
            this.courseMaagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.courseManagerToolStripMenuItem,
            this.makeABookingToolStripMenuItem,
            this.getCourseReportToolStripMenuItem});
            this.courseMaagementToolStripMenuItem.Name = "courseMaagementToolStripMenuItem";
            this.courseMaagementToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.courseMaagementToolStripMenuItem.Text = "Course Management";
            this.courseMaagementToolStripMenuItem.Click += new System.EventHandler(this.courseMaagementToolStripMenuItem_Click);
            // 
            // courseManagerToolStripMenuItem
            // 
            this.courseManagerToolStripMenuItem.Name = "courseManagerToolStripMenuItem";
            this.courseManagerToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.courseManagerToolStripMenuItem.Text = "Course Manager";
            this.courseManagerToolStripMenuItem.Click += new System.EventHandler(this.courseManagerToolStripMenuItem_Click);
            // 
            // makeABookingToolStripMenuItem
            // 
            this.makeABookingToolStripMenuItem.Name = "makeABookingToolStripMenuItem";
            this.makeABookingToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.makeABookingToolStripMenuItem.Text = "Make A Booking";
            this.makeABookingToolStripMenuItem.Click += new System.EventHandler(this.makeABookingToolStripMenuItem_Click);
            // 
            // getCourseReportToolStripMenuItem
            // 
            this.getCourseReportToolStripMenuItem.Name = "getCourseReportToolStripMenuItem";
            this.getCourseReportToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.getCourseReportToolStripMenuItem.Text = "Get Course Report";
            this.getCourseReportToolStripMenuItem.Click += new System.EventHandler(this.getCourseReportToolStripMenuItem_Click);
            // 
            // exhibitionManagementToolStripMenuItem
            // 
            this.exhibitionManagementToolStripMenuItem.Name = "exhibitionManagementToolStripMenuItem";
            this.exhibitionManagementToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.exhibitionManagementToolStripMenuItem.Text = "Exhibition Management";
            this.exhibitionManagementToolStripMenuItem.Click += new System.EventHandler(this.exhibitionManagementToolStripMenuItem_Click);
            // 
            // artworkManagementToolStripMenuItem
            // 
            this.artworkManagementToolStripMenuItem.Name = "artworkManagementToolStripMenuItem";
            this.artworkManagementToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.artworkManagementToolStripMenuItem.Text = "Artwork Management";
            this.artworkManagementToolStripMenuItem.Click += new System.EventHandler(this.artworkManagementToolStripMenuItem_Click);
            // 
            // mainMenuToolStripMenuItem1
            // 
            this.mainMenuToolStripMenuItem1.Name = "mainMenuToolStripMenuItem1";
            this.mainMenuToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.mainMenuToolStripMenuItem1.Text = "Main Menu";
            this.mainMenuToolStripMenuItem1.Click += new System.EventHandler(this.mainMenuToolStripMenuItem1_Click);
            // 
            // btnAddGuest
            // 
            this.btnAddGuest.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGuest.Location = new System.Drawing.Point(727, 365);
            this.btnAddGuest.Name = "btnAddGuest";
            this.btnAddGuest.Size = new System.Drawing.Size(199, 45);
            this.btnAddGuest.TabIndex = 21;
            this.btnAddGuest.Text = "Add Guest";
            this.btnAddGuest.UseVisualStyleBackColor = true;
            this.btnAddGuest.Click += new System.EventHandler(this.btnAddGuest_Click);
            // 
            // lblNoOfRecords
            // 
            this.lblNoOfRecords.AutoSize = true;
            this.lblNoOfRecords.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfRecords.ForeColor = System.Drawing.Color.Black;
            this.lblNoOfRecords.Location = new System.Drawing.Point(780, 454);
            this.lblNoOfRecords.Name = "lblNoOfRecords";
            this.lblNoOfRecords.Size = new System.Drawing.Size(147, 16);
            this.lblNoOfRecords.TabIndex = 22;
            this.lblNoOfRecords.Text = "Number of Records: 0000";
            this.lblNoOfRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxSkillLevelAddUpdate
            // 
            this.cbxSkillLevelAddUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSkillLevelAddUpdate.FormattingEnabled = true;
            this.cbxSkillLevelAddUpdate.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Advanced"});
            this.cbxSkillLevelAddUpdate.Location = new System.Drawing.Point(727, 327);
            this.cbxSkillLevelAddUpdate.Name = "cbxSkillLevelAddUpdate";
            this.cbxSkillLevelAddUpdate.Size = new System.Drawing.Size(200, 21);
            this.cbxSkillLevelAddUpdate.TabIndex = 23;
            this.cbxSkillLevelAddUpdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.myCombo_KeyPress);
            // 
            // btnUpdateGuest
            // 
            this.btnUpdateGuest.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateGuest.Location = new System.Drawing.Point(727, 365);
            this.btnUpdateGuest.Name = "btnUpdateGuest";
            this.btnUpdateGuest.Size = new System.Drawing.Size(199, 45);
            this.btnUpdateGuest.TabIndex = 24;
            this.btnUpdateGuest.Text = "Update Guest";
            this.btnUpdateGuest.UseVisualStyleBackColor = true;
            this.btnUpdateGuest.Click += new System.EventHandler(this.btnUpdateGuest_Click);
            // 
            // btnCancelUpdate
            // 
            this.btnCancelUpdate.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelUpdate.Location = new System.Drawing.Point(727, 415);
            this.btnCancelUpdate.Name = "btnCancelUpdate";
            this.btnCancelUpdate.Size = new System.Drawing.Size(55, 31);
            this.btnCancelUpdate.TabIndex = 25;
            this.btnCancelUpdate.Text = "Add";
            this.btnCancelUpdate.UseVisualStyleBackColor = true;
            this.btnCancelUpdate.Click += new System.EventHandler(this.btnCancelUpdate_Click);
            // 
            // btnEnterUpdate
            // 
            this.btnEnterUpdate.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterUpdate.Location = new System.Drawing.Point(871, 415);
            this.btnEnterUpdate.Name = "btnEnterUpdate";
            this.btnEnterUpdate.Size = new System.Drawing.Size(55, 31);
            this.btnEnterUpdate.TabIndex = 26;
            this.btnEnterUpdate.Text = "Update";
            this.btnEnterUpdate.UseVisualStyleBackColor = true;
            this.btnEnterUpdate.Click += new System.EventHandler(this.btnEnterUpdate_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Black;
            this.lblSearch.Location = new System.Drawing.Point(225, 29);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(49, 16);
            this.lblSearch.TabIndex = 27;
            this.lblSearch.Text = "Search:";
            // 
            // lblNoResults
            // 
            this.lblNoResults.AutoSize = true;
            this.lblNoResults.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblNoResults.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoResults.Location = new System.Drawing.Point(302, 268);
            this.lblNoResults.Name = "lblNoResults";
            this.lblNoResults.Size = new System.Drawing.Size(119, 27);
            this.lblNoResults.TabIndex = 33;
            this.lblNoResults.Text = "No Results";
            // 
            // txtGuestIDsearch
            // 
            this.txtGuestIDsearch.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtGuestIDsearch.ForeColor = System.Drawing.Color.Black;
            this.txtGuestIDsearch.Location = new System.Drawing.Point(280, 27);
            this.txtGuestIDsearch.Name = "txtGuestIDsearch";
            this.txtGuestIDsearch.Size = new System.Drawing.Size(200, 20);
            this.txtGuestIDsearch.TabIndex = 41;
            this.txtGuestIDsearch.TextChanged += new System.EventHandler(this.txtGuestID_TextChanged);
            // 
            // txtForenamesearch
            // 
            this.txtForenamesearch.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtForenamesearch.ForeColor = System.Drawing.Color.Black;
            this.txtForenamesearch.Location = new System.Drawing.Point(280, 27);
            this.txtForenamesearch.Name = "txtForenamesearch";
            this.txtForenamesearch.Size = new System.Drawing.Size(200, 20);
            this.txtForenamesearch.TabIndex = 39;
            this.txtForenamesearch.TextChanged += new System.EventHandler(this.txtForename_TextChanged);
            // 
            // txtSurnamesearch
            // 
            this.txtSurnamesearch.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSurnamesearch.ForeColor = System.Drawing.Color.Black;
            this.txtSurnamesearch.Location = new System.Drawing.Point(280, 26);
            this.txtSurnamesearch.Name = "txtSurnamesearch";
            this.txtSurnamesearch.Size = new System.Drawing.Size(200, 20);
            this.txtSurnamesearch.TabIndex = 37;
            this.txtSurnamesearch.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // cbxSearchBy
            // 
            this.cbxSearchBy.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbxSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSearchBy.ForeColor = System.Drawing.Color.Black;
            this.cbxSearchBy.FormattingEnabled = true;
            this.cbxSearchBy.Items.AddRange(new object[] {
            "Forename",
            "Surname",
            "Guest ID"});
            this.cbxSearchBy.Location = new System.Drawing.Point(90, 26);
            this.cbxSearchBy.Name = "cbxSearchBy";
            this.cbxSearchBy.Size = new System.Drawing.Size(119, 21);
            this.cbxSearchBy.TabIndex = 35;
            this.cbxSearchBy.SelectedIndexChanged += new System.EventHandler(this.cbxSearchBy_SelectedIndexChanged);
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBy.ForeColor = System.Drawing.Color.Black;
            this.lblSearchBy.Location = new System.Drawing.Point(23, 30);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(63, 16);
            this.lblSearchBy.TabIndex = 34;
            this.lblSearchBy.Text = "Search By";
            this.lblSearchBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSearch.Location = new System.Drawing.Point(486, 26);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(45, 22);
            this.btnClearSearch.TabIndex = 42;
            this.btnClearSearch.Text = "Clear";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // btnDeleteMode
            // 
            this.btnDeleteMode.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMode.Location = new System.Drawing.Point(799, 415);
            this.btnDeleteMode.Name = "btnDeleteMode";
            this.btnDeleteMode.Size = new System.Drawing.Size(55, 31);
            this.btnDeleteMode.TabIndex = 43;
            this.btnDeleteMode.Text = "Delete";
            this.btnDeleteMode.UseVisualStyleBackColor = true;
            this.btnDeleteMode.Click += new System.EventHandler(this.btnDeleteMode_Click);
            // 
            // btnDeleteGuest
            // 
            this.btnDeleteGuest.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteGuest.Location = new System.Drawing.Point(727, 364);
            this.btnDeleteGuest.Name = "btnDeleteGuest";
            this.btnDeleteGuest.Size = new System.Drawing.Size(199, 45);
            this.btnDeleteGuest.TabIndex = 46;
            this.btnDeleteGuest.Text = "Delete Guest";
            this.btnDeleteGuest.UseVisualStyleBackColor = true;
            this.btnDeleteGuest.Click += new System.EventHandler(this.btnDeleteGuest_Click);
            // 
            // txtGuestIDDelete
            // 
            this.txtGuestIDDelete.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtGuestIDDelete.ForeColor = System.Drawing.Color.Black;
            this.txtGuestIDDelete.Location = new System.Drawing.Point(727, 80);
            this.txtGuestIDDelete.Name = "txtGuestIDDelete";
            this.txtGuestIDDelete.Size = new System.Drawing.Size(200, 20);
            this.txtGuestIDDelete.TabIndex = 45;
            this.txtGuestIDDelete.TextChanged += new System.EventHandler(this.txtGuestIDDelete_TextChanged);
            this.txtGuestIDDelete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGuestIDDelete_KeyPress);
            // 
            // lblGuestIDDelete
            // 
            this.lblGuestIDDelete.AutoSize = true;
            this.lblGuestIDDelete.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestIDDelete.ForeColor = System.Drawing.Color.Black;
            this.lblGuestIDDelete.Location = new System.Drawing.Point(724, 61);
            this.lblGuestIDDelete.Name = "lblGuestIDDelete";
            this.lblGuestIDDelete.Size = new System.Drawing.Size(56, 16);
            this.lblGuestIDDelete.TabIndex = 44;
            this.lblGuestIDDelete.Text = "Guest ID";
            // 
            // lblexistingbooking
            // 
            this.lblexistingbooking.AutoSize = true;
            this.lblexistingbooking.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexistingbooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblexistingbooking.Location = new System.Drawing.Point(724, 327);
            this.lblexistingbooking.Name = "lblexistingbooking";
            this.lblexistingbooking.Size = new System.Drawing.Size(203, 28);
            this.lblexistingbooking.TabIndex = 47;
            this.lblexistingbooking.Text = "This guest has a future booking and \r\ntherefore skill level cannot be changed.";
            // 
            // FrmAddGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(944, 498);
            this.Controls.Add(this.lblexistingbooking);
            this.Controls.Add(this.btnDeleteGuest);
            this.Controls.Add(this.txtGuestIDDelete);
            this.Controls.Add(this.lblGuestIDDelete);
            this.Controls.Add(this.btnDeleteMode);
            this.Controls.Add(this.btnClearSearch);
            this.Controls.Add(this.txtGuestIDsearch);
            this.Controls.Add(this.txtForenamesearch);
            this.Controls.Add(this.txtSurnamesearch);
            this.Controls.Add(this.cbxSearchBy);
            this.Controls.Add(this.lblSearchBy);
            this.Controls.Add(this.lblNoResults);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnEnterUpdate);
            this.Controls.Add(this.btnCancelUpdate);
            this.Controls.Add(this.btnUpdateGuest);
            this.Controls.Add(this.cbxSkillLevelAddUpdate);
            this.Controls.Add(this.lblNoOfRecords);
            this.Controls.Add(this.btnAddGuest);
            this.Controls.Add(this.GuestMenuStrip);
            this.Controls.Add(this.lblDialCodeAddUpdate);
            this.Controls.Add(this.lblSkillLevelAddUpdate);
            this.Controls.Add(this.txtAddressLine3AddUpdate);
            this.Controls.Add(this.lblAddressLine3AddUpdate);
            this.Controls.Add(this.txtAddressLine2AddUpdate);
            this.Controls.Add(this.lblAddressLine2AddUpdate);
            this.Controls.Add(this.txtAddressLine1AddUpdate);
            this.Controls.Add(this.lblAddressLine1AddUpdate);
            this.Controls.Add(this.txtContactNoAddUpdate);
            this.Controls.Add(this.lblContactNoAddUpdate);
            this.Controls.Add(this.txtSurnameAddUpdate);
            this.Controls.Add(this.lblSurnameAddUpdate);
            this.Controls.Add(this.txtForenameAddUpdate);
            this.Controls.Add(this.lblForenameAddUpdate);
            this.Controls.Add(this.lblAddGuestDetails);
            this.Controls.Add(this.dgvGuestsOut);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAddGuest";
            this.Text = "Guest Management";
            this.Load += new System.EventHandler(this.FrmHalfTermTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestsOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestDataSetForHalfTermTask)).EndInit();
            this.GuestMenuStrip.ResumeLayout(false);
            this.GuestMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGuestsOut;
        private DataSets.GuestDataSetForHalfTermTask guestDataSetForHalfTermTask;
        private System.Windows.Forms.BindingSource guestBindingSource;
        private DataSets.GuestDataSetForHalfTermTaskTableAdapters.GuestTableAdapter guestTableAdapter;
        private System.Windows.Forms.Label lblAddGuestDetails;
        private System.Windows.Forms.Label lblForenameAddUpdate;
        private System.Windows.Forms.TextBox txtForenameAddUpdate;
        private System.Windows.Forms.TextBox txtSurnameAddUpdate;
        private System.Windows.Forms.Label lblSurnameAddUpdate;
        private System.Windows.Forms.TextBox txtContactNoAddUpdate;
        private System.Windows.Forms.Label lblContactNoAddUpdate;
        private System.Windows.Forms.TextBox txtAddressLine1AddUpdate;
        private System.Windows.Forms.Label lblAddressLine1AddUpdate;
        private System.Windows.Forms.TextBox txtAddressLine2AddUpdate;
        private System.Windows.Forms.Label lblAddressLine2AddUpdate;
        private System.Windows.Forms.TextBox txtAddressLine3AddUpdate;
        private System.Windows.Forms.Label lblAddressLine3AddUpdate;
        private System.Windows.Forms.Label lblSkillLevelAddUpdate;
        private System.Windows.Forms.Label lblDialCodeAddUpdate;
        private System.Windows.Forms.MenuStrip GuestMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btnAddGuest;
        private System.Windows.Forms.Label lblNoOfRecords;
        private System.Windows.Forms.ComboBox cbxSkillLevelAddUpdate;
        private System.Windows.Forms.Button btnUpdateGuest;
        private System.Windows.Forms.Button btnCancelUpdate;
        private System.Windows.Forms.Button btnEnterUpdate;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblNoResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn forenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn homeAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortBySkillToolStripMenuItem;
        private System.Windows.Forms.TextBox txtGuestIDsearch;
        private System.Windows.Forms.TextBox txtForenamesearch;
        private System.Windows.Forms.TextBox txtSurnamesearch;
        private System.Windows.Forms.ComboBox cbxSearchBy;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.Button btnDeleteMode;
        private System.Windows.Forms.Button btnDeleteGuest;
        private System.Windows.Forms.TextBox txtGuestIDDelete;
        private System.Windows.Forms.Label lblGuestIDDelete;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guestManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logEquipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guestInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseMaagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exhibitionManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artworkManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem makeABookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getCourseReportToolStripMenuItem;
        private System.Windows.Forms.Label lblexistingbooking;
        private System.Windows.Forms.ToolStripMenuItem sortByCityToolStripMenuItem;
    }
}