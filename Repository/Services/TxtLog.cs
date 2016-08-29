using NLog;
using Repository.Models;

namespace Repository.Services
{
    public class TxtLog : Models.ILogger
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public void Log(LogDto logDto)
        {
            Logger.Log(LogLevel.Info, logDto.Name + " " + logDto.Surname);
        }
    }
}