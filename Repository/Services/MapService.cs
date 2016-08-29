using AutoMapper;
using Models;
using Repository.Models;

namespace Repository.Services
{
    public static class MapService
    {
        public static LogDto Map(IPerson person)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<IPerson, LogDto>());
            return Mapper.Map<LogDto>(person);
        }
    }
}
