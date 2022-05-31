using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeWalker
{
    public partial class Splashscreen : Form
    {
        Spielfeld spielfeld = new Spielfeld();
        SpielInfo spielInfo = new SpielInfo();
        private string PlayerName = "Anon.Spieler";
        private int PlayerMode = 1;
        private int Easy = 1;
        private int Hard = 2;

        public Splashscreen()
        {
            InitializeComponent();
           

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayerName = txUsername.Text;
           
            spielfeld.Show();
            spielfeld.SetPlayerName(PlayerName);
            spielfeld.SetPlayerMode(PlayerMode);
            spielfeld.TopMost = true;
            spielfeld.BringToFront();
         
        }

        private void txUsername_Leave(object sender, EventArgs e)
        {

        }

        private void btnScores_Click(object sender, EventArgs e)
        {
         
            spielInfo.Show();
            spielInfo.SetScores();
        }

        private void btnResume_Click(object sender, EventArgs e)
        {

            Form form1 = Application.OpenForms["Spielfeld"];
            form1.Close();


            this.Hide();
            PlayerName = txUsername.Text;

            spielfeld.Show();
            spielfeld.SetPlayerName(PlayerName);
            spielfeld.SetPlayerMode(PlayerMode);
            spielfeld.TopMost = true;
            spielfeld.BringToFront();
            btnRestart.Visible = false;
        

        }
        private void btnBeenden_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Splashscreen_Load(object sender, EventArgs e)
        {

        }

        private void rdEasy_CheckedChanged(object sender, EventArgs e)
        {
            PlayerMode = Easy;
        }

        private void rdHard_CheckedChanged(object sender, EventArgs e)
        {
            PlayerMode = Hard;
        }
    }
}
