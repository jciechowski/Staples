using Castle.Windsor;
using Models;
using Repository.Installers;
using Repository.Models;

namespace Repository.Services
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
            var logDto = MapService.Map(person);
            var loggers = _container.ResolveAll<ILogger>();
            foreach (var logger in loggers)
            {
                logger.Log(logDto);
            }
        }

        public void LogToXml(IPerson person)
        {
            var logDto = MapService.Map(person);
            var xmlLogger = _container.Resolve<XmlLog>("XmlLog");
            xmlLogger.Log(logDto);
        }
    }
}
