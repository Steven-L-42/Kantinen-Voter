namespace CanteenVoter
{
    partial class MenueList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenueList));
            this.lbTue = new System.Windows.Forms.Label();
            this.lbThu = new System.Windows.Forms.Label();
            this.lbMo = new System.Windows.Forms.Label();
            this.lbClose = new System.Windows.Forms.Label();
            this.AdminPageHeader = new System.Windows.Forms.Panel();
            this.lbWed = new System.Windows.Forms.Label();
            this.lbAdminPanel = new System.Windows.Forms.Label();
            this.AdminSplit = new System.Windows.Forms.SplitContainer();
            this.dataMenu = new System.Windows.Forms.DataGridView();
            this.btnInformation = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txMenueD = new System.Windows.Forms.RichTextBox();
            this.txMenueC = new System.Windows.Forms.RichTextBox();
            this.txMenueB = new System.Windows.Forms.RichTextBox();
            this.txMenueA = new System.Windows.Forms.RichTextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.MenueToolTip = new ReaLTaiizor.Controls.PoisonToolTip();
            this.AdminPageHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminSplit)).BeginInit();
            this.AdminSplit.Panel1.SuspendLayout();
            this.AdminSplit.Panel2.SuspendLayout();
            this.AdminSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTue
            // 
            this.lbTue.AutoSize = true;
            this.lbTue.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTue.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbTue.Location = new System.Drawing.Point(339, 37);
            this.lbTue.Name = "lbTue";
            this.lbTue.Size = new System.Drawing.Size(56, 34);
            this.lbTue.TabIndex = 30;
            this.lbTue.Text = "Menü B\r\n(Vegan)";
            this.lbTue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminPageHeader_MouseDown);
            // 
            // lbThu
            // 
            this.lbThu.AutoSize = true;
            this.lbThu.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThu.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbThu.Location = new System.Drawing.Point(784, 37);
            this.lbThu.Name = "lbThu";
            this.lbThu.Size = new System.Drawing.Size(126, 34);
            this.lbThu.TabIndex = 32;
            this.lbThu.Text = "Menü D\r\n(Gluten /Lak.  Frei)";
            this.lbThu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminPageHeader_MouseDown);
            // 
            // lbMo
            // 
            this.lbMo.AutoSize = true;
            this.lbMo.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMo.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbMo.Location = new System.Drawing.Point(86, 37);
            this.lbMo.Name = "lbMo";
            this.lbMo.Size = new System.Drawing.Size(95, 34);
            this.lbMo.TabIndex = 29;
            this.lbMo.Text = "Menü A\r\n(Normal Kost)\r\n";
            this.lbMo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminPageHeader_MouseDown);
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
            // AdminPageHeader
            // 
            this.AdminPageHeader.BackColor = System.Drawing.Color.Transparent;
            this.AdminPageHeader.Controls.Add(this.lbWed);
            this.AdminPageHeader.Controls.Add(this.lbTue);
            this.AdminPageHeader.Controls.Add(this.lbThu);
            this.AdminPageHeader.Controls.Add(this.lbMo);
            this.AdminPageHeader.Controls.Add(this.lbAdminPanel);
            this.AdminPageHeader.Controls.Add(this.lbClose);
            this.AdminPageHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.AdminPageHeader.ForeColor = System.Drawing.Color.Black;
            this.AdminPageHeader.Location = new System.Drawing.Point(0, 0);
            this.AdminPageHeader.Name = "AdminPageHeader";
            this.AdminPageHeader.Size = new System.Drawing.Size(972, 77);
            this.AdminPageHeader.TabIndex = 25;
            this.AdminPageHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminPageHeader_MouseDown);
            // 
            // lbWed
            // 
            this.lbWed.AutoSize = true;
            this.lbWed.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWed.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbWed.Location = new System.Drawing.Point(550, 37);
            this.lbWed.Name = "lbWed";
            this.lbWed.Size = new System.Drawing.Size(89, 34);
            this.lbWed.TabIndex = 31;
            this.lbWed.Text = "Menü C\r\n(Vegetarisch)";
            this.lbWed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminPageHeader_MouseDown);
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
            this.lbAdminPanel.Location = new System.Drawing.Point(381, 4);
            this.lbAdminPanel.Name = "lbAdminPanel";
            this.lbAdminPanel.Size = new System.Drawing.Size(191, 25);
            this.lbAdminPanel.TabIndex = 21;
            this.lbAdminPanel.Text = "Erstellen von Menüs";
            this.lbAdminPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbAdminPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminPageHeader_MouseDown);
            // 
            // AdminSplit
            // 
            this.AdminSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.AdminSplit.IsSplitterFixed = true;
            this.AdminSplit.Location = new System.Drawing.Point(0, 77);
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
            this.AdminSplit.Panel2.Controls.Add(this.btnInformation);
            this.AdminSplit.Panel2.Controls.Add(this.btnDelete);
            this.AdminSplit.Panel2.Controls.Add(this.label1);
            this.AdminSplit.Panel2.Controls.Add(this.txMenueD);
            this.AdminSplit.Panel2.Controls.Add(this.txMenueC);
            this.AdminSplit.Panel2.Controls.Add(this.txMenueB);
            this.AdminSplit.Panel2.Controls.Add(this.txMenueA);
            this.AdminSplit.Panel2.Controls.Add(this.btnInsert);
            this.AdminSplit.Panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminPageHeader_MouseDown);
            this.AdminSplit.Size = new System.Drawing.Size(972, 753);
            this.AdminSplit.SplitterDistance = 634;
            this.AdminSplit.SplitterWidth = 7;
            this.AdminSplit.TabIndex = 24;
            this.AdminSplit.TabStop = false;
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
            this.dataMenu.MultiSelect = false;
            this.dataMenu.Name = "dataMenu";
            this.dataMenu.ReadOnly = true;
            this.dataMenu.RowHeadersVisible = false;
            this.dataMenu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataMenu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMenu.ShowCellErrors = false;
            this.dataMenu.ShowEditingIcon = false;
            this.dataMenu.ShowRowErrors = false;
            this.dataMenu.Size = new System.Drawing.Size(972, 634);
            this.dataMenu.TabIndex = 4;
            this.dataMenu.TabStop = false;
            this.dataMenu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataMenu_CellClick);
            this.dataMenu.DoubleClick += new System.EventHandler(this.dataMenu_DoubleClick);
            // 
            // btnInformation
            // 
            this.btnInformation.BackColor = System.Drawing.Color.GhostWhite;
            this.btnInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInformation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformation.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformation.ForeColor = System.Drawing.Color.Black;
            this.btnInformation.Location = new System.Drawing.Point(759, 75);
            this.btnInformation.Margin = new System.Windows.Forms.Padding(5);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(208, 26);
            this.btnInformation.TabIndex = 18;
            this.btnInformation.Text = "&Information";
            this.btnInformation.UseVisualStyleBackColor = false;
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.GhostWhite;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(897, 35);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 36);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "&Löschen";
            this.MenueToolTip.SetToolTip(this.btnDelete, "Zum löschen einer Zeile\r\nmuss sie ausgewählt sein.\r\n\r\nSolltest du Sie nur verände" +
        "rn wollen:\r\n\r\nKlicke bitte auf \'Information\'");
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(757, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 30);
            this.label1.TabIndex = 16;
            this.label1.Text = "Erstelle hier neue Gerichte, fülle vor \r\ndem hinzufügen alle Felder aus.";
            // 
            // txMenueD
            // 
            this.txMenueD.BackColor = System.Drawing.Color.GhostWhite;
            this.txMenueD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txMenueD.Location = new System.Drawing.Point(572, 17);
            this.txMenueD.Name = "txMenueD";
            this.txMenueD.Size = new System.Drawing.Size(181, 84);
            this.txMenueD.TabIndex = 15;
            this.txMenueD.Text = "Menü D: Neues Gericht...";
            // 
            // txMenueC
            // 
            this.txMenueC.BackColor = System.Drawing.Color.GhostWhite;
            this.txMenueC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txMenueC.Location = new System.Drawing.Point(385, 17);
            this.txMenueC.Name = "txMenueC";
            this.txMenueC.Size = new System.Drawing.Size(181, 84);
            this.txMenueC.TabIndex = 14;
            this.txMenueC.Text = "Menü C: Neues Gericht...";
            // 
            // txMenueB
            // 
            this.txMenueB.BackColor = System.Drawing.Color.GhostWhite;
            this.txMenueB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txMenueB.Location = new System.Drawing.Point(198, 17);
            this.txMenueB.Name = "txMenueB";
            this.txMenueB.Size = new System.Drawing.Size(181, 84);
            this.txMenueB.TabIndex = 13;
            this.txMenueB.Text = "Menü B: Neues Gericht...";
            // 
            // txMenueA
            // 
            this.txMenueA.BackColor = System.Drawing.Color.GhostWhite;
            this.txMenueA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txMenueA.Location = new System.Drawing.Point(11, 17);
            this.txMenueA.Name = "txMenueA";
            this.txMenueA.Size = new System.Drawing.Size(181, 84);
            this.txMenueA.TabIndex = 12;
            this.txMenueA.Text = "Menü A: Neues Gericht...";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.GhostWhite;
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.Black;
            this.btnInsert.Location = new System.Drawing.Point(759, 35);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(5);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(136, 36);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = "&Hinzufügen";
            this.MenueToolTip.SetToolTip(this.btnInsert, "Stelle sicher das alle Felder\r\nkorrekt befüllt wurden und\r\nklicke dann auf \'Hinzu" +
        "fügen\'.");
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // MenueToolTip
            // 
            this.MenueToolTip.Style = ReaLTaiizor.Enum.Poison.ColorStyle.White;
            this.MenueToolTip.StyleManager = null;
            this.MenueToolTip.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Default;
            // 
            // MenueList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CanteenVoter.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(972, 830);
            this.Controls.Add(this.AdminSplit);
            this.Controls.Add(this.AdminPageHeader);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenueList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenueList";
            this.Load += new System.EventHandler(this.MenueList_Load);
            this.AdminPageHeader.ResumeLayout(false);
            this.AdminPageHeader.PerformLayout();
            this.AdminSplit.Panel1.ResumeLayout(false);
            this.AdminSplit.Panel2.ResumeLayout(false);
            this.AdminSplit.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminSplit)).EndInit();
            this.AdminSplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbTue;
        private System.Windows.Forms.Label lbThu;
        private System.Windows.Forms.Label lbMo;
        private System.Windows.Forms.Label lbClose;
        private System.Windows.Forms.Panel AdminPageHeader;
        private System.Windows.Forms.Label lbWed;
        private System.Windows.Forms.Label lbAdminPanel;
        private System.Windows.Forms.SplitContainer AdminSplit;
        private System.Windows.Forms.DataGridView dataMenu;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.RichTextBox txMenueD;
        private System.Windows.Forms.RichTextBox txMenueC;
        private System.Windows.Forms.RichTextBox txMenueB;
        private System.Windows.Forms.RichTextBox txMenueA;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.PoisonToolTip MenueToolTip;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInformation;
    }
}