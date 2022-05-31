namespace CanteenVoter
{
    partial class MainPage
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMenuA = new System.Windows.Forms.Button();
            this.btnMenuB = new System.Windows.Forms.Button();
            this.btnMenuC = new System.Windows.Forms.Button();
            this.dataMenu = new System.Windows.Forms.DataGridView();
            this.MainSplit = new System.Windows.Forms.SplitContainer();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnMyAccount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenuD = new System.Windows.Forms.Button();
            this.lbClose = new System.Windows.Forms.Label();
            this.MainPageHeader = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbAdminPanel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplit)).BeginInit();
            this.MainSplit.Panel1.SuspendLayout();
            this.MainSplit.Panel2.SuspendLayout();
            this.MainSplit.SuspendLayout();
            this.MainPageHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMenuA
            // 
            this.btnMenuA.BackColor = System.Drawing.Color.GhostWhite;
            this.btnMenuA.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnMenuA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuA.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuA.ForeColor = System.Drawing.Color.Black;
            this.btnMenuA.Location = new System.Drawing.Point(195, 44);
            this.btnMenuA.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenuA.Name = "btnMenuA";
            this.btnMenuA.Size = new System.Drawing.Size(119, 44);
            this.btnMenuA.TabIndex = 0;
            this.btnMenuA.Text = "Menü A\r\n(Normal Kost)";
            this.btnMenuA.UseVisualStyleBackColor = false;
            this.btnMenuA.Click += new System.EventHandler(this.btnMenuA_Click);
            // 
            // btnMenuB
            // 
            this.btnMenuB.BackColor = System.Drawing.Color.GhostWhite;
            this.btnMenuB.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnMenuB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuB.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuB.ForeColor = System.Drawing.Color.Black;
            this.btnMenuB.Location = new System.Drawing.Point(346, 44);
            this.btnMenuB.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenuB.Name = "btnMenuB";
            this.btnMenuB.Size = new System.Drawing.Size(119, 44);
            this.btnMenuB.TabIndex = 1;
            this.btnMenuB.Text = "Menü B\r\n(Vegan)";
            this.btnMenuB.UseVisualStyleBackColor = false;
            this.btnMenuB.Click += new System.EventHandler(this.btnMenuB_Click);
            // 
            // btnMenuC
            // 
            this.btnMenuC.BackColor = System.Drawing.Color.GhostWhite;
            this.btnMenuC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnMenuC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuC.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuC.ForeColor = System.Drawing.Color.Black;
            this.btnMenuC.Location = new System.Drawing.Point(498, 44);
            this.btnMenuC.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenuC.Name = "btnMenuC";
            this.btnMenuC.Size = new System.Drawing.Size(119, 44);
            this.btnMenuC.TabIndex = 2;
            this.btnMenuC.Text = "Menü C\r\n(Vegetarisch)";
            this.btnMenuC.UseVisualStyleBackColor = false;
            this.btnMenuC.Click += new System.EventHandler(this.btnMenuC_Click);
            // 
            // dataMenu
            // 
            this.dataMenu.AllowUserToAddRows = false;
            this.dataMenu.AllowUserToDeleteRows = false;
            this.dataMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataMenu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataMenu.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataMenu.Location = new System.Drawing.Point(0, 0);
            this.dataMenu.Margin = new System.Windows.Forms.Padding(4);
            this.dataMenu.Name = "dataMenu";
            this.dataMenu.ReadOnly = true;
            this.dataMenu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataMenu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataMenu.Size = new System.Drawing.Size(972, 424);
            this.dataMenu.TabIndex = 3;
            // 
            // MainSplit
            // 
            this.MainSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.MainSplit.IsSplitterFixed = true;
            this.MainSplit.Location = new System.Drawing.Point(0, 34);
            this.MainSplit.Margin = new System.Windows.Forms.Padding(4);
            this.MainSplit.Name = "MainSplit";
            this.MainSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MainSplit.Panel1
            // 
            this.MainSplit.Panel1.BackgroundImage = global::CanteenVoter.Properties.Resources.background;
            this.MainSplit.Panel1.Controls.Add(this.dataMenu);
            // 
            // MainSplit.Panel2
            // 
            this.MainSplit.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.MainSplit.Panel2.BackgroundImage = global::CanteenVoter.Properties.Resources.background;
            this.MainSplit.Panel2.Controls.Add(this.btnUpdate);
            this.MainSplit.Panel2.Controls.Add(this.btnMyAccount);
            this.MainSplit.Panel2.Controls.Add(this.label1);
            this.MainSplit.Panel2.Controls.Add(this.btnMenuD);
            this.MainSplit.Panel2.Controls.Add(this.btnMenuC);
            this.MainSplit.Panel2.Controls.Add(this.btnMenuA);
            this.MainSplit.Panel2.Controls.Add(this.btnMenuB);
            this.MainSplit.Size = new System.Drawing.Size(972, 528);
            this.MainSplit.SplitterDistance = 424;
            this.MainSplit.SplitterWidth = 5;
            this.MainSplit.TabIndex = 4;
            this.MainSplit.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.GhostWhite;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(842, 12);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 28);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Aktualisieren";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnMyAccount
            // 
            this.btnMyAccount.BackColor = System.Drawing.Color.GhostWhite;
            this.btnMyAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnMyAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyAccount.Font = new System.Drawing.Font("Nirmala UI", 9F);
            this.btnMyAccount.ForeColor = System.Drawing.Color.Black;
            this.btnMyAccount.Location = new System.Drawing.Point(842, 49);
            this.btnMyAccount.Margin = new System.Windows.Forms.Padding(4);
            this.btnMyAccount.Name = "btnMyAccount";
            this.btnMyAccount.Size = new System.Drawing.Size(117, 39);
            this.btnMyAccount.TabIndex = 6;
            this.btnMyAccount.Text = "Mein Konto";
            this.btnMyAccount.UseVisualStyleBackColor = false;
            this.btnMyAccount.Click += new System.EventHandler(this.btnMyAccount_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "Suche dir dein gewünschtes Menü aus\r\nund klicke dann auf den jeweiligen Button.";
            // 
            // btnMenuD
            // 
            this.btnMenuD.BackColor = System.Drawing.Color.GhostWhite;
            this.btnMenuD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnMenuD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuD.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuD.ForeColor = System.Drawing.Color.Black;
            this.btnMenuD.Location = new System.Drawing.Point(647, 44);
            this.btnMenuD.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenuD.Name = "btnMenuD";
            this.btnMenuD.Size = new System.Drawing.Size(119, 44);
            this.btnMenuD.TabIndex = 3;
            this.btnMenuD.Text = "Menü D\r\n(Gluten-/Lak.- Frei)";
            this.btnMenuD.UseVisualStyleBackColor = false;
            this.btnMenuD.Click += new System.EventHandler(this.btnMenuD_Click);
            // 
            // lbClose
            // 
            this.lbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbClose.AutoSize = true;
            this.lbClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbClose.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClose.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbClose.Location = new System.Drawing.Point(896, 5);
            this.lbClose.Name = "lbClose";
            this.lbClose.Size = new System.Drawing.Size(73, 21);
            this.lbClose.TabIndex = 19;
            this.lbClose.Text = "LOGOUT";
            this.lbClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbClose.Click += new System.EventHandler(this.lbClose_Click);
            // 
            // MainPageHeader
            // 
            this.MainPageHeader.BackColor = System.Drawing.Color.Transparent;
            this.MainPageHeader.Controls.Add(this.label2);
            this.MainPageHeader.Controls.Add(this.lbAdminPanel);
            this.MainPageHeader.Controls.Add(this.lbClose);
            this.MainPageHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPageHeader.Location = new System.Drawing.Point(0, 0);
            this.MainPageHeader.Name = "MainPageHeader";
            this.MainPageHeader.Size = new System.Drawing.Size(972, 34);
            this.MainPageHeader.TabIndex = 20;
            this.MainPageHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPageHeader_MouseDown);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.GhostWhite;
            this.label2.Location = new System.Drawing.Point(408, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Kantinen-Voting";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // lbAdminPanel
            // 
            this.lbAdminPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAdminPanel.AutoSize = true;
            this.lbAdminPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbAdminPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbAdminPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbAdminPanel.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdminPanel.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbAdminPanel.Location = new System.Drawing.Point(5, 6);
            this.lbAdminPanel.Name = "lbAdminPanel";
            this.lbAdminPanel.Size = new System.Drawing.Size(77, 20);
            this.lbAdminPanel.TabIndex = 20;
            this.lbAdminPanel.Text = "> ADMIN";
            this.lbAdminPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbAdminPanel.Visible = false;
            this.lbAdminPanel.Click += new System.EventHandler(this.lbAdminPanel_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CanteenVoter.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(972, 562);
            this.Controls.Add(this.MainSplit);
            this.Controls.Add(this.MainPageHeader);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataMenu)).EndInit();
            this.MainSplit.Panel1.ResumeLayout(false);
            this.MainSplit.Panel2.ResumeLayout(false);
            this.MainSplit.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplit)).EndInit();
            this.MainSplit.ResumeLayout(false);
            this.MainPageHeader.ResumeLayout(false);
            this.MainPageHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMenuA;
        private System.Windows.Forms.Button btnMenuB;
        private System.Windows.Forms.Button btnMenuC;
        private System.Windows.Forms.DataGridView dataMenu;
        private System.Windows.Forms.SplitContainer MainSplit;
        private System.Windows.Forms.Button btnMenuD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMyAccount;
        private System.Windows.Forms.Label lbClose;
        private System.Windows.Forms.Panel MainPageHeader;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lbAdminPanel;
        private System.Windows.Forms.Label label2;
    }
}

