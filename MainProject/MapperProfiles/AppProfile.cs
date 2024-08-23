using AutoMapper;
using Core.Dtos;
using Data.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ShopMvcApp_PD211.MapperProfiles
{
    public class AppProfile : Profile
    {
        public AppProfile()
        {
            CreateMap<MovieDto, Movie>().ReverseMap();
            //.ForMember(x => x.CategoryName, opt => opt.MapFrom(src => src.Category.Name));
        }
    }
}
