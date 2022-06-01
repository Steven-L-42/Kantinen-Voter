using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CanteenVoter
{

    public partial class MainPage : Form
    {
        string day;
        // Ich vergebe ich die Rechte auf das setzen meines Benutzernames, den erhalten ich aus dem Login Bereich.
        // Anschließend beim Aufruf des UserACP's wird diese Information
        // weitergegeben um weitere Aktionen mit dem Benutzernamen auszuführen
        //
        // Außerdem schränke ich die Get Methode ein, sodass die Information hier privat bleibt.
        //
        public string getUsername { private get; set; }

        public MainPage()
        {
            InitializeComponent();
         
        }
      
        private void MainPage_Load(object sender, EventArgs e)
        {
          
            dataMenu.DataSource = GetdataMenu();
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
                if (command.ExecuteNonQuery() == 1)
                {
                    AlertClass.Show("Dein Menü wurde erfolgreich gewählt!", Alert.enmType.Success);
                    switch (day)
                    {
                        case "Montag":
                            lbMonday.Text = menu;
                            break;
                        case "Dienstag":
                            lbTuesday.Text = menu;
                            break;
                        case "Mittwoch":
                            lbWednesday.Text = menu;
                            break;
                        case "Donnerstag":
                            lbThursday.Text = menu;
                            break;
                        case "Freitag":
                            lbFriday.Text = menu;
                            break;
                        case "Samstag":
                            lbSaturday.Text = menu;
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

        private void btnMenuA_Click(object sender, EventArgs e)
        {

            SelectMenu("Menü A \n" +
                       "(Normal Kost)");
        }

        private void btnMenuB_Click(object sender, EventArgs e)
        {
            SelectMenu("Menü B \n" +
                       "(Vegan)");
        }

        private void btnMenuC_Click(object sender, EventArgs e)
        {
            SelectMenu("Menü C \n" +
                       "(Vegetarisch)");
        }

        private void btnMenuD_Click(object sender, EventArgs e)
        {
            SelectMenu("Menü D \n" +
                       "(Gluten-/Lak.- Frei)");
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

        private void dataMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                day = dataMenu.Columns[e.ColumnIndex].HeaderText;
                // MessageBox.Show(day.ToString());
               
            }
            catch (ArgumentOutOfRangeException ex)
            {
                AlertClass.Show("Es können nur Reihen markiert werden!", Alert.enmType.Info);
            }
        }
    }
}
