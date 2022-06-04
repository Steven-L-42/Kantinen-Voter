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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmbMenue = new System.Windows.Forms.ComboBox();
            this.txSuturday = new System.Windows.Forms.RichTextBox();
            this.txFriday = new System.Windows.Forms.RichTextBox();
            this.txThursday = new System.Windows.Forms.RichTextBox();
            this.txWednesday = new System.Windows.Forms.RichTextBox();
            this.txTuesday = new System.Windows.Forms.RichTextBox();
            this.txMonday = new System.Windows.Forms.RichTextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.AdminPageHeader = new System.Windows.Forms.Panel();
            this.lbMenu = new System.Windows.Forms.Label();
            this.lbWed = new System.Windows.Forms.Label();
            this.lbTue = new System.Windows.Forms.Label();
            this.lbSat = new System.Windows.Forms.Label();
            this.lbFri = new System.Windows.Forms.Label();
            this.lbThu = new System.Windows.Forms.Label();
            this.lbMo = new System.Windows.Forms.Label();
            this.lbAdminPanel = new System.Windows.Forms.Label();
            this.lbClose = new System.Windows.Forms.Label();
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
            this.dataMenu.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataMenu.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataMenu.ColumnHeadersVisible = false;
            this.dataMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataMenu.Location = new System.Drawing.Point(0, 0);
            this.dataMenu.Margin = new System.Windows.Forms.Padding(0);
            this.dataMenu.Name = "dataMenu";
            this.dataMenu.ReadOnly = true;
            this.dataMenu.RowHeadersVisible = false;
            this.dataMenu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataMenu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMenu.ShowCellErrors = false;
            this.dataMenu.ShowEditingIcon = false;
            this.dataMenu.ShowRowErrors = false;
            this.dataMenu.Size = new System.Drawing.Size(972, 606);
            this.dataMenu.TabIndex = 3;
            this.dataMenu.TabStop = false;
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
            this.AdminSplit.Panel2.Controls.Add(this.comboBox1);
            this.AdminSplit.Panel2.Controls.Add(this.cmbMenue);
            this.AdminSplit.Panel2.Controls.Add(this.txSuturday);
            this.AdminSplit.Panel2.Controls.Add(this.txFriday);
            this.AdminSplit.Panel2.Controls.Add(this.txThursday);
            this.AdminSplit.Panel2.Controls.Add(this.txWednesday);
            this.AdminSplit.Panel2.Controls.Add(this.txTuesday);
            this.AdminSplit.Panel2.Controls.Add(this.txMonday);
            this.AdminSplit.Panel2.Controls.Add(this.btnInsert);
            this.AdminSplit.Panel2.Controls.Add(this.btnDelete);
            this.AdminSplit.Panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminPageHeader_MouseDown);
            this.AdminSplit.Size = new System.Drawing.Size(972, 767);
            this.AdminSplit.SplitterDistance = 606;
            this.AdminSplit.SplitterWidth = 7;
            this.AdminSplit.TabIndex = 5;
            this.AdminSplit.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.comboBox1.DropDownHeight = 150;
            this.comboBox1.DropDownWidth = 170;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Location = new System.Drawing.Point(4, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(146, 25);
            this.comboBox1.TabIndex = 10;
            // 
            // cmbMenue
            // 
            this.cmbMenue.BackColor = System.Drawing.Color.GhostWhite;
            this.cmbMenue.DropDownHeight = 150;
            this.cmbMenue.DropDownWidth = 170;
            this.cmbMenue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbMenue.ForeColor = System.Drawing.Color.Black;
            this.cmbMenue.FormattingEnabled = true;
            this.cmbMenue.IntegralHeight = false;
            this.cmbMenue.Location = new System.Drawing.Point(4, 18);
            this.cmbMenue.Name = "cmbMenue";
            this.cmbMenue.Size = new System.Drawing.Size(146, 25);
            this.cmbMenue.TabIndex = 1;

            // 
            // txSuturday
            // 
            this.txSuturday.BackColor = System.Drawing.Color.GhostWhite;
            this.txSuturday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txSuturday.Location = new System.Drawing.Point(528, 75);
            this.txSuturday.Name = "txSuturday";
            this.txSuturday.Size = new System.Drawing.Size(181, 63);
            this.txSuturday.TabIndex = 7;
            this.txSuturday.Text = "SAMSTAG";
            // 
            // txFriday
            // 
            this.txFriday.BackColor = System.Drawing.Color.GhostWhite;
            this.txFriday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txFriday.Location = new System.Drawing.Point(342, 75);
            this.txFriday.Name = "txFriday";
            this.txFriday.Size = new System.Drawing.Size(181, 63);
            this.txFriday.TabIndex = 6;
            this.txFriday.Text = "FREITAG";
            // 
            // txThursday
            // 
            this.txThursday.BackColor = System.Drawing.Color.GhostWhite;
            this.txThursday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txThursday.Location = new System.Drawing.Point(156, 75);
            this.txThursday.Name = "txThursday";
            this.txThursday.Size = new System.Drawing.Size(181, 63);
            this.txThursday.TabIndex = 5;
            this.txThursday.Text = "DONNERSTAG";
            // 
            // txWednesday
            // 
            this.txWednesday.BackColor = System.Drawing.Color.GhostWhite;
            this.txWednesday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txWednesday.Location = new System.Drawing.Point(528, 6);
            this.txWednesday.Name = "txWednesday";
            this.txWednesday.Size = new System.Drawing.Size(181, 63);
            this.txWednesday.TabIndex = 4;
            this.txWednesday.Text = "MITTWOCH";
            // 
            // txTuesday
            // 
            this.txTuesday.BackColor = System.Drawing.Color.GhostWhite;
            this.txTuesday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txTuesday.Location = new System.Drawing.Point(342, 6);
            this.txTuesday.Name = "txTuesday";
            this.txTuesday.Size = new System.Drawing.Size(181, 63);
            this.txTuesday.TabIndex = 3;
            this.txTuesday.Text = "DIENSTAG";
            // 
            // txMonday
            // 
            this.txMonday.BackColor = System.Drawing.Color.GhostWhite;
            this.txMonday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txMonday.Location = new System.Drawing.Point(156, 6);
            this.txMonday.Name = "txMonday";
            this.txMonday.Size = new System.Drawing.Size(181, 63);
            this.txMonday.TabIndex = 2;
            this.txMonday.Text = "MONTAG";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.GhostWhite;
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.Black;
            this.btnInsert.Location = new System.Drawing.Point(717, 19);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(5);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(136, 36);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "&Hinzufügen";
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
            this.btnDelete.Location = new System.Drawing.Point(717, 85);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 36);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "&Löschen";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // AdminPageHeader
            // 
            this.AdminPageHeader.BackColor = System.Drawing.Color.Transparent;
            this.AdminPageHeader.Controls.Add(this.lbMenu);
            this.AdminPageHeader.Controls.Add(this.lbWed);
            this.AdminPageHeader.Controls.Add(this.lbTue);
            this.AdminPageHeader.Controls.Add(this.lbSat);
            this.AdminPageHeader.Controls.Add(this.lbFri);
            this.AdminPageHeader.Controls.Add(this.lbThu);
            this.AdminPageHeader.Controls.Add(this.lbMo);
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
            // lbMenu
            // 
            this.lbMenu.AutoSize = true;
            this.lbMenu.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenu.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbMenu.Location = new System.Drawing.Point(48, 39);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(49, 17);
            this.lbMenu.TabIndex = 35;
            this.lbMenu.Text = "Menüs";
            this.lbMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminPageHeader_MouseDown);
            // 
            // lbWed
            // 
            this.lbWed.AutoSize = true;
            this.lbWed.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWed.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbWed.Location = new System.Drawing.Point(457, 39);
            this.lbWed.Name = "lbWed";
            this.lbWed.Size = new System.Drawing.Size(66, 17);
            this.lbWed.TabIndex = 31;
            this.lbWed.Text = "Mittwoch";
            this.lbWed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminPageHeader_MouseDown);
            // 
            // lbTue
            // 
            this.lbTue.AutoSize = true;
            this.lbTue.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTue.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbTue.Location = new System.Drawing.Point(319, 39);
            this.lbTue.Name = "lbTue";
            this.lbTue.Size = new System.Drawing.Size(63, 17);
            this.lbTue.TabIndex = 30;
            this.lbTue.Text = "Dienstag";
            this.lbTue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminPageHeader_MouseDown);
            // 
            // lbSat
            // 
            this.lbSat.AutoSize = true;
            this.lbSat.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSat.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbSat.Location = new System.Drawing.Point(871, 39);
            this.lbSat.Name = "lbSat";
            this.lbSat.Size = new System.Drawing.Size(60, 17);
            this.lbSat.TabIndex = 34;
            this.lbSat.Text = "Samstag";
            this.lbSat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminPageHeader_MouseDown);
            // 
            // lbFri
            // 
            this.lbFri.AutoSize = true;
            this.lbFri.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFri.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbFri.Location = new System.Drawing.Point(738, 39);
            this.lbFri.Name = "lbFri";
            this.lbFri.Size = new System.Drawing.Size(51, 17);
            this.lbFri.TabIndex = 33;
            this.lbFri.Text = "Freitag";
            this.lbFri.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminPageHeader_MouseDown);
            // 
            // lbThu
            // 
            this.lbThu.AutoSize = true;
            this.lbThu.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThu.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbThu.Location = new System.Drawing.Point(585, 39);
            this.lbThu.Name = "lbThu";
            this.lbThu.Size = new System.Drawing.Size(80, 17);
            this.lbThu.TabIndex = 32;
            this.lbThu.Text = "Donnerstag";
            this.lbThu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminPageHeader_MouseDown);
            // 
            // lbMo
            // 
            this.lbMo.AutoSize = true;
            this.lbMo.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMo.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbMo.Location = new System.Drawing.Point(184, 39);
            this.lbMo.Name = "lbMo";
            this.lbMo.Size = new System.Drawing.Size(56, 17);
            this.lbMo.TabIndex = 29;
            this.lbMo.Text = "Montag";
            this.lbMo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminPageHeader_MouseDown);
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
            this.lbAdminPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminPageHeader_MouseDown);
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
            this.lbClose.TabIndex = 99;
            this.lbClose.Text = "X";
            this.lbClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbClose.Click += new System.EventHandler(this.lbClose_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CanteenVoter.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(972, 830);
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
        private System.Windows.Forms.Label lbMenu;
        private System.Windows.Forms.Label lbWed;
        private System.Windows.Forms.Label lbTue;
        private System.Windows.Forms.Label lbSat;
        private System.Windows.Forms.Label lbFri;
        private System.Windows.Forms.Label lbThu;
        private System.Windows.Forms.Label lbMo;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}