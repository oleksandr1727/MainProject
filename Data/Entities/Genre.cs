﻿namespace Data.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<FilmGenre> FilmGenres { get; set; }
    }
}
