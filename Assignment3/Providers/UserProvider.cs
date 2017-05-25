using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using Assignment3.Models;

namespace Assignment3.Providers
{
    public class UserProvider
    {
        public static string connString;

        public static IEnumerable<User> GetList()
        {
            List<User> UsersList = new List<User>();
            connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM users";
                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        User user = new Models.User();
                        user.idUser = reader.GetInt32("idUser");
                        user.password = reader.GetString("password");
                        user.tip = reader.GetString("tip");
                        UsersList.Add(user);
                    }
                }
                conn.Close();
            }
            
                return UsersList;
        }
        public static User GetUser(int idUser)
        {
            connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM users where idUser = " + idUser + ";";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    {
                        User user = new User();
                        user.idUser = reader.GetInt32("idUser");
                        user.password = reader.GetString("password");
                        user.tip = reader.GetString("tip");
                        return user;
                    }
                }
            }

            return null;
        }
        public static void AddUser(User user)
        {
            Security secure = new Security();
            user.password = secure.HashSHA1(user.password);
            connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddUser";

                cmd.Parameters.Add(new MySqlParameter("idUser", user.idUser));
                cmd.Parameters.Add(new MySqlParameter("newPassword", user.password));
                cmd.Parameters.Add(new MySqlParameter("tip", user.tip ));

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        public static void UpdateUser(User user)
        {
            Security secure = new Security();
            user.password = secure.HashSHA1(user.password);
            connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateUser";

                cmd.Parameters.Add(new MySqlParameter("idUser", user.idUser));
                cmd.Parameters.Add(new MySqlParameter("newPassword", user.password));
                cmd.Parameters.Add(new MySqlParameter("tip", user.tip));

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        public static void DeleteUser(User user)
        {
            Security secure = new Security();
            user.password = secure.HashSHA1(user.password);
            connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteUser";

                cmd.Parameters.Add(new MySqlParameter("idUser", user.idUser));
                

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        public static User Login(int userId, string password)
        {
           // connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            User user = GetUser(userId);
            if (user != null)
            {
                Security secure = new Security();
                if (secure.VerifyHash(password, user.password))
                {
                    return user;
                }
            }
            return null;
        }
       

    }
}