namespace AlphaBird
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
            this.pipeUp = new System.Windows.Forms.PictureBox();
            this.PipeDown = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.lbScore = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.txSpielername = new System.Windows.Forms.TextBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.Air = new System.Windows.Forms.PictureBox();
            this.Bird = new PingPong_by_Steven.RoundBox();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Air)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).BeginInit();
            this.SuspendLayout();
            // 
            // pipeUp
            // 
            this.pipeUp.BackColor = System.Drawing.Color.Green;
            this.pipeUp.Location = new System.Drawing.Point(440, -3);
            this.pipeUp.Name = "pipeUp";
            this.pipeUp.Size = new System.Drawing.Size(177, 197);
            this.pipeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeUp.TabIndex = 4;
            this.pipeUp.TabStop = false;
            // 
            // PipeDown
            // 
            this.PipeDown.BackColor = System.Drawing.Color.Green;
            this.PipeDown.Location = new System.Drawing.Point(635, 340);
            this.PipeDown.Name = "PipeDown";
            this.PipeDown.Size = new System.Drawing.Size(177, 224);
            this.PipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeDown.TabIndex = 5;
            this.PipeDown.TabStop = false;
            // 
            // Ground
            // 
            this.Ground.BackColor = System.Drawing.Color.Lime;
            this.Ground.Location = new System.Drawing.Point(-7, 555);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(1201, 98);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 6;
            this.Ground.TabStop = false;
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.BackColor = System.Drawing.Color.Lime;
            this.lbScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbScore.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.Location = new System.Drawing.Point(674, 615);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(60, 21);
            this.lbScore.TabIndex = 8;
            this.lbScore.Text = "Score: ";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(129, 25);
            this.btnStart.TabIndex = 99;
            this.btnStart.TabStop = false;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txSpielername
            // 
            this.txSpielername.Location = new System.Drawing.Point(12, 43);
            this.txSpielername.Name = "txSpielername";
            this.txSpielername.Size = new System.Drawing.Size(129, 20);
            this.txSpielername.TabIndex = 99;
            this.txSpielername.TabStop = false;
            this.txSpielername.Text = "Spielername";
            this.txSpielername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // Air
            // 
            this.Air.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Air.Location = new System.Drawing.Point(-17, -87);
            this.Air.Name = "Air";
            this.Air.Size = new System.Drawing.Size(1201, 98);
            this.Air.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Air.TabIndex = 11;
            this.Air.TabStop = false;
            // 
            // Bird
            // 
            this.Bird.BackColor = System.Drawing.Color.Black;
            this.Bird.Location = new System.Drawing.Point(23, 255);
            this.Bird.Name = "Bird";
            this.Bird.Size = new System.Drawing.Size(91, 79);
            this.Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bird.TabIndex = 12;
            this.Bird.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 645);
            this.Controls.Add(this.Bird);
            this.Controls.Add(this.Air);
            this.Controls.Add(this.txSpielername);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.PipeDown);
            this.Controls.Add(this.pipeUp);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Air)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pipeUp;
        private System.Windows.Forms.PictureBox PipeDown;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txSpielername;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox Air;
        private PingPong_by_Steven.RoundBox Bird;
    }
}

