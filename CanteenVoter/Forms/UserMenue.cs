using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CanteenVoter
{
    public partial class UserMenue : Form
    {
     
        private bool dayLabel_ChangeLoc = false;

        public UserMenue()
        {
            InitializeComponent();
        }

        private void AdminPageHeader_MouseDown(object sender, MouseEventArgs e)
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

        private void UserMenue_Load(object sender, EventArgs e)
        {
            dataMenu.DataSource = GetdataMenu();
            dataMenu.ClearSelection();
            dataMenu.ForeColor = Color.Black;
            dataMenu.RowsDefaultCellStyle.BackColor = Color.GhostWhite;
            dataMenu.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            dataMenu.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Sollte ScrollBar erscheinen werden die label diese die Tage anzeigen,
            // um wenige pixel versetzt, damit eine sauber zentrierte UI hinterlassen wird.
            // Außerdem setze ich einen bool, so das es insgesamt auch nur 1x möglich ist die label zu versetzen.
            //
            if (dataMenu.Controls.OfType<VScrollBar>().First().Visible && !dayLabel_ChangeLoc)
            {
                dayLabel_ChangeLoc = true;

                lbMenu.Left -= 5;
                lbMo.Left -= 5;
                lbTue.Left -= 5;
                lbWed.Left -= 6;
                lbThu.Left -= 8;
                lbFri.Left -= 11;
                lbSat.Left -= 10;
            }

            EnableDoubleBuffering();
        }
        private DataTable GetdataMenu()
        {
            Datenbank db = new Datenbank();
            DataTable table = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter())
            {
 

                using (MySqlCommand command = new MySqlCommand("SELECT CONCAT(us.Benutzername,'\n',us.Vorname,' ',us.Nachname), me.MontagGericht, me.DienstagGericht, " +
                                  "me.MittwochGericht, me.DonnerstagGericht, me.FreitagGericht, " +
                                  "me.SamstagGericht FROM UserTable us INNER JOIN UserMenueTable me " +
                                  "ON me.Benutzername= us.Benutzername", db.getConnection()))



                    //"SELECT CONCAT(`Vorname`,' ',`Nachname`) as Benutzername FROM UserTable;" +
                    //"SELECT `Benutzername`,`MontagGericht`, `DienstagGericht`,`MittwochGericht`,`DonnerstagGericht`," +
                    //"`FreitagGericht`,`SamstagGericht` FROM UserMenueTable", db.getConnection()))
                {
              
                    db.openConnection();
                    MySqlDataReader reader = command.ExecuteReader();

                    table.Load(reader);
                    db.closeConnection();
                }
            }
            return table;
        }


        private void EnableDoubleBuffering()
        {
            // --- CODE IST NICHT VON MIR ---
            // Hier wird das DoubleBuffering aktiviert, einige WinForms Steuerelemente oder auch Formen flackern hin und wieder.
            // Durch das aktivieren von DoubleBuffering werden diese Objekte doppelt gepuffert, das führt zu einer kurzen Verzögerung bei der Anzeige,
            // verhindert aber das sie bei der Laufzeit des Programms, bei interaktion oder bewegungungen flackern.
            //
            SetStyle(ControlStyles.DoubleBuffer |
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint,
            true);
            UpdateStyles();
        }

        private void dataMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
               // cellID = dataMenu.Rows[e.RowIndex].Cells["Menues"].Value as string;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                AlertClass.Show("Es können nur Reihen markiert werden!", Alert.enmType.Info);
            }
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            Form adminPageO = Application.OpenForms.Cast<Form>().Where(x => x.Name == "AdminPage").FirstOrDefault();
            if (null != adminPageO)
            {
                adminPageO.Show();
                
            }
            this.Close();
        }
    }
}
