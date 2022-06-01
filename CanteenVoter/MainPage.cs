using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CanteenVoter
{
    public partial class MainPage : Form
    {
        // Ich vergebe ich die Rechte auf das setzen meines Benutzernames, den erhalten ich aus dem Login Bereich.
        // Anschließend beim Aufruf des UserACP's wird diese Information
        // weitergegeben um weitere Aktionen mit dem Benutzernamen auszuführen
        //
        // Außerdem schränke ich die Get Methode ein, sodass die Information hier privat bleibt.
        //
        public string getUsername { private get; set; }

        private string day;

        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            dataMenu.DataSource = GetdataMenu();
            getDataSelectedMenue();
            this.dataMenu.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            if (getUsername == "ShiiikK" || getUsername == "Mentalill")
            {
                lbAdminPanel.Visible = true;
            }
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

        private void MainPageHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                RegAndLogin.MoveWindow.ReleaseCapture();
                RegAndLogin.MoveWindow.SendMessage(Handle,
                RegAndLogin.MoveWindow.WM_NCLBUTTONDOWN,
                RegAndLogin.MoveWindow.HT_CAPTION, 0);
            }
        }

        private void getDataSelectedMenue()
        {
            Datenbank db = new Datenbank();
            DataTable dt = new DataTable();

            // Öffnet die DB Verbindung
            //
            db.openConnection();
            try
            {
                // Wähle 'Alle' Einträge von meiner UserMenueTable aus dessen Benutzername mit dem des Logins ubereinstimmt.
                //
                MySqlCommand sqlCmd = new MySqlCommand("SELECT * FROM UserMenueTable WHERE Benutzername = @Benutzername", db.getConnection());
                MySqlDataAdapter sqlDa = new MySqlDataAdapter(sqlCmd);

                sqlCmd.Parameters.AddWithValue("@Benutzername", this.getUsername);
                sqlDa.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txMonday.Text = dt.Rows[0]["Montag"].ToString(); // Zeigt mir die geforderte Spalte 'Montag' in der in der Selected Menue Area an.
                    txTuesday.Text = dt.Rows[0]["Dienstag"].ToString();
                    txWednesday.Text = dt.Rows[0]["Mittwoch"].ToString();
                    txThursday.Text = dt.Rows[0]["Donnerstag"].ToString();
                    txFriday.Text = dt.Rows[0]["Freitag"].ToString();
                    txSaturday.Text = dt.Rows[0]["Samstag"].ToString();
                }
            }
            catch (MySqlException ex)
            {
                AlertClass.Show("MySQL Verbindungsproblem!", Alert.enmType.Error);
            }
            finally
            {
                db.closeConnection();
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

        private void SelectMenu(string menu)
        {
            Datenbank db = new Datenbank();
            MySqlCommand command = new MySqlCommand(@"UPDATE UserMenueTable SET " + day + "='" + menu + "' " +
                                                            "WHERE Benutzername='" + this.getUsername + "'",
                                                            db.getConnection());
            db.openConnection();
            // Öffnet die DB Verbindung
            //
            db.openConnection();
            try
            {
                // Führt die Anweisung durch
                //
                if (menu == "Menues")
                {
                    AlertClass.Show("Du kannst nicht die Kategorie Menues als Menü speichern!", Alert.enmType.Warning);
                }
                else
                if (command.ExecuteNonQuery() == 1)
                {
                    AlertClass.Show("Dein Menü wurde erfolgreich gewählt!", Alert.enmType.Success);
                    switch (day)
                    {
                        case "Montag":
                            txMonday.Text = menu;
                            break;

                        case "Dienstag":
                            txTuesday.Text = menu;
                            break;

                        case "Mittwoch":
                            txWednesday.Text = menu;
                            break;

                        case "Donnerstag":
                            txThursday.Text = menu;
                            break;

                        case "Freitag":
                            txFriday.Text = menu;
                            break;

                        case "Samstag":
                            txSaturday.Text = menu;
                            break;
                    }
                    dataMenu.ClearSelection();
                }
                else
                {
                    AlertClass.Show("Deine Menü Auswahl war nicht erfolgreich!", Alert.enmType.Warning);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                AlertClass.Show("MySQL Verbindungsproblem!", Alert.enmType.Error);
            }
            finally
            {
                db.closeConnection();
            }
        }

        private void btnMyAccount_Click(object sender, EventArgs e)
        {
            var userAcpO = Application.OpenForms.Cast<Form>().Where(x => x.Name == "UserAcp").FirstOrDefault();
            if (null != userAcpO)
            {
                userAcpO.Close();
                userAcpO = null;
            }
            var userAcp = new UserAcp();
            userAcp.getUsername = getUsername;
            userAcp.Show();
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            var adminPageO = Application.OpenForms.Cast<Form>().Where(x => x.Name == "AdminPage").FirstOrDefault();
            var userAcpO = Application.OpenForms.Cast<Form>().Where(x => x.Name == "UserAcp").FirstOrDefault();

            if (null != adminPageO)
            {
                adminPageO.Close();
                adminPageO = null;
            }
            if (null != userAcpO)
            {
                userAcpO.Close();
                userAcpO = null;
            }
            this.Close();
            Form login = Application.OpenForms["RegAndLogin"];
            login.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dataMenu.DataSource = GetdataMenu();
        }

        #region SelectMenueButton

        private void btnMenuA_Click(object sender, EventArgs e)
        {
            if (day != null)
                SelectMenu("Menü A \n" +
                       "(Normal Kost)");
            else
            {
                AlertClass.Show("Es wurde kein Menü ausgewählt!", Alert.enmType.Info);
            }
        }

        private void btnMenuB_Click(object sender, EventArgs e)
        {
            if (day != null)
                SelectMenu("Menü B \n" +
                       "(Vegan)");
            else
            {
                AlertClass.Show("Es wurde kein Menü ausgewählt!", Alert.enmType.Info);
            }
        }

        private void btnMenuC_Click(object sender, EventArgs e)
        {
            if (day != null)
                SelectMenu("Menü C \n" +
                       "(Vegetarisch)");
            else
            {
                AlertClass.Show("Es wurde kein Menü ausgewählt!", Alert.enmType.Info);
            }
        }

        private void btnMenuD_Click(object sender, EventArgs e)
        {
            if (day != null)
                SelectMenu("Menü D \n" +
                       "(Gluten-/Lak.- Frei)");
            else
            {
                AlertClass.Show("Es wurde kein Menü ausgewählt!", Alert.enmType.Info);
            }
        }

        #endregion SelectMenueButton

        private void lbAdminPanel_Click(object sender, EventArgs e)
        {
            var adminPageO = Application.OpenForms.Cast<Form>().Where(x => x.Name == "AdminPage").FirstOrDefault();
            if (null != adminPageO)
            {
                adminPageO.Close();
                adminPageO = null;
            }
            var admin = new AdminPage();
            admin.Show();
        }

        private void dataMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                day = dataMenu.Columns[e.ColumnIndex].HeaderText;
                if (day == "Menues")
                {
                    AlertClass.Show("Du kannst nicht die Kategorie\n" +
                        "Menues als Menü speichern!", Alert.enmType.Warning);
                    day = null;
                    dataMenu.ClearSelection();
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                AlertClass.Show("Es können nur einzelne Menüs markiert werden!", Alert.enmType.Info);
            }
        }
    }
}