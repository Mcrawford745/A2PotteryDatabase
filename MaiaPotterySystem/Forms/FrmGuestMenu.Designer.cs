namespace PotteryDBA_V1._0.Forms
{
    partial class FrmGuestMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGuestMenu));
            this.GuestMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogEquipment = new System.Windows.Forms.Button();
            this.btnAddGuest = new System.Windows.Forms.Button();
            this.lblMenuInstructions = new System.Windows.Forms.Label();
            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.btnGuestInvoice = new System.Windows.Forms.Button();
            this.GuestMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // GuestMenuStrip
            // 
            this.GuestMenuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.GuestMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.GuestMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.GuestMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.GuestMenuStrip.Name = "GuestMenuStrip";
            this.GuestMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.GuestMenuStrip.Size = new System.Drawing.Size(484, 23);
            this.GuestMenuStrip.TabIndex = 19;
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
            // btnLogEquipment
            // 
            this.btnLogEquipment.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogEquipment.Location = new System.Drawing.Point(124, 174);
            this.btnLogEquipment.Name = "btnLogEquipment";
            this.btnLogEquipment.Size = new System.Drawing.Size(235, 54);
            this.btnLogEquipment.TabIndex = 18;
            this.btnLogEquipment.Text = "Log Equipment";
            this.btnLogEquipment.UseVisualStyleBackColor = true;
            this.btnLogEquipment.Click += new System.EventHandler(this.btnLogEquipment_Click);
            // 
            // btnAddGuest
            // 
            this.btnAddGuest.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGuest.Location = new System.Drawing.Point(124, 108);
            this.btnAddGuest.Name = "btnAddGuest";
            this.btnAddGuest.Size = new System.Drawing.Size(235, 54);
            this.btnAddGuest.TabIndex = 16;
            this.btnAddGuest.Text = "Guest Manager";
            this.btnAddGuest.UseVisualStyleBackColor = true;
            this.btnAddGuest.Click += new System.EventHandler(this.btnAddGuest_Click);
            // 
            // lblMenuInstructions
            // 
            this.lblMenuInstructions.AutoSize = true;
            this.lblMenuInstructions.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuInstructions.ForeColor = System.Drawing.Color.Black;
            this.lblMenuInstructions.Location = new System.Drawing.Point(92, 73);
            this.lblMenuInstructions.Name = "lblMenuInstructions";
            this.lblMenuInstructions.Size = new System.Drawing.Size(298, 20);
            this.lblMenuInstructions.TabIndex = 15;
            this.lblMenuInstructions.Text = "Please select an option below to continue:";
            // 
            // lblMenuTitle
            // 
            this.lblMenuTitle.AutoSize = true;
            this.lblMenuTitle.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuTitle.ForeColor = System.Drawing.Color.Black;
            this.lblMenuTitle.Location = new System.Drawing.Point(127, 35);
            this.lblMenuTitle.Name = "lblMenuTitle";
            this.lblMenuTitle.Size = new System.Drawing.Size(229, 31);
            this.lblMenuTitle.TabIndex = 14;
            this.lblMenuTitle.Text = "Guest Management";
            // 
            // btnGuestInvoice
            // 
            this.btnGuestInvoice.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuestInvoice.Location = new System.Drawing.Point(391, 217);
            this.btnGuestInvoice.Name = "btnGuestInvoice";
            this.btnGuestInvoice.Size = new System.Drawing.Size(85, 31);
            this.btnGuestInvoice.TabIndex = 61;
            this.btnGuestInvoice.Text = "Guest Invoice";
            this.btnGuestInvoice.UseVisualStyleBackColor = true;
            this.btnGuestInvoice.Click += new System.EventHandler(this.btnGuestInvoice_Click);
            // 
            // FrmGuestMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 256);
            this.Controls.Add(this.btnGuestInvoice);
            this.Controls.Add(this.GuestMenuStrip);
            this.Controls.Add(this.btnLogEquipment);
            this.Controls.Add(this.btnAddGuest);
            this.Controls.Add(this.lblMenuInstructions);
            this.Controls.Add(this.lblMenuTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGuestMenu";
            this.Text = "Guest Management Menu";
            this.GuestMenuStrip.ResumeLayout(false);
            this.GuestMenuStrip.PerformLayout();
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
        private System.Windows.Forms.Button btnLogEquipment;
        private System.Windows.Forms.Button btnAddGuest;
        private System.Windows.Forms.Label lblMenuInstructions;
        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.Button btnGuestInvoice;
    }
}