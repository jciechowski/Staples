using NLog;

namespace Repository
{
    public class SaveLog : ISaveable
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public void Save(LogDto logDto)
        {
            logger.Log(LogLevel.Info, logDto.Name + " " + logDto.Surname);
        }
    }
}
