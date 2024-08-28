using AutoMapper;
using Core.Dtos;
using Data.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Core.MapperProfiles
{
    public class AppProfile : Profile
    {
        public AppProfile()
        {
            CreateMap<MovieDto, Movie>();
            CreateMap<Movie, MovieDto>()
                .ForMember(x => x.Genres, opt => opt.MapFrom(src => src.FilmGenres.Select(x => x.Genre.Name)));
        }
    }
}
