using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace iBUS
{
    class Company
    {
        public Nullable<int> id;
        public String name;


        public static List<Company> all()
        {
            MySqlConnection conn = new MySqlConnection(MYSQLConnection.connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbl_company", conn);
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            MySqlDataReader rdr = cmd.ExecuteReader();
            List<Company> companies = new List<Company>();
            while (rdr.Read())
            {
                var company = new Company();
                company.id = int.Parse(rdr["id"].ToString());
                company.name = rdr["name"].ToString();
                companies.Add(company);
            }
            return companies;
        }
    }
}
