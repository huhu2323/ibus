using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace iBUS
{
    static class Auth
    {
        public static Nullable<int> user_id;
        public static Nullable<int> user_company;
        public static String user_fname;
        public static String user_lname;
        public static String user_email;
        public static String user_contact;
        public static String user_username;
        public static String user_password;
        public static String user_position;
        public static String user_question;
        public static String user_answer;
        public static byte[] user_photo;



        public static bool login(String username, String password)
        {
            var user = User.checkLogin(username, password);
            if (user.user_id == null)
            {
                Console.WriteLine("Error!");
                Auth.user_id = null;
                Auth.user_company = null;
                Auth.user_fname = "";
                Auth.user_lname = "";
                Auth.user_email = "";
                Auth.user_contact = "";
                Auth.user_username = "";
                Auth.user_password = "";
                Auth.user_position = "";
                Auth.user_question = "";
                Auth.user_answer = "";
                return false;
            }
            else
            {
                Auth.user_id = user.user_id;
                Auth.user_company = user.user_company;
                Auth.user_fname = user.user_fname;
                Auth.user_lname = user.user_lname;
                Auth.user_email = user.user_email;
                Auth.user_contact = user.user_contact;
                Auth.user_username = user.user_username;
                Auth.user_password = user.user_password;
                Auth.user_position = user.user_position;
                Auth.user_question = user.user_question;
                Auth.user_answer = user.user_answer;
                Auth.user_photo = user.user_photo;
                return true;
            }
        }

        public static bool can(String permission)
        {
            String query = "SELECT * FROM user_permits WHERE "
                + "user_id=" + Auth.user_id;
            List<int> permits = new List<int>();
            List<String> permisions = new List<String>();

            MySqlConnection conn = new MySqlConnection(MYSQLConnection.connectionString);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine("im in permits query");
                permits.Add(int.Parse(rdr["permission_id"].ToString()));
            }
            conn.Close();
            conn.Dispose();
            if (permits.Count <= 0)
            {
                return false;
            }

            foreach (var x in permits)
            {
                Console.WriteLine("im in loop of permits");
                query = "SELECT permission FROM user_permissions WHERE id=" + x;
                conn.Open();
                cmd = new MySqlCommand(query, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Console.WriteLine("permission: " + x);
                    if (permission == rdr[0].ToString())
                    {
                        return true;
                    }
                }
                conn.Close();
                conn.Dispose();
            }

            return false;
        }

        public static Company getCompany()
        {
            Company company = new Company();
            if (Auth.user_company == 0)
            {
                company.name = "Admin";
                company.id = 0;
                return company;
            }
            MySqlConnection conn = new MySqlConnection(MYSQLConnection.connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tbl_company WHERE id = " + Auth.user_company, conn);
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                company.id = int.Parse(rdr["id"].ToString());
                company.name = rdr["name"].ToString();
            }
            return company;
        }

        public static void logout()
        {
            Auth.user_id = null;
            Auth.user_company = null;
            Auth.user_fname = "";
            Auth.user_lname = "";
            Auth.user_email = "";
            Auth.user_contact = "";
            Auth.user_username = "";
            Auth.user_password = "";
            Auth.user_position = "";
            Auth.user_question = "";
            Auth.user_answer = "";
        }
    }
}
