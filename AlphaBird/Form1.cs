using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlphaBird
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gravity = 8;
        int score = 0;

        public string PlayerName { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        internal void SetPlayerName(string playerName)
        {
            PlayerName = playerName;
        }

        private void endGame()
        {
            gameTimer.Enabled = false;
            btnStart.Enabled = true;
            txSpielername.Enabled = true;
            var form = new Form1();
            form.Focus();
            gameTimer.Stop();
            ScoreUtils.WriteScore(new PlayerScore { Score = score, Name = PlayerName });
            lbScore.Text = "Game Over! Your score is: " + score;
        }

        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            Bird.Top += gravity;
            PipeDown.Left -= pipeSpeed;
            pipeUp.Left -= pipeSpeed;

            if (PipeDown.Left < -80)
            {
                PipeDown.Left = 800;
                score++;
                lbScore.Text = "Score: " + score.ToString();
            }
            if (pipeUp.Left < -110)
            {
                pipeUp.Left = 950;
                score++;
                lbScore.Text = "Score: " + score.ToString();
            }
            if (score == 5 || score == 10)
                pipeSpeed += 1;
            
            if (Bird.Bounds.IntersectsWith(PipeDown.Bounds) || 
                Bird.Bounds.IntersectsWith(pipeUp.Bounds) ||
                Bird.Bounds.IntersectsWith(Ground.Bounds) ||
                Bird.Bounds.IntersectsWith(Air.Bounds))
            {
                endGame();
            }
        }
      
        private void btnStart_Click(object sender, EventArgs e)
        {
            gameTimer.Enabled = true;
            btnStart.Enabled = false;
            txSpielername.Enabled = false;
            var form = new Form1();
            form.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}