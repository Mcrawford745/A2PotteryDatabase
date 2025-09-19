namespace PotteryDBA_V1._0.Forms
{
    partial class FrmExhibitionViewer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExhibitionViewer));
            this.GuestMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedGuestArtworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalGuestArtworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allExhibitionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestManagementToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logEquipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseMaagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeABookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getCourseReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artworkManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAllExhibitions = new System.Windows.Forms.Label();
            this.lblPastExhibitions = new System.Windows.Forms.Label();
            this.lblFutureExhibitions = new System.Windows.Forms.Label();
            this.dgvAllExhibitions = new System.Windows.Forms.DataGridView();
            this.exhibitionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exhibitionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cateringNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populateAllExhibitionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.populateAllExhibitions = new PotteryDBA_V1._0.DataSets.PopulateAllExhibitions();
            this.populateAllExhibitionsTableAdapter = new PotteryDBA_V1._0.DataSets.PopulateAllExhibitionsTableAdapters.PopulateAllExhibitionsTableAdapter();
            this.dgvFutureExhibitions = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populateFutureExhibitionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.populateFutureExhibitions = new PotteryDBA_V1._0.DataSets.PopulateFutureExhibitions();
            this.populateFutureExhibitionsTableAdapter = new PotteryDBA_V1._0.DataSets.PopulateFutureExhibitionsTableAdapters.PopulateFutureExhibitionsTableAdapter();
            this.dgvPastExhibitions = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populatePastExhibitionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.populatePastExhibitions = new PotteryDBA_V1._0.DataSets.PopulatePastExhibitions();
            this.populatePastExhibitionsTableAdapter = new PotteryDBA_V1._0.DataSets.PopulatePastExhibitionsTableAdapters.PopulatePastExhibitionsTableAdapter();
            this.lblNoOfRecords = new System.Windows.Forms.Label();
            this.btnUpdateMode = new System.Windows.Forms.Button();
            this.btnDeleteMode = new System.Windows.Forms.Button();
            this.btnAddMode = new System.Windows.Forms.Button();
            this.lblheader = new System.Windows.Forms.Label();
            this.lblExhibitionYearAdd = new System.Windows.Forms.Label();
            this.mcExhibitionDate = new System.Windows.Forms.MonthCalendar();
            this.lblExhibitionDateAdd = new System.Windows.Forms.Label();
            this.nudExhibitionYearAdd = new System.Windows.Forms.NumericUpDown();
            this.lblYearFull = new System.Windows.Forms.Label();
            this.btnAddExhibition = new System.Windows.Forms.Button();
            this.txtExhibitionIDDelete = new System.Windows.Forms.TextBox();
            this.lblExhibitionIDDelete = new System.Windows.Forms.Label();
            this.btnDeleteExhibition = new System.Windows.Forms.Button();
            this.lblExhibitionHAsArtworks = new System.Windows.Forms.Label();
            this.txtExhibitionIDUpdate = new System.Windows.Forms.TextBox();
            this.lblExhibitionIDUpdate = new System.Windows.Forms.Label();
            this.lblExhibitionDateUpdate = new System.Windows.Forms.Label();
            this.mcExhibitionDateUpdate = new System.Windows.Forms.MonthCalendar();
            this.btnUpdateExhibition = new System.Windows.Forms.Button();
            this.lblCateringNoUpdate = new System.Windows.Forms.Label();
            this.nudCateringNumberUpdate = new System.Windows.Forms.NumericUpDown();
            this.GuestMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllExhibitions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.populateAllExhibitionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.populateAllExhibitions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFutureExhibitions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.populateFutureExhibitionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.populateFutureExhibitions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPastExhibitions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.populatePastExhibitionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.populatePastExhibitions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExhibitionYearAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCateringNumberUpdate)).BeginInit();
            this.SuspendLayout();
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
            this.GuestMenuStrip.Size = new System.Drawing.Size(744, 23);
            this.GuestMenuStrip.TabIndex = 23;
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
            this.advancedGuestArtworkToolStripMenuItem,
            this.generalGuestArtworkToolStripMenuItem,
            this.allExhibitionsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // advancedGuestArtworkToolStripMenuItem
            // 
            this.advancedGuestArtworkToolStripMenuItem.Name = "advancedGuestArtworkToolStripMenuItem";
            this.advancedGuestArtworkToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.advancedGuestArtworkToolStripMenuItem.Text = "Future Exhibitions";
            this.advancedGuestArtworkToolStripMenuItem.Click += new System.EventHandler(this.advancedGuestArtworkToolStripMenuItem_Click);
            // 
            // generalGuestArtworkToolStripMenuItem
            // 
            this.generalGuestArtworkToolStripMenuItem.Name = "generalGuestArtworkToolStripMenuItem";
            this.generalGuestArtworkToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.generalGuestArtworkToolStripMenuItem.Text = "Past Exhibitions";
            this.generalGuestArtworkToolStripMenuItem.Click += new System.EventHandler(this.generalGuestArtworkToolStripMenuItem_Click);
            // 
            // allExhibitionsToolStripMenuItem
            // 
            this.allExhibitionsToolStripMenuItem.Name = "allExhibitionsToolStripMenuItem";
            this.allExhibitionsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.allExhibitionsToolStripMenuItem.Text = "All Exhibitions";
            this.allExhibitionsToolStripMenuItem.Click += new System.EventHandler(this.allExhibitionsToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guestManagementToolStripMenuItem,
            this.courseMaagementToolStripMenuItem,
            this.artworkManagementToolStripMenuItem,
            this.mainMenuToolStripMenuItem1});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(48, 19);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // guestManagementToolStripMenuItem
            // 
            this.guestManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guestManagementToolStripMenuItem1,
            this.logEquipmentToolStripMenuItem,
            this.guestInvoiceToolStripMenuItem});
            this.guestManagementToolStripMenuItem.Name = "guestManagementToolStripMenuItem";
            this.guestManagementToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.guestManagementToolStripMenuItem.Text = "Guest Management";
            this.guestManagementToolStripMenuItem.Click += new System.EventHandler(this.guestManagementToolStripMenuItem_Click);
            // 
            // guestManagementToolStripMenuItem1
            // 
            this.guestManagementToolStripMenuItem1.Name = "guestManagementToolStripMenuItem1";
            this.guestManagementToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.guestManagementToolStripMenuItem1.Text = "Guest Management";
            this.guestManagementToolStripMenuItem1.Click += new System.EventHandler(this.guestManagementToolStripMenuItem1_Click);
            // 
            // logEquipmentToolStripMenuItem
            // 
            this.logEquipmentToolStripMenuItem.Name = "logEquipmentToolStripMenuItem";
            this.logEquipmentToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.logEquipmentToolStripMenuItem.Text = "Log Equipment";
            this.logEquipmentToolStripMenuItem.Click += new System.EventHandler(this.logEquipmentToolStripMenuItem_Click);
            // 
            // guestInvoiceToolStripMenuItem
            // 
            this.guestInvoiceToolStripMenuItem.Name = "guestInvoiceToolStripMenuItem";
            this.guestInvoiceToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
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
            this.courseMaagementToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
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
            // artworkManagementToolStripMenuItem
            // 
            this.artworkManagementToolStripMenuItem.Name = "artworkManagementToolStripMenuItem";
            this.artworkManagementToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.artworkManagementToolStripMenuItem.Text = "Artwork Management";
            this.artworkManagementToolStripMenuItem.Click += new System.EventHandler(this.artworkManagementToolStripMenuItem_Click);
            // 
            // mainMenuToolStripMenuItem1
            // 
            this.mainMenuToolStripMenuItem1.Name = "mainMenuToolStripMenuItem1";
            this.mainMenuToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.mainMenuToolStripMenuItem1.Text = "Main Menu";
            this.mainMenuToolStripMenuItem1.Click += new System.EventHandler(this.mainMenuToolStripMenuItem1_Click);
            // 
            // lblAllExhibitions
            // 
            this.lblAllExhibitions.AutoSize = true;
            this.lblAllExhibitions.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllExhibitions.ForeColor = System.Drawing.Color.Black;
            this.lblAllExhibitions.Location = new System.Drawing.Point(12, 33);
            this.lblAllExhibitions.Name = "lblAllExhibitions";
            this.lblAllExhibitions.Size = new System.Drawing.Size(151, 27);
            this.lblAllExhibitions.TabIndex = 27;
            this.lblAllExhibitions.Text = "All Exhibitions";
            // 
            // lblPastExhibitions
            // 
            this.lblPastExhibitions.AutoSize = true;
            this.lblPastExhibitions.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPastExhibitions.ForeColor = System.Drawing.Color.Black;
            this.lblPastExhibitions.Location = new System.Drawing.Point(12, 33);
            this.lblPastExhibitions.Name = "lblPastExhibitions";
            this.lblPastExhibitions.Size = new System.Drawing.Size(169, 27);
            this.lblPastExhibitions.TabIndex = 28;
            this.lblPastExhibitions.Text = "Past Exhibitions";
            // 
            // lblFutureExhibitions
            // 
            this.lblFutureExhibitions.AutoSize = true;
            this.lblFutureExhibitions.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFutureExhibitions.ForeColor = System.Drawing.Color.Black;
            this.lblFutureExhibitions.Location = new System.Drawing.Point(12, 33);
            this.lblFutureExhibitions.Name = "lblFutureExhibitions";
            this.lblFutureExhibitions.Size = new System.Drawing.Size(188, 27);
            this.lblFutureExhibitions.TabIndex = 29;
            this.lblFutureExhibitions.Text = "Future Exhibitions";
            // 
            // dgvAllExhibitions
            // 
            this.dgvAllExhibitions.AllowUserToAddRows = false;
            this.dgvAllExhibitions.AllowUserToDeleteRows = false;
            this.dgvAllExhibitions.AllowUserToResizeColumns = false;
            this.dgvAllExhibitions.AllowUserToResizeRows = false;
            this.dgvAllExhibitions.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllExhibitions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllExhibitions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllExhibitions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.exhibitionIDDataGridViewTextBoxColumn,
            this.exhibitionDateDataGridViewTextBoxColumn,
            this.cateringNoDataGridViewTextBoxColumn,
            this.column1DataGridViewTextBoxColumn});
            this.dgvAllExhibitions.DataSource = this.populateAllExhibitionsBindingSource;
            this.dgvAllExhibitions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAllExhibitions.EnableHeadersVisualStyles = false;
            this.dgvAllExhibitions.Location = new System.Drawing.Point(17, 64);
            this.dgvAllExhibitions.MultiSelect = false;
            this.dgvAllExhibitions.Name = "dgvAllExhibitions";
            this.dgvAllExhibitions.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllExhibitions.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvAllExhibitions.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllExhibitions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllExhibitions.Size = new System.Drawing.Size(459, 404);
            this.dgvAllExhibitions.TabIndex = 30;
            this.dgvAllExhibitions.SelectionChanged += new System.EventHandler(this.DGVSelectionChange);
            // 
            // exhibitionIDDataGridViewTextBoxColumn
            // 
            this.exhibitionIDDataGridViewTextBoxColumn.DataPropertyName = "ExhibitionID";
            this.exhibitionIDDataGridViewTextBoxColumn.HeaderText = "Exhibition ID";
            this.exhibitionIDDataGridViewTextBoxColumn.Name = "exhibitionIDDataGridViewTextBoxColumn";
            this.exhibitionIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // exhibitionDateDataGridViewTextBoxColumn
            // 
            this.exhibitionDateDataGridViewTextBoxColumn.DataPropertyName = "ExhibitionDate";
            this.exhibitionDateDataGridViewTextBoxColumn.HeaderText = "Exhibition Date";
            this.exhibitionDateDataGridViewTextBoxColumn.Name = "exhibitionDateDataGridViewTextBoxColumn";
            this.exhibitionDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.exhibitionDateDataGridViewTextBoxColumn.Width = 105;
            // 
            // cateringNoDataGridViewTextBoxColumn
            // 
            this.cateringNoDataGridViewTextBoxColumn.DataPropertyName = "CateringNo";
            this.cateringNoDataGridViewTextBoxColumn.HeaderText = "Catering No";
            this.cateringNoDataGridViewTextBoxColumn.Name = "cateringNoDataGridViewTextBoxColumn";
            this.cateringNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.cateringNoDataGridViewTextBoxColumn.Width = 90;
            // 
            // column1DataGridViewTextBoxColumn
            // 
            this.column1DataGridViewTextBoxColumn.DataPropertyName = "Column1";
            this.column1DataGridViewTextBoxColumn.HeaderText = "Artwork Count";
            this.column1DataGridViewTextBoxColumn.Name = "column1DataGridViewTextBoxColumn";
            this.column1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // populateAllExhibitionsBindingSource
            // 
            this.populateAllExhibitionsBindingSource.DataMember = "PopulateAllExhibitions";
            this.populateAllExhibitionsBindingSource.DataSource = this.populateAllExhibitions;
            // 
            // populateAllExhibitions
            // 
            this.populateAllExhibitions.DataSetName = "PopulateAllExhibitions";
            this.populateAllExhibitions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // populateAllExhibitionsTableAdapter
            // 
            this.populateAllExhibitionsTableAdapter.ClearBeforeFill = true;
            // 
            // dgvFutureExhibitions
            // 
            this.dgvFutureExhibitions.AllowUserToAddRows = false;
            this.dgvFutureExhibitions.AllowUserToDeleteRows = false;
            this.dgvFutureExhibitions.AllowUserToResizeColumns = false;
            this.dgvFutureExhibitions.AllowUserToResizeRows = false;
            this.dgvFutureExhibitions.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFutureExhibitions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFutureExhibitions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFutureExhibitions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvFutureExhibitions.DataSource = this.populateFutureExhibitionsBindingSource;
            this.dgvFutureExhibitions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFutureExhibitions.EnableHeadersVisualStyles = false;
            this.dgvFutureExhibitions.Location = new System.Drawing.Point(17, 64);
            this.dgvFutureExhibitions.MultiSelect = false;
            this.dgvFutureExhibitions.Name = "dgvFutureExhibitions";
            this.dgvFutureExhibitions.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFutureExhibitions.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvFutureExhibitions.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvFutureExhibitions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFutureExhibitions.Size = new System.Drawing.Size(459, 404);
            this.dgvFutureExhibitions.TabIndex = 31;
            this.dgvFutureExhibitions.SelectionChanged += new System.EventHandler(this.DGVSelectionChange);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ExhibitionID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Exhibition ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ExhibitionDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "Exhibition Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 105;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CateringNo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Catering No";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 90;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Column1";
            this.dataGridViewTextBoxColumn4.HeaderText = "Artwork Count";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // populateFutureExhibitionsBindingSource
            // 
            this.populateFutureExhibitionsBindingSource.DataMember = "PopulateFutureExhibitions";
            this.populateFutureExhibitionsBindingSource.DataSource = this.populateFutureExhibitions;
            // 
            // populateFutureExhibitions
            // 
            this.populateFutureExhibitions.DataSetName = "PopulateFutureExhibitions";
            this.populateFutureExhibitions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // populateFutureExhibitionsTableAdapter
            // 
            this.populateFutureExhibitionsTableAdapter.ClearBeforeFill = true;
            // 
            // dgvPastExhibitions
            // 
            this.dgvPastExhibitions.AllowUserToAddRows = false;
            this.dgvPastExhibitions.AllowUserToDeleteRows = false;
            this.dgvPastExhibitions.AllowUserToResizeColumns = false;
            this.dgvPastExhibitions.AllowUserToResizeRows = false;
            this.dgvPastExhibitions.AutoGenerateColumns = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPastExhibitions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPastExhibitions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPastExhibitions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dgvPastExhibitions.DataSource = this.populatePastExhibitionsBindingSource;
            this.dgvPastExhibitions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPastExhibitions.EnableHeadersVisualStyles = false;
            this.dgvPastExhibitions.Location = new System.Drawing.Point(17, 64);
            this.dgvPastExhibitions.MultiSelect = false;
            this.dgvPastExhibitions.Name = "dgvPastExhibitions";
            this.dgvPastExhibitions.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPastExhibitions.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvPastExhibitions.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPastExhibitions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPastExhibitions.Size = new System.Drawing.Size(459, 404);
            this.dgvPastExhibitions.TabIndex = 32;
            this.dgvPastExhibitions.SelectionChanged += new System.EventHandler(this.DGVSelectionChange);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ExhibitionID";
            this.dataGridViewTextBoxColumn5.HeaderText = "Exhibition ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ExhibitionDate";
            this.dataGridViewTextBoxColumn6.HeaderText = "Exhibition Date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 105;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CateringNo";
            this.dataGridViewTextBoxColumn7.HeaderText = "Catering No";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 90;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Column1";
            this.dataGridViewTextBoxColumn8.HeaderText = "Artwork Count";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // populatePastExhibitionsBindingSource
            // 
            this.populatePastExhibitionsBindingSource.DataMember = "PopulatePastExhibitions";
            this.populatePastExhibitionsBindingSource.DataSource = this.populatePastExhibitions;
            // 
            // populatePastExhibitions
            // 
            this.populatePastExhibitions.DataSetName = "PopulatePastExhibitions";
            this.populatePastExhibitions.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // populatePastExhibitionsTableAdapter
            // 
            this.populatePastExhibitionsTableAdapter.ClearBeforeFill = true;
            // 
            // lblNoOfRecords
            // 
            this.lblNoOfRecords.AutoSize = true;
            this.lblNoOfRecords.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfRecords.ForeColor = System.Drawing.Color.Black;
            this.lblNoOfRecords.Location = new System.Drawing.Point(329, 45);
            this.lblNoOfRecords.Name = "lblNoOfRecords";
            this.lblNoOfRecords.Size = new System.Drawing.Size(147, 16);
            this.lblNoOfRecords.TabIndex = 36;
            this.lblNoOfRecords.Text = "Number of Records: 0000";
            this.lblNoOfRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnUpdateMode
            // 
            this.btnUpdateMode.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMode.Location = new System.Drawing.Point(653, 68);
            this.btnUpdateMode.Name = "btnUpdateMode";
            this.btnUpdateMode.Size = new System.Drawing.Size(55, 31);
            this.btnUpdateMode.TabIndex = 67;
            this.btnUpdateMode.TabStop = false;
            this.btnUpdateMode.Text = "Update";
            this.btnUpdateMode.UseVisualStyleBackColor = true;
            this.btnUpdateMode.Click += new System.EventHandler(this.btnUpdateMode_Click);
            // 
            // btnDeleteMode
            // 
            this.btnDeleteMode.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMode.Location = new System.Drawing.Point(581, 68);
            this.btnDeleteMode.Name = "btnDeleteMode";
            this.btnDeleteMode.Size = new System.Drawing.Size(55, 31);
            this.btnDeleteMode.TabIndex = 66;
            this.btnDeleteMode.TabStop = false;
            this.btnDeleteMode.Text = "Delete";
            this.btnDeleteMode.UseVisualStyleBackColor = true;
            this.btnDeleteMode.Click += new System.EventHandler(this.btnDeleteMode_Click);
            // 
            // btnAddMode
            // 
            this.btnAddMode.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMode.Location = new System.Drawing.Point(507, 68);
            this.btnAddMode.Name = "btnAddMode";
            this.btnAddMode.Size = new System.Drawing.Size(55, 31);
            this.btnAddMode.TabIndex = 65;
            this.btnAddMode.TabStop = false;
            this.btnAddMode.Text = "Add";
            this.btnAddMode.UseVisualStyleBackColor = true;
            this.btnAddMode.Click += new System.EventHandler(this.btnAddMode_Click);
            // 
            // lblheader
            // 
            this.lblheader.AutoSize = true;
            this.lblheader.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheader.ForeColor = System.Drawing.Color.Black;
            this.lblheader.Location = new System.Drawing.Point(504, 33);
            this.lblheader.Name = "lblheader";
            this.lblheader.Size = new System.Drawing.Size(204, 27);
            this.lblheader.TabIndex = 64;
            this.lblheader.Text = "Manage Exhibitions";
            // 
            // lblExhibitionYearAdd
            // 
            this.lblExhibitionYearAdd.AutoSize = true;
            this.lblExhibitionYearAdd.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExhibitionYearAdd.ForeColor = System.Drawing.Color.Black;
            this.lblExhibitionYearAdd.Location = new System.Drawing.Point(506, 117);
            this.lblExhibitionYearAdd.Name = "lblExhibitionYearAdd";
            this.lblExhibitionYearAdd.Size = new System.Drawing.Size(89, 16);
            this.lblExhibitionYearAdd.TabIndex = 88;
            this.lblExhibitionYearAdd.Text = "Exhibition Year";
            // 
            // mcExhibitionDate
            // 
            this.mcExhibitionDate.Location = new System.Drawing.Point(499, 184);
            this.mcExhibitionDate.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.mcExhibitionDate.MaxSelectionCount = 1;
            this.mcExhibitionDate.MinDate = new System.DateTime(2023, 12, 1, 0, 0, 0, 0);
            this.mcExhibitionDate.Name = "mcExhibitionDate";
            this.mcExhibitionDate.ShowToday = false;
            this.mcExhibitionDate.ShowTodayCircle = false;
            this.mcExhibitionDate.TabIndex = 89;
            this.mcExhibitionDate.TitleBackColor = System.Drawing.SystemColors.Window;
            this.mcExhibitionDate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mcExhibitionDate_MouseDown);
            // 
            // lblExhibitionDateAdd
            // 
            this.lblExhibitionDateAdd.AutoSize = true;
            this.lblExhibitionDateAdd.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExhibitionDateAdd.ForeColor = System.Drawing.Color.Black;
            this.lblExhibitionDateAdd.Location = new System.Drawing.Point(506, 163);
            this.lblExhibitionDateAdd.Name = "lblExhibitionDateAdd";
            this.lblExhibitionDateAdd.Size = new System.Drawing.Size(91, 16);
            this.lblExhibitionDateAdd.TabIndex = 90;
            this.lblExhibitionDateAdd.Text = "Exhibition Date";
            // 
            // nudExhibitionYearAdd
            // 
            this.nudExhibitionYearAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudExhibitionYearAdd.Location = new System.Drawing.Point(509, 137);
            this.nudExhibitionYearAdd.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudExhibitionYearAdd.Minimum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.nudExhibitionYearAdd.Name = "nudExhibitionYearAdd";
            this.nudExhibitionYearAdd.Size = new System.Drawing.Size(199, 22);
            this.nudExhibitionYearAdd.TabIndex = 91;
            this.nudExhibitionYearAdd.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.nudExhibitionYearAdd.ValueChanged += new System.EventHandler(this.nudYear_ValueChanged);
            this.nudExhibitionYearAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudExhibitionYearAdd_KeyPress);
            // 
            // lblYearFull
            // 
            this.lblYearFull.AutoSize = true;
            this.lblYearFull.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearFull.ForeColor = System.Drawing.Color.Firebrick;
            this.lblYearFull.Location = new System.Drawing.Point(501, 340);
            this.lblYearFull.Name = "lblYearFull";
            this.lblYearFull.Size = new System.Drawing.Size(223, 32);
            this.lblYearFull.TabIndex = 92;
            this.lblYearFull.Text = "An exhibition is already booked for this \r\nyear. Please choose an unbooked year.";
            this.lblYearFull.Visible = false;
            // 
            // btnAddExhibition
            // 
            this.btnAddExhibition.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExhibition.Location = new System.Drawing.Point(509, 420);
            this.btnAddExhibition.Name = "btnAddExhibition";
            this.btnAddExhibition.Size = new System.Drawing.Size(201, 45);
            this.btnAddExhibition.TabIndex = 93;
            this.btnAddExhibition.Text = "Add Exhibition";
            this.btnAddExhibition.UseVisualStyleBackColor = true;
            this.btnAddExhibition.Click += new System.EventHandler(this.btnAddExhibition_Click);
            // 
            // txtExhibitionIDDelete
            // 
            this.txtExhibitionIDDelete.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtExhibitionIDDelete.ForeColor = System.Drawing.Color.Black;
            this.txtExhibitionIDDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtExhibitionIDDelete.Location = new System.Drawing.Point(509, 138);
            this.txtExhibitionIDDelete.Name = "txtExhibitionIDDelete";
            this.txtExhibitionIDDelete.Size = new System.Drawing.Size(200, 20);
            this.txtExhibitionIDDelete.TabIndex = 95;
            this.txtExhibitionIDDelete.TextChanged += new System.EventHandler(this.txtExhibitionIDDelete_TextChanged);
            this.txtExhibitionIDDelete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExhibitionIDDelete_KeyPress);
            // 
            // lblExhibitionIDDelete
            // 
            this.lblExhibitionIDDelete.AutoSize = true;
            this.lblExhibitionIDDelete.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExhibitionIDDelete.ForeColor = System.Drawing.Color.Black;
            this.lblExhibitionIDDelete.Location = new System.Drawing.Point(506, 118);
            this.lblExhibitionIDDelete.Name = "lblExhibitionIDDelete";
            this.lblExhibitionIDDelete.Size = new System.Drawing.Size(77, 16);
            this.lblExhibitionIDDelete.TabIndex = 94;
            this.lblExhibitionIDDelete.Text = "Exhibition ID";
            // 
            // btnDeleteExhibition
            // 
            this.btnDeleteExhibition.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteExhibition.Location = new System.Drawing.Point(509, 420);
            this.btnDeleteExhibition.Name = "btnDeleteExhibition";
            this.btnDeleteExhibition.Size = new System.Drawing.Size(201, 45);
            this.btnDeleteExhibition.TabIndex = 96;
            this.btnDeleteExhibition.Text = "Delete Exhibition";
            this.btnDeleteExhibition.UseVisualStyleBackColor = true;
            this.btnDeleteExhibition.Click += new System.EventHandler(this.btnDeleteExhibition_Click);
            // 
            // lblExhibitionHAsArtworks
            // 
            this.lblExhibitionHAsArtworks.AutoSize = true;
            this.lblExhibitionHAsArtworks.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExhibitionHAsArtworks.ForeColor = System.Drawing.Color.Firebrick;
            this.lblExhibitionHAsArtworks.Location = new System.Drawing.Point(496, 170);
            this.lblExhibitionHAsArtworks.Name = "lblExhibitionHAsArtworks";
            this.lblExhibitionHAsArtworks.Size = new System.Drawing.Size(230, 64);
            this.lblExhibitionHAsArtworks.TabIndex = 97;
            this.lblExhibitionHAsArtworks.Text = "This Exhibition has existing artwork or\r\n has already occured, and as a result\r\n " +
    "cannot be deleted. You may only delete \r\nfuture and empty Exhibitions.";
            this.lblExhibitionHAsArtworks.Visible = false;
            // 
            // txtExhibitionIDUpdate
            // 
            this.txtExhibitionIDUpdate.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtExhibitionIDUpdate.ForeColor = System.Drawing.Color.Black;
            this.txtExhibitionIDUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtExhibitionIDUpdate.Location = new System.Drawing.Point(510, 137);
            this.txtExhibitionIDUpdate.Name = "txtExhibitionIDUpdate";
            this.txtExhibitionIDUpdate.ReadOnly = true;
            this.txtExhibitionIDUpdate.Size = new System.Drawing.Size(200, 20);
            this.txtExhibitionIDUpdate.TabIndex = 101;
            this.txtExhibitionIDUpdate.TextChanged += new System.EventHandler(this.txtExhibitionIDUpdate_TextChanged);
            this.txtExhibitionIDUpdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExhibitionIDDelete_KeyPress);
            // 
            // lblExhibitionIDUpdate
            // 
            this.lblExhibitionIDUpdate.AutoSize = true;
            this.lblExhibitionIDUpdate.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExhibitionIDUpdate.ForeColor = System.Drawing.Color.Black;
            this.lblExhibitionIDUpdate.Location = new System.Drawing.Point(507, 117);
            this.lblExhibitionIDUpdate.Name = "lblExhibitionIDUpdate";
            this.lblExhibitionIDUpdate.Size = new System.Drawing.Size(77, 16);
            this.lblExhibitionIDUpdate.TabIndex = 100;
            this.lblExhibitionIDUpdate.Text = "Exhibition ID";
            // 
            // lblExhibitionDateUpdate
            // 
            this.lblExhibitionDateUpdate.AutoSize = true;
            this.lblExhibitionDateUpdate.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExhibitionDateUpdate.ForeColor = System.Drawing.Color.Black;
            this.lblExhibitionDateUpdate.Location = new System.Drawing.Point(507, 162);
            this.lblExhibitionDateUpdate.Name = "lblExhibitionDateUpdate";
            this.lblExhibitionDateUpdate.Size = new System.Drawing.Size(91, 16);
            this.lblExhibitionDateUpdate.TabIndex = 99;
            this.lblExhibitionDateUpdate.Text = "Exhibition Date";
            // 
            // mcExhibitionDateUpdate
            // 
            this.mcExhibitionDateUpdate.Location = new System.Drawing.Point(500, 183);
            this.mcExhibitionDateUpdate.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.mcExhibitionDateUpdate.MaxSelectionCount = 1;
            this.mcExhibitionDateUpdate.MinDate = new System.DateTime(2023, 12, 1, 0, 0, 0, 0);
            this.mcExhibitionDateUpdate.Name = "mcExhibitionDateUpdate";
            this.mcExhibitionDateUpdate.ShowToday = false;
            this.mcExhibitionDateUpdate.ShowTodayCircle = false;
            this.mcExhibitionDateUpdate.TabIndex = 98;
            this.mcExhibitionDateUpdate.TitleBackColor = System.Drawing.SystemColors.Window;
            this.mcExhibitionDateUpdate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mcExhibitionDateUpdate_MouseDown);
            // 
            // btnUpdateExhibition
            // 
            this.btnUpdateExhibition.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateExhibition.Location = new System.Drawing.Point(509, 420);
            this.btnUpdateExhibition.Name = "btnUpdateExhibition";
            this.btnUpdateExhibition.Size = new System.Drawing.Size(201, 45);
            this.btnUpdateExhibition.TabIndex = 102;
            this.btnUpdateExhibition.Text = "Update Exhibition";
            this.btnUpdateExhibition.UseVisualStyleBackColor = true;
            this.btnUpdateExhibition.Click += new System.EventHandler(this.btnUpdateExhibition_Click);
            // 
            // lblCateringNoUpdate
            // 
            this.lblCateringNoUpdate.AutoSize = true;
            this.lblCateringNoUpdate.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCateringNoUpdate.ForeColor = System.Drawing.Color.Black;
            this.lblCateringNoUpdate.Location = new System.Drawing.Point(501, 357);
            this.lblCateringNoUpdate.Name = "lblCateringNoUpdate";
            this.lblCateringNoUpdate.Size = new System.Drawing.Size(101, 16);
            this.lblCateringNoUpdate.TabIndex = 103;
            this.lblCateringNoUpdate.Text = "Catering Number";
            // 
            // nudCateringNumberUpdate
            // 
            this.nudCateringNumberUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCateringNumberUpdate.Location = new System.Drawing.Point(509, 380);
            this.nudCateringNumberUpdate.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCateringNumberUpdate.Name = "nudCateringNumberUpdate";
            this.nudCateringNumberUpdate.Size = new System.Drawing.Size(199, 26);
            this.nudCateringNumberUpdate.TabIndex = 104;
            this.nudCateringNumberUpdate.ValueChanged += new System.EventHandler(this.nudCateringNumberUpdate_ValueChanged);
            this.nudCateringNumberUpdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudExhibitionYearAdd_KeyPress);
            // 
            // FrmExhibitionViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 494);
            this.Controls.Add(this.nudCateringNumberUpdate);
            this.Controls.Add(this.lblCateringNoUpdate);
            this.Controls.Add(this.btnUpdateExhibition);
            this.Controls.Add(this.txtExhibitionIDUpdate);
            this.Controls.Add(this.lblExhibitionIDUpdate);
            this.Controls.Add(this.lblExhibitionDateUpdate);
            this.Controls.Add(this.mcExhibitionDateUpdate);
            this.Controls.Add(this.lblExhibitionHAsArtworks);
            this.Controls.Add(this.btnDeleteExhibition);
            this.Controls.Add(this.txtExhibitionIDDelete);
            this.Controls.Add(this.lblExhibitionIDDelete);
            this.Controls.Add(this.btnAddExhibition);
            this.Controls.Add(this.lblYearFull);
            this.Controls.Add(this.nudExhibitionYearAdd);
            this.Controls.Add(this.lblExhibitionDateAdd);
            this.Controls.Add(this.mcExhibitionDate);
            this.Controls.Add(this.lblExhibitionYearAdd);
            this.Controls.Add(this.btnUpdateMode);
            this.Controls.Add(this.btnDeleteMode);
            this.Controls.Add(this.btnAddMode);
            this.Controls.Add(this.lblheader);
            this.Controls.Add(this.lblNoOfRecords);
            this.Controls.Add(this.dgvPastExhibitions);
            this.Controls.Add(this.dgvFutureExhibitions);
            this.Controls.Add(this.dgvAllExhibitions);
            this.Controls.Add(this.lblFutureExhibitions);
            this.Controls.Add(this.lblPastExhibitions);
            this.Controls.Add(this.lblAllExhibitions);
            this.Controls.Add(this.GuestMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmExhibitionViewer";
            this.Text = "Exhibition Management";
            this.Load += new System.EventHandler(this.FrmExhibitionViewer_Load);
            this.GuestMenuStrip.ResumeLayout(false);
            this.GuestMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllExhibitions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.populateAllExhibitionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.populateAllExhibitions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFutureExhibitions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.populateFutureExhibitionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.populateFutureExhibitions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPastExhibitions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.populatePastExhibitionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.populatePastExhibitions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExhibitionYearAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCateringNumberUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip GuestMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedGuestArtworkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalGuestArtworkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allExhibitionsToolStripMenuItem;
        private System.Windows.Forms.Label lblAllExhibitions;
        private System.Windows.Forms.Label lblPastExhibitions;
        private System.Windows.Forms.Label lblFutureExhibitions;
        private System.Windows.Forms.DataGridView dgvAllExhibitions;
        private DataSets.PopulateAllExhibitions populateAllExhibitions;
        private System.Windows.Forms.BindingSource populateAllExhibitionsBindingSource;
        private DataSets.PopulateAllExhibitionsTableAdapters.PopulateAllExhibitionsTableAdapter populateAllExhibitionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn exhibitionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exhibitionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cateringNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvFutureExhibitions;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataSets.PopulateFutureExhibitions populateFutureExhibitions;
        private System.Windows.Forms.BindingSource populateFutureExhibitionsBindingSource;
        private DataSets.PopulateFutureExhibitionsTableAdapters.PopulateFutureExhibitionsTableAdapter populateFutureExhibitionsTableAdapter;
        private System.Windows.Forms.DataGridView dgvPastExhibitions;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataSets.PopulatePastExhibitions populatePastExhibitions;
        private System.Windows.Forms.BindingSource populatePastExhibitionsBindingSource;
        private DataSets.PopulatePastExhibitionsTableAdapters.PopulatePastExhibitionsTableAdapter populatePastExhibitionsTableAdapter;
        private System.Windows.Forms.Label lblNoOfRecords;
        private System.Windows.Forms.Button btnUpdateMode;
        private System.Windows.Forms.Button btnDeleteMode;
        private System.Windows.Forms.Button btnAddMode;
        private System.Windows.Forms.Label lblheader;
        private System.Windows.Forms.Label lblExhibitionYearAdd;
        private System.Windows.Forms.MonthCalendar mcExhibitionDate;
        private System.Windows.Forms.Label lblExhibitionDateAdd;
        private System.Windows.Forms.NumericUpDown nudExhibitionYearAdd;
        private System.Windows.Forms.Label lblYearFull;
        private System.Windows.Forms.Button btnAddExhibition;
        private System.Windows.Forms.TextBox txtExhibitionIDDelete;
        private System.Windows.Forms.Label lblExhibitionIDDelete;
        private System.Windows.Forms.Button btnDeleteExhibition;
        private System.Windows.Forms.Label lblExhibitionHAsArtworks;
        private System.Windows.Forms.TextBox txtExhibitionIDUpdate;
        private System.Windows.Forms.Label lblExhibitionIDUpdate;
        private System.Windows.Forms.Label lblExhibitionDateUpdate;
        private System.Windows.Forms.MonthCalendar mcExhibitionDateUpdate;
        private System.Windows.Forms.Button btnUpdateExhibition;
        private System.Windows.Forms.Label lblCateringNoUpdate;
        private System.Windows.Forms.NumericUpDown nudCateringNumberUpdate;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guestManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guestManagementToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logEquipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guestInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseMaagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeABookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getCourseReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artworkManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem1;
    }
}