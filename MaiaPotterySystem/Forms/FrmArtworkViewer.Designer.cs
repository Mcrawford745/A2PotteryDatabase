namespace PotteryDBA_V1._0.Forms
{
    partial class FrmArtworkViewer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArtworkViewer));
            this.GuestMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedGuestArtworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalGuestArtworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvArtworksOutNormal = new System.Windows.Forms.DataGridView();
            this.artworkIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skillLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getArtworksNormalModeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.normalModeFetchArtworkInfo = new PotteryDBA_V1._0.DataSets.NormalModeFetchArtworkInfo();
            this.getArtworksNormalModeTableAdapter = new PotteryDBA_V1._0.DataSets.NormalModeFetchArtworkInfoTableAdapters.GetArtworksNormalModeTableAdapter();
            this.dgvArtworkOutAdvanced = new System.Windows.Forms.DataGridView();
            this.artworkIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.forenameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soldDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.getArtworkAdvancedModeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advancedModeFetchArtworkInfo = new PotteryDBA_V1._0.DataSets.AdvancedModeFetchArtworkInfo();
            this.getArtworkAdvancedModeTableAdapter = new PotteryDBA_V1._0.DataSets.AdvancedModeFetchArtworkInfoTableAdapters.GetArtworkAdvancedModeTableAdapter();
            this.lblAdvancedArtwork = new System.Windows.Forms.Label();
            this.lblAllArtworks = new System.Windows.Forms.Label();
            this.lblNoResults = new System.Windows.Forms.Label();
            this.lblNoOfRecords = new System.Windows.Forms.Label();
            this.lblsearch = new System.Windows.Forms.Label();
            this.cbxSearchby = new System.Windows.Forms.ComboBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.btnAddMode = new System.Windows.Forms.Button();
            this.btnDeleteMode = new System.Windows.Forms.Button();
            this.btnUpdateMode = new System.Windows.Forms.Button();
            this.lblsearchtext = new System.Windows.Forms.Label();
            this.txtAdvancedName = new System.Windows.Forms.TextBox();
            this.txtNormalName = new System.Windows.Forms.TextBox();
            this.txtAdvancedID = new System.Windows.Forms.TextBox();
            this.txtNormalID = new System.Windows.Forms.TextBox();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.txtGuestID = new System.Windows.Forms.TextBox();
            this.lblGuestID = new System.Windows.Forms.Label();
            this.cbxCourseIDAdd = new System.Windows.Forms.ComboBox();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.lblSalePriceAdd = new System.Windows.Forms.Label();
            this.lblSur = new System.Windows.Forms.Label();
            this.lblFore = new System.Windows.Forms.Label();
            this.lblnocourses = new System.Windows.Forms.Label();
            this.btnAddArtwork = new System.Windows.Forms.Button();
            this.txtArtworkIDDelete = new System.Windows.Forms.TextBox();
            this.lblArtworkIDDelete = new System.Windows.Forms.Label();
            this.btnDeleteArtwork = new System.Windows.Forms.Button();
            this.txtArtworkIDUpdate = new System.Windows.Forms.TextBox();
            this.lblArtworkIDUpdate = new System.Windows.Forms.Label();
            this.lblSalePriceUpdate = new System.Windows.Forms.Label();
            this.chbxSold = new System.Windows.Forms.CheckBox();
            this.btnUpdateArtwork = new System.Windows.Forms.Button();
            this.cbxExhibtionEdit = new System.Windows.Forms.ComboBox();
            this.lblExhibition = new System.Windows.Forms.Label();
            this.lblSoldUpdate = new System.Windows.Forms.Label();
            this.lblUpdateAllowed = new System.Windows.Forms.Label();
            this.lblCurrentExhibition = new System.Windows.Forms.Label();
            this.nudSalePriceUpdate = new NumericUpDownPoundSign();
            this.nudAddPrice = new NumericUpDownPoundSign();
            this.nudAmount = new NumericUpDownPoundSign();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestManagementToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logEquipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseMaagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeABookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getCourseReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exhibitionManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.GuestMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtworksOutNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getArtworksNormalModeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalModeFetchArtworkInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtworkOutAdvanced)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getArtworkAdvancedModeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedModeFetchArtworkInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalePriceUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
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
            this.GuestMenuStrip.Size = new System.Drawing.Size(831, 23);
            this.GuestMenuStrip.TabIndex = 22;
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
            this.generalGuestArtworkToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // advancedGuestArtworkToolStripMenuItem
            // 
            this.advancedGuestArtworkToolStripMenuItem.Name = "advancedGuestArtworkToolStripMenuItem";
            this.advancedGuestArtworkToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.advancedGuestArtworkToolStripMenuItem.Text = "Advanced Guest Artwork";
            this.advancedGuestArtworkToolStripMenuItem.Click += new System.EventHandler(this.advancedGuestArtworkToolStripMenuItem_Click);
            // 
            // generalGuestArtworkToolStripMenuItem
            // 
            this.generalGuestArtworkToolStripMenuItem.Name = "generalGuestArtworkToolStripMenuItem";
            this.generalGuestArtworkToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.generalGuestArtworkToolStripMenuItem.Text = "All Artwork";
            this.generalGuestArtworkToolStripMenuItem.Click += new System.EventHandler(this.generalGuestArtworkToolStripMenuItem_Click);
            // 
            // dgvArtworksOutNormal
            // 
            this.dgvArtworksOutNormal.AllowUserToAddRows = false;
            this.dgvArtworksOutNormal.AllowUserToDeleteRows = false;
            this.dgvArtworksOutNormal.AllowUserToResizeColumns = false;
            this.dgvArtworksOutNormal.AllowUserToResizeRows = false;
            this.dgvArtworksOutNormal.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArtworksOutNormal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArtworksOutNormal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtworksOutNormal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artworkIDDataGridViewTextBoxColumn,
            this.guestIDDataGridViewTextBoxColumn,
            this.forenameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.skillLevelDataGridViewTextBoxColumn});
            this.dgvArtworksOutNormal.DataSource = this.getArtworksNormalModeBindingSource;
            this.dgvArtworksOutNormal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArtworksOutNormal.EnableHeadersVisualStyles = false;
            this.dgvArtworksOutNormal.GridColor = System.Drawing.Color.Black;
            this.dgvArtworksOutNormal.Location = new System.Drawing.Point(12, 78);
            this.dgvArtworksOutNormal.MultiSelect = false;
            this.dgvArtworksOutNormal.Name = "dgvArtworksOutNormal";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArtworksOutNormal.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvArtworksOutNormal.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvArtworksOutNormal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArtworksOutNormal.Size = new System.Drawing.Size(565, 404);
            this.dgvArtworksOutNormal.TabIndex = 23;
            this.dgvArtworksOutNormal.SelectionChanged += new System.EventHandler(this.dgvArtwork_SelectionChanged);
            // 
            // artworkIDDataGridViewTextBoxColumn
            // 
            this.artworkIDDataGridViewTextBoxColumn.DataPropertyName = "ArtworkID";
            this.artworkIDDataGridViewTextBoxColumn.HeaderText = "ArtworkID";
            this.artworkIDDataGridViewTextBoxColumn.Name = "artworkIDDataGridViewTextBoxColumn";
            // 
            // guestIDDataGridViewTextBoxColumn
            // 
            this.guestIDDataGridViewTextBoxColumn.DataPropertyName = "GuestID";
            this.guestIDDataGridViewTextBoxColumn.HeaderText = "GuestID";
            this.guestIDDataGridViewTextBoxColumn.Name = "guestIDDataGridViewTextBoxColumn";
            // 
            // forenameDataGridViewTextBoxColumn
            // 
            this.forenameDataGridViewTextBoxColumn.DataPropertyName = "Forename";
            this.forenameDataGridViewTextBoxColumn.HeaderText = "Forename";
            this.forenameDataGridViewTextBoxColumn.Name = "forenameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // skillLevelDataGridViewTextBoxColumn
            // 
            this.skillLevelDataGridViewTextBoxColumn.DataPropertyName = "SkillLevel";
            this.skillLevelDataGridViewTextBoxColumn.HeaderText = "Skill Level";
            this.skillLevelDataGridViewTextBoxColumn.Name = "skillLevelDataGridViewTextBoxColumn";
            // 
            // getArtworksNormalModeBindingSource
            // 
            this.getArtworksNormalModeBindingSource.DataMember = "GetArtworksNormalMode";
            this.getArtworksNormalModeBindingSource.DataSource = this.normalModeFetchArtworkInfo;
            // 
            // normalModeFetchArtworkInfo
            // 
            this.normalModeFetchArtworkInfo.DataSetName = "NormalModeFetchArtworkInfo";
            this.normalModeFetchArtworkInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getArtworksNormalModeTableAdapter
            // 
            this.getArtworksNormalModeTableAdapter.ClearBeforeFill = true;
            // 
            // dgvArtworkOutAdvanced
            // 
            this.dgvArtworkOutAdvanced.AllowUserToAddRows = false;
            this.dgvArtworkOutAdvanced.AllowUserToDeleteRows = false;
            this.dgvArtworkOutAdvanced.AllowUserToResizeColumns = false;
            this.dgvArtworkOutAdvanced.AllowUserToResizeRows = false;
            this.dgvArtworkOutAdvanced.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArtworkOutAdvanced.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvArtworkOutAdvanced.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtworkOutAdvanced.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artworkIDDataGridViewTextBoxColumn1,
            this.guestIDDataGridViewTextBoxColumn1,
            this.forenameDataGridViewTextBoxColumn1,
            this.surnameDataGridViewTextBoxColumn1,
            this.salePriceDataGridViewTextBoxColumn,
            this.soldDataGridViewCheckBoxColumn});
            this.dgvArtworkOutAdvanced.DataSource = this.getArtworkAdvancedModeBindingSource;
            this.dgvArtworkOutAdvanced.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArtworkOutAdvanced.EnableHeadersVisualStyles = false;
            this.dgvArtworkOutAdvanced.GridColor = System.Drawing.Color.Black;
            this.dgvArtworkOutAdvanced.Location = new System.Drawing.Point(12, 79);
            this.dgvArtworkOutAdvanced.MultiSelect = false;
            this.dgvArtworkOutAdvanced.Name = "dgvArtworkOutAdvanced";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArtworkOutAdvanced.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.dgvArtworkOutAdvanced.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvArtworkOutAdvanced.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArtworkOutAdvanced.Size = new System.Drawing.Size(565, 404);
            this.dgvArtworkOutAdvanced.TabIndex = 24;
            this.dgvArtworkOutAdvanced.SelectionChanged += new System.EventHandler(this.dgvArtwork_SelectionChanged);
            // 
            // artworkIDDataGridViewTextBoxColumn1
            // 
            this.artworkIDDataGridViewTextBoxColumn1.DataPropertyName = "ArtworkID";
            this.artworkIDDataGridViewTextBoxColumn1.HeaderText = "Artwork ID";
            this.artworkIDDataGridViewTextBoxColumn1.Name = "artworkIDDataGridViewTextBoxColumn1";
            // 
            // guestIDDataGridViewTextBoxColumn1
            // 
            this.guestIDDataGridViewTextBoxColumn1.DataPropertyName = "GuestID";
            this.guestIDDataGridViewTextBoxColumn1.HeaderText = "Guest ID";
            this.guestIDDataGridViewTextBoxColumn1.Name = "guestIDDataGridViewTextBoxColumn1";
            this.guestIDDataGridViewTextBoxColumn1.Width = 75;
            // 
            // forenameDataGridViewTextBoxColumn1
            // 
            this.forenameDataGridViewTextBoxColumn1.DataPropertyName = "Forename";
            this.forenameDataGridViewTextBoxColumn1.HeaderText = "Forename";
            this.forenameDataGridViewTextBoxColumn1.Name = "forenameDataGridViewTextBoxColumn1";
            // 
            // surnameDataGridViewTextBoxColumn1
            // 
            this.surnameDataGridViewTextBoxColumn1.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn1.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn1.Name = "surnameDataGridViewTextBoxColumn1";
            // 
            // salePriceDataGridViewTextBoxColumn
            // 
            this.salePriceDataGridViewTextBoxColumn.DataPropertyName = "SalePrice";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = "00.00";
            this.salePriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.salePriceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.salePriceDataGridViewTextBoxColumn.Name = "salePriceDataGridViewTextBoxColumn";
            this.salePriceDataGridViewTextBoxColumn.Width = 75;
            // 
            // soldDataGridViewCheckBoxColumn
            // 
            this.soldDataGridViewCheckBoxColumn.DataPropertyName = "Sold";
            this.soldDataGridViewCheckBoxColumn.HeaderText = "Sold";
            this.soldDataGridViewCheckBoxColumn.Name = "soldDataGridViewCheckBoxColumn";
            this.soldDataGridViewCheckBoxColumn.Width = 50;
            // 
            // getArtworkAdvancedModeBindingSource
            // 
            this.getArtworkAdvancedModeBindingSource.DataMember = "GetArtworkAdvancedMode";
            this.getArtworkAdvancedModeBindingSource.DataSource = this.advancedModeFetchArtworkInfo;
            // 
            // advancedModeFetchArtworkInfo
            // 
            this.advancedModeFetchArtworkInfo.DataSetName = "AdvancedModeFetchArtworkInfo";
            this.advancedModeFetchArtworkInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // getArtworkAdvancedModeTableAdapter
            // 
            this.getArtworkAdvancedModeTableAdapter.ClearBeforeFill = true;
            // 
            // lblAdvancedArtwork
            // 
            this.lblAdvancedArtwork.AutoSize = true;
            this.lblAdvancedArtwork.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvancedArtwork.ForeColor = System.Drawing.Color.Black;
            this.lblAdvancedArtwork.Location = new System.Drawing.Point(12, 43);
            this.lblAdvancedArtwork.Name = "lblAdvancedArtwork";
            this.lblAdvancedArtwork.Size = new System.Drawing.Size(263, 27);
            this.lblAdvancedArtwork.TabIndex = 25;
            this.lblAdvancedArtwork.Text = "Advanced Guest Artworks";
            // 
            // lblAllArtworks
            // 
            this.lblAllArtworks.AutoSize = true;
            this.lblAllArtworks.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllArtworks.ForeColor = System.Drawing.Color.Black;
            this.lblAllArtworks.Location = new System.Drawing.Point(12, 43);
            this.lblAllArtworks.Name = "lblAllArtworks";
            this.lblAllArtworks.Size = new System.Drawing.Size(131, 27);
            this.lblAllArtworks.TabIndex = 26;
            this.lblAllArtworks.Text = "All Artworks";
            // 
            // lblNoResults
            // 
            this.lblNoResults.AutoSize = true;
            this.lblNoResults.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblNoResults.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoResults.Location = new System.Drawing.Point(230, 265);
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
            this.lblNoOfRecords.Location = new System.Drawing.Point(648, 466);
            this.lblNoOfRecords.Name = "lblNoOfRecords";
            this.lblNoOfRecords.Size = new System.Drawing.Size(147, 16);
            this.lblNoOfRecords.TabIndex = 35;
            this.lblNoOfRecords.Text = "Number of Records: 0000";
            this.lblNoOfRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.ForeColor = System.Drawing.Color.Black;
            this.lblsearch.Location = new System.Drawing.Point(613, 43);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(184, 27);
            this.lblsearch.TabIndex = 36;
            this.lblsearch.Text = "Manage Artworks";
            // 
            // cbxSearchby
            // 
            this.cbxSearchby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSearchby.FormattingEnabled = true;
            this.cbxSearchby.Items.AddRange(new object[] {
            "Artwork ID",
            "Name"});
            this.cbxSearchby.Location = new System.Drawing.Point(309, 52);
            this.cbxSearchby.Name = "cbxSearchby";
            this.cbxSearchby.Size = new System.Drawing.Size(100, 21);
            this.cbxSearchby.TabIndex = 38;
            this.cbxSearchby.SelectedIndexChanged += new System.EventHandler(this.cbxSearchby_SelectedIndexChanged);
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBy.ForeColor = System.Drawing.Color.Black;
            this.lblSearchBy.Location = new System.Drawing.Point(306, 33);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(66, 16);
            this.lblSearchBy.TabIndex = 37;
            this.lblSearchBy.Text = "Search By:";
            this.lblSearchBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddMode
            // 
            this.btnAddMode.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMode.Location = new System.Drawing.Point(603, 78);
            this.btnAddMode.Name = "btnAddMode";
            this.btnAddMode.Size = new System.Drawing.Size(55, 31);
            this.btnAddMode.TabIndex = 61;
            this.btnAddMode.TabStop = false;
            this.btnAddMode.Text = "Add";
            this.btnAddMode.UseVisualStyleBackColor = true;
            this.btnAddMode.Click += new System.EventHandler(this.btnAddMode_Click);
            // 
            // btnDeleteMode
            // 
            this.btnDeleteMode.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMode.Location = new System.Drawing.Point(677, 78);
            this.btnDeleteMode.Name = "btnDeleteMode";
            this.btnDeleteMode.Size = new System.Drawing.Size(55, 31);
            this.btnDeleteMode.TabIndex = 62;
            this.btnDeleteMode.TabStop = false;
            this.btnDeleteMode.Text = "Delete";
            this.btnDeleteMode.UseVisualStyleBackColor = true;
            this.btnDeleteMode.Click += new System.EventHandler(this.btnDeleteMode_Click);
            // 
            // btnUpdateMode
            // 
            this.btnUpdateMode.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMode.Location = new System.Drawing.Point(749, 78);
            this.btnUpdateMode.Name = "btnUpdateMode";
            this.btnUpdateMode.Size = new System.Drawing.Size(55, 31);
            this.btnUpdateMode.TabIndex = 63;
            this.btnUpdateMode.TabStop = false;
            this.btnUpdateMode.Text = "Update";
            this.btnUpdateMode.UseVisualStyleBackColor = true;
            this.btnUpdateMode.Click += new System.EventHandler(this.btnUpdateMode_Click);
            // 
            // lblsearchtext
            // 
            this.lblsearchtext.AutoSize = true;
            this.lblsearchtext.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearchtext.ForeColor = System.Drawing.Color.Black;
            this.lblsearchtext.Location = new System.Drawing.Point(411, 33);
            this.lblsearchtext.Name = "lblsearchtext";
            this.lblsearchtext.Size = new System.Drawing.Size(49, 16);
            this.lblsearchtext.TabIndex = 64;
            this.lblsearchtext.Text = "Search:";
            this.lblsearchtext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAdvancedName
            // 
            this.txtAdvancedName.Location = new System.Drawing.Point(415, 53);
            this.txtAdvancedName.Name = "txtAdvancedName";
            this.txtAdvancedName.Size = new System.Drawing.Size(108, 20);
            this.txtAdvancedName.TabIndex = 65;
            this.txtAdvancedName.TextChanged += new System.EventHandler(this.txtAdvancedName_TextChanged);
            // 
            // txtNormalName
            // 
            this.txtNormalName.Location = new System.Drawing.Point(415, 53);
            this.txtNormalName.Name = "txtNormalName";
            this.txtNormalName.Size = new System.Drawing.Size(108, 20);
            this.txtNormalName.TabIndex = 66;
            this.txtNormalName.TextChanged += new System.EventHandler(this.txtNormalName_TextChanged);
            // 
            // txtAdvancedID
            // 
            this.txtAdvancedID.Location = new System.Drawing.Point(415, 53);
            this.txtAdvancedID.Name = "txtAdvancedID";
            this.txtAdvancedID.Size = new System.Drawing.Size(108, 20);
            this.txtAdvancedID.TabIndex = 67;
            this.txtAdvancedID.TextChanged += new System.EventHandler(this.txtAdvancedID_TextChanged);
            // 
            // txtNormalID
            // 
            this.txtNormalID.Location = new System.Drawing.Point(415, 53);
            this.txtNormalID.Name = "txtNormalID";
            this.txtNormalID.Size = new System.Drawing.Size(108, 20);
            this.txtNormalID.TabIndex = 68;
            this.txtNormalID.TextChanged += new System.EventHandler(this.txtNormalID_TextChanged);
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Font = new System.Drawing.Font("Yu Gothic Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSearch.Location = new System.Drawing.Point(529, 52);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(48, 22);
            this.btnClearSearch.TabIndex = 71;
            this.btnClearSearch.Text = "Clear";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // txtGuestID
            // 
            this.txtGuestID.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtGuestID.ForeColor = System.Drawing.Color.Black;
            this.txtGuestID.Location = new System.Drawing.Point(603, 146);
            this.txtGuestID.Name = "txtGuestID";
            this.txtGuestID.Size = new System.Drawing.Size(200, 20);
            this.txtGuestID.TabIndex = 73;
            this.txtGuestID.TextChanged += new System.EventHandler(this.txtGuestID_TextChanged);
            // 
            // lblGuestID
            // 
            this.lblGuestID.AutoSize = true;
            this.lblGuestID.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestID.ForeColor = System.Drawing.Color.Black;
            this.lblGuestID.Location = new System.Drawing.Point(600, 127);
            this.lblGuestID.Name = "lblGuestID";
            this.lblGuestID.Size = new System.Drawing.Size(56, 16);
            this.lblGuestID.TabIndex = 72;
            this.lblGuestID.Text = "Guest ID";
            // 
            // cbxCourseIDAdd
            // 
            this.cbxCourseIDAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCourseIDAdd.FormattingEnabled = true;
            this.cbxCourseIDAdd.Items.AddRange(new object[] {
            "Artwork ID",
            "Name"});
            this.cbxCourseIDAdd.Location = new System.Drawing.Point(603, 224);
            this.cbxCourseIDAdd.Name = "cbxCourseIDAdd";
            this.cbxCourseIDAdd.Size = new System.Drawing.Size(201, 21);
            this.cbxCourseIDAdd.TabIndex = 75;
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseID.ForeColor = System.Drawing.Color.Black;
            this.lblCourseID.Location = new System.Drawing.Point(600, 205);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(62, 16);
            this.lblCourseID.TabIndex = 76;
            this.lblCourseID.Text = "Course ID";
            // 
            // lblSalePriceAdd
            // 
            this.lblSalePriceAdd.AutoSize = true;
            this.lblSalePriceAdd.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalePriceAdd.ForeColor = System.Drawing.Color.Black;
            this.lblSalePriceAdd.Location = new System.Drawing.Point(600, 251);
            this.lblSalePriceAdd.Name = "lblSalePriceAdd";
            this.lblSalePriceAdd.Size = new System.Drawing.Size(63, 16);
            this.lblSalePriceAdd.TabIndex = 77;
            this.lblSalePriceAdd.Text = "Sale Price";
            // 
            // lblSur
            // 
            this.lblSur.AutoSize = true;
            this.lblSur.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSur.ForeColor = System.Drawing.Color.Black;
            this.lblSur.Location = new System.Drawing.Point(605, 185);
            this.lblSur.Name = "lblSur";
            this.lblSur.Size = new System.Drawing.Size(60, 16);
            this.lblSur.TabIndex = 79;
            this.lblSur.Text = "Surname:";
            // 
            // lblFore
            // 
            this.lblFore.AutoSize = true;
            this.lblFore.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFore.ForeColor = System.Drawing.Color.Black;
            this.lblFore.Location = new System.Drawing.Point(600, 169);
            this.lblFore.Name = "lblFore";
            this.lblFore.Size = new System.Drawing.Size(68, 16);
            this.lblFore.TabIndex = 78;
            this.lblFore.Text = "Forename: ";
            // 
            // lblnocourses
            // 
            this.lblnocourses.AutoSize = true;
            this.lblnocourses.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnocourses.ForeColor = System.Drawing.Color.Black;
            this.lblnocourses.Location = new System.Drawing.Point(608, 226);
            this.lblnocourses.Name = "lblnocourses";
            this.lblnocourses.Size = new System.Drawing.Size(190, 16);
            this.lblnocourses.TabIndex = 80;
            this.lblnocourses.Text = "Guest has not attended a course.";
            // 
            // btnAddArtwork
            // 
            this.btnAddArtwork.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddArtwork.Location = new System.Drawing.Point(603, 361);
            this.btnAddArtwork.Name = "btnAddArtwork";
            this.btnAddArtwork.Size = new System.Drawing.Size(201, 45);
            this.btnAddArtwork.TabIndex = 81;
            this.btnAddArtwork.Text = "Add Artwork";
            this.btnAddArtwork.UseVisualStyleBackColor = true;
            this.btnAddArtwork.Click += new System.EventHandler(this.btnAddArtwork_Click);
            // 
            // txtArtworkIDDelete
            // 
            this.txtArtworkIDDelete.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtArtworkIDDelete.ForeColor = System.Drawing.Color.Black;
            this.txtArtworkIDDelete.Location = new System.Drawing.Point(603, 146);
            this.txtArtworkIDDelete.Name = "txtArtworkIDDelete";
            this.txtArtworkIDDelete.Size = new System.Drawing.Size(200, 20);
            this.txtArtworkIDDelete.TabIndex = 83;
            this.txtArtworkIDDelete.TextChanged += new System.EventHandler(this.txtArtworkIDDelete_TextChanged);
            // 
            // lblArtworkIDDelete
            // 
            this.lblArtworkIDDelete.AutoSize = true;
            this.lblArtworkIDDelete.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtworkIDDelete.ForeColor = System.Drawing.Color.Black;
            this.lblArtworkIDDelete.Location = new System.Drawing.Point(600, 127);
            this.lblArtworkIDDelete.Name = "lblArtworkIDDelete";
            this.lblArtworkIDDelete.Size = new System.Drawing.Size(65, 16);
            this.lblArtworkIDDelete.TabIndex = 82;
            this.lblArtworkIDDelete.Text = "Artwork ID";
            // 
            // btnDeleteArtwork
            // 
            this.btnDeleteArtwork.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteArtwork.Location = new System.Drawing.Point(602, 361);
            this.btnDeleteArtwork.Name = "btnDeleteArtwork";
            this.btnDeleteArtwork.Size = new System.Drawing.Size(201, 45);
            this.btnDeleteArtwork.TabIndex = 84;
            this.btnDeleteArtwork.Text = "Delete Artwork";
            this.btnDeleteArtwork.UseVisualStyleBackColor = true;
            this.btnDeleteArtwork.Click += new System.EventHandler(this.btnDeleteArtwork_Click);
            // 
            // txtArtworkIDUpdate
            // 
            this.txtArtworkIDUpdate.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtArtworkIDUpdate.ForeColor = System.Drawing.Color.Black;
            this.txtArtworkIDUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtArtworkIDUpdate.Location = new System.Drawing.Point(604, 146);
            this.txtArtworkIDUpdate.Name = "txtArtworkIDUpdate";
            this.txtArtworkIDUpdate.ReadOnly = true;
            this.txtArtworkIDUpdate.Size = new System.Drawing.Size(200, 20);
            this.txtArtworkIDUpdate.TabIndex = 88;
            this.txtArtworkIDUpdate.TextChanged += new System.EventHandler(this.txtArtworkIDUpdate_TextChanged);
            // 
            // lblArtworkIDUpdate
            // 
            this.lblArtworkIDUpdate.AutoSize = true;
            this.lblArtworkIDUpdate.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtworkIDUpdate.ForeColor = System.Drawing.Color.Black;
            this.lblArtworkIDUpdate.Location = new System.Drawing.Point(601, 127);
            this.lblArtworkIDUpdate.Name = "lblArtworkIDUpdate";
            this.lblArtworkIDUpdate.Size = new System.Drawing.Size(65, 16);
            this.lblArtworkIDUpdate.TabIndex = 87;
            this.lblArtworkIDUpdate.Text = "Artwork ID";
            // 
            // lblSalePriceUpdate
            // 
            this.lblSalePriceUpdate.AutoSize = true;
            this.lblSalePriceUpdate.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalePriceUpdate.ForeColor = System.Drawing.Color.Black;
            this.lblSalePriceUpdate.Location = new System.Drawing.Point(601, 187);
            this.lblSalePriceUpdate.Name = "lblSalePriceUpdate";
            this.lblSalePriceUpdate.Size = new System.Drawing.Size(63, 16);
            this.lblSalePriceUpdate.TabIndex = 86;
            this.lblSalePriceUpdate.Text = "Sale Price";
            // 
            // chbxSold
            // 
            this.chbxSold.AutoSize = true;
            this.chbxSold.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxSold.Location = new System.Drawing.Point(749, 325);
            this.chbxSold.Name = "chbxSold";
            this.chbxSold.Size = new System.Drawing.Size(15, 14);
            this.chbxSold.TabIndex = 90;
            this.chbxSold.UseVisualStyleBackColor = true;
            // 
            // btnUpdateArtwork
            // 
            this.btnUpdateArtwork.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateArtwork.Location = new System.Drawing.Point(603, 361);
            this.btnUpdateArtwork.Name = "btnUpdateArtwork";
            this.btnUpdateArtwork.Size = new System.Drawing.Size(201, 45);
            this.btnUpdateArtwork.TabIndex = 91;
            this.btnUpdateArtwork.Text = "Update Artwork";
            this.btnUpdateArtwork.UseVisualStyleBackColor = true;
            this.btnUpdateArtwork.Click += new System.EventHandler(this.btnUpdateArtwork_Click);
            // 
            // cbxExhibtionEdit
            // 
            this.cbxExhibtionEdit.DropDownHeight = 200;
            this.cbxExhibtionEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxExhibtionEdit.FormattingEnabled = true;
            this.cbxExhibtionEdit.IntegralHeight = false;
            this.cbxExhibtionEdit.Items.AddRange(new object[] {
            "Artwork ID",
            "Name"});
            this.cbxExhibtionEdit.Location = new System.Drawing.Point(602, 265);
            this.cbxExhibtionEdit.Name = "cbxExhibtionEdit";
            this.cbxExhibtionEdit.Size = new System.Drawing.Size(201, 21);
            this.cbxExhibtionEdit.TabIndex = 92;
            // 
            // lblExhibition
            // 
            this.lblExhibition.AutoSize = true;
            this.lblExhibition.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExhibition.ForeColor = System.Drawing.Color.Black;
            this.lblExhibition.Location = new System.Drawing.Point(600, 244);
            this.lblExhibition.Name = "lblExhibition";
            this.lblExhibition.Size = new System.Drawing.Size(61, 16);
            this.lblExhibition.TabIndex = 93;
            this.lblExhibition.Text = "Exhibition";
            // 
            // lblSoldUpdate
            // 
            this.lblSoldUpdate.AutoSize = true;
            this.lblSoldUpdate.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoldUpdate.ForeColor = System.Drawing.Color.Black;
            this.lblSoldUpdate.Location = new System.Drawing.Point(624, 322);
            this.lblSoldUpdate.Name = "lblSoldUpdate";
            this.lblSoldUpdate.Size = new System.Drawing.Size(104, 20);
            this.lblSoldUpdate.TabIndex = 89;
            this.lblSoldUpdate.Text = "Artwork Sold?";
            // 
            // lblUpdateAllowed
            // 
            this.lblUpdateAllowed.AutoSize = true;
            this.lblUpdateAllowed.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateAllowed.ForeColor = System.Drawing.Color.Black;
            this.lblUpdateAllowed.Location = new System.Drawing.Point(631, 409);
            this.lblUpdateAllowed.Name = "lblUpdateAllowed";
            this.lblUpdateAllowed.Size = new System.Drawing.Size(133, 28);
            this.lblUpdateAllowed.TabIndex = 94;
            this.lblUpdateAllowed.Text = "An artwork that has been\r\n sold cannot be updated.";
            // 
            // lblCurrentExhibition
            // 
            this.lblCurrentExhibition.AutoSize = true;
            this.lblCurrentExhibition.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentExhibition.ForeColor = System.Drawing.Color.Black;
            this.lblCurrentExhibition.Location = new System.Drawing.Point(624, 293);
            this.lblCurrentExhibition.Name = "lblCurrentExhibition";
            this.lblCurrentExhibition.Size = new System.Drawing.Size(153, 16);
            this.lblCurrentExhibition.TabIndex = 95;
            this.lblCurrentExhibition.Text = "Current Exhibition: 000000";
            // 
            // nudSalePriceUpdate
            // 
            this.nudSalePriceUpdate.DecimalPlaces = 2;
            this.nudSalePriceUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSalePriceUpdate.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudSalePriceUpdate.LeadingSign = "£";
            this.nudSalePriceUpdate.Location = new System.Drawing.Point(604, 205);
            this.nudSalePriceUpdate.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudSalePriceUpdate.Name = "nudSalePriceUpdate";
            this.nudSalePriceUpdate.Size = new System.Drawing.Size(201, 26);
            this.nudSalePriceUpdate.TabIndex = 85;
            this.nudSalePriceUpdate.ValueChanged += new System.EventHandler(this.nudSalePriceUpdate_ValueChanged);
            this.nudSalePriceUpdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudAmount_KeyPress);
            // 
            // nudAddPrice
            // 
            this.nudAddPrice.DecimalPlaces = 2;
            this.nudAddPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAddPrice.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudAddPrice.LeadingSign = "£";
            this.nudAddPrice.Location = new System.Drawing.Point(603, 270);
            this.nudAddPrice.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudAddPrice.Name = "nudAddPrice";
            this.nudAddPrice.Size = new System.Drawing.Size(201, 26);
            this.nudAddPrice.TabIndex = 74;
            this.nudAddPrice.ValueChanged += new System.EventHandler(this.numericUpDownAddPrice_ValueChanged);
            this.nudAddPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudAmount_KeyPress);
            // 
            // nudAmount
            // 
            this.nudAmount.DecimalPlaces = 2;
            this.nudAmount.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudAmount.LeadingSign = "£";
            this.nudAmount.Location = new System.Drawing.Point(414, 53);
            this.nudAmount.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(109, 20);
            this.nudAmount.TabIndex = 70;
            this.nudAmount.ValueChanged += new System.EventHandler(this.nudAmount_ValueChanged);
            this.nudAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudAmount_KeyPress);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guestManagementToolStripMenuItem,
            this.courseMaagementToolStripMenuItem,
            this.exhibitionManagementToolStripMenuItem,
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
            this.courseManagerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.courseManagerToolStripMenuItem.Text = "Course Manager";
            this.courseManagerToolStripMenuItem.Click += new System.EventHandler(this.courseManagerToolStripMenuItem_Click);
            // 
            // makeABookingToolStripMenuItem
            // 
            this.makeABookingToolStripMenuItem.Name = "makeABookingToolStripMenuItem";
            this.makeABookingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.makeABookingToolStripMenuItem.Text = "Make A Booking";
            this.makeABookingToolStripMenuItem.Click += new System.EventHandler(this.makeABookingToolStripMenuItem_Click);
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
            // mainMenuToolStripMenuItem1
            // 
            this.mainMenuToolStripMenuItem1.Name = "mainMenuToolStripMenuItem1";
            this.mainMenuToolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.mainMenuToolStripMenuItem1.Text = "Main Menu";
            this.mainMenuToolStripMenuItem1.Click += new System.EventHandler(this.mainMenuToolStripMenuItem1_Click);
            // 
            // FrmArtworkViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 494);
            this.Controls.Add(this.lblCurrentExhibition);
            this.Controls.Add(this.lblUpdateAllowed);
            this.Controls.Add(this.lblExhibition);
            this.Controls.Add(this.cbxExhibtionEdit);
            this.Controls.Add(this.btnUpdateArtwork);
            this.Controls.Add(this.chbxSold);
            this.Controls.Add(this.lblSoldUpdate);
            this.Controls.Add(this.txtArtworkIDUpdate);
            this.Controls.Add(this.lblArtworkIDUpdate);
            this.Controls.Add(this.lblSalePriceUpdate);
            this.Controls.Add(this.nudSalePriceUpdate);
            this.Controls.Add(this.btnDeleteArtwork);
            this.Controls.Add(this.txtArtworkIDDelete);
            this.Controls.Add(this.lblArtworkIDDelete);
            this.Controls.Add(this.btnAddArtwork);
            this.Controls.Add(this.lblnocourses);
            this.Controls.Add(this.lblSur);
            this.Controls.Add(this.lblFore);
            this.Controls.Add(this.lblSalePriceAdd);
            this.Controls.Add(this.lblCourseID);
            this.Controls.Add(this.cbxCourseIDAdd);
            this.Controls.Add(this.nudAddPrice);
            this.Controls.Add(this.txtGuestID);
            this.Controls.Add(this.lblGuestID);
            this.Controls.Add(this.btnClearSearch);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.txtNormalID);
            this.Controls.Add(this.txtAdvancedID);
            this.Controls.Add(this.txtNormalName);
            this.Controls.Add(this.txtAdvancedName);
            this.Controls.Add(this.lblsearchtext);
            this.Controls.Add(this.btnUpdateMode);
            this.Controls.Add(this.btnDeleteMode);
            this.Controls.Add(this.btnAddMode);
            this.Controls.Add(this.cbxSearchby);
            this.Controls.Add(this.lblSearchBy);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.lblNoOfRecords);
            this.Controls.Add(this.lblNoResults);
            this.Controls.Add(this.lblAllArtworks);
            this.Controls.Add(this.lblAdvancedArtwork);
            this.Controls.Add(this.dgvArtworkOutAdvanced);
            this.Controls.Add(this.dgvArtworksOutNormal);
            this.Controls.Add(this.GuestMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmArtworkViewer";
            this.Text = "Artwork Management";
            this.Load += new System.EventHandler(this.FrmArtworkViewer_Load);
            this.GuestMenuStrip.ResumeLayout(false);
            this.GuestMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtworksOutNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getArtworksNormalModeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalModeFetchArtworkInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtworkOutAdvanced)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getArtworkAdvancedModeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedModeFetchArtworkInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalePriceUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvArtworksOutNormal;
        private DataSets.NormalModeFetchArtworkInfo normalModeFetchArtworkInfo;
        private System.Windows.Forms.BindingSource getArtworksNormalModeBindingSource;
        private DataSets.NormalModeFetchArtworkInfoTableAdapters.GetArtworksNormalModeTableAdapter getArtworksNormalModeTableAdapter;
        private System.Windows.Forms.DataGridView dgvArtworkOutAdvanced;
        private System.Windows.Forms.BindingSource getArtworkAdvancedModeBindingSource;
        private DataSets.AdvancedModeFetchArtworkInfo advancedModeFetchArtworkInfo;
        private DataSets.AdvancedModeFetchArtworkInfoTableAdapters.GetArtworkAdvancedModeTableAdapter getArtworkAdvancedModeTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedGuestArtworkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalGuestArtworkToolStripMenuItem;
        private System.Windows.Forms.Label lblAdvancedArtwork;
        private System.Windows.Forms.Label lblAllArtworks;
        private System.Windows.Forms.DataGridViewTextBoxColumn artworkIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn forenameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn soldDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label lblNoResults;
        private System.Windows.Forms.Label lblNoOfRecords;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.ComboBox cbxSearchby;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.Button btnAddMode;
        private System.Windows.Forms.Button btnDeleteMode;
        private System.Windows.Forms.Button btnUpdateMode;
        private System.Windows.Forms.Label lblsearchtext;
        private System.Windows.Forms.TextBox txtAdvancedName;
        private System.Windows.Forms.TextBox txtNormalName;
        private System.Windows.Forms.TextBox txtAdvancedID;
        private System.Windows.Forms.TextBox txtNormalID;
        private NumericUpDownPoundSign nudAmount;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.TextBox txtGuestID;
        private System.Windows.Forms.Label lblGuestID;
        private NumericUpDownPoundSign nudAddPrice;
        private System.Windows.Forms.ComboBox cbxCourseIDAdd;
        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.Label lblSalePriceAdd;
        private System.Windows.Forms.Label lblSur;
        private System.Windows.Forms.Label lblFore;
        private System.Windows.Forms.Label lblnocourses;
        private System.Windows.Forms.Button btnAddArtwork;
        private System.Windows.Forms.TextBox txtArtworkIDDelete;
        private System.Windows.Forms.Label lblArtworkIDDelete;
        private System.Windows.Forms.Button btnDeleteArtwork;
        private System.Windows.Forms.TextBox txtArtworkIDUpdate;
        private System.Windows.Forms.Label lblArtworkIDUpdate;
        private System.Windows.Forms.Label lblSalePriceUpdate;
        private NumericUpDownPoundSign nudSalePriceUpdate;
        private System.Windows.Forms.CheckBox chbxSold;
        private System.Windows.Forms.Button btnUpdateArtwork;
        private System.Windows.Forms.ComboBox cbxExhibtionEdit;
        private System.Windows.Forms.Label lblExhibition;
        private System.Windows.Forms.Label lblSoldUpdate;
        private System.Windows.Forms.Label lblUpdateAllowed;
        private System.Windows.Forms.Label lblCurrentExhibition;
        private System.Windows.Forms.DataGridViewTextBoxColumn artworkIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn forenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn skillLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guestManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guestManagementToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logEquipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guestInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseMaagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeABookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getCourseReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exhibitionManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem1;
    }
}