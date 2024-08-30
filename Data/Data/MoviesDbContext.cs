using Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;



namespace Data
{
    public class MoviesDbContext : IdentityDbContext
    {
        public DbSet<User>
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<FilmGenre> FilmGenres { get; set; }

        public MoviesDbContext(DbContextOptions options) : base(options) { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);

        //    optionsBuilder.UseSqlServer("Data Source=(MoviesDbContextConnection)\\ProjectModels;Initial Catalog=MovieDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Genre>().HasData(new List<Genre>()
            {
                new Genre() { Id = 1, Name = "Horror" },
                new Genre() { Id = 2, Name = "Sport" },
                new Genre() { Id = 3, Name = "Drama" },
                new Genre() { Id = 4, Name = "Sci-fi" },
                new Genre() { Id = 5, Name = "Since fiction" },
                new Genre() { Id = 6, Name = "Comedy" },
                new Genre() { Id = 7, Name = "School" },
                new Genre() { Id = 8, Name = "evryday life" },
                new Genre() { Id = 9, Name = "Romantic" },
                new Genre() { Id = 10, Name = "Fantasy" },
                new Genre() { Id = 11, Name = "Adventure" },
                new Genre() { Id = 12, Name = "Magic" },
                new Genre() { Id = 13, Name = "Demons" },
                new Genre() { Id = 14, Name = "Psycology" },
                new Genre() { Id = 15, Name = "Detective" },
                new Genre() { Id = 16, Name = "Parody" },
                new Genre() { Id = 17, Name = "Super hero" },
                new Genre() { Id = 18, Name = "Garem"},
                new Genre() { Id = 19, Name = "Slasher"},
                new Genre() { Id = 20, Name = "Etti"},
                new Genre() { Id = 21, Name = "Syonen"},
                new Genre() { Id = 22, Name = "War"},
                new Genre() { Id = 23, Name = "Meha"},
                new Genre() { Id = 24, Name = "Music"},
                new Genre() { Id = 25, Name = "Historical"},
                new Genre() { Id = 26, Name = "Kids movie"},
                new Genre() { Id = 27, Name = "action film"},
                new Genre() { Id = 28, Name = "Anime"},
                new Genre() { Id = 29, Name = "Uncany"},
                new Genre() { Id = 30, Name = "Post-cyberpunk"},
                new Genre() { Id = 31, Name = "Utopia"},
                new Genre() { Id = 32, Name = "Triler"}
            });

            modelBuilder.Entity<Movie>().HasData(new List<Movie>()
            {
                new Movie() { Id = 1, Name = "Spider man, back to home", Lenght=133, ImageUrl="https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.behance.net%2Fgallery%2F110612527%2FSpider-Man-A-Way-Back-Home&psig=AOvVaw1OG1alyvDjmbDG0McFB2ot&ust=1720878713515000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCPjNgd_SoYcDFQAAAAAdAAAAABAW" ,Rating=4.3, AdultRating=16},
                new Movie() { Id = 2, Name = "Your name", Lenght=106,ImageUrl="https://upload.wikimedia.org/wikipedia/ru/2/2c/Kimi_no_Na_wa.jpg " ,Rating=4.8, AdultRating=16},
                new Movie() { Id = 3, Name = "In Time", Lenght=109,ImageUrl="https://m.media-amazon.com/images/I/81qSoMP2SCL._SL1500_.jpg" ,Rating=3.3, AdultRating=12}
            });
            modelBuilder.Entity<FilmGenre>().HasData(new List<FilmGenre>()
            {
                new FilmGenre(){MovieId=1, GenreId=27}, new FilmGenre(){MovieId=1, GenreId=11}, new FilmGenre(){MovieId=1, GenreId=10},
                new FilmGenre(){MovieId=2, GenreId=28}, new FilmGenre(){MovieId=2, GenreId=9}, new FilmGenre(){MovieId=2, GenreId=29}, new FilmGenre(){MovieId=1, GenreId=7}, new FilmGenre(){MovieId=1, GenreId=3},
                new FilmGenre(){MovieId=3, GenreId=30}, new FilmGenre(){MovieId=3, GenreId=31}, new FilmGenre(){MovieId=3, GenreId=32},

            });
            modelBuilder.Entity<FilmGenre>()
                .HasKey(fg => new { fg.MovieId, fg.GenreId });

            modelBuilder.Entity<FilmGenre>()
                .HasOne(fg => fg.Movie)
                .WithMany(m => m.FilmGenres)
                .HasForeignKey(fg => fg.MovieId);

            modelBuilder.Entity<FilmGenre>()
                .HasOne(fg => fg.Genre)
                .WithMany(g => g.FilmGenres)
                .HasForeignKey(fg => fg.GenreId);
        }
    }
}
