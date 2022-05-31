namespace MazeWalker
{
    partial class Splashscreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splashscreen));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnBeenden = new System.Windows.Forms.Button();
            this.txUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnScores = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.rdHard = new System.Windows.Forms.RadioButton();
            this.rdEasy = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnStart.Location = new System.Drawing.Point(93, 96);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(226, 35);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnBeenden
            // 
            this.btnBeenden.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnBeenden.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBeenden.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnBeenden.Location = new System.Drawing.Point(93, 171);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(226, 26);
            this.btnBeenden.TabIndex = 1;
            this.btnBeenden.Text = "EXIT GAME";
            this.btnBeenden.UseVisualStyleBackColor = false;
            this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
            // 
            // txUsername
            // 
            this.txUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.txUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txUsername.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txUsername.Location = new System.Drawing.Point(110, 65);
            this.txUsername.Name = "txUsername";
            this.txUsername.Size = new System.Drawing.Size(189, 25);
            this.txUsername.TabIndex = 2;
            this.txUsername.Text = "Anon.Player";
            this.txUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txUsername.Leave += new System.EventHandler(this.txUsername_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.ForeColor = System.Drawing.Color.SandyBrown;
            this.label1.Location = new System.Drawing.Point(107, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username:";
            // 
            // btnScores
            // 
            this.btnScores.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnScores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnScores.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnScores.Location = new System.Drawing.Point(12, 12);
            this.btnScores.Name = "btnScores";
            this.btnScores.Size = new System.Drawing.Size(87, 26);
            this.btnScores.TabIndex = 4;
            this.btnScores.Text = "SCORES";
            this.btnScores.UseVisualStyleBackColor = false;
            this.btnScores.Click += new System.EventHandler(this.btnScores_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestart.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnRestart.Location = new System.Drawing.Point(93, 96);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(226, 35);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.Text = "RESTART";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Visible = false;
            this.btnRestart.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // rdHard
            // 
            this.rdHard.AutoSize = true;
            this.rdHard.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.rdHard.FlatAppearance.BorderSize = 0;
            this.rdHard.ForeColor = System.Drawing.Color.SandyBrown;
            this.rdHard.Location = new System.Drawing.Point(217, 137);
            this.rdHard.Name = "rdHard";
            this.rdHard.Size = new System.Drawing.Size(102, 21);
            this.rdHard.TabIndex = 6;
            this.rdHard.Text = "HARDMODE";
            this.rdHard.UseVisualStyleBackColor = false;
            this.rdHard.CheckedChanged += new System.EventHandler(this.rdHard_CheckedChanged);
            // 
            // rdEasy
            // 
            this.rdEasy.AutoSize = true;
            this.rdEasy.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.rdEasy.Checked = true;
            this.rdEasy.FlatAppearance.BorderSize = 0;
            this.rdEasy.ForeColor = System.Drawing.Color.SandyBrown;
            this.rdEasy.Location = new System.Drawing.Point(93, 137);
            this.rdEasy.Name = "rdEasy";
            this.rdEasy.Size = new System.Drawing.Size(96, 21);
            this.rdEasy.TabIndex = 7;
            this.rdEasy.TabStop = true;
            this.rdEasy.Text = "EASYMODE";
            this.rdEasy.UseVisualStyleBackColor = false;
            this.rdEasy.CheckedChanged += new System.EventHandler(this.rdEasy_CheckedChanged);
            // 
            // Splashscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(418, 209);
            this.Controls.Add(this.rdEasy);
            this.Controls.Add(this.rdHard);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnScores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txUsername);
            this.Controls.Add(this.btnBeenden);
            this.Controls.Add(this.btnStart);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Splashscreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splashscreen";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Splashscreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnBeenden;
        private System.Windows.Forms.TextBox txUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnScores;
        public System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.RadioButton rdHard;
        private System.Windows.Forms.RadioButton rdEasy;
    }
}