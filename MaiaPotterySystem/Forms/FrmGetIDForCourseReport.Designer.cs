namespace PotteryDBA_V1._0.Forms
{
    partial class FrmGetIDForCourseReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGetIDForCourseReport));
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.lblCourseCode = new System.Windows.Forms.Label();
            this.btnCourseReport = new System.Windows.Forms.Button();
            this.GuestMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GuestMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(40, 56);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(200, 20);
            this.txtCourseID.TabIndex = 65;
            this.txtCourseID.TextChanged += new System.EventHandler(this.txtCourseID_TextChanged);
            // 
            // lblCourseCode
            // 
            this.lblCourseCode.AutoSize = true;
            this.lblCourseCode.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseCode.ForeColor = System.Drawing.Color.Black;
            this.lblCourseCode.Location = new System.Drawing.Point(37, 32);
            this.lblCourseCode.Name = "lblCourseCode";
            this.lblCourseCode.Size = new System.Drawing.Size(62, 16);
            this.lblCourseCode.TabIndex = 64;
            this.lblCourseCode.Text = "Course ID";
            this.lblCourseCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCourseReport
            // 
            this.btnCourseReport.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourseReport.Location = new System.Drawing.Point(82, 92);
            this.btnCourseReport.Name = "btnCourseReport";
            this.btnCourseReport.Size = new System.Drawing.Size(109, 31);
            this.btnCourseReport.TabIndex = 66;
            this.btnCourseReport.Text = "Print Report";
            this.btnCourseReport.UseVisualStyleBackColor = true;
            this.btnCourseReport.Click += new System.EventHandler(this.btnCourseReport_Click);
            // 
            // GuestMenuStrip
            // 
            this.GuestMenuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.GuestMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem});
            this.GuestMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.GuestMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.GuestMenuStrip.Name = "GuestMenuStrip";
            this.GuestMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.GuestMenuStrip.Size = new System.Drawing.Size(277, 23);
            this.GuestMenuStrip.TabIndex = 67;
            this.GuestMenuStrip.Text = "stpMainMenu";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
            this.mainMenuToolStripMenuItem.Text = "Back";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // FrmGetIDForCourseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 140);
            this.Controls.Add(this.GuestMenuStrip);
            this.Controls.Add(this.btnCourseReport);
            this.Controls.Add(this.txtCourseID);
            this.Controls.Add(this.lblCourseCode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGetIDForCourseReport";
            this.Text = "Enter Course ID For Report";
            this.GuestMenuStrip.ResumeLayout(false);
            this.GuestMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.Label lblCourseCode;
        private System.Windows.Forms.Button btnCourseReport;
        private System.Windows.Forms.MenuStrip GuestMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
    }
}