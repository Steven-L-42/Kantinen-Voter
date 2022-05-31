using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMario
{
    public partial class Form1 : Form
    {
        int steuerung = 0;
        int gravity = 8;
        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            switch (steuerung)
            {
                case 0:
                    person.Top -= 0;
                    person.Left -= 0;
                    person.Left += 0;
                    person.Top += 0;
                    break;
                case 1:
                    person.Top -= 5;
                    break;
                case 2:
                    person.Left -= 5;
                    break;
                case 3:
                    person.Left += 5;
                    break;
                case 4:
                    person.Top += 5;
                    break;
                default:
                    break;
            }
           
            
            if (person.Bounds.IntersectsWith(ground.Bounds))
            {
                person.Top += 0;
            }
            else
            if (person.Bounds.IntersectsWith(tile.Bounds))
            {
                person.Top += 0;


            }
            else
            {
                person.Top += 6;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.D)
            {
                steuerung = 3;
                person.Left += 5;
            }else if(e.KeyCode == Keys.A)
            {
                steuerung = 2;
                person.Left -= 5;
            }
            else 
            if (e.KeyCode == Keys.X)
            {
                steuerung = 0;
            }
            else if(e.KeyCode == Keys.Space)
            {
                person.Top -= 150;
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
