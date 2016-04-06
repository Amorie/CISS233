/*
Paul Adams
Project 8
4/5/16
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project08
{
    public static class DataUtilityClass
    {
        private static System.Data.SqlClient.SqlConnection conn = null;

        public static void ConnectToDB()
        {
            conn = new System.Data.SqlClient.SqlConnection();
            conn.ConnectionString =
                "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\MeasurementDb.mdf;Integrated Security=True";
            conn.Open();
        }
        public static void AddMeasurement(ClassMeasurement measurement)
        {
            try
            {
                ConnectToDB();
                string sql = "insert into measurements(date, measurement) values('" + measurement.PrecipDate + "', " +
                             measurement.PrecipAmount + ")";
                var command = new System.Data.SqlClient.SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                CloseDBConnection();
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                
            }
            
        }

        public static void CloseDBConnection()
        {
            conn.Close();
        }

        public static List<ClassMeasurement> GetMeasurements()
        {
            var myList = new List<ClassMeasurement>();
            try
            {
                ConnectToDB();
                string sql = "SELECT date, measurement FROM measurements ORDER BY date";
                var command = new System.Data.SqlClient.SqlCommand(sql, conn);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    myList.Add(new ClassMeasurement(Convert.ToDateTime(reader["date"]), Convert.ToDecimal(reader["measurement"])));
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                
                myList = null;
            }
            CloseDBConnection();
            return myList;
        } 
    }
}
