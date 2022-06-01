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
            System.Windows.Forms.RichTextBox txMonday;
            System.Windows.Forms.RichTextBox txTuesday;
            System.Windows.Forms.RichTextBox txWednesday;
            System.Windows.Forms.RichTextBox txThursday;
            System.Windows.Forms.RichTextBox txFriday;
            System.Windows.Forms.RichTextBox txSaturday;
            this.btnMenuA = new System.Windows.Forms.Button();
            this.btnMenuB = new System.Windows.Forms.Button();
            this.btnMenuC = new System.Windows.Forms.Button();
            this.dataMenu = new System.Windows.Forms.DataGridView();
            this.MainSplit = new System.Windows.Forms.SplitContainer();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnMyAccount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenuD = new System.Windows.Forms.Button();
            this.lbClose = new System.Windows.Forms.Label();
            this.MainPageHeader = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbAdminPanel = new System.Windows.Forms.Label();
            txMonday = new System.Windows.Forms.RichTextBox();
            txTuesday = new System.Windows.Forms.RichTextBox();
            txWednesday = new System.Windows.Forms.RichTextBox();
            txThursday = new System.Windows.Forms.RichTextBox();
            txFriday = new System.Windows.Forms.RichTextBox();
            txSaturday = new System.Windows.Forms.RichTextBox();
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
            this.btnMenuA.Location = new System.Drawing.Point(195, 63);
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
            this.btnMenuB.Location = new System.Drawing.Point(346, 63);
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
            this.btnMenuC.Location = new System.Drawing.Point(498, 63);
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
            this.dataMenu.MultiSelect = false;
            this.dataMenu.Name = "dataMenu";
            this.dataMenu.ReadOnly = true;
            this.dataMenu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataMenu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataMenu.Size = new System.Drawing.Size(972, 607);
            this.dataMenu.TabIndex = 3;
            this.dataMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMenu_CellClick);
            // 
            // MainSplit
            // 
            this.MainSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.MainSplit.IsSplitterFixed = true;
            this.MainSplit.Location = new System.Drawing.Point(0, 34);
            this.MainSplit.Margin = new System.Windows.Forms.Padding(0);
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
            this.MainSplit.Panel2.Controls.Add(txSaturday);
            this.MainSplit.Panel2.Controls.Add(txFriday);
            this.MainSplit.Panel2.Controls.Add(txThursday);
            this.MainSplit.Panel2.Controls.Add(txWednesday);
            this.MainSplit.Panel2.Controls.Add(txTuesday);
            this.MainSplit.Panel2.Controls.Add(txMonday);
            this.MainSplit.Panel2.Controls.Add(this.label5);
            this.MainSplit.Panel2.Controls.Add(this.label4);
            this.MainSplit.Panel2.Controls.Add(this.label8);
            this.MainSplit.Panel2.Controls.Add(this.label7);
            this.MainSplit.Panel2.Controls.Add(this.label6);
            this.MainSplit.Panel2.Controls.Add(this.label3);
            this.MainSplit.Panel2.Controls.Add(this.btnUpdate);
            this.MainSplit.Panel2.Controls.Add(this.btnMyAccount);
            this.MainSplit.Panel2.Controls.Add(this.label1);
            this.MainSplit.Panel2.Controls.Add(this.btnMenuD);
            this.MainSplit.Panel2.Controls.Add(this.btnMenuC);
            this.MainSplit.Panel2.Controls.Add(this.btnMenuA);
            this.MainSplit.Panel2.Controls.Add(this.btnMenuB);
            this.MainSplit.Size = new System.Drawing.Size(972, 726);
            this.MainSplit.SplitterDistance = 607;
            this.MainSplit.SplitterWidth = 5;
            this.MainSplit.TabIndex = 4;
            this.MainSplit.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.label8.Location = new System.Drawing.Point(721, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Samstag";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.label7.Location = new System.Drawing.Point(605, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Freitag";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.label6.Location = new System.Drawing.Point(492, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Donnerstag";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.label5.Location = new System.Drawing.Point(382, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mittwoch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.label4.Location = new System.Drawing.Point(269, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Dienstag";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.label3.Location = new System.Drawing.Point(158, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Montag";
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
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(4, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 85);
            this.label1.TabIndex = 5;
            this.label1.Text = "Suche dir für jeden Tag \r\ndein gewünschtes Menü.\r\nWähle dazu mit der Maus\r\nein Ge" +
    "richt und klicke dann \r\nauf den jeweiligen Button.\r\n";
            // 
            // btnMenuD
            // 
            this.btnMenuD.BackColor = System.Drawing.Color.GhostWhite;
            this.btnMenuD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnMenuD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuD.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuD.ForeColor = System.Drawing.Color.Black;
            this.btnMenuD.Location = new System.Drawing.Point(647, 63);
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
            // txMonday
            // 
            txMonday.BackColor = System.Drawing.Color.Lavender;
            txMonday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txMonday.DetectUrls = false;
            txMonday.ForeColor = System.Drawing.Color.Black;
            txMonday.Location = new System.Drawing.Point(161, 21);
            txMonday.Margin = new System.Windows.Forms.Padding(0);
            txMonday.Name = "txMonday";
            txMonday.ReadOnly = true;
            txMonday.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            txMonday.Size = new System.Drawing.Size(109, 40);
            txMonday.TabIndex = 20;
            txMonday.TabStop = false;
            txMonday.Text = "Menü D\n(Gluten-/Lak.-Frei)";
            // 
            // txTuesday
            // 
            txTuesday.BackColor = System.Drawing.Color.Lavender;
            txTuesday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txTuesday.DetectUrls = false;
            txTuesday.ForeColor = System.Drawing.Color.Black;
            txTuesday.Location = new System.Drawing.Point(273, 21);
            txTuesday.Margin = new System.Windows.Forms.Padding(0);
            txTuesday.Name = "txTuesday";
            txTuesday.ReadOnly = true;
            txTuesday.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            txTuesday.Size = new System.Drawing.Size(109, 40);
            txTuesday.TabIndex = 21;
            txTuesday.TabStop = false;
            txTuesday.Text = "Menü D\n(Gluten-/Lak.-Frei)";
            // 
            // txWednesday
            // 
            txWednesday.BackColor = System.Drawing.Color.Lavender;
            txWednesday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txWednesday.DetectUrls = false;
            txWednesday.ForeColor = System.Drawing.Color.Black;
            txWednesday.Location = new System.Drawing.Point(385, 21);
            txWednesday.Margin = new System.Windows.Forms.Padding(0);
            txWednesday.Name = "txWednesday";
            txWednesday.ReadOnly = true;
            txWednesday.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            txWednesday.Size = new System.Drawing.Size(109, 40);
            txWednesday.TabIndex = 22;
            txWednesday.TabStop = false;
            txWednesday.Text = "Menü D\n(Gluten-/Lak.-Frei)";
            // 
            // txThursday
            // 
            txThursday.BackColor = System.Drawing.Color.Lavender;
            txThursday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txThursday.DetectUrls = false;
            txThursday.ForeColor = System.Drawing.Color.Black;
            txThursday.Location = new System.Drawing.Point(497, 21);
            txThursday.Margin = new System.Windows.Forms.Padding(0);
            txThursday.Name = "txThursday";
            txThursday.ReadOnly = true;
            txThursday.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            txThursday.Size = new System.Drawing.Size(109, 40);
            txThursday.TabIndex = 23;
            txThursday.TabStop = false;
            txThursday.Text = "Menü D\n(Gluten-/Lak.-Frei)";
            // 
            // txFriday
            // 
            txFriday.BackColor = System.Drawing.Color.Lavender;
            txFriday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txFriday.DetectUrls = false;
            txFriday.ForeColor = System.Drawing.Color.Black;
            txFriday.Location = new System.Drawing.Point(609, 21);
            txFriday.Margin = new System.Windows.Forms.Padding(0);
            txFriday.Name = "txFriday";
            txFriday.ReadOnly = true;
            txFriday.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            txFriday.Size = new System.Drawing.Size(109, 40);
            txFriday.TabIndex = 24;
            txFriday.TabStop = false;
            txFriday.Text = "Menü D\n(Gluten-/Lak.-Frei)";
            // 
            // txSaturday
            // 
            txSaturday.BackColor = System.Drawing.Color.Lavender;
            txSaturday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txSaturday.DetectUrls = false;
            txSaturday.ForeColor = System.Drawing.Color.Black;
            txSaturday.Location = new System.Drawing.Point(721, 21);
            txSaturday.Margin = new System.Windows.Forms.Padding(0);
            txSaturday.Name = "txSaturday";
            txSaturday.ReadOnly = true;
            txSaturday.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            txSaturday.Size = new System.Drawing.Size(109, 40);
            txSaturday.TabIndex = 25;
            txSaturday.TabStop = false;
            txSaturday.Text = "Menü D\n(Gluten-/Lak.-Frei)";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CanteenVoter.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(972, 760);
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

