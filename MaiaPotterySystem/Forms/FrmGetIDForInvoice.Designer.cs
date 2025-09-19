namespace PotteryDBA_V1._0.Forms
{
    partial class FrmGetIDForInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGetIDForInvoice));
            this.GuestMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCourseReport = new System.Windows.Forms.Button();
            this.txtGuestID = new System.Windows.Forms.TextBox();
            this.lblGuestID = new System.Windows.Forms.Label();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.cbxCourseID = new System.Windows.Forms.ComboBox();
            this.lblnocourses = new System.Windows.Forms.Label();
            this.GuestMenuStrip.SuspendLayout();
            this.SuspendLayout();
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
            this.GuestMenuStrip.TabIndex = 71;
            this.GuestMenuStrip.Text = "stpMainMenu";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
            this.mainMenuToolStripMenuItem.Text = "Back";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // btnCourseReport
            // 
            this.btnCourseReport.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourseReport.Location = new System.Drawing.Point(82, 132);
            this.btnCourseReport.Name = "btnCourseReport";
            this.btnCourseReport.Size = new System.Drawing.Size(109, 31);
            this.btnCourseReport.TabIndex = 70;
            this.btnCourseReport.Text = "Print Report";
            this.btnCourseReport.UseVisualStyleBackColor = true;
            this.btnCourseReport.Click += new System.EventHandler(this.btnCourseReport_Click);
            // 
            // txtGuestID
            // 
            this.txtGuestID.Location = new System.Drawing.Point(40, 53);
            this.txtGuestID.Name = "txtGuestID";
            this.txtGuestID.Size = new System.Drawing.Size(200, 20);
            this.txtGuestID.TabIndex = 69;
            this.txtGuestID.TextChanged += new System.EventHandler(this.txtGuestID_TextChanged);
            // 
            // lblGuestID
            // 
            this.lblGuestID.AutoSize = true;
            this.lblGuestID.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestID.ForeColor = System.Drawing.Color.Black;
            this.lblGuestID.Location = new System.Drawing.Point(37, 33);
            this.lblGuestID.Name = "lblGuestID";
            this.lblGuestID.Size = new System.Drawing.Size(56, 16);
            this.lblGuestID.TabIndex = 68;
            this.lblGuestID.Text = "Guest ID";
            this.lblGuestID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseID.ForeColor = System.Drawing.Color.Black;
            this.lblCourseID.Location = new System.Drawing.Point(37, 78);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(62, 16);
            this.lblCourseID.TabIndex = 72;
            this.lblCourseID.Text = "Course ID";
            this.lblCourseID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxCourseID
            // 
            this.cbxCourseID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCourseID.FormattingEnabled = true;
            this.cbxCourseID.Location = new System.Drawing.Point(40, 100);
            this.cbxCourseID.Name = "cbxCourseID";
            this.cbxCourseID.Size = new System.Drawing.Size(200, 21);
            this.cbxCourseID.TabIndex = 73;
            // 
            // lblnocourses
            // 
            this.lblnocourses.AutoSize = true;
            this.lblnocourses.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnocourses.ForeColor = System.Drawing.Color.Black;
            this.lblnocourses.Location = new System.Drawing.Point(44, 103);
            this.lblnocourses.Name = "lblnocourses";
            this.lblnocourses.Size = new System.Drawing.Size(190, 16);
            this.lblnocourses.TabIndex = 81;
            this.lblnocourses.Text = "Guest has not attended a course.";
            // 
            // FrmGetIDForInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 172);
            this.Controls.Add(this.lblnocourses);
            this.Controls.Add(this.cbxCourseID);
            this.Controls.Add(this.lblCourseID);
            this.Controls.Add(this.GuestMenuStrip);
            this.Controls.Add(this.btnCourseReport);
            this.Controls.Add(this.txtGuestID);
            this.Controls.Add(this.lblGuestID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGetIDForInvoice";
            this.Text = "Please Enter Booking Details";
            this.Load += new System.EventHandler(this.FrmGetIDForInvoice_Load);
            this.GuestMenuStrip.ResumeLayout(false);
            this.GuestMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip GuestMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.Button btnCourseReport;
        private System.Windows.Forms.TextBox txtGuestID;
        private System.Windows.Forms.Label lblGuestID;
        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.ComboBox cbxCourseID;
        private System.Windows.Forms.Label lblnocourses;
    }
}