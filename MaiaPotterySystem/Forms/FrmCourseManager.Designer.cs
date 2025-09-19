namespace PotteryDBA_V1._0.Forms
{
    partial class FrmCourseManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCourseManager));
            this.GuestMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestManagementToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logEquipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseMaagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeABookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getCourseReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exhibitionManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artworkManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvCoursesOut = new System.Windows.Forms.DataGridView();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullyBookedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseDetails = new PotteryDBA_V1._0.DataSets.CourseDetails();
            this.lblSearch = new System.Windows.Forms.Label();
            this.courseTableAdapter = new PotteryDBA_V1._0.DataSets.CourseDetailsTableAdapters.CourseTableAdapter();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.rbSearchEDnabled = new System.Windows.Forms.RadioButton();
            this.lblNoResults = new System.Windows.Forms.Label();
            this.lblNoOfRecords = new System.Windows.Forms.Label();
            this.lblAddGuestDetails = new System.Windows.Forms.Label();
            this.cbxSkillLevel = new System.Windows.Forms.ComboBox();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.lblSkillLevel = new System.Windows.Forms.Label();
            this.lblCourseType = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDateEntry = new System.Windows.Forms.DateTimePicker();
            this.ckbxWeekend = new System.Windows.Forms.CheckBox();
            this.ckbxFiveday = new System.Windows.Forms.CheckBox();
            this.btnAddMode = new System.Windows.Forms.Button();
            this.btnDeleteMode = new System.Windows.Forms.Button();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.lblCourseCode = new System.Windows.Forms.Label();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.GuestMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoursesOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // GuestMenuStrip
            // 
            this.GuestMenuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.GuestMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.openToolStripMenuItem});
            this.GuestMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.GuestMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.GuestMenuStrip.Name = "GuestMenuStrip";
            this.GuestMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.GuestMenuStrip.Size = new System.Drawing.Size(944, 23);
            this.GuestMenuStrip.TabIndex = 21;
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
            this.guestManagementToolStripMenuItem1,
            this.logEquipmentToolStripMenuItem,
            this.guestInvoiceToolStripMenuItem});
            this.guestManagementToolStripMenuItem.Name = "guestManagementToolStripMenuItem";
            this.guestManagementToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
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
            this.makeABookingToolStripMenuItem,
            this.getCourseReportToolStripMenuItem});
            this.courseMaagementToolStripMenuItem.Name = "courseMaagementToolStripMenuItem";
            this.courseMaagementToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.courseMaagementToolStripMenuItem.Text = "Course Management";
            this.courseMaagementToolStripMenuItem.Click += new System.EventHandler(this.courseMaagementToolStripMenuItem_Click);
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
            // dgvCoursesOut
            // 
            this.dgvCoursesOut.AllowUserToAddRows = false;
            this.dgvCoursesOut.AllowUserToDeleteRows = false;
            this.dgvCoursesOut.AllowUserToResizeColumns = false;
            this.dgvCoursesOut.AllowUserToResizeRows = false;
            this.dgvCoursesOut.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCoursesOut.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCoursesOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoursesOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseIDDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.courseTypeDataGridViewTextBoxColumn,
            this.skillLevelDataGridViewTextBoxColumn,
            this.courseCostDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.fullyBookedDataGridViewCheckBoxColumn});
            this.dgvCoursesOut.DataSource = this.courseBindingSource;
            this.dgvCoursesOut.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCoursesOut.EnableHeadersVisualStyles = false;
            this.dgvCoursesOut.GridColor = System.Drawing.Color.Black;
            this.dgvCoursesOut.Location = new System.Drawing.Point(15, 55);
            this.dgvCoursesOut.MultiSelect = false;
            this.dgvCoursesOut.Name = "dgvCoursesOut";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCoursesOut.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvCoursesOut.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCoursesOut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCoursesOut.Size = new System.Drawing.Size(696, 427);
            this.dgvCoursesOut.TabIndex = 22;
            this.dgvCoursesOut.SelectionChanged += new System.EventHandler(this.dgvCoursesOut_SelectionChanged);
            // 
            // courseIDDataGridViewTextBoxColumn
            // 
            this.courseIDDataGridViewTextBoxColumn.DataPropertyName = "CourseID";
            this.courseIDDataGridViewTextBoxColumn.HeaderText = "Course ID";
            this.courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
            this.courseIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.courseIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "Start Date";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.Width = 85;
            // 
            // courseTypeDataGridViewTextBoxColumn
            // 
            this.courseTypeDataGridViewTextBoxColumn.DataPropertyName = "CourseType";
            this.courseTypeDataGridViewTextBoxColumn.HeaderText = "Course Type";
            this.courseTypeDataGridViewTextBoxColumn.Name = "courseTypeDataGridViewTextBoxColumn";
            // 
            // skillLevelDataGridViewTextBoxColumn
            // 
            this.skillLevelDataGridViewTextBoxColumn.DataPropertyName = "SkillLevel";
            this.skillLevelDataGridViewTextBoxColumn.HeaderText = "Skill Level";
            this.skillLevelDataGridViewTextBoxColumn.Name = "skillLevelDataGridViewTextBoxColumn";
            // 
            // courseCostDataGridViewTextBoxColumn
            // 
            this.courseCostDataGridViewTextBoxColumn.DataPropertyName = "CourseCost";
            this.courseCostDataGridViewTextBoxColumn.HeaderText = "Course Cost";
            this.courseCostDataGridViewTextBoxColumn.Name = "courseCostDataGridViewTextBoxColumn";
            this.courseCostDataGridViewTextBoxColumn.Width = 90;
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "Capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "Capacity";
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            this.capacityDataGridViewTextBoxColumn.Width = 70;
            // 
            // fullyBookedDataGridViewCheckBoxColumn
            // 
            this.fullyBookedDataGridViewCheckBoxColumn.DataPropertyName = "FullyBooked";
            this.fullyBookedDataGridViewCheckBoxColumn.HeaderText = "Fully Booked?";
            this.fullyBookedDataGridViewCheckBoxColumn.Name = "fullyBookedDataGridViewCheckBoxColumn";
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.courseDetails;
            // 
            // courseDetails
            // 
            this.courseDetails.DataSetName = "CourseDetails";
            this.courseDetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Black;
            this.lblSearch.Location = new System.Drawing.Point(56, 29);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(49, 16);
            this.lblSearch.TabIndex = 28;
            this.lblSearch.Text = "Search:";
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(108, 28);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(125, 20);
            this.dtpStartDate.TabIndex = 29;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(240, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "to";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(263, 28);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(125, 20);
            this.dtpEndDate.TabIndex = 31;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // rbSearchEDnabled
            // 
            this.rbSearchEDnabled.AutoSize = true;
            this.rbSearchEDnabled.Location = new System.Drawing.Point(42, 30);
            this.rbSearchEDnabled.Name = "rbSearchEDnabled";
            this.rbSearchEDnabled.Size = new System.Drawing.Size(14, 13);
            this.rbSearchEDnabled.TabIndex = 32;
            this.rbSearchEDnabled.TabStop = true;
            this.rbSearchEDnabled.UseVisualStyleBackColor = true;
            this.rbSearchEDnabled.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.rbSearchEDnabled.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // lblNoResults
            // 
            this.lblNoResults.AutoSize = true;
            this.lblNoResults.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblNoResults.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoResults.Location = new System.Drawing.Point(299, 246);
            this.lblNoResults.Name = "lblNoResults";
            this.lblNoResults.Size = new System.Drawing.Size(119, 27);
            this.lblNoResults.TabIndex = 34;
            this.lblNoResults.Text = "No Results";
            // 
            // lblNoOfRecords
            // 
            this.lblNoOfRecords.AutoSize = true;
            this.lblNoOfRecords.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfRecords.ForeColor = System.Drawing.Color.Black;
            this.lblNoOfRecords.Location = new System.Drawing.Point(785, 473);
            this.lblNoOfRecords.Name = "lblNoOfRecords";
            this.lblNoOfRecords.Size = new System.Drawing.Size(147, 16);
            this.lblNoOfRecords.TabIndex = 35;
            this.lblNoOfRecords.Text = "Number of Records: 0000";
            this.lblNoOfRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAddGuestDetails
            // 
            this.lblAddGuestDetails.AutoSize = true;
            this.lblAddGuestDetails.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddGuestDetails.ForeColor = System.Drawing.Color.Black;
            this.lblAddGuestDetails.Location = new System.Drawing.Point(749, 25);
            this.lblAddGuestDetails.Name = "lblAddGuestDetails";
            this.lblAddGuestDetails.Size = new System.Drawing.Size(157, 27);
            this.lblAddGuestDetails.TabIndex = 36;
            this.lblAddGuestDetails.Text = "Course Details";
            // 
            // cbxSkillLevel
            // 
            this.cbxSkillLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSkillLevel.FormattingEnabled = true;
            this.cbxSkillLevel.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Advanced"});
            this.cbxSkillLevel.Location = new System.Drawing.Point(727, 179);
            this.cbxSkillLevel.Name = "cbxSkillLevel";
            this.cbxSkillLevel.Size = new System.Drawing.Size(200, 21);
            this.cbxSkillLevel.TabIndex = 52;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.Location = new System.Drawing.Point(726, 209);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(199, 45);
            this.btnAddCourse.TabIndex = 51;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // lblSkillLevel
            // 
            this.lblSkillLevel.AutoSize = true;
            this.lblSkillLevel.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkillLevel.ForeColor = System.Drawing.Color.Black;
            this.lblSkillLevel.Location = new System.Drawing.Point(725, 158);
            this.lblSkillLevel.Name = "lblSkillLevel";
            this.lblSkillLevel.Size = new System.Drawing.Size(63, 16);
            this.lblSkillLevel.TabIndex = 41;
            this.lblSkillLevel.Text = "Skill Level";
            this.lblSkillLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCourseType
            // 
            this.lblCourseType.AutoSize = true;
            this.lblCourseType.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseType.ForeColor = System.Drawing.Color.Black;
            this.lblCourseType.Location = new System.Drawing.Point(725, 62);
            this.lblCourseType.Name = "lblCourseType";
            this.lblCourseType.Size = new System.Drawing.Size(76, 16);
            this.lblCourseType.TabIndex = 39;
            this.lblCourseType.Text = "Course Type";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.Black;
            this.lblStartDate.Location = new System.Drawing.Point(725, 109);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(64, 16);
            this.lblStartDate.TabIndex = 37;
            this.lblStartDate.Text = "Start Date";
            // 
            // dtpStartDateEntry
            // 
            this.dtpStartDateEntry.Location = new System.Drawing.Point(728, 130);
            this.dtpStartDateEntry.Name = "dtpStartDateEntry";
            this.dtpStartDateEntry.Size = new System.Drawing.Size(199, 20);
            this.dtpStartDateEntry.TabIndex = 56;
            this.dtpStartDateEntry.ValueChanged += new System.EventHandler(this.dtpStartDateEntry_ValueChanged);
            // 
            // ckbxWeekend
            // 
            this.ckbxWeekend.AutoSize = true;
            this.ckbxWeekend.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.ckbxWeekend.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbxWeekend.Location = new System.Drawing.Point(749, 84);
            this.ckbxWeekend.Name = "ckbxWeekend";
            this.ckbxWeekend.Size = new System.Drawing.Size(72, 18);
            this.ckbxWeekend.TabIndex = 57;
            this.ckbxWeekend.Text = "Weekend";
            this.ckbxWeekend.UseVisualStyleBackColor = true;
            this.ckbxWeekend.CheckedChanged += new System.EventHandler(this.ckbxWeekend_Changed);
            // 
            // ckbxFiveday
            // 
            this.ckbxFiveday.AutoSize = true;
            this.ckbxFiveday.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbxFiveday.Location = new System.Drawing.Point(835, 84);
            this.ckbxFiveday.Name = "ckbxFiveday";
            this.ckbxFiveday.Size = new System.Drawing.Size(71, 18);
            this.ckbxFiveday.TabIndex = 58;
            this.ckbxFiveday.Text = "Five-Day";
            this.ckbxFiveday.UseVisualStyleBackColor = true;
            this.ckbxFiveday.CheckedChanged += new System.EventHandler(this.ckbxFiveday_Changed);
            // 
            // btnAddMode
            // 
            this.btnAddMode.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMode.Location = new System.Drawing.Point(727, 260);
            this.btnAddMode.Name = "btnAddMode";
            this.btnAddMode.Size = new System.Drawing.Size(90, 31);
            this.btnAddMode.TabIndex = 59;
            this.btnAddMode.Text = "Add Mode";
            this.btnAddMode.UseVisualStyleBackColor = true;
            this.btnAddMode.Click += new System.EventHandler(this.btnAddMode_Click);
            // 
            // btnDeleteMode
            // 
            this.btnDeleteMode.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMode.Location = new System.Drawing.Point(835, 260);
            this.btnDeleteMode.Name = "btnDeleteMode";
            this.btnDeleteMode.Size = new System.Drawing.Size(90, 31);
            this.btnDeleteMode.TabIndex = 60;
            this.btnDeleteMode.Text = "Delete Mode";
            this.btnDeleteMode.UseVisualStyleBackColor = true;
            this.btnDeleteMode.Click += new System.EventHandler(this.btnDeleteMode_Click);
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCourse.Location = new System.Drawing.Point(727, 208);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(199, 45);
            this.btnDeleteCourse.TabIndex = 61;
            this.btnDeleteCourse.Text = "Delete Course";
            this.btnDeleteCourse.UseVisualStyleBackColor = true;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // lblCourseCode
            // 
            this.lblCourseCode.AutoSize = true;
            this.lblCourseCode.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseCode.ForeColor = System.Drawing.Color.Black;
            this.lblCourseCode.Location = new System.Drawing.Point(723, 62);
            this.lblCourseCode.Name = "lblCourseCode";
            this.lblCourseCode.Size = new System.Drawing.Size(62, 16);
            this.lblCourseCode.TabIndex = 62;
            this.lblCourseCode.Text = "Course ID";
            this.lblCourseCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(726, 86);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(200, 20);
            this.txtCourseID.TabIndex = 63;
            this.txtCourseID.TextChanged += new System.EventHandler(this.txtCourseID_TextChanged);
            this.txtCourseID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCourseID_KeyPress);
            // 
            // FrmCourseManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 498);
            this.Controls.Add(this.txtCourseID);
            this.Controls.Add(this.lblCourseCode);
            this.Controls.Add(this.btnDeleteCourse);
            this.Controls.Add(this.btnDeleteMode);
            this.Controls.Add(this.btnAddMode);
            this.Controls.Add(this.ckbxFiveday);
            this.Controls.Add(this.ckbxWeekend);
            this.Controls.Add(this.dtpStartDateEntry);
            this.Controls.Add(this.cbxSkillLevel);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.lblSkillLevel);
            this.Controls.Add(this.lblCourseType);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblAddGuestDetails);
            this.Controls.Add(this.lblNoOfRecords);
            this.Controls.Add(this.lblNoResults);
            this.Controls.Add(this.rbSearchEDnabled);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvCoursesOut);
            this.Controls.Add(this.GuestMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCourseManager";
            this.Text = "Course Management";
            this.Load += new System.EventHandler(this.FrmCourseManager_Load);
            this.GuestMenuStrip.ResumeLayout(false);
            this.GuestMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoursesOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDetails)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvCoursesOut;
        private System.Windows.Forms.Label lblSearch;
        private DataSets.CourseDetails courseDetails;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private DataSets.CourseDetailsTableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.RadioButton rbSearchEDnabled;
        private System.Windows.Forms.Label lblNoResults;
        private System.Windows.Forms.Label lblNoOfRecords;
        private System.Windows.Forms.Label lblAddGuestDetails;
        private System.Windows.Forms.ComboBox cbxSkillLevel;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Label lblSkillLevel;
        private System.Windows.Forms.Label lblCourseType;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDateEntry;
        private System.Windows.Forms.CheckBox ckbxWeekend;
        private System.Windows.Forms.CheckBox ckbxFiveday;
        private System.Windows.Forms.Button btnAddMode;
        private System.Windows.Forms.Button btnDeleteMode;
        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.Label lblCourseCode;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fullyBookedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guestManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guestManagementToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logEquipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guestInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseMaagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeABookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getCourseReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exhibitionManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artworkManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem1;
    }
}