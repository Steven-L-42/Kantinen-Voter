using MySql.Data.MySqlClient;

namespace CanteenVoter
{
    public partial class UserAcp
    {
        private class Datenbank
        {
            private MySqlConnection connection = new MySqlConnection("Server=sql4.freemysqlhosting.net;Database=sql4496417;user=sql4496417;Pwd=3ci2PdzRDR;SslMode=none;port=3306");

            // Eine Methode die eine Datenbank Verbindung nur dann öffnet, wenn sie gerade noch geschlossen ist
            //
            public void openConnection()
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
            }

            // Eine Methode die eine Datenbank Verbindung nur dann schließt, wenn sie gerade noch geöffnet ist
            //
            public void closeConnection()
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            // Eine Return Methode zu einer Datenbank Verbindung
            //
            public MySqlConnection getConnection()
            {
                return connection;
            }
        }
    }
}