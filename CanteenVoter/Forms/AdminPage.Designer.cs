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
            this.cmbThursday = new System.Windows.Forms.ComboBox();
            this.cmbMonday = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSaturday = new System.Windows.Forms.ComboBox();
            this.cmbFriday = new System.Windows.Forms.ComboBox();
            this.cmbWednesday = new System.Windows.Forms.ComboBox();
            this.cmbTuesday = new System.Windows.Forms.ComboBox();
            this.btnMenueList = new System.Windows.Forms.Button();
            this.cmbMenue = new System.Windows.Forms.ComboBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.AdminPageHeader = new System.Windows.Forms.Panel();
            this.btnAdminPanel = new System.Windows.Forms.Button();
            this.lbMenu = new System.Windows.Forms.Label();
            this.lbWed = new System.Windows.Forms.Label();
            this.lbTue = new System.Windows.Forms.Label();
            this.lbSat = new System.Windows.Forms.Label();
            this.lbFri = new System.Windows.Forms.Label();
            this.lbThu = new System.Windows.Forms.Label();
            this.lbMo = new System.Windows.Forms.Label();
            this.lbAdminPanel = new System.Windows.Forms.Label();
            this.lbClose = new System.Windows.Forms.Label();
            this.AdminToolTip = new ReaLTaiizor.Controls.PoisonToolTip();
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
            this.dataMenu.Size = new System.Drawing.Size(972, 610);
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
            this.AdminSplit.Panel2.Controls.Add(this.cmbThursday);
            this.AdminSplit.Panel2.Controls.Add(this.cmbMonday);
            this.AdminSplit.Panel2.Controls.Add(this.label1);
            this.AdminSplit.Panel2.Controls.Add(this.cmbSaturday);
            this.AdminSplit.Panel2.Controls.Add(this.cmbFriday);
            this.AdminSplit.Panel2.Controls.Add(this.cmbWednesday);
            this.AdminSplit.Panel2.Controls.Add(this.cmbTuesday);
            this.AdminSplit.Panel2.Controls.Add(this.btnMenueList);
            this.AdminSplit.Panel2.Controls.Add(this.cmbMenue);
            this.AdminSplit.Panel2.Controls.Add(this.btnInsert);
            this.AdminSplit.Panel2.Controls.Add(this.btnDelete);
            this.AdminSplit.Panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminPageHeader_MouseDown);
            this.AdminSplit.Size = new System.Drawing.Size(972, 767);
            this.AdminSplit.SplitterDistance = 610;
            this.AdminSplit.SplitterWidth = 7;
            this.AdminSplit.TabIndex = 5;
            this.AdminSplit.TabStop = false;
            // 
            // cmbThursday
            // 
            this.cmbThursday.BackColor = System.Drawing.Color.GhostWhite;
            this.cmbThursday.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbThursday.DropDownHeight = 205;
            this.cmbThursday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbThursday.DropDownWidth = 170;
            this.cmbThursday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbThursday.ForeColor = System.Drawing.Color.Black;
            this.cmbThursday.FormattingEnabled = true;
            this.cmbThursday.IntegralHeight = false;
            this.cmbThursday.ItemHeight = 58;
            this.cmbThursday.Location = new System.Drawing.Point(157, 75);
            this.cmbThursday.MaxDropDownItems = 32;
            this.cmbThursday.Name = "cmbThursday";
            this.cmbThursday.Size = new System.Drawing.Size(204, 64);
            this.cmbThursday.TabIndex = 14;
            this.cmbThursday.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbThursday_DrawItem);
            this.cmbThursday.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.cmbMonday_MeasureItem);
            // 
            // cmbMonday
            // 
            this.cmbMonday.BackColor = System.Drawing.Color.GhostWhite;
            this.cmbMonday.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbMonday.DropDownHeight = 205;
            this.cmbMonday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonday.DropDownWidth = 170;
            this.cmbMonday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMonday.ForeColor = System.Drawing.Color.Black;
            this.cmbMonday.FormattingEnabled = true;
            this.cmbMonday.IntegralHeight = false;
            this.cmbMonday.ItemHeight = 58;
            this.cmbMonday.Location = new System.Drawing.Point(157, 6);
            this.cmbMonday.MaxDropDownItems = 32;
            this.cmbMonday.Name = "cmbMonday";
            this.cmbMonday.Size = new System.Drawing.Size(204, 64);
            this.cmbMonday.TabIndex = 11;
            this.cmbMonday.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbMonday_DrawItem);
            this.cmbMonday.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.cmbMonday_MeasureItem);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(785, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 30);
            this.label1.TabIndex = 17;
            this.label1.Text = "Erstelle hier den Speiseplan\r\nfür eine ganze Woche.";
            // 
            // cmbSaturday
            // 
            this.cmbSaturday.BackColor = System.Drawing.Color.GhostWhite;
            this.cmbSaturday.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbSaturday.DropDownHeight = 205;
            this.cmbSaturday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSaturday.DropDownWidth = 170;
            this.cmbSaturday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSaturday.ForeColor = System.Drawing.Color.Black;
            this.cmbSaturday.FormattingEnabled = true;
            this.cmbSaturday.IntegralHeight = false;
            this.cmbSaturday.ItemHeight = 58;
            this.cmbSaturday.Location = new System.Drawing.Point(577, 76);
            this.cmbSaturday.MaxDropDownItems = 32;
            this.cmbSaturday.Name = "cmbSaturday";
            this.cmbSaturday.Size = new System.Drawing.Size(204, 64);
            this.cmbSaturday.TabIndex = 16;
            this.cmbSaturday.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbSaturday_DrawItem);
            this.cmbSaturday.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.cmbMonday_MeasureItem);
            // 
            // cmbFriday
            // 
            this.cmbFriday.BackColor = System.Drawing.Color.GhostWhite;
            this.cmbFriday.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbFriday.DropDownHeight = 205;
            this.cmbFriday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFriday.DropDownWidth = 170;
            this.cmbFriday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFriday.ForeColor = System.Drawing.Color.Black;
            this.cmbFriday.FormattingEnabled = true;
            this.cmbFriday.IntegralHeight = false;
            this.cmbFriday.ItemHeight = 58;
            this.cmbFriday.Location = new System.Drawing.Point(367, 76);
            this.cmbFriday.MaxDropDownItems = 32;
            this.cmbFriday.Name = "cmbFriday";
            this.cmbFriday.Size = new System.Drawing.Size(204, 64);
            this.cmbFriday.TabIndex = 15;
            this.cmbFriday.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbFriday_DrawItem);
            this.cmbFriday.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.cmbMonday_MeasureItem);
            // 
            // cmbWednesday
            // 
            this.cmbWednesday.BackColor = System.Drawing.Color.GhostWhite;
            this.cmbWednesday.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbWednesday.DropDownHeight = 205;
            this.cmbWednesday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWednesday.DropDownWidth = 170;
            this.cmbWednesday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbWednesday.ForeColor = System.Drawing.Color.Black;
            this.cmbWednesday.FormattingEnabled = true;
            this.cmbWednesday.IntegralHeight = false;
            this.cmbWednesday.ItemHeight = 58;
            this.cmbWednesday.Location = new System.Drawing.Point(577, 6);
            this.cmbWednesday.MaxDropDownItems = 32;
            this.cmbWednesday.Name = "cmbWednesday";
            this.cmbWednesday.Size = new System.Drawing.Size(204, 64);
            this.cmbWednesday.TabIndex = 13;
            this.cmbWednesday.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbWednesday_DrawItem);
            this.cmbWednesday.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.cmbMonday_MeasureItem);
            // 
            // cmbTuesday
            // 
            this.cmbTuesday.BackColor = System.Drawing.Color.GhostWhite;
            this.cmbTuesday.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbTuesday.DropDownHeight = 205;
            this.cmbTuesday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTuesday.DropDownWidth = 170;
            this.cmbTuesday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTuesday.ForeColor = System.Drawing.Color.Black;
            this.cmbTuesday.FormattingEnabled = true;
            this.cmbTuesday.IntegralHeight = false;
            this.cmbTuesday.ItemHeight = 58;
            this.cmbTuesday.Location = new System.Drawing.Point(367, 6);
            this.cmbTuesday.MaxDropDownItems = 32;
            this.cmbTuesday.Name = "cmbTuesday";
            this.cmbTuesday.Size = new System.Drawing.Size(204, 64);
            this.cmbTuesday.TabIndex = 12;
            this.cmbTuesday.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbTuesday_DrawItem);
            this.cmbTuesday.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.cmbMonday_MeasureItem);
            // 
            // btnMenueList
            // 
            this.btnMenueList.BackColor = System.Drawing.Color.GhostWhite;
            this.btnMenueList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenueList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnMenueList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenueList.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenueList.ForeColor = System.Drawing.Color.Black;
            this.btnMenueList.Location = new System.Drawing.Point(10, 103);
            this.btnMenueList.Margin = new System.Windows.Forms.Padding(5);
            this.btnMenueList.Name = "btnMenueList";
            this.btnMenueList.Size = new System.Drawing.Size(136, 36);
            this.btnMenueList.TabIndex = 10;
            this.btnMenueList.Text = "&Menü Auswahl";
            this.AdminToolTip.SetToolTip(this.btnMenueList, "Hier kannst du für jedes Menü\r\neigene Gerichte erstellen.");
            this.btnMenueList.UseVisualStyleBackColor = false;
            this.btnMenueList.Click += new System.EventHandler(this.btnMenueList_Click);
            // 
            // cmbMenue
            // 
            this.cmbMenue.BackColor = System.Drawing.Color.GhostWhite;
            this.cmbMenue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbMenue.DropDownHeight = 205;
            this.cmbMenue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMenue.DropDownWidth = 170;
            this.cmbMenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMenue.ForeColor = System.Drawing.Color.Black;
            this.cmbMenue.FormattingEnabled = true;
            this.cmbMenue.IntegralHeight = false;
            this.cmbMenue.ItemHeight = 40;
            this.cmbMenue.Location = new System.Drawing.Point(4, 7);
            this.cmbMenue.Name = "cmbMenue";
            this.cmbMenue.Size = new System.Drawing.Size(146, 46);
            this.cmbMenue.TabIndex = 1;
            this.cmbMenue.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbMenue_DrawItem);
            this.cmbMenue.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.cmbMenue_MeasureItem);
            this.cmbMenue.SelectedIndexChanged += new System.EventHandler(this.cmbMenue_SelectedIndexChanged);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.GhostWhite;
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.Black;
            this.btnInsert.Location = new System.Drawing.Point(808, 45);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(5);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(136, 36);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "&Hinzufügen";
            this.AdminToolTip.SetToolTip(this.btnInsert, "Vor dem hinzufügen sicher sein\r\ndas alle Felder wie gewünscht\r\nausgewählt wurden." +
        "");
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
            this.btnDelete.Location = new System.Drawing.Point(808, 97);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 36);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "&Löschen";
            this.AdminToolTip.SetToolTip(this.btnDelete, "Das löschen ist nicht umkehrbar.");
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // AdminPageHeader
            // 
            this.AdminPageHeader.BackColor = System.Drawing.Color.Transparent;
            this.AdminPageHeader.Controls.Add(this.btnAdminPanel);
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
            // btnAdminPanel
            // 
            this.btnAdminPanel.BackColor = System.Drawing.Color.Transparent;
            this.btnAdminPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminPanel.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.btnAdminPanel.FlatAppearance.BorderSize = 0;
            this.btnAdminPanel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdminPanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdminPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminPanel.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAdminPanel.ForeColor = System.Drawing.Color.Coral;
            this.btnAdminPanel.Location = new System.Drawing.Point(0, 1);
            this.btnAdminPanel.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdminPanel.Name = "btnAdminPanel";
            this.btnAdminPanel.Size = new System.Drawing.Size(198, 29);
            this.btnAdminPanel.TabIndex = 100;
            this.btnAdminPanel.Text = "> AUSGEWÄHLTE MENÜ&S";
            this.AdminToolTip.SetToolTip(this.btnAdminPanel, "Hier gelangst du zu den von \r\nNutzer ausgewählten Menüs.");
            this.btnAdminPanel.UseVisualStyleBackColor = false;
            this.btnAdminPanel.Click += new System.EventHandler(this.btnAdminPanel_Click);
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
            this.lbAdminPanel.Location = new System.Drawing.Point(387, 5);
            this.lbAdminPanel.Name = "lbAdminPanel";
            this.lbAdminPanel.Size = new System.Drawing.Size(229, 25);
            this.lbAdminPanel.TabIndex = 21;
            this.lbAdminPanel.Text = "Kreiere einen Speiseplan";
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
            // AdminToolTip
            // 
            this.AdminToolTip.Style = ReaLTaiizor.Enum.Poison.ColorStyle.White;
            this.AdminToolTip.StyleManager = null;
            this.AdminToolTip.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Default;
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
            this.AdminSplit.Panel2.PerformLayout();
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
        private System.Windows.Forms.Button btnAdminPanel;
        private System.Windows.Forms.Button btnMenueList;
        private System.Windows.Forms.ComboBox cmbSaturday;
        private System.Windows.Forms.ComboBox cmbFriday;
        private System.Windows.Forms.ComboBox cmbThursday;
        private System.Windows.Forms.ComboBox cmbWednesday;
        private System.Windows.Forms.ComboBox cmbTuesday;
        private System.Windows.Forms.ComboBox cmbMonday;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.PoisonToolTip AdminToolTip;
    }
}