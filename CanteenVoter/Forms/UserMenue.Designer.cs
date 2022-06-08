namespace CanteenVoter
{
    partial class UserMenue
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
            this.lbMo = new System.Windows.Forms.Label();
            this.lbClose = new System.Windows.Forms.Label();
            this.lbTue = new System.Windows.Forms.Label();
            this.lbSat = new System.Windows.Forms.Label();
            this.lbFri = new System.Windows.Forms.Label();
            this.lbThu = new System.Windows.Forms.Label();
            this.lbMenu = new System.Windows.Forms.Label();
            this.AdminPageHeader = new System.Windows.Forms.Panel();
            this.lbWed = new System.Windows.Forms.Label();
            this.lbAdminPanel = new System.Windows.Forms.Label();
            this.AdminSplit = new System.Windows.Forms.SplitContainer();
            this.dataMenu = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            this.MenueToolTip = new ReaLTaiizor.Controls.PoisonToolTip();
            this.label1 = new System.Windows.Forms.Label();
            this.AdminPageHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminSplit)).BeginInit();
            this.AdminSplit.Panel1.SuspendLayout();
            this.AdminSplit.Panel2.SuspendLayout();
            this.AdminSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMenu)).BeginInit();
            this.SuspendLayout();
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
            // lbMenu
            // 
            this.lbMenu.AutoSize = true;
            this.lbMenu.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMenu.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbMenu.Location = new System.Drawing.Point(48, 39);
            this.lbMenu.Name = "lbMenu";
            this.lbMenu.Size = new System.Drawing.Size(44, 17);
            this.lbMenu.TabIndex = 35;
            this.lbMenu.Text = "Name";
            this.lbMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminPageHeader_MouseDown);
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
            this.AdminPageHeader.TabIndex = 23;
            this.AdminPageHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminPageHeader_MouseDown);
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
            // lbAdminPanel
            // 
            this.lbAdminPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAdminPanel.AutoSize = true;
            this.lbAdminPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbAdminPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbAdminPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbAdminPanel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbAdminPanel.ForeColor = System.Drawing.Color.GhostWhite;
            this.lbAdminPanel.Location = new System.Drawing.Point(403, 4);
            this.lbAdminPanel.Name = "lbAdminPanel";
            this.lbAdminPanel.Size = new System.Drawing.Size(173, 25);
            this.lbAdminPanel.TabIndex = 21;
            this.lbAdminPanel.Text = "Menüs der Nutzer";
            this.lbAdminPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbAdminPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminPageHeader_MouseDown);
            // 
            // AdminSplit
            // 
            this.AdminSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminSplit.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
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
            this.AdminSplit.Panel2.Controls.Add(this.label1);
            this.AdminSplit.Panel2.Controls.Add(this.btnExport);
            this.AdminSplit.Panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminPageHeader_MouseDown);
            this.AdminSplit.Size = new System.Drawing.Size(972, 567);
            this.AdminSplit.SplitterDistance = 529;
            this.AdminSplit.SplitterWidth = 7;
            this.AdminSplit.TabIndex = 22;
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
            this.dataMenu.Name = "dataMenu";
            this.dataMenu.ReadOnly = true;
            this.dataMenu.RowHeadersVisible = false;
            this.dataMenu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataMenu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataMenu.ShowCellErrors = false;
            this.dataMenu.ShowEditingIcon = false;
            this.dataMenu.ShowRowErrors = false;
            this.dataMenu.Size = new System.Drawing.Size(972, 529);
            this.dataMenu.TabIndex = 3;
            this.dataMenu.TabStop = false;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.GhostWhite;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.Black;
            this.btnExport.Location = new System.Drawing.Point(833, 2);
            this.btnExport.Margin = new System.Windows.Forms.Padding(5);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(138, 25);
            this.btnExport.TabIndex = 102;
            this.btnExport.Text = "&Export to PDF";
            this.MenueToolTip.SetToolTip(this.btnExport, "Exportiert die Tabelle in eine PDF Datei\r\n(Experimental)");
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // MenueToolTip
            // 
            this.MenueToolTip.Style = ReaLTaiizor.Enum.Poison.ColorStyle.White;
            this.MenueToolTip.StyleManager = null;
            this.MenueToolTip.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Default;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(200, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 17);
            this.label1.TabIndex = 103;
            this.label1.Text = "Diese Ansicht dient nur der Übersicht: Welcher Nutzer wünscht aktuell welches Men" +
    "ü";
            // 
            // UserMenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CanteenVoter.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(972, 630);
            this.Controls.Add(this.AdminSplit);
            this.Controls.Add(this.AdminPageHeader);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            this.ForeColor = System.Drawing.Color.GhostWhite;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserMenue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserMenue";
            this.Load += new System.EventHandler(this.UserMenue_Load);
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

        private System.Windows.Forms.Label lbMo;
        private System.Windows.Forms.Label lbClose;
        private System.Windows.Forms.Label lbTue;
        private System.Windows.Forms.Label lbSat;
        private System.Windows.Forms.Label lbFri;
        private System.Windows.Forms.Label lbThu;
        private System.Windows.Forms.Label lbMenu;
        private System.Windows.Forms.Panel AdminPageHeader;
        private System.Windows.Forms.Label lbWed;
        private System.Windows.Forms.Label lbAdminPanel;
        private System.Windows.Forms.SplitContainer AdminSplit;
        private System.Windows.Forms.DataGridView dataMenu;
        private System.Windows.Forms.Button btnExport;
        private ReaLTaiizor.Controls.PoisonToolTip MenueToolTip;
        private System.Windows.Forms.Label label1;
    }
}