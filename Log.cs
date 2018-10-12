using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace iBUS
{
    class Log
    {
        public Nullable<int> id;
        public String message;
        public String date;


        public void save()
        {
            MySqlConnection conn = new MySqlConnection(MYSQLConnection.connectionString);
            MySqlCommand cmd = new MySqlCommand("INSERT INTO tbl_logs SET message='" + this.message + "', date='" + this.date + "'", conn);
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
