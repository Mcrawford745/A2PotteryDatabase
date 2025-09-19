namespace PotteryDBA_V1._0.Forms
{
    partial class FrmMaintainance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMaintainance));
            this.lblMaintainance = new System.Windows.Forms.Label();
            this.btnMainMenuHelpDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaintainance
            // 
            this.lblMaintainance.AutoSize = true;
            this.lblMaintainance.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaintainance.ForeColor = System.Drawing.Color.Black;
            this.lblMaintainance.Location = new System.Drawing.Point(80, 28);
            this.lblMaintainance.Name = "lblMaintainance";
            this.lblMaintainance.Size = new System.Drawing.Size(282, 62);
            this.lblMaintainance.TabIndex = 3;
            this.lblMaintainance.Text = "This section is currently \r\nunder development.";
            this.lblMaintainance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMainMenuHelpDone
            // 
            this.btnMainMenuHelpDone.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenuHelpDone.Location = new System.Drawing.Point(132, 100);
            this.btnMainMenuHelpDone.Name = "btnMainMenuHelpDone";
            this.btnMainMenuHelpDone.Size = new System.Drawing.Size(177, 37);
            this.btnMainMenuHelpDone.TabIndex = 7;
            this.btnMainMenuHelpDone.Text = "Done";
            this.btnMainMenuHelpDone.UseVisualStyleBackColor = true;
            this.btnMainMenuHelpDone.Click += new System.EventHandler(this.btnMainMenuHelpDone_Click);
            // 
            // FrmMaintainance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 161);
            this.Controls.Add(this.btnMainMenuHelpDone);
            this.Controls.Add(this.lblMaintainance);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMaintainance";
            this.Text = "Section Under Maintainance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaintainance;
        private System.Windows.Forms.Button btnMainMenuHelpDone;
    }
}