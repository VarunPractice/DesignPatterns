using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DesignPatterns.DesignPatterns.Creational.AdapterPattern
{
    //Existing Interface
    public interface IConnection
    {
        void Connect();
        void Disconnect();
        void Execute(string query);
    }

}
