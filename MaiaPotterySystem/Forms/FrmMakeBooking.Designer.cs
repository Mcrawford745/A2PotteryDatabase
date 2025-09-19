namespace PotteryDBA_V1._0.Forms
{
    partial class FrmMakeBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMakeBooking));
            this.dgvBookingAvailable = new System.Windows.Forms.DataGridView();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skilllevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getTableForBookingManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingManagerSetFromProcedure = new PotteryDBA_V1._0.DataSets.BookingManagerSetFromProcedure();
            this.getTableForBookingManagerTableAdapter = new PotteryDBA_V1._0.DataSets.BookingManagerSetFromProcedureTableAdapters.GetTableForBookingManagerTableAdapter();
            this.GuestMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAvailableCourses = new System.Windows.Forms.Label();
            this.lblNoOfRecords = new System.Windows.Forms.Label();
            this.txtGuestID = new System.Windows.Forms.TextBox();
            this.lblGuestID = new System.Windows.Forms.Label();
            this.lblDetailEntry = new System.Windows.Forms.Label();
            this.lblSur = new System.Windows.Forms.Label();
            this.lblFore = new System.Windows.Forms.Label();
            this.lblNoResults = new System.Windows.Forms.Label();
            this.cbxCourseID = new System.Windows.Forms.ComboBox();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.btnMakeBooking = new System.Windows.Forms.Button();
            this.lblexistingbooking = new System.Windows.Forms.Label();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestManagementToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logEquipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseMaagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getCourseReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exhibitionManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artworkManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getTableForBookingManagerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingManagerSetFromProcedure)).BeginInit();
            this.GuestMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBookingAvailable
            // 
            this.dgvBookingAvailable.AllowUserToAddRows = false;
            this.dgvBookingAvailable.AllowUserToDeleteRows = false;
            this.dgvBookingAvailable.AutoGenerateColumns = false;
            this.dgvBookingAvailable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookingAvailable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseIDDataGridViewTextBoxColumn,
            this.skilllevelDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn});
            this.dgvBookingAvailable.DataSource = this.getTableForBookingManagerBindingSource;
            this.dgvBookingAvailable.Location = new System.Drawing.Point(17, 72);
            this.dgvBookingAvailable.Name = "dgvBookingAvailable";
            this.dgvBookingAvailable.ReadOnly = true;
            this.dgvBookingAvailable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookingAvailable.Size = new System.Drawing.Size(363, 358);
            this.dgvBookingAvailable.TabIndex = 0;
            this.dgvBookingAvailable.SelectionChanged += new System.EventHandler(this.dgvBookingAvailable_SelectionChanged);
            // 
            // courseIDDataGridViewTextBoxColumn
            // 
            this.courseIDDataGridViewTextBoxColumn.DataPropertyName = "CourseID";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.courseIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.courseIDDataGridViewTextBoxColumn.HeaderText = "Course ID";
            this.courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
            this.courseIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // skilllevelDataGridViewTextBoxColumn
            // 
            this.skilllevelDataGridViewTextBoxColumn.DataPropertyName = "Skilllevel";
            this.skilllevelDataGridViewTextBoxColumn.HeaderText = "Skill Level";
            this.skilllevelDataGridViewTextBoxColumn.Name = "skilllevelDataGridViewTextBoxColumn";
            this.skilllevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "Start Date";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getTableForBookingManagerBindingSource
            // 
            this.getTableForBookingManagerBindingSource.DataMember = "GetTableForBookingManager";
            this.getTableForBookingManagerBindingSource.DataSource = this.bookingManagerSetFromProcedure;
            // 
            // bookingManagerSetFromProcedure
            // 
            this.bookingManagerSetFromProcedure.DataSetName = "BookingManagerSetFromProcedure";
            this.bookingManagerSetFromProcedure.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getTableForBookingManagerTableAdapter
            // 
            this.getTableForBookingManagerTableAdapter.ClearBeforeFill = true;
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
            this.GuestMenuStrip.Size = new System.Drawing.Size(657, 23);
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
            // lblAvailableCourses
            // 
            this.lblAvailableCourses.AutoSize = true;
            this.lblAvailableCourses.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableCourses.ForeColor = System.Drawing.Color.Black;
            this.lblAvailableCourses.Location = new System.Drawing.Point(12, 36);
            this.lblAvailableCourses.Name = "lblAvailableCourses";
            this.lblAvailableCourses.Size = new System.Drawing.Size(188, 27);
            this.lblAvailableCourses.TabIndex = 22;
            this.lblAvailableCourses.Text = "Available Courses";
            // 
            // lblNoOfRecords
            // 
            this.lblNoOfRecords.AutoSize = true;
            this.lblNoOfRecords.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfRecords.ForeColor = System.Drawing.Color.Black;
            this.lblNoOfRecords.Location = new System.Drawing.Point(498, 414);
            this.lblNoOfRecords.Name = "lblNoOfRecords";
            this.lblNoOfRecords.Size = new System.Drawing.Size(147, 16);
            this.lblNoOfRecords.TabIndex = 23;
            this.lblNoOfRecords.Text = "Number of Records: 0000";
            this.lblNoOfRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGuestID
            // 
            this.txtGuestID.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtGuestID.ForeColor = System.Drawing.Color.Black;
            this.txtGuestID.Location = new System.Drawing.Point(421, 100);
            this.txtGuestID.Name = "txtGuestID";
            this.txtGuestID.Size = new System.Drawing.Size(200, 20);
            this.txtGuestID.TabIndex = 27;
            this.txtGuestID.TextChanged += new System.EventHandler(this.txtGuestID_TextChanged);
            // 
            // lblGuestID
            // 
            this.lblGuestID.AutoSize = true;
            this.lblGuestID.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestID.ForeColor = System.Drawing.Color.Black;
            this.lblGuestID.Location = new System.Drawing.Point(418, 81);
            this.lblGuestID.Name = "lblGuestID";
            this.lblGuestID.Size = new System.Drawing.Size(56, 16);
            this.lblGuestID.TabIndex = 26;
            this.lblGuestID.Text = "Guest ID";
            // 
            // lblDetailEntry
            // 
            this.lblDetailEntry.AutoSize = true;
            this.lblDetailEntry.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailEntry.ForeColor = System.Drawing.Color.Black;
            this.lblDetailEntry.Location = new System.Drawing.Point(454, 36);
            this.lblDetailEntry.Name = "lblDetailEntry";
            this.lblDetailEntry.Size = new System.Drawing.Size(167, 27);
            this.lblDetailEntry.TabIndex = 28;
            this.lblDetailEntry.Text = "Booking Details";
            // 
            // lblSur
            // 
            this.lblSur.AutoSize = true;
            this.lblSur.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSur.ForeColor = System.Drawing.Color.Black;
            this.lblSur.Location = new System.Drawing.Point(423, 140);
            this.lblSur.Name = "lblSur";
            this.lblSur.Size = new System.Drawing.Size(60, 16);
            this.lblSur.TabIndex = 31;
            this.lblSur.Text = "Surname:";
            // 
            // lblFore
            // 
            this.lblFore.AutoSize = true;
            this.lblFore.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFore.ForeColor = System.Drawing.Color.Black;
            this.lblFore.Location = new System.Drawing.Point(418, 124);
            this.lblFore.Name = "lblFore";
            this.lblFore.Size = new System.Drawing.Size(68, 16);
            this.lblFore.TabIndex = 30;
            this.lblFore.Text = "Forename: ";
            // 
            // lblNoResults
            // 
            this.lblNoResults.AutoSize = true;
            this.lblNoResults.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblNoResults.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoResults.Location = new System.Drawing.Point(83, 250);
            this.lblNoResults.Name = "lblNoResults";
            this.lblNoResults.Size = new System.Drawing.Size(222, 27);
            this.lblNoResults.TabIndex = 34;
            this.lblNoResults.Text = "No Available Courses";
            // 
            // cbxCourseID
            // 
            this.cbxCourseID.BackColor = System.Drawing.SystemColors.Window;
            this.cbxCourseID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCourseID.FormattingEnabled = true;
            this.cbxCourseID.Location = new System.Drawing.Point(421, 197);
            this.cbxCourseID.Name = "cbxCourseID";
            this.cbxCourseID.Size = new System.Drawing.Size(198, 21);
            this.cbxCourseID.TabIndex = 35;
            this.cbxCourseID.TextChanged += new System.EventHandler(this.cbxCourseID_SelectedIndexChanged);
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseID.ForeColor = System.Drawing.Color.Black;
            this.lblCourseID.Location = new System.Drawing.Point(418, 176);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(62, 16);
            this.lblCourseID.TabIndex = 36;
            this.lblCourseID.Text = "Course ID";
            // 
            // btnMakeBooking
            // 
            this.btnMakeBooking.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeBooking.Location = new System.Drawing.Point(421, 247);
            this.btnMakeBooking.Name = "btnMakeBooking";
            this.btnMakeBooking.Size = new System.Drawing.Size(199, 45);
            this.btnMakeBooking.TabIndex = 37;
            this.btnMakeBooking.Text = "Make Booking";
            this.btnMakeBooking.UseVisualStyleBackColor = true;
            this.btnMakeBooking.Click += new System.EventHandler(this.btnMakeBooking_Click);
            // 
            // lblexistingbooking
            // 
            this.lblexistingbooking.AutoSize = true;
            this.lblexistingbooking.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexistingbooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblexistingbooking.Location = new System.Drawing.Point(395, 305);
            this.lblexistingbooking.Name = "lblexistingbooking";
            this.lblexistingbooking.Size = new System.Drawing.Size(250, 48);
            this.lblexistingbooking.TabIndex = 38;
            this.lblexistingbooking.Text = "This guest already has a booking for the\r\n selected course. Courses cannot be boo" +
    "ked\r\n twice, please choose a different course.";
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
            this.guestManagementToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.guestManagementToolStripMenuItem1.Text = "Guest Management";
            this.guestManagementToolStripMenuItem1.Click += new System.EventHandler(this.guestManagementToolStripMenuItem1_Click);
            // 
            // logEquipmentToolStripMenuItem
            // 
            this.logEquipmentToolStripMenuItem.Name = "logEquipmentToolStripMenuItem";
            this.logEquipmentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logEquipmentToolStripMenuItem.Text = "Log Equipment";
            this.logEquipmentToolStripMenuItem.Click += new System.EventHandler(this.logEquipmentToolStripMenuItem_Click);
            // 
            // guestInvoiceToolStripMenuItem
            // 
            this.guestInvoiceToolStripMenuItem.Name = "guestInvoiceToolStripMenuItem";
            this.guestInvoiceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guestInvoiceToolStripMenuItem.Text = "Guest Invoice";
            this.guestInvoiceToolStripMenuItem.Click += new System.EventHandler(this.guestInvoiceToolStripMenuItem_Click);
            // 
            // courseMaagementToolStripMenuItem
            // 
            this.courseMaagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.courseManagerToolStripMenuItem,
            this.getCourseReportToolStripMenuItem});
            this.courseMaagementToolStripMenuItem.Name = "courseMaagementToolStripMenuItem";
            this.courseMaagementToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.courseMaagementToolStripMenuItem.Text = "Course Management";
            this.courseMaagementToolStripMenuItem.Click += new System.EventHandler(this.courseMaagementToolStripMenuItem_Click);
            // 
            // courseManagerToolStripMenuItem
            // 
            this.courseManagerToolStripMenuItem.Name = "courseManagerToolStripMenuItem";
            this.courseManagerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.courseManagerToolStripMenuItem.Text = "Course Manager";
            this.courseManagerToolStripMenuItem.Click += new System.EventHandler(this.courseManagerToolStripMenuItem_Click);
            // 
            // getCourseReportToolStripMenuItem
            // 
            this.getCourseReportToolStripMenuItem.Name = "getCourseReportToolStripMenuItem";
            this.getCourseReportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            // FrmMakeBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(this.lblexistingbooking);
            this.Controls.Add(this.btnMakeBooking);
            this.Controls.Add(this.lblCourseID);
            this.Controls.Add(this.cbxCourseID);
            this.Controls.Add(this.lblNoResults);
            this.Controls.Add(this.lblSur);
            this.Controls.Add(this.lblFore);
            this.Controls.Add(this.lblDetailEntry);
            this.Controls.Add(this.txtGuestID);
            this.Controls.Add(this.lblGuestID);
            this.Controls.Add(this.lblNoOfRecords);
            this.Controls.Add(this.lblAvailableCourses);
            this.Controls.Add(this.GuestMenuStrip);
            this.Controls.Add(this.dgvBookingAvailable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMakeBooking";
            this.Text = "Booking Manager";
            this.Load += new System.EventHandler(this.FrmMakeBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getTableForBookingManagerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingManagerSetFromProcedure)).EndInit();
            this.GuestMenuStrip.ResumeLayout(false);
            this.GuestMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBookingAvailable;
        private DataSets.BookingManagerSetFromProcedure bookingManagerSetFromProcedure;
        private System.Windows.Forms.BindingSource getTableForBookingManagerBindingSource;
        private DataSets.BookingManagerSetFromProcedureTableAdapters.GetTableForBookingManagerTableAdapter getTableForBookingManagerTableAdapter;
        private System.Windows.Forms.MenuStrip GuestMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label lblAvailableCourses;
        private System.Windows.Forms.Label lblNoOfRecords;
        private System.Windows.Forms.TextBox txtGuestID;
        private System.Windows.Forms.Label lblGuestID;
        private System.Windows.Forms.Label lblDetailEntry;
        private System.Windows.Forms.Label lblSur;
        private System.Windows.Forms.Label lblFore;
        private System.Windows.Forms.Label lblNoResults;
        private System.Windows.Forms.ComboBox cbxCourseID;
        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.Button btnMakeBooking;
        private System.Windows.Forms.Label lblexistingbooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skilllevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guestManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guestManagementToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logEquipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guestInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseMaagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getCourseReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exhibitionManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artworkManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem1;
    }
}