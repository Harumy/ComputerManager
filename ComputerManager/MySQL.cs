using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ComputerManager
{
    class MySQL
    {
        private void MySQLConnection()
        {
            string ConnectString = "userid=;password=;database=Tset;Host=harmine.jp";
            MySqlConnection Connection = new MySqlConnection(ConnectString);
            Connection.Open();
        }


    }
}
