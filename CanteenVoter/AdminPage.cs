using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CanteenVoter
{
    public partial class AdminPage : Form
    {
        string id;
        public AdminPage()
        {
            InitializeComponent();
            InitializeEvents();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            dataMenu.DataSource = GetdataMenu();
            this.dataMenu.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            
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
            EnableDoubleBuffering();
        }
        public void EnableDoubleBuffering()
        {
            this.SetStyle(ControlStyles.DoubleBuffer |
               ControlStyles.UserPaint |
               ControlStyles.AllPaintingInWmPaint,
               true);
            this.UpdateStyles();
        }
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

        #region InitializeEvents
        private void TxSuturday_LostFocus(object sender, EventArgs e)
        {
            if (txSuturday.Text == String.Empty)
                txSuturday.Text = "SAMSTAG";
        }

        private void TxSuturday_GotFocus(object sender, EventArgs e)
        {
            if (txSuturday.Text == "SAMSTAG")
                txSuturday.Text = String.Empty;
        }

        private void TxFriday_LostFocus(object sender, EventArgs e)
        {
            if (txFriday.Text == String.Empty)
                txFriday.Text = "FREITAG";
        }

        private void TxFriday_GotFocus(object sender, EventArgs e)
        {
            if (txFriday.Text == "FREITAG")
                txFriday.Text = String.Empty;
        }

        private void TxThursday_LostFocus(object sender, EventArgs e)
        {
            if (txThursday.Text == String.Empty)
                txThursday.Text = "DONNERSTAG";
        }

        private void TxThursday_GotFocus(object sender, EventArgs e)
        {
            if (txThursday.Text == "DONNERSTAG")
                txThursday.Text = String.Empty;
        }

        private void TxWednesday_LostFocus(object sender, EventArgs e)
        {
            if (txWednesday.Text == String.Empty)
                txWednesday.Text = "MITTWOCH";
        }

        private void TxWednesday_GotFocus(object sender, EventArgs e)
        {
            if (txWednesday.Text == "MITTWOCH")
                txWednesday.Text = String.Empty;
        }
        private void TxTuesday_LostFocus(object sender, EventArgs e)
        {
            if (txTuesday.Text == String.Empty)
                txTuesday.Text = "DIENSTAG";
        }

        private void TxTuesday_GotFocus(object sender, EventArgs e)
        {
            if (txTuesday.Text == "DIENSTAG")
                txTuesday.Text = String.Empty;
        }

        private void TxMonday_LostFocus(object sender, EventArgs e)
        {
            if (txMonday.Text == String.Empty)
                txMonday.Text = "MONTAG";
        }

        private void TxMonday_GotFocus(object sender, EventArgs e)
        {
            if (txMonday.Text == "MONTAG")
                txMonday.Text = String.Empty;
        }

        #endregion

        private void AdminPageHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                RegAndLogin.MoveWindow.ReleaseCapture();
                RegAndLogin.MoveWindow.SendMessage(Handle,
                RegAndLogin.MoveWindow.WM_NCLBUTTONDOWN,
                RegAndLogin.MoveWindow.HT_CAPTION, 0);
            }
        }

        private DataTable GetdataMenu()
        {
            Datenbank db = new Datenbank();
            DataTable table = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter())
            {
                using (MySqlCommand command = new MySqlCommand("SELECT * FROM CanteenTable", db.getConnection()))
                {
                    db.openConnection();
                    MySqlDataReader reader = command.ExecuteReader();

                    table.Load(reader);
                    db.closeConnection();
                }
            }
            return table;

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
                // Führt die Anweisung durch 
                //
                if (command.ExecuteNonQuery() == 1)
                {
                    AlertClass.Show("Menü wurde hinzugefügt", Alert.enmType.Success);
                    dataMenu.DataSource = GetdataMenu();
                }
                else
                {
                    MessageBox.Show("ERROR");
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
                }
                finally
                {
                    db.closeConnection();
                    dataMenu.DataSource = GetdataMenu();
                }
            }
            catch (MySqlException ex)
            {
                AlertClass.Show("MySQL Verbindungsproblem!", Alert.enmType.Warning);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlInsert();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Soll diese Spalte wirklich gelöscht werden?",
                                                "Löschvorgang bestätigen!", MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2);

            if (confirmResult == DialogResult.Yes)
            {
                SqlDelete(id);
            }
        }

        private void dataMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = dataMenu.Rows[e.RowIndex].Cells["Menues"].Value as string;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                AlertClass.Show("Es können nur Reihen markiert werden!", Alert.enmType.Info);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dataMenu.DataSource = GetdataMenu();
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

