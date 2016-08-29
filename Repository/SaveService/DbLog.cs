using System.Data.SqlClient;

namespace Repository
{
    public class DbLog : ILogger
    {
        public void Log(LogDto logDto)
        {
            using (var dbConnection = new SqlConnection(Properties.Settings.Default.LogInfoDbConnectionString))
            {
                dbConnection.Open();
                using (var cmd = new SqlCommand("INSERT INTO LogInfo ( Name, Surname) VALUES (@Name, @Surname)", dbConnection))
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
