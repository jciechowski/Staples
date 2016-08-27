using AutoMapper;
using Models;
namespace Repository
{
    public class MapService
    {
        public LogDto Map(IDbSaveable person)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<IDbSaveable, LogDto>());
            return Mapper.Map<LogDto>(person);
        }
    }
}
