using System.Data.SqlClient;

namespace Repository
{
    public class SaveDb : ISaveable
    {
        public void Save(LogDto logDto)
        {
            using (var dbConnection = new SqlConnection(Properties.Settings.Default.DatabaseConnectionString))
            {
                dbConnection.Open();
                using (var cmd = new SqlCommand("INSERT INTO LogInfo ( Name, Surname) VALUES (@Name, @Surname)", dbConnection))
                {
                    cmd.Parameters.AddWithValue("Name", logDto.Name);
                    cmd.Parameters.AddWithValue("Surname", logDto.Surname);
                    cmd.ExecuteNonQuery();
                }
                dbConnection.Close();
            }
        }
    }
}
