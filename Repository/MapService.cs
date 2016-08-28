using AutoMapper;
using Models;
namespace Repository
{
    public class MapService
    {
        public LogDto Map(IPerson person)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<IPerson, LogDto>());
            return Mapper.Map<LogDto>(person);
        }
    }
}
