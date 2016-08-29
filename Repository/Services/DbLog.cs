using System.Configuration;
using System.Data.SqlClient;
using Repository.Models;

namespace Repository.Services
{
    public class DbLog : ILogger
    {
        public void Log(LogDto logDto)
        {
            var dbConnectionString = ConfigurationManager.ConnectionStrings["dbConnectionString"].ConnectionString;
            using (var dbConnection = new SqlConnection(dbConnectionString))
            {
                dbConnection.Open();
                using (var cmd = new SqlCommand("INSERT INTO LogInfo ( Name, Surname) VALUES (@Name, @Surname)",dbConnection))
                {
                    cmd.Parameters.AddWithValue("@Name", logDto.Name);
                    cmd.Parameters.AddWithValue("@Surname", logDto.Surname);
                    cmd.ExecuteNonQuery();
                }
                dbConnection.Close();
            }
        }
    }
}