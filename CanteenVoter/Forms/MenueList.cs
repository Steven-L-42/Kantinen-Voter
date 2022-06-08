using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CanteenVoter
{
    public partial class MenueList : Form
    {

        private string cellMenueA,cellMenueB,cellMenueC,cellMenueD;
        private bool dayLabel_ChangeLoc = false;

        public MenueList()
        {
            InitializeComponent();
            InitializeEvents();
        }


        #region InitializeEvents
        private void InitializeEvents()
        {

            txMenueA.GotFocus += TxMenueA_GotFocus;
            txMenueA.LostFocus += TxMenueA_LostFocus;
            txMenueB.GotFocus += TxMenueB_GotFocus;
            txMenueB.LostFocus += TxMenueB_LostFocus;
            txMenueC.GotFocus += TxMenueC_GotFocus;
            txMenueC.LostFocus += TxMenueC_LostFocus;
            txMenueD.GotFocus += TxMenueD_GotFocus;
            txMenueD.LostFocus += TxMenueD_LostFocus;
          
        }

        private void TxMenueD_GotFocus(object sender, EventArgs e)
        {
            if (txMenueD.Text == "Menü D: Neues Gericht...")
                txMenueD.Text = String.Empty;
        }

        private void TxMenueD_LostFocus(object sender, EventArgs e)
        {
            if (txMenueD.Text == String.Empty)
                txMenueD.Text = "Menü D: Neues Gericht...";
        }

        private void TxMenueC_GotFocus(object sender, EventArgs e)
        {
            if (txMenueC.Text == "Menü C: Neues Gericht...")
                txMenueC.Text = String.Empty;
        }

        private void TxMenueC_LostFocus(object sender, EventArgs e)
        {
            if (txMenueC.Text == String.Empty)
                txMenueC.Text = "Menü C: Neues Gericht...";
        }

        private void TxMenueB_GotFocus(object sender, EventArgs e)
        {
            if (txMenueB.Text == "Menü B: Neues Gericht...")
                txMenueB.Text = String.Empty;
        }

        private void TxMenueB_LostFocus(object sender, EventArgs e)
        {
            if (txMenueB.Text == String.Empty)
                txMenueB.Text = "Menü B: Neues Gericht...";
        }

        private void TxMenueA_GotFocus(object sender, EventArgs e)
        {
            if (txMenueA.Text == "Menü A: Neues Gericht...")
                txMenueA.Text = String.Empty;
        }

        private void TxMenueA_LostFocus(object sender, EventArgs e)
        {
            if (txMenueA.Text == String.Empty)
                txMenueA.Text = "Menü A: Neues Gericht...";
        }

        #endregion


        private void MenueList_Load(object sender, EventArgs e)
        {
            dataMenu.DataSource = GetdataMenu();
            dataMenu.ClearSelection();
            dataMenu.RowsDefaultCellStyle.BackColor = Color.GhostWhite;
            dataMenu.RowsDefaultCellStyle.ForeColor = Color.Black;
            dataMenu.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            dataMenu.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

           

            // Sollte ScrollBar erscheinen werden die label diese die Tage anzeigen,
            // um wenige pixel versetzt, damit eine sauber zentrierte UI hinterlassen wird.
            // Außerdem setze ich einen bool, so das es insgesamt auch nur 1x möglich ist die label zu versetzen.
            //
            if (dataMenu.Controls.OfType<VScrollBar>().First().Visible && !dayLabel_ChangeLoc)
            {
                dayLabel_ChangeLoc = true;

              
                lbMo.Left -= 5;
                lbTue.Left -= 5;
                lbWed.Left -= 6;
                lbThu.Left -= 8;
        
            }

            EnableDoubleBuffering();
        }
    

        private DataTable GetdataMenu()
        {
            Datenbank db = new Datenbank();
            DataTable table = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter())
            {


                using (MySqlCommand command = new MySqlCommand("SELECT `Menü A`,`Menü B`,`Menü C`,`Menü D` FROM MenuesTable", db.getConnection()))
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
               cellMenueA = dataMenu.Rows[e.RowIndex].Cells[0].Value as string;
                cellMenueB = dataMenu.Rows[e.RowIndex].Cells[1].Value as string;
                cellMenueC = dataMenu.Rows[e.RowIndex].Cells[2].Value as string;
                cellMenueD = dataMenu.Rows[e.RowIndex].Cells[3].Value as string;
                //cellText = dataMenu.Rows[e.RowIndex].Cells[e.ColumnIndex].Value as string;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                AlertClass.Show("Es können nur Reihen markiert werden!", Alert.enmType.Info);
            }
        }


        public void SqlInsert()
        {
            Datenbank db = new Datenbank();
            MySqlCommand command = new MySqlCommand("INSERT INTO `MenuesTable`(`Menü A`,`Menü B`,`Menü C`,`Menü D`) " +
                                                    "VALUES (@MenueA,@MenueB,@MenueC,@MenueD)", db.getConnection());

            command.Parameters.Add("@MenueA", MySqlDbType.VarChar).Value = txMenueA.Text;
            command.Parameters.Add("@MenueB", MySqlDbType.VarChar).Value = txMenueB.Text;
            command.Parameters.Add("@MenueC", MySqlDbType.VarChar).Value = txMenueC.Text;
            command.Parameters.Add("@MenueD", MySqlDbType.VarChar).Value = txMenueD.Text;


            // Öffnet die DB Verbindung
            //
            db.openConnection();
            try
            {
                // Führt die Anweisung durch wenn exakt 1 Eintrag erfolgreich war
                //
                if (command.ExecuteNonQuery() == 1)
                {
                    AlertClass.Show("Gerichte wurden hinzugefügt", Alert.enmType.Success);
                    dataMenu.DataSource = GetdataMenu();
                    dataMenu.ClearSelection();
                    txMenueA.Text = "Menü A: Neues Gericht...";
                    txMenueB.Text = "Menü B: Neues Gericht...";
                    txMenueC.Text = "Menü C: Neues Gericht...";
                    txMenueD.Text = "Menü D: Neues Gericht...";

                }
                else
                {
                    AlertClass.Show("Fehler beim hinzufügen der Gerichte!", Alert.enmType.Error);
                    dataMenu.DataSource = GetdataMenu();
                    dataMenu.ClearSelection();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);    
                AlertClass.Show("MySQL Verbindungsproblem!", Alert.enmType.Warning);
            }
            finally
            {
                db.closeConnection();
            }
        }


        private void btnInformation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zum ändern von Gerichten:\n" +
                            "Doppel Klick auf die Zeile, alle Daten werden dann\n" +
                            "auf das Eingabefeld übernommen.\n\n" +
                            "Anschließend kann die Zeile gelöscht und die neu\n" +
                            "editierte kann hinzugefügt werden",
                            "Ändern von bereits existierenden Gerichten");
        }


        public void SqlDelete(string id)
        {
            try
            {
                Datenbank db = new Datenbank();
                db.openConnection();
                try
                {
                    MySqlCommand command = new MySqlCommand("DELETE FROM `MenuesTable` WHERE `Menü A` = '" + id + "'", db.getConnection());
                    command.ExecuteNonQuery();
                    dataMenu.DataSource = GetdataMenu();
                    cellMenueA = null;
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
            if(cellMenueA == null)
            {
                AlertClass.Show("Wähle zuerst eine Spalte aus!", Alert.enmType.Info);
            }
            else
            {
                var confirmResult = MessageBox.Show("Sollen diese Gerichte wirklich gelöscht werden?\n\n" +
                                                "Alternativ können Gerichte auch bearbeitet werden,\n" +
                                                "für mehr Informationen darüber klicke auf den Information Button",
                                               "Löschvorgang bestätigen!", MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2);

                if (confirmResult == DialogResult.Yes)
                {
                    SqlDelete(cellMenueA);
                }
            }
            
        }

        private void dataMenu_DoubleClick(object sender, EventArgs e)
        {
           
                txMenueA.Text = cellMenueA;
                txMenueB.Text = cellMenueB;
                txMenueC.Text = cellMenueC;
                txMenueD.Text = cellMenueD; 
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlInsert();
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
