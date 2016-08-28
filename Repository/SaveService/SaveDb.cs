using System.Data;
using System.Data.SqlClient;

namespace Repository
{
    public class SaveDb : ISaveable
    {
        public void Save(LogDto logDto)
        {
            using (var dbConnection = new SqlConnection(Properties.Settings.Default.LogDBConnectionString))
            {
                dbConnection.Open();
                using (var cmd = new SqlCommand("INSERT INTO LogInfo ( Name, Surname) VALUES (@Name, @Surname)", dbConnection))
                {
                    cmd.Parameters.AddWithValue("@Name", logDto.Name);
                    cmd.Parameters.AddWithValue("@Surname", logDto.Surname);
                    var result = cmd.ExecuteNonQuery();
                }
                dbConnection.Close();
            }
        }
    }
}
