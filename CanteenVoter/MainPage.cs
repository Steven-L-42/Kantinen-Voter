using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
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
        public bool getImagePanel { get; set; }
        private string day;
        private string gerichtText;
        private string menuesText;


        public MainPage()
        {
            InitializeComponent();
        }


        private void MainPage_Load(object sender, EventArgs e)
        {
            dataMenu.DataSource = GetdataMenu();
            getDataSelectedMenue();
            dataMenu.ClearSelection();
            this.dataMenu.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            if (getUsername == "ShiiikK" || getUsername == "Mentalill")
            {
                lbAdminPanel.Visible = true;
            }
            EnableDoubleBuffering();
           
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


        public void EnableDoubleBuffering()
        {
            this.SetStyle(ControlStyles.DoubleBuffer |
               ControlStyles.UserPaint |
               ControlStyles.AllPaintingInWmPaint,
               true);
            this.UpdateStyles();
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
            userAcp.Owner = this;
            userAcp.Show();
            getTimer.Start();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dataMenu.DataSource = GetdataMenu();
            dataMenu.ClearSelection();
         
        }
        private bool menuChange = false;

        DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
        private void dataMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

          



            try
            {
                if (!menuChange)
                {
                    var confirmResult = MessageBox.Show("Willst du deine Menüs wirklich ändern?",
                                                 "Menü Änderung!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (confirmResult == DialogResult.Yes)
                    {
                        menuChange = true;
                    }


                }
                if (menuChange)
                {
                    day = dataMenu.Columns[e.ColumnIndex].HeaderText;
                    gerichtText = dataMenu.CurrentRow.Cells[e.ColumnIndex].Value as string;
                    menuesText = dataMenu.CurrentRow.Cells[0].Value.ToString();

                    if (day == "Menues")
                    {
                        AlertClass.Show("Du kannst nicht die Kategorie\n" +
                            "Menues als Menü speichern!", Alert.enmType.Warning);
                        day = null;
                        dataMenu.ClearSelection();
                    }
                    else
                    {
                        SelectMenu(menuesText);
                        if (e.RowIndex < 0 || e.RowIndex == dataMenu.NewRowIndex)
                        {
                            return;
                        }
                        dataGridViewCellStyle = new DataGridViewCellStyle(dataMenu.DefaultCellStyle)
                        {
                            BackColor = Color.CornflowerBlue
                        };
                        dataMenu[e.ColumnIndex, e.RowIndex].Style = dataGridViewCellStyle;

                    }
                }

            }
            catch (ArgumentOutOfRangeException ex)
            {
                AlertClass.Show("Es können nur einzelne Menüs markiert werden!", Alert.enmType.Info);
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
                MySqlCommand sqlCmd = new MySqlCommand("SELECT * FROM UserMenueTable WHERE Benutzername = @Benutzername",db.getConnection());
                MySqlDataAdapter sqlDa = new MySqlDataAdapter(sqlCmd);
               
                sqlCmd.Parameters.AddWithValue("@Benutzername", this.getUsername);
                sqlDa.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txMondayI.Text = dt.Rows[0]["MontagGericht"].ToString(); // Zeigt mir die geforderte Spalte 'MontagGericht' in der in der Selected Menue Area an.
                    txTuesdayI.Text = dt.Rows[0]["DienstagGericht"].ToString();
                    txWednesdayI.Text = dt.Rows[0]["MittwochGericht"].ToString();
                    txThursdayI.Text = dt.Rows[0]["DonnerstagGericht"].ToString();
                    txFridayI.Text = dt.Rows[0]["FreitagGericht"].ToString();
                    txSaturdayI.Text = dt.Rows[0]["SamstagGericht"].ToString();

                    txMonday.Text = dt.Rows[0]["Montag"].ToString(); // Zeigt mir die geforderte Spalte 'Montag' in der in der Selected Menue Area an.
                    txTuesday.Text = dt.Rows[0]["Dienstag"].ToString();
                    txWednesday.Text = dt.Rows[0]["Mittwoch"].ToString();
                    txThursday.Text = dt.Rows[0]["Donnerstag"].ToString();
                    txFriday.Text = dt.Rows[0]["Freitag"].ToString();
                    txSaturday.Text = dt.Rows[0]["Samstag"].ToString();
                    SetEmptyTextBoxes();
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


 


        private void SelectMenu(string menu)
        {
            Datenbank db = new Datenbank();
            MySqlCommand command = new MySqlCommand(@"UPDATE UserMenueTable SET " + day + "='" + menuesText + "'," + day +"Gericht='" + gerichtText + "' WHERE Benutzername='" + this.getUsername + "'",
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
                            txMonday.Text = menuesText;
                            txMondayI.Text = gerichtText;
                            break;

                        case "Dienstag":
                            txTuesday.Text = menuesText;
                            txTuesdayI.Text = gerichtText;
                            break;

                        case "Mittwoch":
                            txWednesday.Text = menuesText;
                            txWednesdayI.Text = gerichtText;
                            break;

                        case "Donnerstag":
                            txThursday.Text = menuesText;
                            txThursdayI.Text = gerichtText;
                            break;

                        case "Freitag":
                            txFriday.Text = menuesText;
                            txFridayI.Text = gerichtText;
                            break;

                        case "Samstag":
                            txSaturday.Text = menuesText;
                            txSaturdayI.Text = gerichtText;
                            break;
                    }
                 
                    dataMenu.ClearSelection();
                    day = null;
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

        #region SetEmptyTextBoxes
        private void SetEmptyTextBoxes()
        {
            if (txMonday.Text == string.Empty)
            {
                txMonday.Text = "Menü wurde noch\n" +
                                "nicht gewählt.";
            }
            if (txTuesday.Text == string.Empty)
            {
                txTuesday.Text = "Menü wurde noch\n" +
                                "nicht gewählt.";
            }
            if (txWednesday.Text == string.Empty)
            {
                txWednesday.Text = "Menü wurde noch\n" +
                                "nicht gewählt.";
            }
            if (txThursday.Text == string.Empty)
            {
                txThursday.Text = "Menü wurde noch\n" +
                                "nicht gewählt.";
            }
            if (txFriday.Text == string.Empty)
            {
                txFriday.Text = "Menü wurde noch\n" +
                                "nicht gewählt.";
            }
            if (txSaturday.Text == string.Empty)
            {
                txSaturday.Text = "Menü wurde noch\n" +
                                "nicht gewählt.";
            }
        }
        #endregion

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

        private void getTimer_Tick(object sender, EventArgs e)
        {
            if(getImagePanel)
            {
                ImagePanel.Visible = true;
            }
        }
    }
}