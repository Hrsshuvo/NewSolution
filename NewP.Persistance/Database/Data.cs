using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace NewP.Persistance.Database
{
    public class LibryData
    {
        public static String ConnectionString()
        {
            var connectionString = @"Server=localhost; Database = PharmaDb; Trusted_Connection=true";
            return connectionString;
        }
        public int ExecuteNonQuery(string query, string connectionString)
        {
            try
            {
                var connection = new SqlConnection(connectionString);
                connection.Open();
                var command = new SqlCommand(query, connection);
                int rewAffected = command.ExecuteNonQuery();
                connection.Close();
                return rewAffected;
            }
            catch (Exception e)
            {

                throw new Exception (e.Message);
            }
        }
        public SqlDataReader ExecuteReader(string query, string connectionString)
        {
            try

            {
                var connection = new SqlConnection(connectionString);
                connection.Open();
                var command = new SqlCommand(query, connection);
                var reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public SqlDataAdapter ExecuteAdapter(string query, string connectionString)
        {
            try
            {
                var connection = new SqlConnection(connectionString);
                connection.Open();
                var command = new SqlCommand(query, connection);
                var adapter = new SqlDataAdapter(command);
                return adapter;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public decimal ExecuteScalar(string query, string connectionString)
        {
            try
            {
                var connection = new SqlConnection(connectionString);
                connection.Open();
                var command = new SqlCommand(query, connection);
                object success = command.ExecuteScalar();
                connection.Close();
                return Convert.ToDecimal(success);
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
