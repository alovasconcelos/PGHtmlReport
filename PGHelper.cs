using Npgsql;

namespace PGHrmlReport
{
    public class PGHelper
    {
        
        private NpgsqlConnection _conn;
        private string server;
        private string username;
        private string password;
        private int port;
        private string database;

        public PGHelper(string server,
                        string database,
                        int port,
                        string user,
                        string password)
        {
            this.server = server;
            this.database = database;
            this.port = port;
            this.username = user;
            this.password = CriptoHelper.Decripto(password, "ALOV");
        }

        public NpgsqlConnection Connection()
        {
            if (_conn == null)
            {
                _conn = new NpgsqlConnection(ConnectionString());
            }
            return _conn;
        }


        private string ConnectionString()
        {
            return $"Server={server};Username={username};Database={database};Port={port.ToString()};Password={password};SSLMode=Prefer";
        }

        public bool Test()
        {
            try
            {
                _conn.Open();  // Tenta abrir a conexão

                if (_conn.State == System.Data.ConnectionState.Open)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (_conn.State == System.Data.ConnectionState.Open)
                {
                    _conn.Close();  // Fechar a conexão, se estiver aberta
                }
            }
        }
    }
}
