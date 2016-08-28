using Models;

namespace Repository
{
    public class SaveService
    {
        public void Save(IPerson person)
        {
            var logDto = new MapService().Map(person);
            new SaveXml().Save(logDto);
            new SaveLog().Save(logDto);
            new SaveDb().Save(logDto);
        }
    }
}
