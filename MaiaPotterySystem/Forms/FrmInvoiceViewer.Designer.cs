namespace PotteryDBA_V1._0.Forms
{
    partial class FrmInvoiceViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInvoiceViewer));
            this.btnMainMenuHelpDone = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // btnMainMenuHelpDone
            // 
            this.btnMainMenuHelpDone.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenuHelpDone.Location = new System.Drawing.Point(308, 568);
            this.btnMainMenuHelpDone.Name = "btnMainMenuHelpDone";
            this.btnMainMenuHelpDone.Size = new System.Drawing.Size(177, 37);
            this.btnMainMenuHelpDone.TabIndex = 25;
            this.btnMainMenuHelpDone.Text = "Done";
            this.btnMainMenuHelpDone.UseVisualStyleBackColor = true;
            this.btnMainMenuHelpDone.Click += new System.EventHandler(this.btnMainMenuHelpDone_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.DocumentMapWidth = 61;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PotteryDBA_V1._0.Reports.GuestInvoice.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 540);
            this.reportViewer1.TabIndex = 24;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // FrmInvoiceViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 619);
            this.Controls.Add(this.btnMainMenuHelpDone);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmInvoiceViewer";
            this.Text = "Guest Invoice";
            this.Load += new System.EventHandler(this.FrmInvoiceViewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMainMenuHelpDone;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}