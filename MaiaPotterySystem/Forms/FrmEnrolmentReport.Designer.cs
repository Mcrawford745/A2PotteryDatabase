namespace PotteryDBA_V1._0.Forms
{
    partial class FrmEnrolmentReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEnrolmentReport));
            this.enrolmentSetfromQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.enrolmentSetfromQuery = new PotteryDBA_V1._0.DataSets.EnrolmentSetfromQuery();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.getParticipantsTableAdapter1 = new PotteryDBA_V1._0.DataSets.EnrolmentSetfromQueryTableAdapters.getParticipantsTableAdapter();
            this.btnMainMenuHelpDone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.enrolmentSetfromQueryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrolmentSetfromQuery)).BeginInit();
            this.SuspendLayout();
            // 
            // enrolmentSetfromQueryBindingSource
            // 
            this.enrolmentSetfromQueryBindingSource.DataSource = this.enrolmentSetfromQuery;
            this.enrolmentSetfromQueryBindingSource.Position = 0;
            // 
            // enrolmentSetfromQuery
            // 
            this.enrolmentSetfromQuery.DataSetName = "EnrolmentSetfromQuery";
            this.enrolmentSetfromQuery.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.DocumentMapWidth = 61;
            reportDataSource1.Name = "enrolmentv2";
            reportDataSource1.Value = this.enrolmentSetfromQueryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PotteryDBA_V1._0.Reports.EnrolmentV2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 380);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // getParticipantsTableAdapter1
            // 
            this.getParticipantsTableAdapter1.ClearBeforeFill = true;
            // 
            // btnMainMenuHelpDone
            // 
            this.btnMainMenuHelpDone.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenuHelpDone.Location = new System.Drawing.Point(308, 401);
            this.btnMainMenuHelpDone.Name = "btnMainMenuHelpDone";
            this.btnMainMenuHelpDone.Size = new System.Drawing.Size(177, 37);
            this.btnMainMenuHelpDone.TabIndex = 23;
            this.btnMainMenuHelpDone.Text = "Done";
            this.btnMainMenuHelpDone.UseVisualStyleBackColor = true;
            this.btnMainMenuHelpDone.Click += new System.EventHandler(this.btnMainMenuHelpDone_Click);
            // 
            // FrmEnrolmentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMainMenuHelpDone);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEnrolmentReport";
            this.Text = "Enrolment Report";
            this.Load += new System.EventHandler(this.FrmEnrolmentReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enrolmentSetfromQueryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enrolmentSetfromQuery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource enrolmentSetfromQueryBindingSource;
        private DataSets.EnrolmentSetfromQuery enrolmentSetfromQuery;
        private DataSets.EnrolmentSetfromQueryTableAdapters.getParticipantsTableAdapter getParticipantsTableAdapter1;
        private System.Windows.Forms.Button btnMainMenuHelpDone;
    }
}