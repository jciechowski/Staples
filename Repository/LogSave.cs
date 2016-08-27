using NLog;

namespace Repository
{

    public class LogSave : ISaveable
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public void Save(LogDto entity)
        {
            logger.Log(LogLevel.Info, entity.Name + " " + entity.Surname);
        }
    }
}
