namespace PotteryDBA_V1._0.Forms
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pictoff = new System.Windows.Forms.PictureBox();
            this.picton = new System.Windows.Forms.PictureBox();
            this.menuLogin = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGINDETAILSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictoff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picton)).BeginInit();
            this.menuLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Yu Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Black;
            this.lblLogin.Location = new System.Drawing.Point(137, 22);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(74, 31);
            this.lblLogin.TabIndex = 8;
            this.lblLogin.Text = "Login";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.Location = new System.Drawing.Point(76, 127);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(166, 20);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(73, 108);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(61, 16);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(76, 86);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 20);
            this.txtUsername.TabIndex = 10;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Black;
            this.lblUsername.Location = new System.Drawing.Point(73, 67);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(64, 16);
            this.lblUsername.TabIndex = 9;
            this.lblUsername.Text = "Username";
            // 
            // pictoff
            // 
            this.pictoff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictoff.Image = global::PotteryDBA_V1._0.Properties.Resources.Not_Visible_Eye;
            this.pictoff.Location = new System.Drawing.Point(248, 127);
            this.pictoff.Name = "pictoff";
            this.pictoff.Size = new System.Drawing.Size(27, 19);
            this.pictoff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictoff.TabIndex = 13;
            this.pictoff.TabStop = false;
            this.pictoff.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picton
            // 
            this.picton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picton.Image = global::PotteryDBA_V1._0.Properties.Resources.Visible_Eye;
            this.picton.Location = new System.Drawing.Point(248, 127);
            this.picton.Name = "picton";
            this.picton.Size = new System.Drawing.Size(27, 19);
            this.picton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picton.TabIndex = 14;
            this.picton.TabStop = false;
            this.picton.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuLogin
            // 
            this.menuLogin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuLogin.Location = new System.Drawing.Point(0, 0);
            this.menuLogin.Name = "menuLogin";
            this.menuLogin.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuLogin.Size = new System.Drawing.Size(348, 24);
            this.menuLogin.TabIndex = 15;
            this.menuLogin.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.lOGINDETAILSToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lOGINDETAILSToolStripMenuItem
            // 
            this.lOGINDETAILSToolStripMenuItem.Name = "lOGINDETAILSToolStripMenuItem";
            this.lOGINDETAILSToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.lOGINDETAILSToolStripMenuItem.Text = "*LOGIN DETAILS*";
            this.lOGINDETAILSToolStripMenuItem.Click += new System.EventHandler(this.lOGINDETAILSToolStripMenuItem_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(86, 171);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(177, 37);
            this.btnLogin.TabIndex = 16;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 247);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.picton);
            this.Controls.Add(this.pictoff);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.menuLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuLogin;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.Text = "Lakeside Escapes";
            ((System.ComponentModel.ISupportInitialize)(this.pictoff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picton)).EndInit();
            this.menuLogin.ResumeLayout(false);
            this.menuLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pictoff;
        private System.Windows.Forms.PictureBox picton;
        private System.Windows.Forms.MenuStrip menuLogin;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGINDETAILSToolStripMenuItem;
        private System.Windows.Forms.Button btnLogin;
    }
}