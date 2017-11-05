using System;
using System.Data;
using System.Data.SqlClient;

namespace GelreAirport.Controller
{
    class DatabaseConnection
    {
        private readonly IniParser _ini = new IniParser("database.ini");
        private readonly SqlConnection _mySqlConnection;

        public DatabaseConnection()
        {
            String server = this._ini.GetValue("database", "server");
            String database = this._ini.GetValue("database", "database");
            String user = this._ini.GetValue("database", "user");
            String password = this._ini.GetValue("database", "password");

            this._mySqlConnection = new SqlConnection("user id=" + user + ";" +
                                                           "password=" + password + ";" +
                                                           "server=" + server + ";" +
                                                           "Trusted_Connection=yes;" +
                                                           "database=" + database + ";" +
                                                           "connection timeout=15");
        }


        public SqlConnection GetConnection()
        {
            return this._mySqlConnection;
        }

        public Boolean IsConnected()
        {
            return (GetConnection() != null && GetConnection().State == ConnectionState.Open) ? true : false;
        }
    }
}
