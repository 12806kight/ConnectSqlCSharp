using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect2Mysql
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string host = "localhost";
            string database = "test";
            string username = "root";
            string password = "password";
            string constring = "HOST=" + host + ";" + "DATABASE=" + database + ";" +
                "UID=" + username + ";" + "PASSWORD=" + password + ";" + "Port=" + 3306 + ";";
            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();
            string query = "select * from person";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["FirstName"]);
            }
        }
    }
}
