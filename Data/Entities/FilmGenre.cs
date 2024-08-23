using Microsoft.EntityFrameworkCore;

namespace Data.Entities
{
    public class FilmGenre
    {
        public int MovieId { get; set; }

        public Movie Movie { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }
    
}
