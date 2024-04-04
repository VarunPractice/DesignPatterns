using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DesignPatterns.Creational.AdapterPattern
{
    //Adaptee Class
    /*
     
The adaptee is the class with the specific functionality needed but with an interface that doesn't fit the current system.
In our example, SqlConnection is the adaptee, having methods like Open, Close, and ExecuteQuery that don’t directly align with the IConnection interface.
     */
    public class SqlConnection
    {
        private readonly string _connectionString;

        public SqlConnection(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Open()
        {
            Console.WriteLine("SQL Connection Opened.");
            // Actual implementation opens the database connection
        }

        public void Close()
        {
            Console.WriteLine("SQL Connection Closed.");
            // Actual implementation closes the database connection
        }

        public void ExecuteQuery(string query)
        {
            Console.WriteLine($"Executing SQL Query: {query}");
            // Actual implementation executes the SQL query
        }
    }

}
