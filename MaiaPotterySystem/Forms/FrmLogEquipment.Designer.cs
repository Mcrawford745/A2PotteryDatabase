namespace PotteryDBA_V1._0.Forms
{
    partial class FrmLogEquipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogEquipment));
            this.LblLogEquipmentTitle = new System.Windows.Forms.Label();
            this.GuestMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestManagementToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guestInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseMaagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeABookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getCourseReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exhibitionManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artworkManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtGuestID = new System.Windows.Forms.TextBox();
            this.lblGuestID = new System.Windows.Forms.Label();
            this.lblFore = new System.Windows.Forms.Label();
            this.lblSur = new System.Windows.Forms.Label();
            this.cbxItemType = new System.Windows.Forms.ComboBox();
            this.lblItemType = new System.Windows.Forms.Label();
            this.cbxClayItemName = new System.Windows.Forms.ComboBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.cbxGlazeItemName = new System.Windows.Forms.ComboBox();
            this.cbxPaintItemName = new System.Windows.Forms.ComboBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblInPounds = new System.Windows.Forms.Label();
            this.lblInPints = new System.Windows.Forms.Label();
            this.lblInOunces = new System.Windows.Forms.Label();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.cbxCourseOptions = new System.Windows.Forms.ComboBox();
            this.lblCourseOptions = new System.Windows.Forms.Label();
            this.btnLogEquipment = new System.Windows.Forms.Button();
            this.GuestMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // LblLogEquipmentTitle
            // 
            this.LblLogEquipmentTitle.AutoSize = true;
            this.LblLogEquipmentTitle.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogEquipmentTitle.ForeColor = System.Drawing.Color.Black;
            this.LblLogEquipmentTitle.Location = new System.Drawing.Point(95, 34);
            this.LblLogEquipmentTitle.Name = "LblLogEquipmentTitle";
            this.LblLogEquipmentTitle.Size = new System.Drawing.Size(204, 27);
            this.LblLogEquipmentTitle.TabIndex = 2;
            this.LblLogEquipmentTitle.Text = "Log Equipment Use";
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
            this.GuestMenuStrip.Size = new System.Drawing.Size(389, 23);
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
            // txtGuestID
            // 
            this.txtGuestID.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtGuestID.ForeColor = System.Drawing.Color.Black;
            this.txtGuestID.Location = new System.Drawing.Point(96, 88);
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
            this.lblGuestID.Location = new System.Drawing.Point(93, 69);
            this.lblGuestID.Name = "lblGuestID";
            this.lblGuestID.Size = new System.Drawing.Size(56, 16);
            this.lblGuestID.TabIndex = 26;
            this.lblGuestID.Text = "Guest ID";
            // 
            // lblFore
            // 
            this.lblFore.AutoSize = true;
            this.lblFore.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFore.ForeColor = System.Drawing.Color.Black;
            this.lblFore.Location = new System.Drawing.Point(97, 111);
            this.lblFore.Name = "lblFore";
            this.lblFore.Size = new System.Drawing.Size(68, 16);
            this.lblFore.TabIndex = 28;
            this.lblFore.Text = "Forename: ";
            // 
            // lblSur
            // 
            this.lblSur.AutoSize = true;
            this.lblSur.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSur.ForeColor = System.Drawing.Color.Black;
            this.lblSur.Location = new System.Drawing.Point(102, 127);
            this.lblSur.Name = "lblSur";
            this.lblSur.Size = new System.Drawing.Size(60, 16);
            this.lblSur.TabIndex = 29;
            this.lblSur.Text = "Surname:";
            // 
            // cbxItemType
            // 
            this.cbxItemType.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbxItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxItemType.ForeColor = System.Drawing.Color.Black;
            this.cbxItemType.FormattingEnabled = true;
            this.cbxItemType.Items.AddRange(new object[] {
            "Clay",
            "Glaze",
            "Paint"});
            this.cbxItemType.Location = new System.Drawing.Point(96, 216);
            this.cbxItemType.Name = "cbxItemType";
            this.cbxItemType.Size = new System.Drawing.Size(200, 21);
            this.cbxItemType.TabIndex = 31;
            this.cbxItemType.SelectedIndexChanged += new System.EventHandler(this.cbxItemType_SelectedIndexChanged);
            this.cbxItemType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.myCombo_KeyPress);
            // 
            // lblItemType
            // 
            this.lblItemType.AutoSize = true;
            this.lblItemType.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemType.ForeColor = System.Drawing.Color.Black;
            this.lblItemType.Location = new System.Drawing.Point(93, 197);
            this.lblItemType.Name = "lblItemType";
            this.lblItemType.Size = new System.Drawing.Size(62, 16);
            this.lblItemType.TabIndex = 30;
            this.lblItemType.Text = "Item Type";
            this.lblItemType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxClayItemName
            // 
            this.cbxClayItemName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbxClayItemName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxClayItemName.ForeColor = System.Drawing.Color.Black;
            this.cbxClayItemName.FormattingEnabled = true;
            this.cbxClayItemName.Items.AddRange(new object[] {
            "Earthenware",
            "Stoneware",
            "Porcelain",
            "Raku"});
            this.cbxClayItemName.Location = new System.Drawing.Point(96, 269);
            this.cbxClayItemName.Name = "cbxClayItemName";
            this.cbxClayItemName.Size = new System.Drawing.Size(200, 21);
            this.cbxClayItemName.TabIndex = 33;
            this.cbxClayItemName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.myCombo_KeyPress);
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.Color.Black;
            this.lblItemName.Location = new System.Drawing.Point(93, 250);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(68, 16);
            this.lblItemName.TabIndex = 32;
            this.lblItemName.Text = "Item Name";
            this.lblItemName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxGlazeItemName
            // 
            this.cbxGlazeItemName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbxGlazeItemName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGlazeItemName.ForeColor = System.Drawing.Color.Black;
            this.cbxGlazeItemName.FormattingEnabled = true;
            this.cbxGlazeItemName.Items.AddRange(new object[] {
            "Majolica",
            "Celadon",
            "Crystalline",
            "Raku"});
            this.cbxGlazeItemName.Location = new System.Drawing.Point(96, 269);
            this.cbxGlazeItemName.Name = "cbxGlazeItemName";
            this.cbxGlazeItemName.Size = new System.Drawing.Size(200, 21);
            this.cbxGlazeItemName.TabIndex = 34;
            this.cbxGlazeItemName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.myCombo_KeyPress);
            // 
            // cbxPaintItemName
            // 
            this.cbxPaintItemName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbxPaintItemName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPaintItemName.ForeColor = System.Drawing.Color.Black;
            this.cbxPaintItemName.FormattingEnabled = true;
            this.cbxPaintItemName.Items.AddRange(new object[] {
            "Underglaze",
            "Overglaze",
            "Majolica",
            "Metallic"});
            this.cbxPaintItemName.Location = new System.Drawing.Point(96, 269);
            this.cbxPaintItemName.Name = "cbxPaintItemName";
            this.cbxPaintItemName.Size = new System.Drawing.Size(200, 21);
            this.cbxPaintItemName.TabIndex = 35;
            this.cbxPaintItemName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.myCombo_KeyPress);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.Black;
            this.lblAmount.Location = new System.Drawing.Point(93, 302);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(53, 16);
            this.lblAmount.TabIndex = 36;
            this.lblAmount.Text = "Amount:";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInPounds
            // 
            this.lblInPounds.AutoSize = true;
            this.lblInPounds.Font = new System.Drawing.Font("Yu Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInPounds.ForeColor = System.Drawing.Color.Black;
            this.lblInPounds.Location = new System.Drawing.Point(144, 303);
            this.lblInPounds.Name = "lblInPounds";
            this.lblInPounds.Size = new System.Drawing.Size(54, 14);
            this.lblInPounds.TabIndex = 37;
            this.lblInPounds.Text = "in Pounds";
            this.lblInPounds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInPints
            // 
            this.lblInPints.AutoSize = true;
            this.lblInPints.Font = new System.Drawing.Font("Yu Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInPints.ForeColor = System.Drawing.Color.Black;
            this.lblInPints.Location = new System.Drawing.Point(144, 303);
            this.lblInPints.Name = "lblInPints";
            this.lblInPints.Size = new System.Drawing.Size(41, 14);
            this.lblInPints.TabIndex = 38;
            this.lblInPints.Text = "in Pints";
            this.lblInPints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInOunces
            // 
            this.lblInOunces.AutoSize = true;
            this.lblInOunces.Font = new System.Drawing.Font("Yu Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInOunces.ForeColor = System.Drawing.Color.Black;
            this.lblInOunces.Location = new System.Drawing.Point(144, 303);
            this.lblInOunces.Name = "lblInOunces";
            this.lblInOunces.Size = new System.Drawing.Size(54, 14);
            this.lblInOunces.TabIndex = 39;
            this.lblInOunces.Text = "in Ounces";
            this.lblInOunces.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudAmount
            // 
            this.nudAmount.DecimalPlaces = 2;
            this.nudAmount.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAmount.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudAmount.Location = new System.Drawing.Point(96, 323);
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(200, 39);
            this.nudAmount.TabIndex = 40;
            this.nudAmount.ValueChanged += new System.EventHandler(this.nudAmount_ValueChanged);
            // 
            // cbxCourseOptions
            // 
            this.cbxCourseOptions.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cbxCourseOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCourseOptions.ForeColor = System.Drawing.Color.Black;
            this.cbxCourseOptions.FormattingEnabled = true;
            this.cbxCourseOptions.Location = new System.Drawing.Point(96, 167);
            this.cbxCourseOptions.Name = "cbxCourseOptions";
            this.cbxCourseOptions.Size = new System.Drawing.Size(200, 21);
            this.cbxCourseOptions.TabIndex = 42;
            this.cbxCourseOptions.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.myCombo_KeyPress);
            // 
            // lblCourseOptions
            // 
            this.lblCourseOptions.AutoSize = true;
            this.lblCourseOptions.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseOptions.ForeColor = System.Drawing.Color.Black;
            this.lblCourseOptions.Location = new System.Drawing.Point(93, 148);
            this.lblCourseOptions.Name = "lblCourseOptions";
            this.lblCourseOptions.Size = new System.Drawing.Size(62, 16);
            this.lblCourseOptions.TabIndex = 41;
            this.lblCourseOptions.Text = "Course ID";
            this.lblCourseOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnLogEquipment
            // 
            this.btnLogEquipment.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogEquipment.Location = new System.Drawing.Point(96, 381);
            this.btnLogEquipment.Name = "btnLogEquipment";
            this.btnLogEquipment.Size = new System.Drawing.Size(199, 45);
            this.btnLogEquipment.TabIndex = 43;
            this.btnLogEquipment.Text = "Log Charges";
            this.btnLogEquipment.UseVisualStyleBackColor = true;
            this.btnLogEquipment.Click += new System.EventHandler(this.btnLogEquipment_Click);
            // 
            // FrmLogEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 450);
            this.Controls.Add(this.btnLogEquipment);
            this.Controls.Add(this.cbxCourseOptions);
            this.Controls.Add(this.lblCourseOptions);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.lblInOunces);
            this.Controls.Add(this.lblInPints);
            this.Controls.Add(this.lblInPounds);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.cbxPaintItemName);
            this.Controls.Add(this.cbxGlazeItemName);
            this.Controls.Add(this.cbxClayItemName);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.cbxItemType);
            this.Controls.Add(this.lblItemType);
            this.Controls.Add(this.lblSur);
            this.Controls.Add(this.lblFore);
            this.Controls.Add(this.txtGuestID);
            this.Controls.Add(this.lblGuestID);
            this.Controls.Add(this.GuestMenuStrip);
            this.Controls.Add(this.LblLogEquipmentTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogEquipment";
            this.Text = "Log Equipment";
            this.GuestMenuStrip.ResumeLayout(false);
            this.GuestMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblLogEquipmentTitle;
        private System.Windows.Forms.MenuStrip GuestMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox txtGuestID;
        private System.Windows.Forms.Label lblGuestID;
        private System.Windows.Forms.Label lblFore;
        private System.Windows.Forms.Label lblSur;
        private System.Windows.Forms.ComboBox cbxItemType;
        private System.Windows.Forms.Label lblItemType;
        private System.Windows.Forms.ComboBox cbxClayItemName;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.ComboBox cbxGlazeItemName;
        private System.Windows.Forms.ComboBox cbxPaintItemName;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblInPounds;
        private System.Windows.Forms.Label lblInPints;
        private System.Windows.Forms.Label lblInOunces;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.ComboBox cbxCourseOptions;
        private System.Windows.Forms.Label lblCourseOptions;
        private System.Windows.Forms.Button btnLogEquipment;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guestManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guestManagementToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem guestInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseMaagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeABookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getCourseReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exhibitionManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artworkManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem1;
    }
}