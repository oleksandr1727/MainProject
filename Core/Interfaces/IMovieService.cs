using Core.Dtos;
using Data.Entities;
using System.Xml.Serialization;

namespace Core.Services
{
    public interface IFavoriteService
    {
        List<MovieDto> GetProducts();
        //List<Movie> GetMoviesEntity();
        int GetCount();
        void Add(int id);
        void Remove(int id);
    }
}
