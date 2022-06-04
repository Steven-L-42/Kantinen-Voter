using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CanteenVoter
{
    public partial class RegAndLogin : Form
    {
        private string username, password;

        public RegAndLogin()
        {
            InitializeComponent();
        }


        private void RegAndLogin_Load(object sender, EventArgs e)
        {
            // Direkt beim laden der Form übergebe ich noch von der letzten 'erfolgreich'
            // eingeloggten Sitzung die Login Daten aus den Properties.Settings.
            //
            txUsername.Text = Properties.Settings.Default.txUsername;
            txPassword.Text = Properties.Settings.Default.txPassword;
            txUsername.GotFocus += TxUsername_GotFocus;
            txPassword.GotFocus += TxPassword_GotFocus;

            EnableDoubleBuffering();
        }

        private void EnableDoubleBuffering()
        {
            // --- CODE IST NICHT VON MIR ---
            // Hier wird das DoubleBuffering aktiviert, einige WinForms Steuerelemente oder auch Formen flackern hin und wieder.
            // Durch das aktivieren von DoubleBuffering werden diese Objekte doppelte geladen, das führt zu einer kurzen Verzögerung bei der Anzeige,
            // verhindert aber das sie bei der Laufzeit des Programms, bei interaktion oder bewegungungen flackern.
            //
            SetStyle(ControlStyles.DoubleBuffer |

                         ControlStyles.UserPaint |

                         ControlStyles.AllPaintingInWmPaint,
                         true);
            UpdateStyles();

        }
        private void RegLoginHeader_MouseDown(object sender, MouseEventArgs e)
        {
            // --- CODE IST NICHT VON MIR ---
            // Ich nutze den FormBorderStyle "none" und mache mir mit dieser Klasse möglich
            // die Form dennoch verschieben zu können, dabei habe ich das MouseDown Event
            // für 'RegLoginHeader' genommen. Und habe da dann noch meine Form verlinkt.
            // 
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
            Encryptor cryp = new Encryptor();
            MySqlCommand command = new MySqlCommand(@"INSERT INTO UserTable SET Benutzername=@Benutzername,  Passwort=@Passwort;" +
                                                     "INSERT INTO UserMenueTable SET Benutzername=@Benutzername", db.getConnection());

            // Überprüft ob die mindest Anforderung an Zeichen erreicht wurde.
            //
            if (!checkTextBoxesValues())
            {
                command.Parameters.Add("@Benutzername", MySqlDbType.VarChar).Value = username;
                command.Parameters.Add("@Passwort", MySqlDbType.VarChar).Value = cryp.MD5Hash(password);

                // Öffnet die DB Verbindung.
                //
                db.openConnection();
                try
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
                catch (MySqlException ex)
                {
                    AlertClass.Show("MySQL Verbindungsproblem!", Alert.enmType.Error);
                }
                finally
                {
                    db.closeConnection();
                }
            }
            else
            {
                if (username.Length < 5)
                {
                    AlertClass.Show("Dein Benutzername muss\n" +
                                    "mindestens 5 Zeichen enthalten!", Alert.enmType.Info);
                }
                else if (password.Length < 8)
                {
                    AlertClass.Show("Dein Passwort muss\n" +
                                    "mindestens 8 Zeichen enthalten!", Alert.enmType.Info);
                }

            }
        }


        public Boolean checkTextBoxesValues()
        {
            // Hier lege ich fest das der Benutzername mindestens 5 und
            // das Passwort mindestens 8 Zeichen beinhalten muss.
            // Außerdem werden die TextBoxen getrimmt um eventuelle
            // fehlerhafte Leerzeichen zu entfernen.
            //
            username = txUsername.Text.Trim();
            password = txPassword.Text.Trim();
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

            // Die prüfung auf einen bereits vorhandenen Benutzernamen, funktioniert hier mittels einem Return Wert.
            // Wenn 'return true' ausgegeben wird, bedeutet es das mindestens 1 Eintrag mit dem selben Benutzernamen
            // vorliegt. Bei 'return false' war die überprüfung in Ordnung und noch kein Eintrag vorhanden.
            //
            if (table.Rows.Count > 0)
            {
                return true; // Bei Ausgabe: Registrierung wird abgebrochen.
            }
            else
            {
                return false; // Bei Ausgabe: Registrierung wird fortgestzt.
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
            Encryptor cryp = new Encryptor();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            if (!checkTextBoxesValues())
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM UserTable WHERE Benutzername = '" + username + "' " +
                                                        "AND Passwort = '" + cryp.MD5Hash(password) + "'", db.getConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);
            }
            if (table.Rows.Count == 1)
            {
                Properties.Settings.Default.txUsername = username;
                Properties.Settings.Default.txPassword = password;
                Properties.Settings.Default.Save();
                string getUsernameL = txUsername.Text.Trim();
                var mainPage = new MainPage();
                mainPage.getUsername = getUsernameL;
                mainPage.Show();
                Hide();
            }
            else
            {
                AlertClass.Show("Bitte überprüfe deine Login Daten!", Alert.enmType.Warning);
            }

        }


        private void lbRegisterTab_Click(object sender, EventArgs e)
        {
            // Beim Klick auf diesen Label wird von Login zu Register geswitcht
            // dabei habe ich mich nach der Implementierung von einem TabControl,
            // aus Optik Gründen wieder dagegen entschieden und es so lösen wollen.
            //
            txUsername.Text = txPassword.Text = string.Empty;
            lbLoginArea.Visible = chBoxPasswordShowL.Visible = lbNoAccount.Visible = lbRegisterTab.Visible = btnLogin.Visible = false;

            lbRegisterArea.Visible = lbExistAccount.Visible = lbAccountExist.Visible = 
                btnRegister.Visible = lbPasswordCompare.Visible = txPasswordCompare.Visible = chBoxPasswordShow.Visible = true;
        }


        private void lbExistAccount_Click(object sender, EventArgs e)
        {
            // Beim Klick auf diesen Label wird von Register zu Login geswitcht.
            // Die besonderheit hier ist, das die TextBoxen automatisch mit von der zuvor
            // gespeicherten Sitzung Login Daten befüllt wird.
            //
            // Hier werden auch einzelne Controls auf false und true gesetzt.
            //
            txUsername.Text = Properties.Settings.Default.txUsername;
            txPassword.Text = Properties.Settings.Default.txPassword;
            lbLoginArea.Visible = chBoxPasswordShowL.Visible = lbNoAccount.Visible = lbRegisterTab.Visible = btnLogin.Visible = true;

            lbRegisterArea.Visible = lbExistAccount.Visible = lbAccountExist.Visible = 
                btnRegister.Visible = lbPasswordCompare.Visible = txPasswordCompare.Visible = chBoxPasswordShow.Visible = false;
        }


        private void txPassword_KeyDown(object sender, KeyEventArgs e)
        {
            // Hiermit wandert der Focus beim KeyDown'Enter' von der TextBox Passwort zu
            // PasswortCompare und auch nur wenn die TextBox PasswortCompare sichtbar ist
            //
            if (e.KeyCode == Keys.Enter && txPasswordCompare.Visible)
            {
                txPasswordCompare.Focus();
            }
            if (e.KeyCode == Keys.Enter && !txPasswordCompare.Visible)
            {
                LoginMethod();
            }
        }


        private void txPasswordCompare_KeyDown(object sender, KeyEventArgs e)
        {
            // Hiermit kann ich beim betätigen der Taste 'Enter'
            // direkt den Registrierungsvorgang starten
            //
            if (e.KeyCode == Keys.Enter)
            {
                RegisterMethod();
            }
        }


        private void txUsername_KeyDown(object sender, KeyEventArgs e)
        {
            // Hiermit kann ich beim betätigen der Taste 'Enter'
            // direkt den Loginvorgang starten
            //
            if (e.KeyCode == Keys.Enter)
            {
                txPassword.Focus();
            }
        }
        private void RegAndLogin_MouseDown(object sender, MouseEventArgs e)
        {
            // Ich nutze den FormBorderStyle "none" und mache mir mit dieser Klasse möglich
            // die Form dennoch verschieben zu können, dabei habe ich das MouseDown
            // meiner Form genommen. Alternativ kann man das auch auf andere
            // Steuerelemente beschränken oder auch erweitern.
            // 
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
            // Beim betreten der Textbox wird das GotFocus Event aufgerufen,
            // dabei wir dafür gesorgt das der Cursor 'nicht' den ganzen Text markiert,
            // sondern direkt an das Ende eines Textes springt und da dann auch den Cursor abstellt.
            //
            txPassword.SelectionStart = txPassword.Text.Length;
            txPassword.SelectionLength = 0;
        }

        private void TxUsername_GotFocus(object sender, EventArgs e)
        {
            txUsername.SelectionStart = txUsername.Text.Length;
            txUsername.SelectionLength = 0;
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
            Close();
        }
    }
}