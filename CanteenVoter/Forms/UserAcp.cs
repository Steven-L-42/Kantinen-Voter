using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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

            checkIfDataExist();

            InitializeEvents();

            // Hier wird das DoubleBuffering aktiviert, einige WinForms Steuerelemente oder auch Formen flackern hin und wieder.
            // Durch das aktivieren von DoubleBuffering werden diese Objekte doppelte geladen, das führt zu einer kurzen Verzögerung bei der Anzeige,
            // verhindert aber das sie bei der Laufzeit des Programms, bei interaktion oder bewegungungen flackern.
            //
            EnableDoubleBuffering();
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

                sqlCmd.Parameters.AddWithValue("@Benutzername", getUsername);
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


        private void checkIfDataExist()
        {
            if ((Owner as MainPage).txMondayI.Text == string.Empty ||
                (Owner as MainPage).txTuesdayI.Text == string.Empty ||
                (Owner as MainPage).txWednesdayI.Text == string.Empty ||
                (Owner as MainPage).txThursdayI.Text == string.Empty ||
                (Owner as MainPage).txFridayI.Text == string.Empty ||
                (Owner as MainPage).txSaturdayI.Text == string.Empty)
            {
                btnYourPlan.BackColor = Color.LightGray;
            }
            if (txFirstName.Text != string.Empty)
            {
             
                txFirstName.Enabled = false;
                txSurname.Enabled = false;
                txAllergic.Enabled = false;
                dateBorn.Enabled = false;
                btnSave.Enabled = false;
                btnSave.BackColor = Color.LightGray;
            }
        }


        private void InitializeEvents()
        {
            txFirstName.GotFocus += TxFirstName_GotFocus;
            txSurname.GotFocus += TxSurname_GotFocus;
            txAllergic.GotFocus += TxAllergic_GotFocus;
        }


        public void EnableDoubleBuffering()
        {
            SetStyle(ControlStyles.DoubleBuffer |
           ControlStyles.UserPaint |
           ControlStyles.AllPaintingInWmPaint,
           true);
            UpdateStyles();
        }


        private void UserAcp_MouseDown(object sender, MouseEventArgs e)
        {
            // Ich nutze den FormBorderStyle "none" und mache mir mit dieser Klasse möglich die Form dennoch verschieben zu können,
            // dabei habe ich das MouseDown meiner Form genommen. Alternativ kann man das auch auf andere Steuerelemente beschränken.
            // 
            if (e.Button == MouseButtons.Left)
            {
                MoveWindow.ReleaseCapture();
                MoveWindow.SendMessage(Handle,
                MoveWindow.WM_NCLBUTTONDOWN,
                MoveWindow.HT_CAPTION, 0);
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txFirstName.Text.Length < 3||
                txSurname.Text.Length < 3)
            {
                AlertClass.Show("Die Felder: Vorname\n" +
                                "und Nachname müssen min.\n" +
                                "3 Zeichen enthalten!", Alert.enmType.Info);
            }
            else
            {
                var confirmResult = MessageBox.Show("Sind alle Angaben richtig?\n\n" +
                                                    "Du kannst Sie später 'nicht' mehr ändern!",
                                                    "Speichervorgang bestätigen!", MessageBoxButtons.YesNo, 
                                                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

                if (confirmResult == DialogResult.Yes)
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
                                                            "WHERE Benutzername='" + getUsername + "'",
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
                            txFirstName.Enabled = false;
                            txSurname.Enabled = false;
                            txAllergic.Enabled = false;
                            dateBorn.Enabled = false;
                            btnSave.Enabled = false;
                            btnSave.BackColor = Color.LightGray;
                            btnYourPlan.BackColor = Color.GhostWhite;

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
            }
           
        }

 
        private void btnYourPlan_Click(object sender, EventArgs e)
        {
            if ((Owner as MainPage).txMondayI.Text == string.Empty ||
                (Owner as MainPage).txTuesdayI.Text == string.Empty ||
                (Owner as MainPage).txWednesdayI.Text == string.Empty ||
                (Owner as MainPage).txThursdayI.Text == string.Empty ||
                (Owner as MainPage).txFridayI.Text == string.Empty ||
                (Owner as MainPage).txSaturdayI.Text == string.Empty ||
                  txFirstName.Enabled || txSurname.Enabled)
            {
                AlertClass.Show("Bevor wir dir deinen Persönlichen\n" +
                                "Plan ausgeben können benötigen wir\n" +
                                "noch deinen Namen und deine Menü Wahl.", Alert.enmType.Info);
            }
            else
            {
                
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.FileName = "Essensplan von " + getUsername;
                dialog.DefaultExt = "jpg";
                dialog.Filter = "JPG Image File | *.jpg";
                dialog.ValidateNames = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    
                    (Owner as MainPage).lbNameI.Text = txFirstName.Text + ", "+ txSurname.Text;
                    (Owner as MainPage).ImagePanel.Visible = true;

                    int width = (Owner as MainPage).ImagePanel.Width;
                    int height = (Owner as MainPage).ImagePanel.Height;

                    Bitmap bmp = new Bitmap(width, height);
                    (Owner as MainPage).ImagePanel.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));

                    bmp.Save(dialog.FileName, ImageFormat.Jpeg);

                    (Owner as MainPage).ImagePanel.Visible = false;
                }
            }
            
        }


        private void TxAllergic_GotFocus(object sender, EventArgs e)
        {
            txAllergic.SelectionStart = txAllergic.Text.Length;
            txAllergic.SelectionLength = 0;
        }
        private void TxSurname_GotFocus(object sender, EventArgs e)
        {
            txSurname.SelectionStart = txSurname.Text.Length;
            txSurname.SelectionLength = 0;
        }
        private void TxFirstName_GotFocus(object sender, EventArgs e)
        {
            txFirstName.SelectionStart = txFirstName.Text.Length;
            txFirstName.SelectionLength = 0;
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnDecline_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}