﻿// <auto-generated />
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MainProject.Migrations
{
    [DbContext(typeof(MoviesDbContext))]
    [Migration("20240708141851_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MainProject.Entities.FilmGenre", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.HasKey("MovieId", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("FilmGenres");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            GenreId = 27
                        },
                        new
                        {
                            MovieId = 1,
                            GenreId = 11
                        },
                        new
                        {
                            MovieId = 1,
                            GenreId = 10
                        },
                        new
                        {
                            MovieId = 2,
                            GenreId = 28
                        },
                        new
                        {
                            MovieId = 2,
                            GenreId = 9
                        },
                        new
                        {
                            MovieId = 2,
                            GenreId = 29
                        },
                        new
                        {
                            MovieId = 1,
                            GenreId = 7
                        },
                        new
                        {
                            MovieId = 1,
                            GenreId = 3
                        },
                        new
                        {
                            MovieId = 3,
                            GenreId = 30
                        },
                        new
                        {
                            MovieId = 3,
                            GenreId = 31
                        },
                        new
                        {
                            MovieId = 3,
                            GenreId = 32
                        });
                });

            modelBuilder.Entity("MainProject.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Horror"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Sport"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Drama"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Sci-fi"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Since fiction"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Comedy"
                        },
                        new
                        {
                            Id = 7,
                            Name = "School"
                        },
                        new
                        {
                            Id = 8,
                            Name = "evryday life"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Romantic"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Magic"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Demons"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Psycology"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Detective"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Parody"
                        },
                        new
                        {
                            Id = 17,
                            Name = "Super hero"
                        },
                        new
                        {
                            Id = 18,
                            Name = "Garem"
                        },
                        new
                        {
                            Id = 19,
                            Name = "Slasher"
                        },
                        new
                        {
                            Id = 20,
                            Name = "Etti"
                        },
                        new
                        {
                            Id = 21,
                            Name = "Syonen"
                        },
                        new
                        {
                            Id = 22,
                            Name = "War"
                        },
                        new
                        {
                            Id = 23,
                            Name = "Meha"
                        },
                        new
                        {
                            Id = 24,
                            Name = "Music"
                        },
                        new
                        {
                            Id = 25,
                            Name = "Historical"
                        },
                        new
                        {
                            Id = 26,
                            Name = "Kids movie"
                        },
                        new
                        {
                            Id = 27,
                            Name = "action film"
                        },
                        new
                        {
                            Id = 28,
                            Name = "Anime"
                        },
                        new
                        {
                            Id = 29,
                            Name = "Uncany"
                        },
                        new
                        {
                            Id = 30,
                            Name = "Post-cyberpunk"
                        },
                        new
                        {
                            Id = 31,
                            Name = "Utopia"
                        },
                        new
                        {
                            Id = 32,
                            Name = "Triler"
                        });
                });

            modelBuilder.Entity("MainProject.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AdultRating")
                        .HasColumnType("int");

                    b.Property<int>("Lenght")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Movie");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdultRating = 16,
                            Lenght = 133,
                            Name = "Spider man, back to home",
                            Rating = 4.2999999999999998
                        },
                        new
                        {
                            Id = 2,
                            AdultRating = 16,
                            Lenght = 106,
                            Name = "Your name",
                            Rating = 4.7999999999999998
                        },
                        new
                        {
                            Id = 3,
                            AdultRating = 12,
                            Lenght = 109,
                            Name = "Time",
                            Rating = 3.2999999999999998
                        });
                });

            modelBuilder.Entity("MainProject.Entities.FilmGenre", b =>
                {
                    b.HasOne("MainProject.Entities.Genre", "Genre")
                        .WithMany("FilmGenres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MainProject.Entities.Movie", "Movie")
                        .WithMany("FilmGenres")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("MainProject.Entities.Genre", b =>
                {
                    b.Navigation("FilmGenres");
                });

            modelBuilder.Entity("MainProject.Entities.Movie", b =>
                {
                    b.Navigation("FilmGenres");
                });
#pragma warning restore 612, 618
        }
    }
}
