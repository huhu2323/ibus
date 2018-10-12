﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iBUS
{
    static class Auth
    {
        public static int user_id;
        public static int user_company;
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

        public static void login(String username, String password)
        {
            var user = User.checkLogin(username, password);
            if (string.IsNullOrEmpty(user.user_username))
            {
                Console.WriteLine("Error!");
            }
            else
            {
                Auth.user_id = user.user_id;
                Auth.user_company = user.user_id;
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
            }
        }
    }
}