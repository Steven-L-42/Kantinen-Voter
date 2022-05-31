using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeWalker
{
    public partial class Spielfeld : Form
    {
        Random rnd = new Random();
        PictureBox Enemy = new PictureBox();
        PictureBox Boss = new PictureBox();
        List<PictureBox> enemyList = new List<PictureBox>();
        List<PictureBox> BossList = new List<PictureBox>();

        bool power = false;
        bool changed = false;
        int time = 0;
        int Steuerung;
        int score = 0;

        public string PlayerName { get; private set; }
        public int PlayerMode { get; private set; }

        public Spielfeld()
        {
            InitializeComponent();
        }

        internal void SetPlayerName(string playerName)
        {
            PlayerName = playerName;
        }

        internal void SetPlayerMode(int playerMode)
        {
            PlayerMode = playerMode;
        }
       
        private void Spielfeld_Load(object sender, EventArgs e)
        {
            Food.Location = new Point(rnd.Next(5, playground.Right - 5), rnd.Next(5, playground.Bottom - 5));
            Power2.Enabled = false;
        }

        private void Spielfeld_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (PlayerMode == 1 && gameTimer.Enabled)
            {
                if (e.KeyCode == Keys.W && Steuerung != 4)
                {
                    Person.Top -= 20;
                    Steuerung = 1;
                }
                else
                           if (e.KeyCode == Keys.A && Steuerung != 3)
                {
                    Person.Left -= 20;
                    Steuerung = 2;
                }
                else
                           if (e.KeyCode == Keys.D && Steuerung != 2)
                {
                    Person.Left += 20;
                    Steuerung = 3;
                }
                else
                           if (e.KeyCode == Keys.S && Steuerung != 1)
                {
                    Person.Top += 20;
                    Steuerung = 4;
                }
            }else if (PlayerMode == 2 && gameTimer.Enabled)
            {
                if (e.KeyCode == Keys.W && Steuerung != 1)
                {
                    Person.Top += 20;
                    Steuerung = 4;
                }
                else
                          if (e.KeyCode == Keys.A && Steuerung != 2)
                {
                    Person.Left += 20;
                    Steuerung = 3;
                }
                else
                          if (e.KeyCode == Keys.D && Steuerung != 3)
                {
                    Person.Left -= 20;
                    Steuerung = 2;
                }
                else
                          if (e.KeyCode == Keys.S && Steuerung != 4)
                {
                    Person.Top -= 20;
                    Steuerung = 1;
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                var splashscreen = new Splashscreen();
                splashscreen.Show();
                splashscreen.TopMost = true;
                splashscreen.btnRestart.Visible = true;
                gameTimer.Enabled = false;
                timer.Enabled = false;
                ScoreUtils.WriteScore(new PlayerScore { Score = score, Name = PlayerName });
                lbScore.Location = new Point(lbScore.Location.X - 130, lbScore.Location.Y);
                lbTime.Location = new Point(lbScore.Location.X - 130, lbScore.Location.Y);
                lbScore.Text = "Game Stopped! Your score is: " + score;
            }
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            pickUpPower();
            pickUpFood();
            contactWithEnemy();
            contactWithWall();

            switch (Steuerung)
            {
                case 1:
                    Person.Top -= 5;
                    break;
                case 2:
                    Person.Left -= 5;
                    break;
                case 3:
                    Person.Left += 5;
                    break;
                case 4:
                    Person.Top += 5;
                    break;
                default:
                    break;
            }

            switch (changed)
            {
                case false:

                    break;
                case true:
                    await Task.Delay(500);
                    changed = false;
                    break;
            }
        }

        private void contactWithWall()
        {
            if (Person.Bottom >= groundBottom.Top)
            {
                Steuerung = 0;
                Person.Top -= 5;
            }
            else
                        if (Person.Top <= groundTop.Bottom)
            {
                Steuerung = 0;
                Person.Top += 5;
            }
            else
                        if (Person.Left <= playground.Left && !changed)
            {

                Person.Location = new Point(playground.Right, Person.Location.Y);
                changed = true;

            }
            else
                        if (Person.Right >= playground.Right && !changed)
            {
                Person.Location = new Point(playground.Left, Person.Location.Y);
                changed = true;

            }
            else
                        if (Person.Top <= playground.Top && !changed)
            {
                Person.Location = new Point(Person.Location.X, playground.Bottom);
                changed = true;

            }
            else
                        if (Person.Bottom >= playground.Bottom && !changed)
            {
                Person.Location = new Point(Person.Location.X, playground.Top);
                changed = true;

            }
        }

        private void contactWithEnemy()
        {
            if (!power)
            {
                foreach (PictureBox p in BossList)
                {
                    if (Person.Bounds.IntersectsWith(p.Bounds))
                    {
                        var splashscreen = new Splashscreen();
                        splashscreen.Show();
                        splashscreen.TopMost = true;
                        splashscreen.btnRestart.Visible = true;
                        gameTimer.Enabled = false;
                        timer.Enabled = false;
                        ScoreUtils.WriteScore(new PlayerScore { Score = score, Name = PlayerName });
                        lbScore.Location = new Point(lbScore.Location.X - 130, lbScore.Location.Y);
                        lbTime.Location = new Point(lbScore.Location.X - 130, lbScore.Location.Y);
                        lbScore.Text = "Game Over! Your score is: " + score;
                    }
                }
                foreach (PictureBox p in enemyList)
                {
                    if (Person.Bounds.IntersectsWith(p.Bounds))
                        //Person.Bounds.IntersectsWith(death1.Bounds)
                        //Person.Bounds.IntersectsWith(death2.Bounds)
                    {


                        var splashscreen = new Splashscreen();
                        splashscreen.Show();
                        splashscreen.TopMost = true;
                        splashscreen.btnRestart.Visible = true;
                        gameTimer.Enabled = false;
                        timer.Enabled = false;
                        ScoreUtils.WriteScore(new PlayerScore { Score = score, Name = PlayerName });
                        lbScore.Location = new Point(lbScore.Location.X - 130, lbScore.Location.Y);
                        lbTime.Location = new Point(lbScore.Location.X - 130, lbScore.Location.Y);
                        lbScore.Text = "Game Over! Your score is: " + score;
                    }
                }
            }
        }

        private void pickUpFood()
        {
            if (Person.Bounds.IntersectsWith(Food.Bounds))
            {
                if (score == 1)
                {
                    Power2.Enabled = true;
                    Power2.Visible = true;
                    Power2.Location = new Point(rnd.Next(20, playground.Right - 20), rnd.Next(20, playground.Bottom - 20));
                }
                Enemy = new PictureBox
                {
                    Location = new Point(rnd.Next(20, playground.Right - 20), rnd.Next(20, playground.Bottom - 20)),

                    SizeMode = PictureBoxSizeMode.Normal,
                    Size = new Size(26, 24),
                    BackColor = Color.Transparent,
                    BackgroundImage = Image.FromFile(@"./enemy.png"),
                };
                this.Controls.Add(Enemy);
                enemyList.Add(Enemy);
                Enemy.BringToFront();
                if (enemyList.IndexOf(Enemy) == 1)
                {
                    Boss = new PictureBox
                    {
                        Location = new Point(rnd.Next(100, playground.Right - 100), rnd.Next(100, playground.Bottom - 100)),

                        SizeMode = PictureBoxSizeMode.Normal,
                        Size = new Size(26, 24),
                        BackColor = Color.Transparent,
                        BackgroundImage = Image.FromFile(@"./Boss.png"),
                    };
                    this.Controls.Add(Boss);
                    BossList.Add(Boss);
                    Boss.BringToFront();

                    MoveBoss();

                }
                if (Person.Bounds.IntersectsWith(Enemy.Bounds)
                    || Enemy.Bounds.IntersectsWith(groundTop.Bounds)
                    || Enemy.Bounds.IntersectsWith(groundBottom.Bounds))
                {
                    Enemy.Location = new Point(rnd.Next(20, playground.Right - 20), rnd.Next(20, playground.Bottom - 20));
                }


                Food.Location = new Point(rnd.Next(20, playground.Right - 20), rnd.Next(20, playground.Bottom - 20));
                foreach (PictureBox p in enemyList)
                {
                    if (Food.Bounds.IntersectsWith(groundBottom.Bounds)
                    || Food.Bounds.IntersectsWith(groundTop.Bounds)
                    || Food.Bounds.IntersectsWith(p.Bounds))
                    {
                        Food.Location = new Point(rnd.Next(20, playground.Right - 20), rnd.Next(20, playground.Bottom - 20));
                    }
                }

                    

                score++;
                lbScore.Text = "Score: " + score.ToString();
            }
        }
        int sekunden = 6;
        DateTime dt = new DateTime();
        private void timer_Tick(object sender, EventArgs e)
        {
            if (power == true)
            {
                sekunden--;
                lbPowertime.Text = "Powertime: " + dt.AddSeconds(sekunden).ToString("ss");
            }
            time += 1;
            lbTime.Text = "Time: " + time.ToString();
        }

        private async void pickUpPower()
        {
            if (Person.Bounds.IntersectsWith(Power2.Bounds))
            {
                Power2.Enabled = false;
                Power2.Visible = false;
                power = true;
                lbPowertime.Visible = true;
                Person.BackColor = Color.Blue;
                for(int i = 0; i < 6; i++)
                {
                    await Task.Delay(1000);
                }
                Person.BackColor = Color.Black;
                power = false;
                lbPowertime.Visible = false;



            }
        }

        private async void MoveBoss()
        {
            while (gameTimer.Enabled)
            {
                for (int i = 0; i < 20; i++)
                {
                    if (gameTimer.Enabled)
                    {
                        Boss.Left -= 5;
                        await Task.Delay(100);
                    }

                }
                for (int i = 0; i < 20; i++)
                {
                    if (gameTimer.Enabled)
                    {
                        Boss.Top += 5;
                        await Task.Delay(100);
                    }
                }
                for (int i = 0; i < 20; i++)
                {
                    if (gameTimer.Enabled)
                    {
                        Boss.Left += 5;
                        await Task.Delay(100);
                    }
                }
                for (int i = 0; i < 20; i++)
                {
                    if (gameTimer.Enabled)
                    {
                        Boss.Top -= 5;
                        await Task.Delay(100);
                    }
                }
            }
        }
           
        private void btnPause_Click(object sender, EventArgs e)
        {

           
            lbTime.Location = new Point(lbScore.Location.X - 130, lbScore.Location.Y);
         
            timer.Enabled = false;
            gameTimer.Enabled = false;
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            gameTimer.Enabled = true;
        }
    }
}
