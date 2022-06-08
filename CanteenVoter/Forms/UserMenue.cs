using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CanteenVoter
{
    public partial class UserMenue : Form
    {
     
        private bool dayLabel_ChangeLoc = false;

        public UserMenue()
        {
            InitializeComponent();
        }


        private void AdminPageHeader_MouseDown(object sender, MouseEventArgs e)
        {
            // --- CODE IST NICHT VON MIR ---
            // Ich nutze den FormBorderStyle "none" und mache mir mit dieser Klasse möglich
            // die Form dennoch verschieben zu können, dabei habe ich das MouseDown
            // meines AdminPageHeader genommen. Zusätzlich habe ich noch einige andere
            // Steuerelemente auf das selbe Event verlinkt.
            // 
            if (e.Button == MouseButtons.Left)
            {
                MoveWindow.ReleaseCapture();
                MoveWindow.SendMessage(Handle,
                MoveWindow.WM_NCLBUTTONDOWN,
                MoveWindow.HT_CAPTION, 0);
            }
        }


        private void UserMenue_Load(object sender, EventArgs e)
        {
            dataMenu.DataSource = GetdataMenu();
            dataMenu.ClearSelection();
            dataMenu.ForeColor = Color.Black;
            dataMenu.RowsDefaultCellStyle.BackColor = Color.GhostWhite;
            dataMenu.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            dataMenu.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Sollte ScrollBar erscheinen werden die label diese die Tage anzeigen,
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
            Datenbank db = new Datenbank();
            DataTable table = new DataTable();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter())
            {
 
                // Die Besonderheit ist hier das ich CONCAT nutze um 2 verschiedene Tabellen in einer Zelle zusammen zuführen.
                // Dabei werden die die Spalten mit einem Tabellenkürzel versehen welchen ich zum schluss dann definiert habe.
                // Mit 'INNER JOIN' werden dann letztendlich die beiden Tabellen beieinandner geführt.
                //
                using (MySqlCommand command = new MySqlCommand("SELECT CONCAT(us.Benutzername,'\n',us.Vorname,' ',us.Nachname), me.MontagGericht, me.DienstagGericht, " +
                                  "me.MittwochGericht, me.DonnerstagGericht, me.FreitagGericht, " +
                                  "me.SamstagGericht FROM UserTable us INNER JOIN UserMenueTable me " +
                                  "ON me.Benutzername= us.Benutzername", db.getConnection()))
                {
              
                    db.openConnection();
                    MySqlDataReader reader = command.ExecuteReader();

                    table.Load(reader);
                    db.closeConnection();
                }
            }
            return table;
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


        private void lbClose_Click(object sender, EventArgs e)
        {
            Form adminPageO = Application.OpenForms.Cast<Form>().Where(x => x.Name == "AdminPage").FirstOrDefault();
            if (null != adminPageO)
            {
                adminPageO.Show();
                
            }
            this.Close();
        }


        private void btnExport_Click(object sender, EventArgs e)
        {


            if (dataMenu.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Ausgewählte Menüs "+DateTime.Now.ToString("[dd-MM-yyyy]")+".pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            AlertClass.Show("Der Speicher-/ Schreibevorgang\n" +
                                            "war nicht erfolgreich!", Alert.enmType.Error);
                  
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataMenu.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            //foreach (DataGridViewColumn column in dataMenu.Columns)
                            //{
                            //    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                            //    pdfTable.AddCell(cell);
                            //}

                            foreach (DataGridViewRow row in dataMenu.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }
                            AlertClass.Show("PDF wurde erfolgreich erstellt\n" +
                                            "und gesichert.", Alert.enmType.Success);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                AlertClass.Show("Es konnten keine Daten\n" +
                                "gefunden werden!", Alert.enmType.Info);
             
            }
        }
    }
}
