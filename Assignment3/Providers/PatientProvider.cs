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
    public class PatientProvider
    {
        private static string connString;
        
        public static Patient Get(int idPatient)
        {
            
            connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM patients where idPatient= " + idPatient + ";";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    {
                        Patient patient = new Patient();
                        patient.idPatient = reader.GetInt32("idPatient");
                        patient.cnp = reader.GetString("cnp");
                        patient.birthDate = reader.GetDateTime("birthDate");
                        patient.address = reader.GetString("address");
                        return patient;
                    }
                }
                conn.Close();
            }
            return null;
        }
    
        public static IEnumerable<Patient> GetList()
        {
            List<Patient> PatientsList = new List<Patient>();
            string connString;
            connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM patients";
                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Patient patient = new Patient();
                        patient.idPatient = reader.GetInt32("idPatient");
                        patient.cnp = reader.GetString ("cnp");
                        patient.name = reader.GetString("name");
                        patient.birthDate = reader.GetDateTime("birthDate");
                        patient.address = reader.GetString("address");
                        PatientsList.Add(patient);
                    }
                }
                conn.Close();
            }

            return PatientsList;
        }

        

        public static void AddPatient(Patient patient)
        {
            
            connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddPatient";

                cmd.Parameters.Add(new MySqlParameter("idPatient",patient.idPatient));
                cmd.Parameters.Add(new MySqlParameter("cnp",patient.cnp));
                cmd.Parameters.Add(new MySqlParameter("name", patient.name));
                cmd.Parameters.Add(new MySqlParameter("birthDate", patient.birthDate));
                cmd.Parameters.Add(new MySqlParameter("address", patient.address));
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public static void UpdatePatient(Patient patient)
        {
           
            connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdatePatient";

                cmd.Parameters.Add(new MySqlParameter("idPatient", patient.idPatient));
                cmd.Parameters.Add(new MySqlParameter("cnp", patient.cnp));
                cmd.Parameters.Add(new MySqlParameter("name", patient.name));
                cmd.Parameters.Add(new MySqlParameter("birthDate", patient.birthDate));
                cmd.Parameters.Add(new MySqlParameter("address", patient.address));
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}