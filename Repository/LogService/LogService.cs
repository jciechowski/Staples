using Castle.Windsor;
using Models;
using Repository.Installers;

namespace Repository
{
    public class LogService
    {
        private readonly IWindsorContainer _container;

        public LogService()
        {
            _container = new WindsorContainer().Install(new LoggerInstallers());
        }
        public void Log(IPerson person)
        {
            var logDto = new MapService().Map(person);
            var loggers = _container.ResolveAll<ILogger>();
            foreach (var logger in loggers)
            {
                logger.Log(logDto);
            }
        }
    }
}
