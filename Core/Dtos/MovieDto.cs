
using Data.Entities;

namespace Core.Dtos
{
    public class MovieDto
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public int Lenght { get; set; }
        public string? ImageUrl { get; set; }
        public int Rating { get; set; }
        public int AdultRating { get; set; }
        public ICollection<FilmGenre> FilmGenres { get; set; }
    }
}
