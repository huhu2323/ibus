using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace iBUS
{
    class User
    {
        public Nullable<int> user_id;
        public Nullable<int> user_company;
        public String user_fname;
        public String user_lname;
        public String user_email;
        public String user_contact;
        public String user_username;
        public String user_password;
        public String user_position;
        public String user_question;
        public String user_answer;
        public byte[] user_photo;

        public static User checkLogin(String username, String password)
        {
            String query = "SELECT * FROM user_accounts WHERE"
                + " user_username='" + username
                + "' AND user_password='" + password + "'";
            
            MySqlConnection conn = new MySqlConnection(MYSQLConnection.connectionString);
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);   
            }
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            User user = new User();
            while (rdr.Read())
            {
                user.user_id = int.Parse( rdr["user_id"].ToString());
                user.user_company = int.Parse( rdr["user_company"].ToString());
                user.user_fname = rdr["user_fname"].ToString();
                user.user_lname = rdr["user_lname"].ToString();
                user.user_email = rdr["user_email"].ToString();
                user.user_contact = rdr["user_contact"].ToString();
                user.user_username = rdr["user_username"].ToString();
                user.user_password = rdr["user_password"].ToString();
                user.user_position = rdr["user_position"].ToString();
                user.user_question = rdr["user_question"].ToString();
                user.user_answer = rdr["user_answer"].ToString();
                user.user_photo = (byte[])rdr["user_photo"];
            }
            Console.WriteLine(user.user_fname);
            return user;
        }

        public static List<User> all()
        {
            String query = "SELECT * FROM user_accounts";

            MySqlConnection conn = new MySqlConnection(MYSQLConnection.connectionString);
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            List<User> users = new List<User>();
            while (rdr.Read())
            {
                var user = new User();
                user.user_id = int.Parse(rdr["user_id"].ToString());
                user.user_company = int.Parse(rdr["user_company"].ToString());
                user.user_fname = rdr["user_fname"].ToString();
                user.user_lname = rdr["user_lname"].ToString();
                user.user_email = rdr["user_email"].ToString();
                user.user_contact = rdr["user_contact"].ToString();
                user.user_username = rdr["user_username"].ToString();
                user.user_password = rdr["user_password"].ToString();
                user.user_position = rdr["user_position"].ToString();
                user.user_question = rdr["user_question"].ToString();
                user.user_answer = rdr["user_answer"].ToString();
                user.user_photo = (byte[])rdr["user_photo"];
                users.Add(user);
            }
            return users;
        }
    }
}
