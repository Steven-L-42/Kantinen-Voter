namespace AbschlussProjekt
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
            this.lbClose = new System.Windows.Forms.Label();
            this.panelIntro = new System.Windows.Forms.Panel();
            this.roundPicBoxIntro = new AbschlussProjekt.roundPicBox();
            this.btnCanteenVoting = new System.Windows.Forms.Button();
            this.btnSnake = new System.Windows.Forms.Button();
            this.btnAlphaBird = new System.Windows.Forms.Button();
            this.btnChaosBot = new System.Windows.Forms.Button();
            this.btnPingNoPong = new System.Windows.Forms.Button();
            this.panelIntro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPicBoxIntro)).BeginInit();
            this.SuspendLayout();
            // 
            // lbClose
            // 
            this.lbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbClose.AutoSize = true;
            this.lbClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.lbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbClose.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClose.Location = new System.Drawing.Point(643, 6);
            this.lbClose.Name = "lbClose";
            this.lbClose.Size = new System.Drawing.Size(72, 20);
            this.lbClose.TabIndex = 0;
            this.lbClose.Text = "{ CLOSE }";
            this.lbClose.Click += new System.EventHandler(this.lbClose_Click);
            // 
            // panelIntro
            // 
            this.panelIntro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panelIntro.Controls.Add(this.roundPicBoxIntro);
            this.panelIntro.Controls.Add(this.btnCanteenVoting);
            this.panelIntro.Controls.Add(this.btnSnake);
            this.panelIntro.Controls.Add(this.btnAlphaBird);
            this.panelIntro.Controls.Add(this.btnChaosBot);
            this.panelIntro.Controls.Add(this.btnPingNoPong);
            this.panelIntro.Controls.Add(this.lbClose);
            this.panelIntro.Location = new System.Drawing.Point(3, 3);
            this.panelIntro.Name = "panelIntro";
            this.panelIntro.Size = new System.Drawing.Size(718, 377);
            this.panelIntro.TabIndex = 1;
            this.panelIntro.Paint += new System.Windows.Forms.PaintEventHandler(this.panelIntro_Paint);
            // 
            // roundPicBoxIntro
            // 
            this.roundPicBoxIntro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.roundPicBoxIntro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.roundPicBoxIntro.Location = new System.Drawing.Point(85, 28);
            this.roundPicBoxIntro.Name = "roundPicBoxIntro";
            this.roundPicBoxIntro.Size = new System.Drawing.Size(539, 272);
            this.roundPicBoxIntro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundPicBoxIntro.TabIndex = 6;
            this.roundPicBoxIntro.TabStop = false;
            // 
            // btnCanteenVoting
            // 
            this.btnCanteenVoting.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnCanteenVoting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCanteenVoting.ForeColor = System.Drawing.Color.Coral;
            this.btnCanteenVoting.Location = new System.Drawing.Point(521, 320);
            this.btnCanteenVoting.Name = "btnCanteenVoting";
            this.btnCanteenVoting.Size = new System.Drawing.Size(106, 28);
            this.btnCanteenVoting.TabIndex = 5;
            this.btnCanteenVoting.Text = "Canteen Voter";
            this.btnCanteenVoting.UseVisualStyleBackColor = true;
            this.btnCanteenVoting.Click += new System.EventHandler(this.btnCanteenVoting_Click);
            this.btnCanteenVoting.MouseHover += new System.EventHandler(this.btnCanteenVoting_MouseHover);
            // 
            // btnSnake
            // 
            this.btnSnake.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnSnake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnake.ForeColor = System.Drawing.Color.Coral;
            this.btnSnake.Location = new System.Drawing.Point(412, 320);
            this.btnSnake.Name = "btnSnake";
            this.btnSnake.Size = new System.Drawing.Size(106, 28);
            this.btnSnake.TabIndex = 4;
            this.btnSnake.Text = "Snake";
            this.btnSnake.UseVisualStyleBackColor = true;
            this.btnSnake.Click += new System.EventHandler(this.btnSnake_Click);
            this.btnSnake.MouseHover += new System.EventHandler(this.btnSnake_MouseHover);
            // 
            // btnAlphaBird
            // 
            this.btnAlphaBird.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnAlphaBird.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlphaBird.ForeColor = System.Drawing.Color.Coral;
            this.btnAlphaBird.Location = new System.Drawing.Point(303, 320);
            this.btnAlphaBird.Name = "btnAlphaBird";
            this.btnAlphaBird.Size = new System.Drawing.Size(106, 28);
            this.btnAlphaBird.TabIndex = 3;
            this.btnAlphaBird.Text = "AlphaBird";
            this.btnAlphaBird.UseVisualStyleBackColor = true;
            this.btnAlphaBird.Click += new System.EventHandler(this.btnAlphaBird_Click);
            this.btnAlphaBird.MouseHover += new System.EventHandler(this.btnAlphaBird_MouseHover);
            // 
            // btnChaosBot
            // 
            this.btnChaosBot.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnChaosBot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChaosBot.ForeColor = System.Drawing.Color.Coral;
            this.btnChaosBot.Location = new System.Drawing.Point(194, 320);
            this.btnChaosBot.Name = "btnChaosBot";
            this.btnChaosBot.Size = new System.Drawing.Size(106, 28);
            this.btnChaosBot.TabIndex = 2;
            this.btnChaosBot.Text = "Chaos-Bot";
            this.btnChaosBot.UseVisualStyleBackColor = true;
            this.btnChaosBot.Click += new System.EventHandler(this.btnChaosBot_Click);
            this.btnChaosBot.MouseHover += new System.EventHandler(this.btnChaosBot_MouseHover);
            // 
            // btnPingNoPong
            // 
            this.btnPingNoPong.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnPingNoPong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPingNoPong.ForeColor = System.Drawing.Color.Coral;
            this.btnPingNoPong.Location = new System.Drawing.Point(85, 320);
            this.btnPingNoPong.Name = "btnPingNoPong";
            this.btnPingNoPong.Size = new System.Drawing.Size(106, 28);
            this.btnPingNoPong.TabIndex = 1;
            this.btnPingNoPong.Text = "Ping no Pong";
            this.btnPingNoPong.UseVisualStyleBackColor = true;
            this.btnPingNoPong.Click += new System.EventHandler(this.btnPingNoPong_Click);
            this.btnPingNoPong.MouseLeave += new System.EventHandler(this.btnPingNoPong_MouseLeave);
            this.btnPingNoPong.MouseHover += new System.EventHandler(this.btnPingNoPong_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(724, 383);
            this.Controls.Add(this.panelIntro);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelIntro.ResumeLayout(false);
            this.panelIntro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPicBoxIntro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbClose;
        private System.Windows.Forms.Panel panelIntro;
        private System.Windows.Forms.Button btnCanteenVoting;
        private System.Windows.Forms.Button btnSnake;
        private System.Windows.Forms.Button btnAlphaBird;
        private System.Windows.Forms.Button btnChaosBot;
        private System.Windows.Forms.Button btnPingNoPong;
        private roundPicBox roundPicBoxIntro;
    }
}

