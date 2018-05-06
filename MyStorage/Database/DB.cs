using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStorage.Database
{
    class DB
    {
        public static MySqlConnection connection;

        public static void Connect()
        {
            string server = "localhost";
            string database = "mystorage";
            string uid = "root";
            string password = "root";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
            connection.Open();
        }
        public static void Insert(string sql)
        {
            MySqlCommand msc = new MySqlCommand(sql, connection);
            msc.ExecuteNonQuery();
        }
        public static void Update(string sql) // пока просто так ))
        {
            MySqlCommand msc = new MySqlCommand(sql, connection);
            msc.ExecuteNonQuery();
        }
        public static List<string> Select(string sql)
        {
            List<string> result =new List<string>();
            string str = "";
            using (MySqlCommand command = connection.CreateCommand())
            {
                command.CommandText = sql;
                using (var r = command.ExecuteReader())
                {
                    while (r.Read())
                    {
                        
                        for(int i=0;i<r.FieldCount;i++)
                            //result += (int)r[0] + " " + r[1] + "$";
                            str += r[i]+" ";
                        result.Add(str);
                    }
                }
            }
            return result;
        }

        public static string SelectOne(string sql)
        {
            string result = "";
            using (MySqlCommand command = connection.CreateCommand())
            {
                command.CommandText = sql;
                using (var r = command.ExecuteReader())
                {
                    while (r.Read())
                    {
                        result += (int)r[0];
                    }
                }
            }
            return result;
        }
        public static string SelectOneString(string sql)
        {
            string result = "";
            using (MySqlCommand command = connection.CreateCommand())
            {
                command.CommandText = sql;
                using (var r = command.ExecuteReader())
                {
                    while (r.Read())
                    {
                        result += (string)r[0];
                    }
                }
            }
            return result;
        }
        public static void Close()
        {
            connection.Close();
        }
    }
}

