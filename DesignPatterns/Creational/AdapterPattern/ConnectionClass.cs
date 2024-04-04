using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.AdapterPattern
{
    //Adapter Class
    /*
     The adapter is a class that connects the client with the adaptee.
    It conforms to the interface the client expects and translates calls to the adaptee’s interface.
    For example, ConnectionClass is the adapter, implementing IConnection and converting its calls for SqlConnection.
     */
    public class ConnectionClass : IConnection
    {
        private readonly SqlConnection _sqlConnection;

        public ConnectionClass(string connectionString)
        {
            _sqlConnection = new SqlConnection(connectionString);
        }

        public void Connect()
        {
            _sqlConnection.Open();
        }

        public void Disconnect()
        {
            _sqlConnection.Close();
        }

        public void Execute(string query)
        {
            _sqlConnection.ExecuteQuery(query);
        }
    }

}
