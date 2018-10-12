using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace iBUS
{
    class Bus
    {
        public Nullable<int> bus_id;
        public Nullable<int> bus_company;
        public String bus_no;
        public String bus_model;
        public Nullable<int> bus_class;
        public Nullable<int> bus_from;
        public Nullable<int> bus_to;
        public String bus_plate;
        public String date_added;

        public static List<Bus> all()
        {
            MySqlConnection conn = new MySqlConnection(MYSQLConnection.connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbl_bus ORDER BY date_added DESC", conn);
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            MySqlDataReader rdr = cmd.ExecuteReader();
            List<Bus> buses = new List<Bus>();
            while (rdr.Read())
            {
                var bus = new Bus();
                bus.bus_id = int.Parse(rdr["bus_id"].ToString());
                bus.bus_company = int.Parse(rdr["bus_company"].ToString());
                bus.bus_no = rdr["bus_no"].ToString();
                bus.bus_model = rdr["bus_model"].ToString();
                bus.bus_class = int.Parse(rdr["bus_class"].ToString());
                bus.bus_company = int.Parse(rdr["bus_company"].ToString());
                bus.bus_from = int.Parse(rdr["bus_from"].ToString());
                bus.bus_to = int.Parse(rdr["bus_to"].ToString());
                bus.bus_plate = rdr["bus_plate"].ToString();
                bus.date_added = rdr["date_added"].ToString();
                buses.Add(bus);
            }
            return buses;
        }

        public Company getCompany()
        {
            MySqlConnection conn = new MySqlConnection(MYSQLConnection.connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbl_company WHERE id = '" + this.bus_company + "'", conn);
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            MySqlDataReader rdr = cmd.ExecuteReader();
            Company company = new Company();
            while (rdr.Read())
            {
                company.id = int.Parse(rdr["id"].ToString());
                company.name = rdr["name"].ToString();
            }
            return company;
        }

        public BusClass getBusClass()
        {
            MySqlConnection conn = new MySqlConnection(MYSQLConnection.connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbl_bus_class WHERE id='" + this.bus_class + "'", conn);
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            MySqlDataReader rdr = cmd.ExecuteReader();
            BusClass busClass = new BusClass();
            while (rdr.Read())
            {
                busClass.id = int.Parse(rdr["id"].ToString());
                busClass.name = rdr["name"].ToString();
            }
            return busClass;
        }

        public Station getFrom()
        {
            MySqlConnection conn = new MySqlConnection(MYSQLConnection.connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbl_station WHERE id='" + this.bus_from + "'", conn);
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            MySqlDataReader rdr = cmd.ExecuteReader();
            Station station = new Station();
            while (rdr.Read())
            {
                station.id = int.Parse(rdr["id"].ToString());
                station.name = rdr["name"].ToString();
            }
            return station;
        }

        public Station getTo()
        {
            MySqlConnection conn = new MySqlConnection(MYSQLConnection.connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbl_station WHERE id='" + this.bus_to +"'", conn);
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            MySqlDataReader rdr = cmd.ExecuteReader();
            Station station = new Station();
            while (rdr.Read())
            {
                station.id = int.Parse(rdr["id"].ToString());
                station.name = rdr["name"].ToString();
            }
            return station;
        }

        public bool save()
        {
            if (this.bus_id == null)
            {
                MySqlConnection conn = new MySqlConnection(MYSQLConnection.connectionString);

                try
                {
                    conn.Open();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                String cmdString = "INSERT INTO tbl_bus SET "
                    + "bus_company=" + this.bus_company.ToString() + ","
                    + "bus_no='" + this.bus_no + "',"
                    + "bus_model='" + this.bus_model + "',"
                    + "bus_class=" + this.bus_class + ","
                    + "bus_from=" + this.bus_from + ","
                    + "bus_to=" + this.bus_to + ","
                    + "bus_plate='" + this.bus_plate + "',"
                    + "date_added='" + DateTime.Parse(this.date_added).ToString("yyyy-MM-dd HH:mm:ss") + "'";
                //Y-m-d H:i:s
                Console.WriteLine(cmdString);
                MySqlCommand cmd = new MySqlCommand(cmdString, conn);
                try
                {
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }
            }
            else
            {
 
            }
            return false;
        }

    }
}
