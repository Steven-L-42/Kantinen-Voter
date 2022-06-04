using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
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

        private string day_Selected, gericht_Selected, menues_Selected;
        private bool menuChange_OnClick, dayLabel_ChangeLoc = false;

        public MainPage()
        {
            InitializeComponent();
        }


        private void MainPage_Load(object sender, EventArgs e)
        {
            dataMenu.DataSource = GetdataMenu();
            getDataSelectedMenue();
            dataMenu.RowsDefaultCellStyle.BackColor = Color.GhostWhite;
            dataMenu.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            dataMenu.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataMenu.ClearSelection();

            // Eine Art und Weise wie man 'hardcoded' festlegen kann
            // welcher Benutzername als Admin in Frage kommt.
            // Mit Sicherheit, nicht die sicherste.
            //
            if (getUsername == "ShiiikK" || getUsername == "AndreasK")
            {
                btnAdminPanel.Visible = true;
            }

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

            EnableDoubleBuffering();
        }


        private DataTable GetdataMenu()
        {
            // Ruft die gewünschte Tabelle in der hinterlegten Datenbank auf
            // und füllt mein DataGridView mit dessen Inhalt
            // Wir erhalten hier das verfügbare Menü.
            //
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
            // Lädt zu beginn die hinterlegten bereits ausgewählten Gerichte und
            // macht sie auf TextBoxen sichtbar und auch für den Persönlichen Speiseplan Abruf bereit.
            //
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


        private void MainPageHeader_MouseDown(object sender, MouseEventArgs e)
        {
            // --- CODE IST NICHT VON MIR ---
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
            userAcp.Location = new Point(this.Bounds.Right,this.Bounds.Top);
        
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dataMenu.DataSource = GetdataMenu();
            // Sollte die ScrollBar erscheinen oder verschwinden werden die label diese die Tage anzeigen,
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
            dataMenu.ClearSelection();
         
        }

   
        private void dataMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            // Bei Programmstart ist '!menuChange_OnClick' gesetzt das bewirkt
            // das beim ersten Versuch das Menü auszuwählen
            // ein Dialog Fenster geöffnet wird.
            //
            try
            {
                if (!menuChange_OnClick)
                {
                    var confirmResult = MessageBox.Show("Willst du deine Menüs wirklich ändern?",
                                                 "Menü Änderung!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (confirmResult == DialogResult.Yes)
                    {
                        menuChange_OnClick = true;
                    }


                }
                if (menuChange_OnClick)
                {
                    
                        day_Selected = dataMenu.Columns[e.ColumnIndex].HeaderText;
                        gericht_Selected = dataMenu.CurrentRow.Cells[e.ColumnIndex].Value as string;
                        menues_Selected = dataMenu.CurrentRow.Cells[0].Value as string;

                        if (day_Selected == "Menues")
                        {
                            AlertClass.Show("Du kannst eine Kategorie\n" +
                                "nicht als Menü speichern!", Alert.enmType.Warning);
                            day_Selected = null;
                            dataMenu.ClearSelection();
                        }
                        else
                        {
                            SelectMenu(menues_Selected);


                            // Habe diesbezüglich bei StackOverFlow eine Frage gestellt und diesen Code als Antwort erhalten.
                            //
                            // Ich möchte das wenn ich auf eine einzelne Zelle auswähle,
                            // diese farbig markiert wird und das selbe dann auch mit den nächsten Zellen (bei auswahl) passiert.
                            // Auch soll immer nur eine Zelle innerhalb einer Column markiert sein können, so wurde der Code
                            // dann um die Eigenschaft 'HasStyle' Erweitert und 'Style' auf 'null' gesetzt wenn bereits eine markiert war.
                            // 
                            if (e.ColumnIndex < 0 || e.RowIndex < 0 || e.RowIndex == dataMenu.NewRowIndex)
                            {
                                return;
                            }
                            for (int i = 0; i < dataMenu.Rows.Count; i++)
                            {
                                var cell = dataMenu[e.ColumnIndex, i];
                                if (cell.HasStyle)
                                {
                                    cell.Style = null;
                                }
                            }
                            var style = new DataGridViewCellStyle(dataMenu.DefaultCellStyle)
                            {
                                BackColor = Color.CornflowerBlue,
                                ForeColor = Color.GhostWhite
                            };
                            dataMenu[e.ColumnIndex, e.RowIndex].Style = style;

                        }
                    
                   
                }

            }
            catch (ArgumentNullException ex)
            {
                AlertClass.Show(ex.Message, Alert.enmType.Warning);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                AlertClass.Show("Du kannst diese Spalte\n" +
                                "nicht auswählen!", Alert.enmType.Info);
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
            // Eine Tabelle wird aktualisiert, dabei wird der Eintrag bei dem eingeloggten Benutzernamen getätigt.
            // Der Benutzer wählt per Zellen klick sein Gericht und dieser Eintrag wieder sofort hinterlegt.
            //
            Datenbank db = new Datenbank();
            MySqlCommand command = new MySqlCommand(@"UPDATE UserMenueTable SET " + day_Selected + "='" + menues_Selected + "'," 
                                                    + day_Selected +"Gericht='" + gericht_Selected + "' WHERE Benutzername='" + this.getUsername + "'",
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

                    // Gibt das Menü in die TextBox im unteren Panel und
                    // das Gericht in die TextBox für den Persönlichen Speiseplan aus.
                    //
                    switch (day_Selected)
                    {
                        case "Montag":
                            txMonday.Text = menues_Selected;
                            txMondayI.Text = gericht_Selected;
                            break;

                        case "Dienstag":
                            txTuesday.Text = menues_Selected;
                            txTuesdayI.Text = gericht_Selected;
                            break;

                        case "Mittwoch":
                            txWednesday.Text = menues_Selected;
                            txWednesdayI.Text = gericht_Selected;
                            break;

                        case "Donnerstag":
                            txThursday.Text = menues_Selected;
                            txThursdayI.Text = gericht_Selected;
                            break;

                        case "Freitag":
                            txFriday.Text = menues_Selected;
                            txFridayI.Text = gericht_Selected;
                            break;

                        case "Samstag":
                            txSaturday.Text = menues_Selected;
                            txSaturdayI.Text = gericht_Selected;
                            break;
                    }
                 
                    dataMenu.ClearSelection();
                    day_Selected = null;
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
            // Wenn ein Menü noch nicht gewählt wurde,
            // das wird das im unteren Panel in den TextBoxen ausgegeben.
            // Zu sehen ist das bei einem frisch erstellten Account.
            //
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
            if (day_Selected != null)
                SelectMenu("Menü A \n" +
                       "(Normal Kost)");
            else
            {
                AlertClass.Show("Es wurde kein Menü ausgewählt!", Alert.enmType.Info);
            }
        }

        private void btnMenuB_Click(object sender, EventArgs e)
        {
            if (day_Selected != null)
                SelectMenu("Menü B \n" +
                       "(Vegan)");
            else
            {
                AlertClass.Show("Es wurde kein Menü ausgewählt!", Alert.enmType.Info);
            }
        }

        private void btnMenuC_Click(object sender, EventArgs e)
        {
            if (day_Selected != null)
                SelectMenu("Menü C \n" +
                       "(Vegetarisch)");
            else
            {
                AlertClass.Show("Es wurde kein Menü ausgewählt!", Alert.enmType.Info);
            }
        }

        private void btnMenuD_Click(object sender, EventArgs e)
        {
            if (day_Selected != null)
                SelectMenu("Menü D \n" +
                       "(Gluten-/Lak.- Frei)");
            else
            {
                AlertClass.Show("Es wurde kein Menü ausgewählt!", Alert.enmType.Info);
            }
        }

        #endregion SelectMenueButton

      
    }
}