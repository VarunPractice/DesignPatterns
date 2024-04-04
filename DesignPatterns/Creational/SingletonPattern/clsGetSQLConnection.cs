using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Data.SqlClient;
namespace DesignPatterns.Creational.SingletonPattern
{
    sealed class clsGetSQLConnection
    {
        private clsGetSQLConnection() { }
        private static SqlConnection connection;
        private static clsGetSQLConnection _instance;
        private static readonly object _lockConnection = new object(); // Initialization

        public static clsGetSQLConnection Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lockConnection)
                    {
                        if (_instance == null)
                        {
                            _instance = new clsGetSQLConnection(); // Correct instance creation
                        }
                    }
                }
                return _instance;
            }
        }
        public SqlConnection GetSQLConnection(string connectionStr)
        {
            if (connection == null || connection.State == System.Data.ConnectionState.Closed || connection.State == System.Data.ConnectionState.Broken)
            {
                connection = new SqlConnection(connectionStr);
                connection.Open();
            }
            Console.WriteLine("SQL Connection Opened and Object is created");
            return connection;
        }
    }
}
