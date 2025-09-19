namespace PotteryDBA_V1._0.Forms
{
    partial class FrmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.lblMenuInstructions = new System.Windows.Forms.Label();
            this.btnPodBooking = new System.Windows.Forms.Button();
            this.btnYoga = new System.Windows.Forms.Button();
            this.btnPottery = new System.Windows.Forms.Button();
            this.btnPainting = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnWorkshops = new System.Windows.Forms.Button();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMenuTitle
            // 
            this.lblMenuTitle.AutoSize = true;
            this.lblMenuTitle.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuTitle.ForeColor = System.Drawing.Color.Black;
            this.lblMenuTitle.Location = new System.Drawing.Point(81, 26);
            this.lblMenuTitle.Name = "lblMenuTitle";
            this.lblMenuTitle.Size = new System.Drawing.Size(361, 31);
            this.lblMenuTitle.TabIndex = 2;
            this.lblMenuTitle.Text = "Lakeside Escapes Management";
            // 
            // lblMenuInstructions
            // 
            this.lblMenuInstructions.AutoSize = true;
            this.lblMenuInstructions.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuInstructions.ForeColor = System.Drawing.Color.Black;
            this.lblMenuInstructions.Location = new System.Drawing.Point(121, 57);
            this.lblMenuInstructions.Name = "lblMenuInstructions";
            this.lblMenuInstructions.Size = new System.Drawing.Size(276, 20);
            this.lblMenuInstructions.TabIndex = 3;
            this.lblMenuInstructions.Text = "Please select an option below to begin:";
            // 
            // btnPodBooking
            // 
            this.btnPodBooking.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPodBooking.Location = new System.Drawing.Point(17, 101);
            this.btnPodBooking.Name = "btnPodBooking";
            this.btnPodBooking.Size = new System.Drawing.Size(235, 54);
            this.btnPodBooking.TabIndex = 4;
            this.btnPodBooking.Text = "Pod Booking";
            this.btnPodBooking.UseVisualStyleBackColor = true;
            this.btnPodBooking.Click += new System.EventHandler(this.btnPodBooking_Click);
            // 
            // btnYoga
            // 
            this.btnYoga.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYoga.Location = new System.Drawing.Point(271, 101);
            this.btnYoga.Name = "btnYoga";
            this.btnYoga.Size = new System.Drawing.Size(235, 54);
            this.btnYoga.TabIndex = 5;
            this.btnYoga.Text = "Yoga and Meditiation";
            this.btnYoga.UseVisualStyleBackColor = true;
            this.btnYoga.Click += new System.EventHandler(this.btnYoga_Click);
            // 
            // btnPottery
            // 
            this.btnPottery.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPottery.Location = new System.Drawing.Point(271, 168);
            this.btnPottery.Name = "btnPottery";
            this.btnPottery.Size = new System.Drawing.Size(235, 54);
            this.btnPottery.TabIndex = 7;
            this.btnPottery.Text = "Pottery";
            this.btnPottery.UseVisualStyleBackColor = true;
            this.btnPottery.Click += new System.EventHandler(this.btnPottery_Click);
            // 
            // btnPainting
            // 
            this.btnPainting.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPainting.Location = new System.Drawing.Point(17, 168);
            this.btnPainting.Name = "btnPainting";
            this.btnPainting.Size = new System.Drawing.Size(235, 54);
            this.btnPainting.TabIndex = 6;
            this.btnPainting.Text = "Painting";
            this.btnPainting.UseVisualStyleBackColor = true;
            this.btnPainting.Click += new System.EventHandler(this.btnPainting_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.Location = new System.Drawing.Point(271, 237);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(235, 54);
            this.btnInventory.TabIndex = 9;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnWorkshops
            // 
            this.btnWorkshops.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkshops.Location = new System.Drawing.Point(17, 237);
            this.btnWorkshops.Name = "btnWorkshops";
            this.btnWorkshops.Size = new System.Drawing.Size(235, 54);
            this.btnWorkshops.TabIndex = 8;
            this.btnWorkshops.Text = "Weekend Workshops";
            this.btnWorkshops.UseVisualStyleBackColor = true;
            this.btnWorkshops.Click += new System.EventHandler(this.btnWorkshops_Click);
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MainMenuStrip.Size = new System.Drawing.Size(523, 24);
            this.MainMenuStrip.TabIndex = 10;
            this.MainMenuStrip.Text = "stpMainMenu";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
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
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 332);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnWorkshops);
            this.Controls.Add(this.btnPottery);
            this.Controls.Add(this.btnPainting);
            this.Controls.Add(this.btnYoga);
            this.Controls.Add(this.btnPodBooking);
            this.Controls.Add(this.lblMenuInstructions);
            this.Controls.Add(this.lblMenuTitle);
            this.Controls.Add(this.MainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMainMenu";
            this.Text = "Wecome To Lakeside Escapes";
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.Label lblMenuInstructions;
        private System.Windows.Forms.Button btnPodBooking;
        private System.Windows.Forms.Button btnYoga;
        private System.Windows.Forms.Button btnPottery;
        private System.Windows.Forms.Button btnPainting;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnWorkshops;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}