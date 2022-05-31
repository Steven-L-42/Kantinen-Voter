using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbschlussProjekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panelIntro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPingNoPong_MouseHover(object sender, EventArgs e)
        {
            roundPicBoxIntro.Image = Image.FromFile(@"./pingping.png");
        }

        private void btnPingNoPong_MouseLeave(object sender, EventArgs e)
        {
            roundPicBoxIntro.Image = Image.FromFile(@"./pingping.png");
        }

        private void btnPingNoPong_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Projects VS\PingPong by Steven\PingPong by Steven\bin\Debug\PingPong by Steven.exe");
        }

        private void btnChaosBot_MouseHover(object sender, EventArgs e)
        {
            roundPicBoxIntro.Image = Image.FromFile(@"./highscale_logo.png");
        }

        private void btnChaosBot_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\ShiiikK\Desktop\LXU3E4R0HFYT5TL.exe");
        }

        private void btnSnake_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Projects VS\AbschlussProjekt\MazeWalker\bin\Debug\MazeWalker.exe");
        }

        private void btnAlphaBird_MouseHover(object sender, EventArgs e)
        {
            roundPicBoxIntro.Image = Image.FromFile(@"./alphabird.png");
        }

        private void btnSnake_MouseHover(object sender, EventArgs e)
        {
            roundPicBoxIntro.Image = Image.FromFile(@"./Snake.png");
        }

        private void btnAlphaBird_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Projects VS\AbschlussProjekt\AlphaBird\bin\Debug\AlphaBird.exe");
        }
    }
}
