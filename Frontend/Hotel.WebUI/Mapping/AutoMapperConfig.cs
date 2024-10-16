using AutoMapper;
using Hotel.Entity.Concrete;
using Hotel.WebUI.Dtos.ServiceDto;

namespace Hotel.WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Service, ResultServiceDto>().ReverseMap();
            CreateMap<Service, UpdateServiceDto>().ReverseMap();
            CreateMap<Service, CreateServiceDto>().ReverseMap();
        }
    }
}
