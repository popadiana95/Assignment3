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
    public class ScheduleProvider
    {
        public static string connString;
            
        public static IEnumerable<Schedule> GetSchedules()
        {
            List<Schedule> SchedulesList = new List<Schedule>();
            connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM schedules";
                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Schedule schedule = new Schedule();
                        schedule.idPatient = reader.GetInt32("idPatient");
                        schedule.idDoctor = reader.GetInt32("idDoctor");
                        schedule.scheduleDate = reader.GetDateTime("scheduleDate");
                        schedule.description = reader.GetString("description");
                        schedule.checkin = reader.GetString("checkin");
                        SchedulesList.Add(schedule);
                    }
                }
                conn.Close();
            }

            return SchedulesList;
        }

        public static IEnumerable<Schedule> GetSchedulesForDoctor(int idDoctor)
        {
            List<Schedule> SchedulesList = new List<Schedule>();
            connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM schedules WHERE idDoctor = " + idDoctor + " AND checkin = '1';";
                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Schedule schedule = new Schedule();
                        schedule.idPatient = reader.GetInt32("idPatient");
                        schedule.idDoctor = reader.GetInt32("idDoctor");
                        schedule.scheduleDate = reader.GetDateTime("scheduleDate");
                        schedule.description = reader.GetString("description");
                        schedule.checkin = reader.GetString("checkin");
                        SchedulesList.Add(schedule);
                    }
                }
                conn.Close();
            }

            return SchedulesList;
        }

        public static IEnumerable<Schedule> GetSchedulesForDoctorDaily(int idDoctor)
        {
            List<Schedule> SchedulesList = new List<Schedule>();
            connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM schedules WHERE idDoctor = " + idDoctor + " ;";
                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Schedule schedule = new Schedule();
                        schedule.idPatient = reader.GetInt32("idPatient");
                        schedule.idDoctor = reader.GetInt32("idDoctor");
                        schedule.scheduleDate = reader.GetDateTime("scheduleDate");
                        schedule.description = reader.GetString("description");
                        schedule.checkin = reader.GetString("checkin");
                        SchedulesList.Add(schedule);
                    }
                }
                conn.Close();
            }

            return SchedulesList;
        }
        public static IEnumerable<Schedule> GetPatientSchadule(int idPatient)
        {
            List<Schedule> SchedulesList = new List<Schedule>();
            
            connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM schedules WHERE idPatient = " + idPatient + ";";
                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Schedule schedule = new Schedule();
                        schedule.idPatient = reader.GetInt32("idPatient");
                        schedule.idDoctor = reader.GetInt32("idDoctor");
                        schedule.scheduleDate = reader.GetDateTime("scheduleDate");
                        schedule.description = reader.GetString("description");

                        SchedulesList.Add(schedule);
                    }
                }
                conn.Close();
            }

            return SchedulesList;
        }
        public static void AddSchedule(Schedule schedule)
        {
            //get all schedules for the patients 
            
            connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddSchedule";

                cmd.Parameters.Add(new MySqlParameter("idPatient", schedule.idPatient));
                cmd.Parameters.Add(new MySqlParameter("idDoctor", schedule.idDoctor));
                cmd.Parameters.Add(new MySqlParameter("ScheduleDate", schedule.scheduleDate));
                cmd.Parameters.Add(new MySqlParameter("description", schedule.description));
                cmd.Parameters.Add(new MySqlParameter("check", schedule.checkin));
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        public static void UpdateSchedule(Schedule schedule)
        {
            string connString;
            connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "UpdateSchedule";

                cmd.Parameters.Add(new MySqlParameter("idPatient", schedule.idPatient));
                cmd.Parameters.Add(new MySqlParameter("idDoctor", schedule.idDoctor));
                cmd.Parameters.Add(new MySqlParameter("scheduleDate", schedule.scheduleDate));
                cmd.Parameters.Add(new MySqlParameter("description", schedule.description));
                cmd.Parameters.Add(new MySqlParameter("checkin", schedule.checkin));
                
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        public static void DeleteSchedule(Schedule schedule)
        {
            string connString;
            connString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteSchedule";

                cmd.Parameters.Add(new MySqlParameter("idPatient", schedule.idPatient));
                cmd.Parameters.Add(new MySqlParameter("idDoctor", schedule.idDoctor));
                cmd.Parameters.Add(new MySqlParameter("scheduleDate", schedule.scheduleDate));
               
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}