using Models;
using NLog;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Xml.Serialization;

namespace Repository
{
    public class SaveService
    {
        private LogDto _logDto;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public void Save(IDbSaveable person)
        {
            _logDto = new MapService().Map(person);
            SaveXml();
            SaveLog();
            SaveDb();
        }

        public void SaveXml()
        {
            var xmlSerializer = new XmlSerializer(typeof(LogDto));
            // TODO
            // read path and filename from appconfig
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/log.xml";
            var file = File.Create(path);
            xmlSerializer.Serialize(file, _logDto);
            file.Close();
        }

        public void SaveLog()
        {
            logger.Log(LogLevel.Info, _logDto.Name + " " + _logDto.Surname);
        }

        public void SaveDb()
        {
            //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True
            using (var dbConnection = new SqlConnection(Properties.Settings.Default.DatabaseConnectionString))
            {
                dbConnection.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO LogInfo ( Name, Surname) VALUES (@Name, @Surname)", dbConnection);
                cmd.Parameters.AddWithValue("Name", _logDto.Name);
                cmd.Parameters.AddWithValue("Surname", _logDto.Surname);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
