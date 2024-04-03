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
        private static SqlConnection _con;
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
        public SqlConnection GetSQLConnection(string _conStr)
        {
            if (_con == null || _con.State == System.Data.ConnectionState.Closed || _con.State == System.Data.ConnectionState.Broken)
            {
                _con = new SqlConnection(_conStr);
                _con.Open();
            }
            Console.WriteLine("SQL Connection Opened and Object is created");
            return _con;
        }
    }
}
