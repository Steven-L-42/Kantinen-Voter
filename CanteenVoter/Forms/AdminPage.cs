using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CanteenVoter
{
    public partial class AdminPage : Form
    {
        private string cellID;
        private bool dayLabel_ChangeLoc = false;

        public AdminPage()
        {
            InitializeComponent();
            InitializeEvents();
        }


        #region InitializeEvents
        private void InitializeEvents()
        {
        
            txMonday.GotFocus += TxMonday_GotFocus;
            txMonday.LostFocus += TxMonday_LostFocus;
            txTuesday.GotFocus += TxTuesday_GotFocus;
            txTuesday.LostFocus += TxTuesday_LostFocus;
            txWednesday.GotFocus += TxWednesday_GotFocus;
            txWednesday.LostFocus += TxWednesday_LostFocus;
            txThursday.GotFocus += TxThursday_GotFocus;
            txThursday.LostFocus += TxThursday_LostFocus;
            txFriday.GotFocus += TxFriday_GotFocus;
            txFriday.LostFocus += TxFriday_LostFocus;
            txSuturday.GotFocus += TxSuturday_GotFocus;
            txSuturday.LostFocus += TxSuturday_LostFocus;
        }

        // Got Focus soll die RichTextBox Clearen wenn sie den Focus hat
        // und exakt den Text enthält der im If Statement gefordert wird
        //
        // Lost Focus macht exakt das Gegenteil, wenn Sie den Focus verliert
        // und die RichTextBox leer ist, wird sie mit ihren vorbestimmten Text befüllt.
        //
        private void TxFriday_GotFocus(object sender, EventArgs e)
        {
            if (txFriday.Text == "FREITAG")
                txFriday.Text = String.Empty;
        }

        private void TxFriday_LostFocus(object sender, EventArgs e)
        {
            if (txFriday.Text == String.Empty)
                txFriday.Text = "FREITAG";
        }

        private void TxMonday_GotFocus(object sender, EventArgs e)
        {
            if (txMonday.Text == "MONTAG")
                txMonday.Text = String.Empty;
        }

        private void TxMonday_LostFocus(object sender, EventArgs e)
        {
            if (txMonday.Text == String.Empty)
                txMonday.Text = "MONTAG";
        }

        private void TxSuturday_GotFocus(object sender, EventArgs e)
        {
            if (txSuturday.Text == "SAMSTAG")
                txSuturday.Text = String.Empty;
        }

        private void TxSuturday_LostFocus(object sender, EventArgs e)
        {
            if (txSuturday.Text == String.Empty)
                txSuturday.Text = "SAMSTAG";
        }
        private void TxThursday_GotFocus(object sender, EventArgs e)
        {
            if (txThursday.Text == "DONNERSTAG")
                txThursday.Text = String.Empty;
        }

        private void TxThursday_LostFocus(object sender, EventArgs e)
        {
            if (txThursday.Text == String.Empty)
                txThursday.Text = "DONNERSTAG";
        }
        private void TxTuesday_GotFocus(object sender, EventArgs e)
        {
            if (txTuesday.Text == "DIENSTAG")
                txTuesday.Text = String.Empty;
        }

        private void TxTuesday_LostFocus(object sender, EventArgs e)
        {
            if (txTuesday.Text == String.Empty)
                txTuesday.Text = "DIENSTAG";
        }

        private void TxWednesday_GotFocus(object sender, EventArgs e)
        {
            if (txWednesday.Text == "MITTWOCH")
                txWednesday.Text = String.Empty;
        }

        private void TxWednesday_LostFocus(object sender, EventArgs e)
        {
            if (txWednesday.Text == String.Empty)
                txWednesday.Text = "MITTWOCH";
        }
        #endregion InitializeEvents


        private void AdminPage_Load(object sender, EventArgs e)
        {
            dataMenu.DataSource = GetdataMenu();
            dataMenu.ClearSelection();
            dataMenu.RowsDefaultCellStyle.BackColor = Color.GhostWhite;
            dataMenu.RowsDefaultCellStyle.ForeColor = Color.Black;
            dataMenu.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            dataMenu.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            cmbMenue.Items.Add("Menü wählen...");

            cmbMenue.Items.Add("Menü A \n" +
                                "(Normal Kost)");

            cmbMenue.Items.Add("Menü B \n" +
                                "(Vegan)");

            cmbMenue.Items.Add("Menü C \n" +
                                "(Vegetarisch)");

            cmbMenue.Items.Add("Menü D \n" +
                                "(Gluten-/Lak.- Frei)");
            cmbMenue.SelectedIndex = 0;

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
                using (MySqlCommand command = new MySqlCommand("SELECT " +
                    "`Menues`,`Montag`, `Dienstag`,`Mittwoch`,`Donnerstag`," +
                    "`Freitag`,`Samstag` FROM CanteenTable", db.getConnection()))
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


        public void SqlDelete(string id)
        {
            try
            {
                Datenbank db = new Datenbank();
                db.openConnection();
                try
                {
                    MySqlCommand command = new MySqlCommand("DELETE FROM CanteenTable WHERE Menues = '" + id + "'", db.getConnection());
                    command.ExecuteNonQuery();
                    dataMenu.DataSource = GetdataMenu();
                    dataMenu.ClearSelection();
                }
                finally
                {
                    db.closeConnection();

                }
            }
            catch (MySqlException ex)
            {
                AlertClass.Show("MySQL Verbindungsproblem!", Alert.enmType.Warning);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Soll dieses Menü wirklich gelöscht werden?",
                                                "Löschvorgang bestätigen!", MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2);

            if (confirmResult == DialogResult.Yes)
            {
                SqlDelete(cellID);

                // Sollte die ScrollBar verschwinden werden die label diese die Tage anzeigen,
                // um wenige pixel versetzt, damit eine sauber zentrierte UI hinterlassen wird.
                // Außerdem setze ich einen bool, so das es insgesamt auch nur 1x möglich ist die label zu versetzen.
                //
                if (!dataMenu.Controls.OfType<VScrollBar>().First().Visible && dayLabel_ChangeLoc)
                {
                    dayLabel_ChangeLoc = false;

                     lbMenu.Left += 5;
                     lbMo.Left += 5;
                     lbTue.Left += 5;
                     lbWed.Left += 6;
                     lbThu.Left += 8;
                     lbFri.Left += 11;
                     lbSat.Left += 10;
                }
            }
        }


        public void SqlInsert()
        {
            Datenbank db = new Datenbank();
            MySqlCommand command = new MySqlCommand("INSERT INTO `CanteenTable`(`Menues`, `Montag`, `Dienstag`, `Mittwoch`, `Donnerstag`, `Freitag`, `Samstag`) " +
                                                    "VALUES (@Menues, @Montag, @Dienstag, @Mittwoch, @Donnerstag, @Freitag, @Samstag)", db.getConnection());

            command.Parameters.Add("@Menues", MySqlDbType.VarChar).Value = cmbMenue.SelectedItem.ToString();
            command.Parameters.Add("@Montag", MySqlDbType.VarChar).Value = txMonday.Text;
            command.Parameters.Add("@Dienstag", MySqlDbType.VarChar).Value = txTuesday.Text;
            command.Parameters.Add("@Mittwoch", MySqlDbType.VarChar).Value = txWednesday.Text;
            command.Parameters.Add("@Donnerstag", MySqlDbType.VarChar).Value = txThursday.Text;
            command.Parameters.Add("@Freitag", MySqlDbType.VarChar).Value = txFriday.Text;
            command.Parameters.Add("@Samstag", MySqlDbType.VarChar).Value = txSuturday.Text;

            // Öffnet die DB Verbindung
            //
            db.openConnection();
            try
            {
                // Führt die Anweisung durch wenn exakt 1 Eintrag erfolgreich war
                //
                if (command.ExecuteNonQuery() == 1)
                {
                    AlertClass.Show("Menü wurde hinzugefügt", Alert.enmType.Success);
                    dataMenu.DataSource = GetdataMenu();
                    dataMenu.ClearSelection();
                }
                else
                {
                    AlertClass.Show("Fehler beim hinzufügen des Menüs!", Alert.enmType.Error);
                }
            }
            catch (MySqlException ex)
            {
                AlertClass.Show("MySQL Verbindungsproblem!", Alert.enmType.Warning);
            }
            finally
            {
                db.closeConnection();
            }
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlInsert();

            // Sollte die ScrollBar erscheinen werden die label diese die Tage anzeigen,
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

      
        private void dataMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cellID = dataMenu.Rows[e.RowIndex].Cells["Menues"].Value as string;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                AlertClass.Show("Es können nur Reihen markiert werden!", Alert.enmType.Info);
            }
        }

      

        private void lbClose_Click(object sender, EventArgs e)
        {
            Form mainPageO = Application.OpenForms.Cast<Form>().Where(x => x.Name == "MainPage").FirstOrDefault();
            if (null != mainPageO)
            {
                mainPageO.Show();

            }
            this.Close();
        }

        private void cmbMenue_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Brush myBrush = Brushes.Black;
            Font ft = cmbMenue.Font; ;
            e.Graphics.DrawString(cmbMenue.Items[e.Index].ToString(), ft, myBrush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();

            var combo = sender as ComboBox;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.CornflowerBlue), e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(SystemColors.Window), e.Bounds);
            }

            e.Graphics.DrawString(combo.Items[e.Index].ToString(),
                                          e.Font,
                                          new SolidBrush(Color.Black),
                                          new Point(e.Bounds.X, e.Bounds.Y));
        }

        private void cmbMenue_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 40;
        }

        private void btnUserMenue_Click(object sender, EventArgs e)
        {
            
          
         
        }

        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            this.Hide();
            var userMenuO = Application.OpenForms.Cast<Form>().Where(x => x.Name == "UserMenue").FirstOrDefault();
            if (null != userMenuO)
            {
                userMenuO.Close();
                userMenuO = null;
            }
            UserMenue UserMenue = new UserMenue();
            UserMenue.Owner = this;
            UserMenue.Show();
        }
    }
}