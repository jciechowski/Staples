using NLog;

namespace Repository
{
    public class TxtLog : ILogger
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public void Log(LogDto logDto)
        {
            logger.Log(LogLevel.Info, logDto.Name + " " + logDto.Surname);
        }
    }
}
