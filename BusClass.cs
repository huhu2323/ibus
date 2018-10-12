using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace iBUS
{
    class BusClass
    {
        public Nullable<int> id;
        public String name;

        public static List<BusClass> all()
        {
            MySqlConnection conn = new MySqlConnection(MYSQLConnection.connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbl_bus_class", conn);
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            MySqlDataReader rdr = cmd.ExecuteReader();
            List<BusClass> busClasses = new List<BusClass>();
            while (rdr.Read())
            {
                var busClass = new BusClass();
                busClass.id = int.Parse(rdr["id"].ToString());
                busClass.name = rdr["name"].ToString();
                busClasses.Add(busClass);
            }
            return busClasses;
        }
    }
}
