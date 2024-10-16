using AutoMapper;
using Hotel.Dto.Dtos.RoomDto;
using Hotel.Entity.Concrete;

namespace Hotel.WebAPI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Room, RoomAddDto>().ReverseMap();
            CreateMap<Room, RoomUpdateDto>().ReverseMap();
        }
    }
}
