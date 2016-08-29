using NLog;

namespace Repository
{
    public class TxtLog : ILogger
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public void Log(LogDto logDto)
        {
            Logger.Log(LogLevel.Info, logDto.Name + " " + logDto.Surname);
        }
    }
}