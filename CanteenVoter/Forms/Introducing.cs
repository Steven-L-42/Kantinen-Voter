using System;
using System.Windows.Forms;

namespace CanteenVoter
{
    public partial class Introducing : Form
    {
        public Introducing()
        {
            InitializeComponent();
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            // --- CODE IST NICHT VON MIR ---
            // Ich nutze den FormBorderStyle "none" und mache mir mit dieser Klasse möglich
            // die Form dennoch verschieben zu können, dabei habe ich das MouseDown
            // meines AdminPageHeader genommen. Zusätzlich habe ich noch einige andere
            // Steuerelemente auf das selbe Event verlinkt.
            // 
            if (e.Button == MouseButtons.Left)
            {
                MoveWindow.ReleaseCapture();
                MoveWindow.SendMessage(Handle,
                MoveWindow.WM_NCLBUTTONDOWN,
                MoveWindow.HT_CAPTION, 0);
            }
        }
    }
}
