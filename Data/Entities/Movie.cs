using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Lenght { get; set; }

        [Url(ErrorMessage ="URL Address must be valid")]
        public string? ImageUrl { get; set; }
        public double Rating { get; set; }
        [Range(1, 5)]
        public int AdultRating { get; set; }
        [Range(3, 21)]
        public ICollection<FilmGenre> FilmGenres { get; set;}
    }
}
