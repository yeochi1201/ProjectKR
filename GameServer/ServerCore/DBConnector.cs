using MySql.Data.MySqlClient;

namespace ServerCore
{
    public class DBConnector
    {
        #region Connect Info
        string _server = "localhost";
        int _port = 3300;
        string _database = "projectkr";
        string _uid = "root";
        string _pwd = "hyun8077";
        #endregion
        #region Attribute
        MySqlConnection? connection;
        string? connectionString;
        #endregion
        #region Function
        private void connectForm(string server, int port, string database, string uid, string pwd)
        {
            connectionString = string.Format($"Server={server};Port={port};Database={database};Uid={uid};Pwd={pwd}");
        }
        private void connectForm()
        {
            connectionString = string.Format($"Server={_server};Port={_port};Database={_database};Uid={_uid};Pwd={_pwd}");
        }
        private bool DBConnect()
        {
            try
            {
                connection = new(connectionString);
                connection.OpenAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex}");
                return false;
            }
            return true;
        }
        private bool DBDisconnect()
        {
            try
            {
                connection?.CloseAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex}");
                return false;
            }
            return true;
        }
        #endregion
        #region Interface Function
        public bool InitDB(string server, int port, string database, string uid, string pwd)
        {
            connectForm(server, port, database, uid, pwd);
            return DBConnect();
        }
        public bool InitDB()
        {
            connectForm();
            return DBConnect();
        }
        public bool CloseDB()
        {
            return DBDisconnect(); 
        }
        #endregion
    }
}
