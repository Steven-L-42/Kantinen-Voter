namespace MazeWalker
{
    partial class Spielfeld
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Spielfeld));
            this.playground = new System.Windows.Forms.Panel();
            this.lbPowertime = new System.Windows.Forms.Label();
            this.Power2 = new PingPong_by_Steven.RoundBox();
            this.groundBottom = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.death2 = new System.Windows.Forms.PictureBox();
            this.groundTop = new System.Windows.Forms.PictureBox();
            this.death1 = new System.Windows.Forms.PictureBox();
            this.Food = new PingPong_by_Steven.RoundBox();
            this.Person = new PingPong_by_Steven.RoundBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Power2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.death2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.death1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Food)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Person)).BeginInit();
            this.SuspendLayout();
            // 
            // playground
            // 
            this.playground.BackColor = System.Drawing.Color.Transparent;
            this.playground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playground.BackgroundImage")));
            this.playground.Controls.Add(this.lbPowertime);
            this.playground.Controls.Add(this.Power2);
            this.playground.Controls.Add(this.groundBottom);
            this.playground.Controls.Add(this.label1);
            this.playground.Controls.Add(this.lbScore);
            this.playground.Controls.Add(this.lbTime);
            this.playground.Controls.Add(this.death2);
            this.playground.Controls.Add(this.groundTop);
            this.playground.Controls.Add(this.death1);
            this.playground.Controls.Add(this.Food);
            this.playground.Controls.Add(this.Person);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.ForeColor = System.Drawing.Color.Transparent;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(768, 709);
            this.playground.TabIndex = 1;
            // 
            // lbPowertime
            // 
            this.lbPowertime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPowertime.AutoSize = true;
            this.lbPowertime.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPowertime.Location = new System.Drawing.Point(335, 4);
            this.lbPowertime.Name = "lbPowertime";
            this.lbPowertime.Size = new System.Drawing.Size(76, 17);
            this.lbPowertime.TabIndex = 14;
            this.lbPowertime.Text = "Powertime: ";
            // 
            // Power2
            // 
            this.Power2.BackColor = System.Drawing.Color.Gold;
            this.Power2.Location = new System.Drawing.Point(539, 446);
            this.Power2.Name = "Power2";
            this.Power2.Size = new System.Drawing.Size(24, 24);
            this.Power2.TabIndex = 13;
            this.Power2.TabStop = false;
            this.Power2.Visible = false;
            // 
            // groundBottom
            // 
            this.groundBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groundBottom.BackColor = System.Drawing.Color.Transparent;
            this.groundBottom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groundBottom.BackgroundImage")));
            this.groundBottom.ErrorImage = ((System.Drawing.Image)(resources.GetObject("groundBottom.ErrorImage")));
            this.groundBottom.Location = new System.Drawing.Point(-11, 689);
            this.groundBottom.Name = "groundBottom";
            this.groundBottom.Size = new System.Drawing.Size(793, 20);
            this.groundBottom.TabIndex = 10;
            this.groundBottom.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "ESC to Stop";
            // 
            // lbScore
            // 
            this.lbScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.Location = new System.Drawing.Point(701, 4);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(55, 17);
            this.lbScore.TabIndex = 2;
            this.lbScore.Text = "Score: 0";
            // 
            // lbTime
            // 
            this.lbTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(624, 4);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(50, 17);
            this.lbTime.TabIndex = 5;
            this.lbTime.Text = "Time: 0";
            // 
            // death2
            // 
            this.death2.BackColor = System.Drawing.Color.Transparent;
            this.death2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("death2.BackgroundImage")));
            this.death2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.death2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("death2.ErrorImage")));
            this.death2.Location = new System.Drawing.Point(58, 254);
            this.death2.Name = "death2";
            this.death2.Size = new System.Drawing.Size(192, 33);
            this.death2.TabIndex = 7;
            this.death2.TabStop = false;
            this.death2.Visible = false;
            // 
            // groundTop
            // 
            this.groundTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groundTop.BackColor = System.Drawing.Color.Transparent;
            this.groundTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groundTop.BackgroundImage")));
            this.groundTop.ErrorImage = ((System.Drawing.Image)(resources.GetObject("groundTop.ErrorImage")));
            this.groundTop.Location = new System.Drawing.Point(-13, 0);
            this.groundTop.Name = "groundTop";
            this.groundTop.Size = new System.Drawing.Size(788, 20);
            this.groundTop.TabIndex = 9;
            this.groundTop.TabStop = false;
            // 
            // death1
            // 
            this.death1.BackColor = System.Drawing.Color.Transparent;
            this.death1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("death1.BackgroundImage")));
            this.death1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("death1.ErrorImage")));
            this.death1.Location = new System.Drawing.Point(58, 325);
            this.death1.Name = "death1";
            this.death1.Size = new System.Drawing.Size(192, 33);
            this.death1.TabIndex = 8;
            this.death1.TabStop = false;
            this.death1.Visible = false;
            // 
            // Food
            // 
            this.Food.BackColor = System.Drawing.Color.LimeGreen;
            this.Food.Location = new System.Drawing.Point(458, 327);
            this.Food.Name = "Food";
            this.Food.Size = new System.Drawing.Size(24, 24);
            this.Food.TabIndex = 1;
            this.Food.TabStop = false;
            // 
            // Person
            // 
            this.Person.BackColor = System.Drawing.Color.Black;
            this.Person.Location = new System.Drawing.Point(375, 271);
            this.Person.Name = "Person";
            this.Person.Size = new System.Drawing.Size(28, 28);
            this.Person.TabIndex = 0;
            this.Person.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Spielfeld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(768, 709);
            this.Controls.Add(this.playground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Spielfeld";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlphaSnake";
            this.Load += new System.EventHandler(this.Spielfeld_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Spielfeld_KeyDown);
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Power2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.death2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.death1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Food)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Person)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PingPong_by_Steven.RoundBox Person;
        private System.Windows.Forms.Panel playground;
        private PingPong_by_Steven.RoundBox Food;
        private System.Windows.Forms.Label lbScore;
        public System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lbTime;
        public System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox death2;
        private System.Windows.Forms.PictureBox groundTop;
        private System.Windows.Forms.PictureBox death1;
        private System.Windows.Forms.PictureBox groundBottom;
        private PingPong_by_Steven.RoundBox Power2;
        private System.Windows.Forms.Label lbPowertime;
    }
}

