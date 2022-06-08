using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CanteenVoter
{
    public partial class AdminPage : Form
    {
        private string cellID;
        private bool dayLabel_ChangeLoc = false;

        public AdminPage()
        {
            InitializeComponent();
           
        }


        private void AdminPage_Load(object sender, EventArgs e)
        {
            dataMenu.DataSource = GetdataMenu();
            dataMenu.ClearSelection();
            dataMenu.RowsDefaultCellStyle.BackColor = Color.GhostWhite;
            dataMenu.RowsDefaultCellStyle.ForeColor = Color.Black;
            dataMenu.DefaultCellStyle.SelectionBackColor = Color.CornflowerBlue;
            dataMenu.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            cmbMenue.Items.Add("Menü wählen...");

            cmbMenue.Items.Add("Menü A \n" +
                                "(Normal Kost)");

            cmbMenue.Items.Add("Menü B \n" +
                                "(Vegan)");

            cmbMenue.Items.Add("Menü C \n" +
                                "(Vegetarisch)");

            cmbMenue.Items.Add("Menü D \n" +
                                "(Gluten-/Lak.- Frei)");
            cmbMenue.SelectedIndex = 0;

           

            resetDayCmb();
            setDefaultCmb();
            setIndexDayCmb(0);

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
                using (MySqlCommand command = new MySqlCommand("SELECT " +
                    "`Menues`,`Montag`, `Dienstag`,`Mittwoch`,`Donnerstag`," +
                    "`Freitag`,`Samstag` FROM CanteenTable", db.getConnection()))
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


        public void SqlDelete(string id)
        {
            try
            {
                Datenbank db = new Datenbank();
                db.openConnection();
                try
                {
                    MySqlCommand command = new MySqlCommand("DELETE FROM CanteenTable WHERE Menues = '" + id + "'", db.getConnection());
                    command.ExecuteNonQuery();
                    dataMenu.DataSource = GetdataMenu();
                    dataMenu.ClearSelection();
                }
                finally
                {
                    db.closeConnection();

                }
            }
            catch (MySqlException ex)
            {
                AlertClass.Show("MySQL Verbindungsproblem!", Alert.enmType.Warning);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Soll dieses Menü wirklich gelöscht werden?",
                                                "Löschvorgang bestätigen!", MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2);

            if (confirmResult == DialogResult.Yes)
            {
                SqlDelete(cellID);

                // Sollte die ScrollBar verschwinden werden die label diese die Tage anzeigen,
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
            }
        }


        public void SqlInsert()
        {
            Datenbank db = new Datenbank();
            MySqlCommand command = new MySqlCommand("INSERT INTO `CanteenTable`(`Menues`, `Montag`, `Dienstag`, `Mittwoch`, `Donnerstag`, `Freitag`, `Samstag`) " +
                                                    "VALUES (@Menues, @Montag, @Dienstag, @Mittwoch, @Donnerstag, @Freitag, @Samstag)", db.getConnection());

            command.Parameters.Add("@Menues", MySqlDbType.VarChar).Value = cmbMenue.SelectedItem.ToString();
            command.Parameters.Add("@Montag", MySqlDbType.VarChar).Value = cmbMonday.SelectedItem.ToString();
            command.Parameters.Add("@Dienstag", MySqlDbType.VarChar).Value = cmbTuesday.SelectedItem.ToString();
            command.Parameters.Add("@Mittwoch", MySqlDbType.VarChar).Value = cmbWednesday.SelectedItem.ToString();
            command.Parameters.Add("@Donnerstag", MySqlDbType.VarChar).Value = cmbThursday.SelectedItem.ToString();
            command.Parameters.Add("@Freitag", MySqlDbType.VarChar).Value = cmbFriday.SelectedItem.ToString();
            command.Parameters.Add("@Samstag", MySqlDbType.VarChar).Value = cmbSaturday.SelectedItem.ToString();

            // Öffnet die DB Verbindung
            //
            db.openConnection();
            try
            {
                // Führt die Anweisung durch wenn exakt 1 Eintrag erfolgreich war
                //
                if (command.ExecuteNonQuery() == 1)
                {
                    AlertClass.Show("Menü wurde hinzugefügt", Alert.enmType.Success);
                    dataMenu.DataSource = GetdataMenu();
                    dataMenu.ClearSelection();
                }
                else
                {
                    AlertClass.Show("Fehler beim hinzufügen des Menüs!", Alert.enmType.Error);
                }
            }
            catch (MySqlException ex)
            {
                AlertClass.Show("MySQL Verbindungsproblem!", Alert.enmType.Warning);
            }
            finally
            {
                db.closeConnection();
            }
        }


        private void changeMenues()
        {
            if (cmbMenue.Text == "Menü wählen...")
            {
                resetDayCmb();
                setDefaultCmb();
                setIndexDayCmb(0);
            }
            else
            {

                // Hier werden alle TextBoxen und der
                // DateTimePicker mit den Daten aus der Datenbank befüllt.
                //
                Datenbank db = new Datenbank();
                MySqlDataAdapter da;
                int cmbMenueIndex = cmbMenue.SelectedIndex - 1;
                // Öffnet die DB Verbindung
                //

                try
                {
                    // Wähle 'Alle' Einträge von meiner UserTable aus dessen Benutzername mit dem des Logins ubereinstimmt.
                    //

                    using (MySqlCommand cmd = new MySqlCommand("SELECT `Menü A`,`Menü B`,`Menü C`,`Menü D` FROM MenuesTable", db.getConnection()))
                    {
                        db.openConnection();
                        da = new MySqlDataAdapter(cmd);

                        DataSet ds = new DataSet();

                        da.Fill(ds);
                        resetDayCmb();
                        setDayNameCmb();
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)

                        {


                            cmbMonday.Items.Add(ds.Tables[0].Rows[i][cmbMenueIndex]);
                            cmbTuesday.Items.Add(ds.Tables[0].Rows[i][cmbMenueIndex]);
                            cmbWednesday.Items.Add(ds.Tables[0].Rows[i][cmbMenueIndex]);
                            cmbThursday.Items.Add(ds.Tables[0].Rows[i][cmbMenueIndex]);
                            cmbFriday.Items.Add(ds.Tables[0].Rows[i][cmbMenueIndex]);
                            cmbSaturday.Items.Add(ds.Tables[0].Rows[i][cmbMenueIndex]);


                        }
                        setIndexDayCmb(0);
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
        }

       
        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlInsert();

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


        private void dataMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cellID = dataMenu.Rows[e.RowIndex].Cells["Menues"].Value as string;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                AlertClass.Show("Es können nur Reihen markiert werden!", Alert.enmType.Info);
            }
        }


        #region ComboBox DrawItem
        private void cmbMenue_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                e.DrawFocusRectangle();

                var combo = sender as ComboBox;

                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.CornflowerBlue), e.Bounds);
                }
                else
                {
                    e.Graphics.FillRectangle(new SolidBrush(SystemColors.Window), e.Bounds);
                }

                e.Graphics.DrawString(cmbMenue.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
            }
            catch (ArgumentOutOfRangeException ex)
            {

            }
        }


        private void cmbMonday_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                e.DrawFocusRectangle();

                var combo = sender as ComboBox;
                
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.CornflowerBlue), e.Bounds);
                }
                else
                {
                    e.Graphics.FillRectangle(new SolidBrush(SystemColors.Window), e.Bounds);
                }

                e.Graphics.DrawString(cmbMonday.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
        
  
            }
            catch (ArgumentOutOfRangeException ex)
            {

            }
        }

        private void cmbTuesday_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                e.DrawFocusRectangle();

                var combo = sender as ComboBox;

                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.CornflowerBlue), e.Bounds);
                }
                else
                {
                    e.Graphics.FillRectangle(new SolidBrush(SystemColors.Window), e.Bounds);
                }

                e.Graphics.DrawString(cmbTuesday.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);


            }
            catch (ArgumentOutOfRangeException ex)
            {

            }
        }

        private void cmbWednesday_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                e.DrawFocusRectangle();

                var combo = sender as ComboBox;

                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.CornflowerBlue), e.Bounds);
                }
                else
                {
                    e.Graphics.FillRectangle(new SolidBrush(SystemColors.Window), e.Bounds);
                }

                e.Graphics.DrawString(cmbWednesday.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);


            }
            catch (ArgumentOutOfRangeException ex)
            {

            }
        }

        private void cmbThursday_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                e.DrawFocusRectangle();

                var combo = sender as ComboBox;

                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.CornflowerBlue), e.Bounds);
                }
                else
                {
                    e.Graphics.FillRectangle(new SolidBrush(SystemColors.Window), e.Bounds);
                }

                e.Graphics.DrawString(cmbThursday.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);


            }
            catch (ArgumentOutOfRangeException ex)
            {

            }
        }

        private void cmbFriday_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                e.DrawFocusRectangle();

                var combo = sender as ComboBox;

                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.CornflowerBlue), e.Bounds);
                }
                else
                {
                    e.Graphics.FillRectangle(new SolidBrush(SystemColors.Window), e.Bounds);
                }

                e.Graphics.DrawString(cmbFriday.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);


            }
            catch (ArgumentOutOfRangeException ex)
            {

            }
        }

        private void cmbSaturday_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                e.DrawFocusRectangle();

                var combo = sender as ComboBox;

                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.CornflowerBlue), e.Bounds);
                }
                else
                {
                    e.Graphics.FillRectangle(new SolidBrush(SystemColors.Window), e.Bounds);
                }

                e.Graphics.DrawString(cmbSaturday.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);


            }
            catch (ArgumentOutOfRangeException ex)
            {

            }
        }
        #endregion



        private void btnAdminPanel_Click(object sender, EventArgs e)
        {
            this.Hide();
            var userMenuO = Application.OpenForms.Cast<Form>().Where(x => x.Name == "UserMenue").FirstOrDefault();
            if (null != userMenuO)
            {
                userMenuO.Close();
                userMenuO = null;
            }
            UserMenue UserMenue = new UserMenue();
            UserMenue.Owner = this;
            UserMenue.Show();
        }

        private void btnMenueList_Click(object sender, EventArgs e)
        {
            var menuListO = Application.OpenForms.Cast<Form>().Where(x => x.Name == "MenueList").FirstOrDefault();
            if (null != menuListO)
            {
                menuListO.Close();
                menuListO = null;
            }
            MenueList menuList = new MenueList();
            menuList.Owner = this;
            menuList.Show();
        }


        private void resetDayCmb()
        {
            cmbSaturday.Items.Clear();
            cmbFriday.Items.Clear();
            cmbThursday.Items.Clear();
            cmbWednesday.Items.Clear();
            cmbTuesday.Items.Clear();
            cmbMonday.Items.Clear();
        }

        private void setDefaultCmb()
        {
            cmbMonday.Items.Add("Wähle zuerst ein\nMenü aus...");
            cmbTuesday.Items.Add("Wähle zuerst ein\nMenü aus...");
            cmbWednesday.Items.Add("Wähle zuerst ein\nMenü aus...");
            cmbThursday.Items.Add("Wähle zuerst ein\nMenü aus...");
            cmbFriday.Items.Add("Wähle zuerst ein\nMenü aus...");
            cmbSaturday.Items.Add("Wähle zuerst ein\nMenü aus...");
        }

        private void setDayNameCmb()
        {
            cmbMonday.Items.Add("Montag auswählen...");
            cmbTuesday.Items.Add("Dienstag auswählen...");
            cmbWednesday.Items.Add("Mittwoch auswählen...");
            cmbThursday.Items.Add("Donnerstag auswählen...");
            cmbFriday.Items.Add("Freitag auswählen...");
            cmbSaturday.Items.Add("Samstag auswählen...");
        }

        private void setIndexDayCmb(int index)
        {
            cmbSaturday.SelectedIndex =
            cmbFriday.SelectedIndex =
            cmbThursday.SelectedIndex =
            cmbWednesday.SelectedIndex =
            cmbTuesday.SelectedIndex =
            cmbMonday.SelectedIndex = index;
        }


        private void cmbMenue_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeMenues();
        }

        private void cmbMenue_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 40;

        }
        private void cmbMonday_MeasureItem(object sender, MeasureItemEventArgs e)
        {

            e.ItemHeight = (int)e.Graphics.MeasureString(cmbMonday.Items[e.Index].ToString(), cmbMonday.Font, cmbMonday.Width).Height;
        }


        private void lbClose_Click(object sender, EventArgs e)
        {
            Form mainPageO = Application.OpenForms.Cast<Form>().Where(x => x.Name == "MainPage").FirstOrDefault();
            if (null != mainPageO)
            {
                mainPageO.Show();

            }
            this.Close();
        }
    }
}
