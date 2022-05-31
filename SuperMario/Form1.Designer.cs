namespace SuperMario
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.ground = new System.Windows.Forms.PictureBox();
            this.tile = new System.Windows.Forms.PictureBox();
            this.person = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.person)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.Green;
            this.ground.Location = new System.Drawing.Point(-9, 491);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(9000, 162);
            this.ground.TabIndex = 0;
            this.ground.TabStop = false;
            // 
            // tile
            // 
            this.tile.BackColor = System.Drawing.Color.Brown;
            this.tile.Location = new System.Drawing.Point(914, 397);
            this.tile.Name = "tile";
            this.tile.Size = new System.Drawing.Size(75, 97);
            this.tile.TabIndex = 1;
            this.tile.TabStop = false;
            // 
            // person
            // 
            this.person.BackColor = System.Drawing.Color.Black;
            this.person.Location = new System.Drawing.Point(335, 343);
            this.person.Name = "person";
            this.person.Size = new System.Drawing.Size(26, 151);
            this.person.TabIndex = 2;
            this.person.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.tile);
            this.panel1.Controls.Add(this.ground);
            this.panel1.Controls.Add(this.person);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 642);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 642);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.person)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox tile;
        private System.Windows.Forms.PictureBox person;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Panel panel1;
    }
}

