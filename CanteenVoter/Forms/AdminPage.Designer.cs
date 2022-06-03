namespace CanteenVoter
{
    partial class AdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            this.dataMenu = new System.Windows.Forms.DataGridView();
            this.AdminSplit = new System.Windows.Forms.SplitContainer();
            this.cmbMenue = new System.Windows.Forms.ComboBox();
            this.txSuturday = new System.Windows.Forms.RichTextBox();
            this.txFriday = new System.Windows.Forms.RichTextBox();
            this.txThursday = new System.Windows.Forms.RichTextBox();
            this.txWednesday = new System.Windows.Forms.RichTextBox();
            this.txTuesday = new System.Windows.Forms.RichTextBox();
            this.txMonday = new System.Windows.Forms.RichTextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.AdminPageHeader = new System.Windows.Forms.Panel();
            this.lbAdminPanel = new System.Windows.Forms.Label();
            this.lbClose = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminSplit)).BeginInit();
            this.AdminSplit.Panel1.SuspendLayout();
            this.AdminSplit.Panel2.SuspendLayout();
            this.AdminSplit.SuspendLayout();
            this.AdminPageHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataMenu
            // 
            this.dataMenu.AllowUserToAddRows = false;
            this.dataMenu.AllowUserToDeleteRows = false;
            this.dataMenu.AllowUserToResizeColumns = false;
            this.dataMenu.AllowUserToResizeRows = false;
            this.dataMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataMenu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataMenu.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataMenu.ColumnHeadersVisible = false;
            this.dataMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataMenu.Location = new System.Drawing.Point(0, 0);
            this.dataMenu.Margin = new System.Windows.Forms.Padding(5);
            this.dataMenu.Name = "dataMenu";
            this.dataMenu.ReadOnly = true;
            this.dataMenu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataMenu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMenu.Size = new System.Drawing.Size(972, 583);
            this.dataMenu.TabIndex = 3;
            this.dataMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMenu_CellClick);
            // 
            // AdminSplit
            // 
            this.AdminSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.AdminSplit.IsSplitterFixed = true;
            this.AdminSplit.Location = new System.Drawing.Point(0, 63);
            this.AdminSplit.Margin = new System.Windows.Forms.Padding(5);
            this.AdminSplit.Name = "AdminSplit";
            this.AdminSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // AdminSplit.Panel1
            // 
            this.AdminSplit.Panel1.Controls.Add(this.dataMenu);
            // 
            // AdminSplit.Panel2
            // 
            this.AdminSplit.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.AdminSplit.Panel2.BackgroundImage = global::CanteenVoter.Properties.Resources.background;
            this.AdminSplit.Panel2.Controls.Add(this.cmbMenue);
            this.AdminSplit.Panel2.Controls.Add(this.txSuturday);
            this.AdminSplit.Panel2.Controls.Add(this.txFriday);
            this.AdminSplit.Panel2.Controls.Add(this.txThursday);
            this.AdminSplit.Panel2.Controls.Add(this.txWednesday);
            this.AdminSplit.Panel2.Controls.Add(this.txTuesday);
            this.AdminSplit.Panel2.Controls.Add(this.txMonday);
            this.AdminSplit.Panel2.Controls.Add(this.btnUpdate);
            this.AdminSplit.Panel2.Controls.Add(this.button3);
            this.AdminSplit.Panel2.Controls.Add(this.btnInsert);
            this.AdminSplit.Panel2.Controls.Add(this.btnDelete);
            this.AdminSplit.Size = new System.Drawing.Size(972, 737);
            this.AdminSplit.SplitterDistance = 583;
            this.AdminSplit.SplitterWidth = 7;
            this.AdminSplit.TabIndex = 5;
            this.AdminSplit.TabStop = false;
            // 
            // cmbMenue
            // 
            this.cmbMenue.BackColor = System.Drawing.Color.GhostWhite;
            this.cmbMenue.DropDownHeight = 150;
            this.cmbMenue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMenue.DropDownWidth = 170;
            this.cmbMenue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbMenue.ForeColor = System.Drawing.Color.Black;
            this.cmbMenue.FormattingEnabled = true;
            this.cmbMenue.IntegralHeight = false;
            this.cmbMenue.Location = new System.Drawing.Point(4, 18);
            this.cmbMenue.Name = "cmbMenue";
            this.cmbMenue.Size = new System.Drawing.Size(117, 25);
            this.cmbMenue.TabIndex = 11;
            // 
            // txSuturday
            // 
            this.txSuturday.BackColor = System.Drawing.Color.GhostWhite;
            this.txSuturday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txSuturday.Location = new System.Drawing.Point(496, 74);
            this.txSuturday.Name = "txSuturday";
            this.txSuturday.Size = new System.Drawing.Size(181, 63);
            this.txSuturday.TabIndex = 10;
            this.txSuturday.Text = "SAMSTAG";
            // 
            // txFriday
            // 
            this.txFriday.BackColor = System.Drawing.Color.GhostWhite;
            this.txFriday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txFriday.Location = new System.Drawing.Point(310, 74);
            this.txFriday.Name = "txFriday";
            this.txFriday.Size = new System.Drawing.Size(181, 63);
            this.txFriday.TabIndex = 9;
            this.txFriday.Text = "FREITAG";
            // 
            // txThursday
            // 
            this.txThursday.BackColor = System.Drawing.Color.GhostWhite;
            this.txThursday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txThursday.Location = new System.Drawing.Point(124, 74);
            this.txThursday.Name = "txThursday";
            this.txThursday.Size = new System.Drawing.Size(181, 63);
            this.txThursday.TabIndex = 8;
            this.txThursday.Text = "DONNERSTAG";
            // 
            // txWednesday
            // 
            this.txWednesday.BackColor = System.Drawing.Color.GhostWhite;
            this.txWednesday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txWednesday.Location = new System.Drawing.Point(496, 5);
            this.txWednesday.Name = "txWednesday";
            this.txWednesday.Size = new System.Drawing.Size(181, 63);
            this.txWednesday.TabIndex = 7;
            this.txWednesday.Text = "MITTWOCH";
            // 
            // txTuesday
            // 
            this.txTuesday.BackColor = System.Drawing.Color.GhostWhite;
            this.txTuesday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txTuesday.Location = new System.Drawing.Point(310, 5);
            this.txTuesday.Name = "txTuesday";
            this.txTuesday.Size = new System.Drawing.Size(181, 63);
            this.txTuesday.TabIndex = 6;
            this.txTuesday.Text = "DIENSTAG";
            // 
            // txMonday
            // 
            this.txMonday.BackColor = System.Drawing.Color.GhostWhite;
            this.txMonday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txMonday.Location = new System.Drawing.Point(124, 5);
            this.txMonday.Name = "txMonday";
            this.txMonday.Size = new System.Drawing.Size(181, 63);
            this.txMonday.TabIndex = 5;
            this.txMonday.Text = "MONTAG";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.GhostWhite;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(827, 90);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(136, 31);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.GhostWhite;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(687, 17);
            this.button3.Margin = new System.Windows.Forms.Padding(5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 31);
            this.button3.TabIndex = 2;
            this.button3.Text = "Ändern";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.GhostWhite;
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.Black;
            this.btnInsert.Location = new System.Drawing.Point(687, 90);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(5);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(136, 31);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Hinzufügen";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.GhostWhite;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(827, 17);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 31);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Löschen";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // AdminPageHeader
            // 
            this.AdminPageHeader.BackColor = System.Drawing.Color.Transparent;
            this.AdminPageHeader.Controls.Add(this.label23);
            this.AdminPageHeader.Controls.Add(this.label17);
            this.AdminPageHeader.Controls.Add(this.label18);
            this.AdminPageHeader.Controls.Add(this.label19);
            this.AdminPageHeader.Controls.Add(this.label20);
            this.AdminPageHeader.Controls.Add(this.label21);
            this.AdminPageHeader.Controls.Add(this.label22);
            this.AdminPageHeader.Controls.Add(this.lbAdminPanel);
            this.AdminPageHeader.Controls.Add(this.lbClose);
            this.AdminPageHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.AdminPageHeader.ForeColor = System.Drawing.Color.Black;
            this.AdminPageHeader.Location = new System.Drawing.Point(0, 0);
            this.AdminPageHeader.Name = "AdminPageHeader";
            this.AdminPageHeader.Size = new System.Drawing.Size(972, 63);
            this.AdminPageHeader.TabIndex = 21;
            this.AdminPageHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminPageHeader_MouseDown);
            // 
            // lbAdminPanel
            // 
            this.lbAdminPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAdminPanel.AutoSize = true;
            this.lbAdminPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbAdminPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbAdminPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbAdminPanel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbAdminPanel.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbAdminPanel.Location = new System.Drawing.Point(411, 5);
            this.lbAdminPanel.Name = "lbAdminPanel";
            this.lbAdminPanel.Size = new System.Drawing.Size(127, 25);
            this.lbAdminPanel.TabIndex = 21;
            this.lbAdminPanel.Text = "Admin-Panel";
            this.lbAdminPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbClose
            // 
            this.lbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbClose.AutoSize = true;
            this.lbClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbClose.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClose.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbClose.Location = new System.Drawing.Point(941, 4);
            this.lbClose.Name = "lbClose";
            this.lbClose.Size = new System.Drawing.Size(24, 25);
            this.lbClose.TabIndex = 19;
            this.lbClose.Text = "X";
            this.lbClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbClose.Click += new System.EventHandler(this.lbClose_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.GhostWhite;
            this.label23.Location = new System.Drawing.Point(81, 39);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(49, 17);
            this.label23.TabIndex = 35;
            this.label23.Text = "Menüs";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.GhostWhite;
            this.label17.Location = new System.Drawing.Point(473, 39);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 17);
            this.label17.TabIndex = 31;
            this.label17.Text = "Mittwoch";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.GhostWhite;
            this.label18.Location = new System.Drawing.Point(341, 39);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 17);
            this.label18.TabIndex = 30;
            this.label18.Text = "Dienstag";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.GhostWhite;
            this.label19.Location = new System.Drawing.Point(871, 39);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(60, 17);
            this.label19.TabIndex = 34;
            this.label19.Text = "Samstag";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.GhostWhite;
            this.label20.Location = new System.Drawing.Point(746, 39);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 17);
            this.label20.TabIndex = 33;
            this.label20.Text = "Freitag";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.GhostWhite;
            this.label21.Location = new System.Drawing.Point(598, 39);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 17);
            this.label21.TabIndex = 32;
            this.label21.Text = "Donnerstag";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.GhostWhite;
            this.label22.Location = new System.Drawing.Point(214, 39);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(56, 17);
            this.label22.TabIndex = 29;
            this.label22.Text = "Montag";
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CanteenVoter.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(972, 800);
            this.Controls.Add(this.AdminSplit);
            this.Controls.Add(this.AdminPageHeader);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPage";
            this.Load += new System.EventHandler(this.AdminPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataMenu)).EndInit();
            this.AdminSplit.Panel1.ResumeLayout(false);
            this.AdminSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AdminSplit)).EndInit();
            this.AdminSplit.ResumeLayout(false);
            this.AdminPageHeader.ResumeLayout(false);
            this.AdminPageHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataMenu;
        private System.Windows.Forms.SplitContainer AdminSplit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.RichTextBox txSuturday;
        private System.Windows.Forms.RichTextBox txFriday;
        private System.Windows.Forms.RichTextBox txThursday;
        private System.Windows.Forms.RichTextBox txWednesday;
        private System.Windows.Forms.RichTextBox txTuesday;
        private System.Windows.Forms.RichTextBox txMonday;
        private System.Windows.Forms.Panel AdminPageHeader;
        private System.Windows.Forms.Label lbClose;
        private System.Windows.Forms.ComboBox cmbMenue;
        private System.Windows.Forms.Label lbAdminPanel;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
    }
}