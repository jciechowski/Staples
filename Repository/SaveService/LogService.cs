using Models;

namespace Repository
{
    public class LogService
    {
        public void Log(IPerson person)
        {
            var logDto = new MapService().Map(person);
            new XmlLog().Log(logDto);
            new TxtLog().Log(logDto);
            new DbLog().Log(logDto);
        }
    }
}
