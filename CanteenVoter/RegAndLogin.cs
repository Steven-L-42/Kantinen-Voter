using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CanteenVoter
{
    public partial class RegAndLogin : Form
    {
        public RegAndLogin()
        {
            InitializeComponent();
        }

        public Boolean checkTextBoxesValues()
        {
            string username = txUsername.Text.Trim();
            string password = txPassword.Text.Trim();

            if (username.Equals("Benutzername")
                || password.Equals("Passwort"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean checkUsername()
        {
            Datenbank db = new Datenbank();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `UserTable` WHERE `Benutzername` = @Benutzername", db.getConnection());

            command.Parameters.Add("@Benutzername", MySqlDbType.VarChar).Value = txUsername.Text.Trim();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            // Überprüft ob der Benutzername bereits existiert
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginMethod();
        }

        private void LoginMethod()
        {
            Datenbank db = new Datenbank();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM UserTable WHERE Benutzername = '" + txUsername.Text.Trim() + "' AND Passwort = '" + Encryptor.MD5Hash(txPassword.Text.Trim()) + "'", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                Properties.Settings.Default.txUsername = txUsername.Text.Trim();
                Properties.Settings.Default.txPassword = txPassword.Text.Trim();
                Properties.Settings.Default.Save();
                string getUsernameL = txUsername.Text.Trim();
                var mainPage = new MainPage();
                mainPage.getUsername = getUsernameL;
                mainPage.Show();
                this.Hide();
            }
            else
            {
                AlertClass.Show("Bitte überprüfe deine Login Daten!", Alert.enmType.Warning);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterMethod();
        }

        private void RegisterMethod()
        {
            Datenbank db = new Datenbank();
            MySqlCommand command = new MySqlCommand(@"INSERT INTO UserTable SET Benutzername=@Benutzername,  Passwort=@Passwort;" +
                                                     "INSERT INTO UserMenueTable SET Benutzername=@Benutzername", db.getConnection());

            command.Parameters.Add("@Benutzername", MySqlDbType.VarChar).Value = txUsername.Text.Trim();
            command.Parameters.Add("@Passwort", MySqlDbType.VarChar).Value = Encryptor.MD5Hash(txPassword.Text.Trim());

            // Öffnet die DB Verbindung
            //
            db.openConnection();
            try
            {
                // Überprüft ob die Textbox Eingaben den Standard entsprechen
                //
                if (!checkTextBoxesValues())
                {
                    // Überprüft ob das eingegebene Passwort mit dem ComparePassword übereinstimmt
                    //
                    if (txPassword.Text.Equals(txPasswordCompare.Text))
                    {
                        // Überprüft ob der Benutzername bereits existiert
                        //
                        if (checkUsername())
                        {
                            AlertClass.Show("Dieser Benutzername existiert bereits!", Alert.enmType.Warning);
                        }
                        else
                        {
                            // Führt die Anweisung durch
                            //
                            if (command.ExecuteNonQuery() == 2)
                            {
                                AlertClass.Show("Dein Account wurde erstellt.", Alert.enmType.Success);
                                chBoxPasswordShowL.Visible = lbNoAccount.Visible = lbRegisterTab.Visible = btnLogin.Visible = true;
                                lbExistAccount.Visible = lbAccountExist.Visible = btnRegister.Visible = lbPasswordCompare.Visible = txPasswordCompare.Visible = chBoxPasswordShow.Visible = false;
                            }
                            else
                            {
                                AlertClass.Show("ERROR", Alert.enmType.Warning);
                            }
                        }
                    }
                    else
                    {
                        AlertClass.Show("Passwörter stimmen nicht überein!", Alert.enmType.Warning);
                    }
                }
                else
                {
                    AlertClass.Show("Bitte fülle alle Felder aus!", Alert.enmType.Info);
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

        private void chBoxPasswordShowL_CheckedChanged(object sender, EventArgs e)
        {
            if (txPassword.PasswordChar == (char)0)
            {
                txPassword.PasswordChar = '*';
            }
            else
            {
                txPassword.PasswordChar = (char)0;
                AlertClass.Show("Passwort ist nun in Klarttext lesbar!", Alert.enmType.Info);
            }
        }

        private void chBoxPasswordShow_CheckedChanged(object sender, EventArgs e)
        {
            if (txPassword.PasswordChar == (char)0 && txPasswordCompare.PasswordChar == (char)0)
            {
                txPassword.PasswordChar = txPasswordCompare.PasswordChar = '*';
            }
            else
            {
                txPasswordCompare.PasswordChar = txPassword.PasswordChar = (char)0;
                AlertClass.Show("Passwort ist nun in Klarttext lesbar!", Alert.enmType.Info);
            }
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegLoginHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MoveWindow.ReleaseCapture();
                MoveWindow.SendMessage(Handle, MoveWindow.WM_NCLBUTTONDOWN, MoveWindow.HT_CAPTION, 0);
            }
        }

        private void lbRegisterTab_Click(object sender, EventArgs e)
        {
            chBoxPasswordShowL.Visible = lbNoAccount.Visible = lbRegisterTab.Visible = btnLogin.Visible = false;
            lbExistAccount.Visible = lbAccountExist.Visible = btnRegister.Visible = lbPasswordCompare.Visible = txPasswordCompare.Visible = chBoxPasswordShow.Visible = true;
        }

        private void lbExistAccount_Click(object sender, EventArgs e)
        {
            chBoxPasswordShowL.Visible = lbNoAccount.Visible = lbRegisterTab.Visible = btnLogin.Visible = true;
            lbExistAccount.Visible = lbAccountExist.Visible = btnRegister.Visible = lbPasswordCompare.Visible = txPasswordCompare.Visible = chBoxPasswordShow.Visible = false;
        }

        private void txPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !lbPasswordCompare.Visible)
            {
                LoginMethod();
            }
        }

        private void txPasswordCompare_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RegisterMethod();
            }
        }

        private void RegAndLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MoveWindow.ReleaseCapture();
                MoveWindow.SendMessage(Handle, MoveWindow.WM_NCLBUTTONDOWN, MoveWindow.HT_CAPTION, 0);
            }
        }

        private void RegAndLogin_Load(object sender, EventArgs e)
        {
            txUsername.Text = Properties.Settings.Default.txUsername;
            txPassword.Text = Properties.Settings.Default.txPassword;
            txUsername.GotFocus += TxUsername_GotFocus;
            txPassword.GotFocus += TxPassword_GotFocus;

            EnableDoubleBuffering();
        }

        private void TxPassword_GotFocus(object sender, EventArgs e)
        {
            txPassword.SelectionStart = txPassword.Text.Length;
            txPassword.SelectionLength = 0;
        }

        private void TxUsername_GotFocus(object sender, EventArgs e)
        {
            txUsername.SelectionStart = txUsername.Text.Length;
            txUsername.SelectionLength = 0;
        }

        public void EnableDoubleBuffering()
        {
            this.SetStyle(ControlStyles.DoubleBuffer |
               ControlStyles.UserPaint |
               ControlStyles.AllPaintingInWmPaint,
               true);
            this.UpdateStyles();
        }
    }
}