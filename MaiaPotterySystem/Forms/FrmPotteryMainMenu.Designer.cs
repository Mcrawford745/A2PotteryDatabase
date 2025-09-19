namespace PotteryDBA_V1._0.Forms
{
    partial class FrmPotteryMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPotteryMainMenu));
            this.lblMenuInstructions = new System.Windows.Forms.Label();
            this.lblMenuTitle = new System.Windows.Forms.Label();
            this.btnExhibitionManagement = new System.Windows.Forms.Button();
            this.btnCourseManagement = new System.Windows.Forms.Button();
            this.btnGuestManagement = new System.Windows.Forms.Button();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnArtworkManagement = new System.Windows.Forms.Button();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMenuInstructions
            // 
            this.lblMenuInstructions.AutoSize = true;
            this.lblMenuInstructions.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuInstructions.ForeColor = System.Drawing.Color.Black;
            this.lblMenuInstructions.Location = new System.Drawing.Point(113, 63);
            this.lblMenuInstructions.Name = "lblMenuInstructions";
            this.lblMenuInstructions.Size = new System.Drawing.Size(298, 20);
            this.lblMenuInstructions.TabIndex = 5;
            this.lblMenuInstructions.Text = "Please select an option below to continue:";
            // 
            // lblMenuTitle
            // 
            this.lblMenuTitle.AutoSize = true;
            this.lblMenuTitle.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuTitle.ForeColor = System.Drawing.Color.Black;
            this.lblMenuTitle.Location = new System.Drawing.Point(100, 30);
            this.lblMenuTitle.Name = "lblMenuTitle";
            this.lblMenuTitle.Size = new System.Drawing.Size(328, 31);
            this.lblMenuTitle.TabIndex = 4;
            this.lblMenuTitle.Text = "Pottery Course Management";
            // 
            // btnExhibitionManagement
            // 
            this.btnExhibitionManagement.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExhibitionManagement.Location = new System.Drawing.Point(145, 217);
            this.btnExhibitionManagement.Name = "btnExhibitionManagement";
            this.btnExhibitionManagement.Size = new System.Drawing.Size(235, 54);
            this.btnExhibitionManagement.TabIndex = 11;
            this.btnExhibitionManagement.Text = "Exhibition Management";
            this.btnExhibitionManagement.UseVisualStyleBackColor = true;
            this.btnExhibitionManagement.Click += new System.EventHandler(this.btnExhibitionManagement_Click);
            // 
            // btnCourseManagement
            // 
            this.btnCourseManagement.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourseManagement.Location = new System.Drawing.Point(145, 155);
            this.btnCourseManagement.Name = "btnCourseManagement";
            this.btnCourseManagement.Size = new System.Drawing.Size(235, 54);
            this.btnCourseManagement.TabIndex = 10;
            this.btnCourseManagement.Text = "Course Management";
            this.btnCourseManagement.UseVisualStyleBackColor = true;
            this.btnCourseManagement.Click += new System.EventHandler(this.btnCourseManagement_Click);
            // 
            // btnGuestManagement
            // 
            this.btnGuestManagement.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuestManagement.Location = new System.Drawing.Point(145, 92);
            this.btnGuestManagement.Name = "btnGuestManagement";
            this.btnGuestManagement.Size = new System.Drawing.Size(235, 54);
            this.btnGuestManagement.TabIndex = 9;
            this.btnGuestManagement.Text = "Guest Management\r\n";
            this.btnGuestManagement.UseVisualStyleBackColor = true;
            this.btnGuestManagement.Click += new System.EventHandler(this.btnGuestManagement_Click);
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.MainMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MainMenuStrip.Size = new System.Drawing.Size(523, 23);
            this.MainMenuStrip.TabIndex = 12;
            this.MainMenuStrip.Text = "stpMainMenu";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(80, 19);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
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
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // btnArtworkManagement
            // 
            this.btnArtworkManagement.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtworkManagement.Location = new System.Drawing.Point(145, 279);
            this.btnArtworkManagement.Name = "btnArtworkManagement";
            this.btnArtworkManagement.Size = new System.Drawing.Size(235, 54);
            this.btnArtworkManagement.TabIndex = 13;
            this.btnArtworkManagement.Text = "Artwork Management";
            this.btnArtworkManagement.UseVisualStyleBackColor = true;
            this.btnArtworkManagement.Click += new System.EventHandler(this.btnArtworkManagement_Click);
            // 
            // FrmPotteryMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 353);
            this.Controls.Add(this.btnArtworkManagement);
            this.Controls.Add(this.MainMenuStrip);
            this.Controls.Add(this.btnExhibitionManagement);
            this.Controls.Add(this.btnCourseManagement);
            this.Controls.Add(this.btnGuestManagement);
            this.Controls.Add(this.lblMenuInstructions);
            this.Controls.Add(this.lblMenuTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPotteryMainMenu";
            this.Text = "Pottery Course Menu";
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuInstructions;
        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.Button btnExhibitionManagement;
        private System.Windows.Forms.Button btnCourseManagement;
        private System.Windows.Forms.Button btnGuestManagement;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btnArtworkManagement;
    }
}