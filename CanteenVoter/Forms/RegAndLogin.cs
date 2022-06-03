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


        private void RegAndLogin_Load(object sender, EventArgs e)
        {
            txUsername.Text = Properties.Settings.Default.txUsername;
            txPassword.Text = Properties.Settings.Default.txPassword;
            txUsername.GotFocus += TxUsername_GotFocus;
            txPassword.GotFocus += TxPassword_GotFocus;

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


        private void RegLoginHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MoveWindow.ReleaseCapture();
                MoveWindow.SendMessage(Handle, MoveWindow.WM_NCLBUTTONDOWN, MoveWindow.HT_CAPTION, 0);
            }
        }


        private void RegisterMethod()
        {
            // Hier starten wir den Registrierungsprozess und lassen uns gleich
            // jeweils einen Eintrag in zwei unterschiedliche Datenbank Tabellen erstellen.
            // Bevor das aber geschieht wird zu erst das eingetragene Passwort in ein MD5 umgewandelt.
            // Weiter im Text geht es unten bei den If Statements.
            //
            Datenbank db = new Datenbank();
            MySqlCommand command = new MySqlCommand(@"INSERT INTO UserTable SET Benutzername=@Benutzername,  Passwort=@Passwort;" +
                                                     "INSERT INTO UserMenueTable SET Benutzername=@Benutzername", db.getConnection());

            command.Parameters.Add("@Benutzername", MySqlDbType.VarChar).Value = txUsername.Text.Trim();
            command.Parameters.Add("@Passwort", MySqlDbType.VarChar).Value = Encryptor.MD5Hash(txPassword.Text.Trim());

            // Öffnet die DB Verbindung.
            //
            db.openConnection();
            try
            {
                // Überprüft ob die mindest Anforderung an Zeichen erreicht wurde.
                //
                if (!checkTextBoxesValues())
                {
                    // Überprüft ob das ComparePassword mit dem eingegebene Passwort übereinstimmt.
                    //
                    if (txPassword.Text.Equals(txPasswordCompare.Text))
                    {
                        // Überprüft ob der Benutzername bereits existiert.
                        //
                        if (checkUsername())
                        {
                            AlertClass.Show("Dieser Benutzername existiert bereits!", Alert.enmType.Warning);
                        }
                        else
                        {
                            // Diese Anweisung wird nur dann durchgeführt wenn wir 'erfolgreich'
                            // 2 Einträge in unserer Datenbank tätigen konnten.
                            // 
                            if (command.ExecuteNonQuery() == 2)
                            {
                                AlertClass.Show("Dein Account wurde erstellt.", Alert.enmType.Success);
                                chBoxPasswordShowL.Visible = lbNoAccount.Visible = lbRegisterTab.Visible = btnLogin.Visible = true;

                                lbExistAccount.Visible = lbAccountExist.Visible = btnRegister.Visible = 
                                    lbPasswordCompare.Visible = txPasswordCompare.Visible = chBoxPasswordShow.Visible = false;
                            }
                            // Andernfalls kann davon ausgegangen werden das mindestens eine Datenbank Tabelle nicht zugänglich war.
                            // Wenn nur eine von 2 verfügbar waren, wurde der Eintrag dennoch in diese eine verfügbare getätigt.
                            // 
                            else
                            {
                                AlertClass.Show("Dein Account wurde erstellt\n" +
                                                "aber es gab Datenbank Probleme.\n" +
                                                "Bitte kontaktiere den Support!", Alert.enmType.Warning);
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
                    if(txUsername.Text.Length <5)
                    {
                        AlertClass.Show("Dein Benutzername muss\n" +
                                        "mindestens 5 Zeichen enthalten!", Alert.enmType.Info);
                    }else if(txPassword.Text.Length <8)
                    {
                        AlertClass.Show("Dein Passwort muss\n" +
                                        "mindestens 8 Zeichen enthalten!", Alert.enmType.Info);
                    }
                 
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


        public Boolean checkTextBoxesValues()
        {
            string username = txUsername.Text.Trim();
            string password = txPassword.Text.Trim();
            if (username.Length < 5 || password.Length < 8)
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
            // Es wird überprüft ob der gewünschte Benutzername bereits in der Datenbank hinterlegt ist.
            // Wenn, dann wird dem entsprechend eine Meldung ausgegeben und die Registrierung gestoppt.
            //
            Datenbank db = new Datenbank();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `UserTable` WHERE `Benutzername` = @Benutzername", db.getConnection());

            command.Parameters.Add("@Benutzername", MySqlDbType.VarChar).Value = txUsername.Text.Trim();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            // Prüft ob der Benutzername bereits existiert, in dem die gezählten bereits vorkommenden Einträge
            // mit dem selben Benutzernamen genutzt werden.
            //
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void LoginMethod()
        {
            // Eine sehr einfache Login Art, es wird hier ähnlich wie beim 'CheckUsername' überprüft
            // ob bereits ein Benutzernamen mit dem selben Namen hinterlegt ist.
            // Wenn ja dann wird das damit verbundene Passwort, das in der Datenbank als MD5 hinterlegt
            // ist verglichen und anschließend bei erfolgreicher validierung fortgesetzt.
            //
            // Außerdem wird ein 'Property.Settings.Default.Save()' ausgeführt, das dann die eingetragenen
            // Login Daten für den nächsten Programm Start direkt automatisch hinterlegt.
            //
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


        private void lbRegisterTab_Click(object sender, EventArgs e)
        {
            txUsername.Text = txPassword.Text = string.Empty;
            lbLoginArea.Visible = chBoxPasswordShowL.Visible = lbNoAccount.Visible = lbRegisterTab.Visible = btnLogin.Visible = false;

            lbRegisterArea.Visible = lbExistAccount.Visible = lbAccountExist.Visible = 
                btnRegister.Visible = lbPasswordCompare.Visible = txPasswordCompare.Visible = chBoxPasswordShow.Visible = true;
        }


        private void lbExistAccount_Click(object sender, EventArgs e)
        {
            txUsername.Text = Properties.Settings.Default.txUsername;
            txPassword.Text = Properties.Settings.Default.txPassword;
            lbLoginArea.Visible = chBoxPasswordShowL.Visible = lbNoAccount.Visible = lbRegisterTab.Visible = btnLogin.Visible = true;

            lbRegisterArea.Visible = lbExistAccount.Visible = lbAccountExist.Visible = 
                btnRegister.Visible = lbPasswordCompare.Visible = txPasswordCompare.Visible = chBoxPasswordShow.Visible = false;
        }


        private void txPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && lbPasswordCompare.Visible)
            {
                txPasswordCompare.Focus();
            }
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
                MoveWindow.SendMessage(Handle, 
                MoveWindow.WM_NCLBUTTONDOWN, 
                MoveWindow.HT_CAPTION, 0);
            }
        }


        #region Passwort in Klartext sichtbar machen
        // Eine sehr einfache Möglichkeit Passwörter in TextBoxen wieder lesbar zu machen.
        // (char)0 setzt den PasswordChar zu null und somit auch die Property auf false.
        //
        private void chBoxPasswordShowL_CheckedChanged(object sender, EventArgs e)
        {
            if (txPassword.PasswordChar == (char)0)
            {
                txPassword.PasswordChar = '*';
            }
            else
            {
                txPassword.PasswordChar = (char)0;
                AlertClass.Show("Passwort ist nun in Klartext lesbar!", Alert.enmType.Info);
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
                AlertClass.Show("Passwort ist nun in Klartext lesbar!", Alert.enmType.Info);
            }
        }

        #endregion


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

        private void txUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txPassword.Focus();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginMethod();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterMethod();
        }
        private void lbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}