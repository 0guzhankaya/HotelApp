using AutoMapper;
using Hotel.Entity.Concrete;
using Hotel.WebUI.Dtos.AboutDto;
using Hotel.WebUI.Dtos.LoginDto;
using Hotel.WebUI.Dtos.RegisterDto;
using Hotel.WebUI.Dtos.ServiceDto;
using Hotel.WebUI.Dtos.StaffDto;
using Hotel.WebUI.Dtos.SubscribeDto;
using Hotel.WebUI.Dtos.TestimonialDto;

namespace Hotel.WebUI.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Service, ResultServiceDto>().ReverseMap();
            CreateMap<Service, UpdateServiceDto>().ReverseMap();
            CreateMap<Service, CreateServiceDto>().ReverseMap();
            CreateMap<AppUser, CreateNewUserDto>().ReverseMap();
            CreateMap<AppUser, LoginUserDto>().ReverseMap();
            CreateMap<About, ResultAboutDto>().ReverseMap();
            CreateMap<About, UpdateAboutDto>().ReverseMap();
            CreateMap<Testimonial, ResultTestimonialDto>().ReverseMap();
            CreateMap<Staff, ResultStaffDto>().ReverseMap();
            CreateMap<Subscribe, CreateSubscribeDto>().ReverseMap();
        }
    }
}
