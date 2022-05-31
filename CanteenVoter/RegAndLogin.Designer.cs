namespace CanteenVoter
{
    partial class RegAndLogin
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
            this.chBoxPasswordShowL = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.RegLoginHeader = new System.Windows.Forms.Panel();
            this.lbClose = new System.Windows.Forms.Label();
            this.lbNoAccount = new System.Windows.Forms.Label();
            this.lbRegisterTab = new System.Windows.Forms.Label();
            this.txPasswordCompare = new System.Windows.Forms.TextBox();
            this.lbPasswordCompare = new System.Windows.Forms.Label();
            this.chBoxPasswordShow = new System.Windows.Forms.CheckBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txPassword = new System.Windows.Forms.TextBox();
            this.txUsername = new System.Windows.Forms.TextBox();
            this.lbExistAccount = new System.Windows.Forms.Label();
            this.lbAccountExist = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RegLoginHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // chBoxPasswordShowL
            // 
            this.chBoxPasswordShowL.AutoSize = true;
            this.chBoxPasswordShowL.BackColor = System.Drawing.Color.Transparent;
            this.chBoxPasswordShowL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chBoxPasswordShowL.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold);
            this.chBoxPasswordShowL.ForeColor = System.Drawing.Color.Gainsboro;
            this.chBoxPasswordShowL.Location = new System.Drawing.Point(117, 164);
            this.chBoxPasswordShowL.Name = "chBoxPasswordShowL";
            this.chBoxPasswordShowL.Size = new System.Drawing.Size(126, 19);
            this.chBoxPasswordShowL.TabIndex = 98;
            this.chBoxPasswordShowL.Text = "Passwort anzeigen";
            this.chBoxPasswordShowL.UseVisualStyleBackColor = false;
            this.chBoxPasswordShowL.CheckedChanged += new System.EventHandler(this.chBoxPasswordShowL_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(89, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Passwort:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(89, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Benutzername:";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.GhostWhite;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(98, 194);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(127, 30);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "EINLOGGEN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // RegLoginHeader
            // 
            this.RegLoginHeader.BackColor = System.Drawing.Color.Transparent;
            this.RegLoginHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RegLoginHeader.Controls.Add(this.label3);
            this.RegLoginHeader.Controls.Add(this.lbClose);
            this.RegLoginHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.RegLoginHeader.Location = new System.Drawing.Point(0, 0);
            this.RegLoginHeader.Name = "RegLoginHeader";
            this.RegLoginHeader.Size = new System.Drawing.Size(325, 29);
            this.RegLoginHeader.TabIndex = 1;
            this.RegLoginHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegLoginHeader_MouseDown);
            // 
            // lbClose
            // 
            this.lbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbClose.AutoSize = true;
            this.lbClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbClose.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClose.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbClose.Location = new System.Drawing.Point(298, 3);
            this.lbClose.Name = "lbClose";
            this.lbClose.Size = new System.Drawing.Size(24, 25);
            this.lbClose.TabIndex = 99;
            this.lbClose.Text = "X";
            this.lbClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbClose.Click += new System.EventHandler(this.lbClose_Click);
            // 
            // lbNoAccount
            // 
            this.lbNoAccount.AutoSize = true;
            this.lbNoAccount.BackColor = System.Drawing.Color.Transparent;
            this.lbNoAccount.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoAccount.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbNoAccount.Location = new System.Drawing.Point(112, 228);
            this.lbNoAccount.Name = "lbNoAccount";
            this.lbNoAccount.Size = new System.Drawing.Size(105, 15);
            this.lbNoAccount.TabIndex = 22;
            this.lbNoAccount.Text = "Noch kein Konto?";
            // 
            // lbRegisterTab
            // 
            this.lbRegisterTab.AutoSize = true;
            this.lbRegisterTab.BackColor = System.Drawing.Color.Transparent;
            this.lbRegisterTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbRegisterTab.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegisterTab.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbRegisterTab.Location = new System.Drawing.Point(105, 248);
            this.lbRegisterTab.Name = "lbRegisterTab";
            this.lbRegisterTab.Size = new System.Drawing.Size(124, 17);
            this.lbRegisterTab.TabIndex = 5;
            this.lbRegisterTab.Text = "KONTO ERSTELLEN";
            this.lbRegisterTab.Click += new System.EventHandler(this.lbRegisterTab_Click);
            // 
            // txPasswordCompare
            // 
            this.txPasswordCompare.BackColor = System.Drawing.Color.GhostWhite;
            this.txPasswordCompare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txPasswordCompare.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPasswordCompare.Location = new System.Drawing.Point(83, 184);
            this.txPasswordCompare.Name = "txPasswordCompare";
            this.txPasswordCompare.PasswordChar = '*';
            this.txPasswordCompare.Size = new System.Drawing.Size(163, 25);
            this.txPasswordCompare.TabIndex = 3;
            this.txPasswordCompare.Visible = false;
            this.txPasswordCompare.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txPasswordCompare_KeyDown);
            // 
            // lbPasswordCompare
            // 
            this.lbPasswordCompare.AutoSize = true;
            this.lbPasswordCompare.BackColor = System.Drawing.Color.Transparent;
            this.lbPasswordCompare.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPasswordCompare.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbPasswordCompare.Location = new System.Drawing.Point(88, 165);
            this.lbPasswordCompare.Name = "lbPasswordCompare";
            this.lbPasswordCompare.Size = new System.Drawing.Size(147, 17);
            this.lbPasswordCompare.TabIndex = 21;
            this.lbPasswordCompare.Text = "Passwort wiederholen:";
            this.lbPasswordCompare.Visible = false;
            // 
            // chBoxPasswordShow
            // 
            this.chBoxPasswordShow.AutoSize = true;
            this.chBoxPasswordShow.BackColor = System.Drawing.Color.Transparent;
            this.chBoxPasswordShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chBoxPasswordShow.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxPasswordShow.ForeColor = System.Drawing.Color.Gainsboro;
            this.chBoxPasswordShow.Location = new System.Drawing.Point(119, 209);
            this.chBoxPasswordShow.Name = "chBoxPasswordShow";
            this.chBoxPasswordShow.Size = new System.Drawing.Size(126, 19);
            this.chBoxPasswordShow.TabIndex = 97;
            this.chBoxPasswordShow.Text = "Passwort anzeigen";
            this.chBoxPasswordShow.UseVisualStyleBackColor = false;
            this.chBoxPasswordShow.Visible = false;
            this.chBoxPasswordShow.CheckedChanged += new System.EventHandler(this.chBoxPasswordShow_CheckedChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.GhostWhite;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.btnRegister.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.Location = new System.Drawing.Point(99, 236);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(127, 30);
            this.btnRegister.TabIndex = 17;
            this.btnRegister.Text = "REGISTRIEREN";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Visible = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txPassword
            // 
            this.txPassword.BackColor = System.Drawing.Color.GhostWhite;
            this.txPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txPassword.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPassword.Location = new System.Drawing.Point(83, 139);
            this.txPassword.Name = "txPassword";
            this.txPassword.PasswordChar = '*';
            this.txPassword.Size = new System.Drawing.Size(163, 25);
            this.txPassword.TabIndex = 1;
            this.txPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txPassword_KeyDown);
            // 
            // txUsername
            // 
            this.txUsername.BackColor = System.Drawing.Color.GhostWhite;
            this.txUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txUsername.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txUsername.Location = new System.Drawing.Point(83, 94);
            this.txUsername.Name = "txUsername";
            this.txUsername.Size = new System.Drawing.Size(163, 25);
            this.txUsername.TabIndex = 0;
            // 
            // lbExistAccount
            // 
            this.lbExistAccount.AutoSize = true;
            this.lbExistAccount.BackColor = System.Drawing.Color.Transparent;
            this.lbExistAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbExistAccount.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExistAccount.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbExistAccount.Location = new System.Drawing.Point(86, 291);
            this.lbExistAccount.Name = "lbExistAccount";
            this.lbExistAccount.Size = new System.Drawing.Size(156, 17);
            this.lbExistAccount.TabIndex = 6;
            this.lbExistAccount.Text = "MIT KONTO ANMELDEN";
            this.lbExistAccount.Visible = false;
            this.lbExistAccount.Click += new System.EventHandler(this.lbExistAccount_Click);
            // 
            // lbAccountExist
            // 
            this.lbAccountExist.AutoSize = true;
            this.lbAccountExist.BackColor = System.Drawing.Color.Transparent;
            this.lbAccountExist.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccountExist.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbAccountExist.Location = new System.Drawing.Point(89, 271);
            this.lbAccountExist.Name = "lbAccountExist";
            this.lbAccountExist.Size = new System.Drawing.Size(151, 15);
            this.lbAccountExist.TabIndex = 27;
            this.lbAccountExist.Text = "Konto bereits vorhanden?";
            this.lbAccountExist.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 99;
            this.label3.Text = "Kantinen-Voting";
            // 
            // RegAndLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CanteenVoter.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(325, 385);
            this.Controls.Add(this.lbAccountExist);
            this.Controls.Add(this.lbExistAccount);
            this.Controls.Add(this.txPassword);
            this.Controls.Add(this.txUsername);
            this.Controls.Add(this.lbRegisterTab);
            this.Controls.Add(this.lbNoAccount);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.chBoxPasswordShow);
            this.Controls.Add(this.lbPasswordCompare);
            this.Controls.Add(this.txPasswordCompare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RegLoginHeader);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.chBoxPasswordShowL);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegAndLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegAndLogin";
            this.Load += new System.EventHandler(this.RegAndLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegAndLogin_MouseDown);
            this.RegLoginHeader.ResumeLayout(false);
            this.RegLoginHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chBoxPasswordShowL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel RegLoginHeader;
        private System.Windows.Forms.Label lbClose;
        private System.Windows.Forms.Label lbNoAccount;
        private System.Windows.Forms.Label lbRegisterTab;
        private System.Windows.Forms.Label lbPasswordCompare;
        private System.Windows.Forms.CheckBox chBoxPasswordShow;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txUsername;
        private System.Windows.Forms.Label lbAccountExist;
        public System.Windows.Forms.Label lbExistAccount;
        private System.Windows.Forms.TextBox txPassword;
        private System.Windows.Forms.TextBox txPasswordCompare;
        private System.Windows.Forms.Label label3;
    }
}