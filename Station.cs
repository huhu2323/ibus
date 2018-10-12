using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace iBUS
{
    class Station
    {
        public Nullable<int> id;
        public String name;

        public static List<Station> all()
        {
            MySqlConnection conn = new MySqlConnection(MYSQLConnection.connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbl_station", conn);
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            MySqlDataReader rdr = cmd.ExecuteReader();
            List<Station> stations = new List<Station>();
            while (rdr.Read())
            {
                var station = new Station();
                station.id = int.Parse(rdr["id"].ToString());
                station.name = rdr["name"].ToString();
                stations.Add(station);
            }
            return stations;
        }

        
    }
}
