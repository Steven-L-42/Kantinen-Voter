using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CanteenVoter
{
    public partial class UserAcp : Form
    {
        // Ich vergebe ich die Rechte auf das setzen meines Benutzernames, den erhalten ich aus der MainPage form.
        // Außerdem schränke ich die Get Methode ein, sodass die Information hier privat bleibt.
        //
        public string getUsername { private get; set; }

        public UserAcp()
        {
            InitializeComponent();
        }

        private void UserAcp_Load(object sender, EventArgs e)
        {
            // Hier wird eine Methode aufgerufen die alle TextBoxen und den
            // DateTimePicker mit den Daten aus der Datenbank füllt.
            //
            getData();
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

        private void UserAcp_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                RegAndLogin.MoveWindow.ReleaseCapture();
                RegAndLogin.MoveWindow.SendMessage(Handle,
                RegAndLogin.MoveWindow.WM_NCLBUTTONDOWN,
                RegAndLogin.MoveWindow.HT_CAPTION, 0);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Datenbank db = new Datenbank();

            // Aktualisiere und überschreibe vorhandene Daten oder wenn keine vorhanden,
            // schreibe eingegeben Daten in die Datenbank.
            // Diese Aktion wird nur Einträge bei dem Konto vornehmen, dessen Benutzername mit dem des Logins übereinstimmt.
            //
            MySqlCommand command = new MySqlCommand(@"UPDATE UserTable SET Vorname='" + txFirstName.Text + "', " +
                                                    "Nachname='" + txSurname.Text + "'," +
                                                    "Geburtsdatum='" + dateBorn.Text + "', " +
                                                    "Allergene='" + txAllergic.Text + "' " +
                                                    "WHERE Benutzername='" + this.getUsername + "'",
                                                    db.getConnection());

            // Öffnet die DB Verbindung
            //
            db.openConnection();
            try
            {
                // Führt die Anweisung durch
                //
                if (command.ExecuteNonQuery() == 1)
                {
                    AlertClass.Show("Account Daten wurde aktualisiert!", Alert.enmType.Success);
                }
                else
                {
                    AlertClass.Show("Account Daten wurden nicht aktualisiert!\n\n" +
                                    "Es ist wohl ein Fehler aufgetreten.\n" +
                                    "Bitte kontaktieren Sie den Support.", Alert.enmType.Warning);
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

        private void getData()
        {
            Datenbank db = new Datenbank();
            DataTable dt = new DataTable();

            // Öffnet die DB Verbindung
            //
            db.openConnection();
            try
            {
                // Wähle 'Alle' Einträge von meiner UserTable aus dessen Benutzername mit dem des Logins ubereinstimmt.
                //
                MySqlCommand sqlCmd = new MySqlCommand("SELECT * FROM UserTable WHERE Benutzername = @Benutzername", db.getConnection());
                MySqlDataAdapter sqlDa = new MySqlDataAdapter(sqlCmd);

                sqlCmd.Parameters.AddWithValue("@Benutzername", this.getUsername);
                sqlDa.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    txFirstName.Text = dt.Rows[0]["Vorname"].ToString(); // Zeigt mir die geforderte Spalte 'Vorname' in der TextBox an
                    txSurname.Text = dt.Rows[0]["Nachname"].ToString();
                    dateBorn.Text = dt.Rows[0]["Geburtsdatum"].ToString();
                    txAllergic.Text = dt.Rows[0]["Allergene"].ToString();
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

        private void lbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}