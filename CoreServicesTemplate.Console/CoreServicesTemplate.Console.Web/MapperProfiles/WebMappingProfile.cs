using AutoMapper;
using CoreServicesTemplate.Console.Web.Models;
using CoreServicesTemplate.Shared.Core.Models;

namespace CoreServicesTemplate.Console.Web.MapperProfiles
{
    public class WebMappingProfile : Profile
    {
        public WebMappingProfile()
        {
            CreateMap<UserViewModel, UserApiModel>().ReverseMap();
            CreateMap<UsersViewModel, UsersApiModel>().ReverseMap();
        }
    }
}
