using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MainProject.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lenght = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    AdultRating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FilmGenres",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmGenres", x => new { x.MovieId, x.GenreId });
                    table.ForeignKey(
                        name: "FK_FilmGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmGenres_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Horror" },
                    { 2, "Sport" },
                    { 3, "Drama" },
                    { 4, "Sci-fi" },
                    { 5, "Since fiction" },
                    { 6, "Comedy" },
                    { 7, "School" },
                    { 8, "evryday life" },
                    { 9, "Romantic" },
                    { 10, "Fantasy" },
                    { 11, "Adventure" },
                    { 12, "Magic" },
                    { 13, "Demons" },
                    { 14, "Psycology" },
                    { 15, "Detective" },
                    { 16, "Parody" },
                    { 17, "Super hero" },
                    { 18, "Garem" },
                    { 19, "Slasher" },
                    { 20, "Etti" },
                    { 21, "Syonen" },
                    { 22, "War" },
                    { 23, "Meha" },
                    { 24, "Music" },
                    { 25, "Historical" },
                    { 26, "Kids movie" },
                    { 27, "action film" },
                    { 28, "Anime" },
                    { 29, "Uncany" },
                    { 30, "Post-cyberpunk" },
                    { 31, "Utopia" },
                    { 32, "Triler" }
                });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "AdultRating", "Lenght", "Name", "Rating" },
                values: new object[,]
                {
                    { 1, 16, 133, "Spider man, back to home", 4.2999999999999998 },
                    { 2, 16, 106, "Your name", 4.7999999999999998 },
                    { 3, 12, 109, "Time", 3.2999999999999998 }
                });

            migrationBuilder.InsertData(
                table: "FilmGenres",
                columns: new[] { "GenreId", "MovieId" },
                values: new object[,]
                {
                    { 3, 1 },
                    { 7, 1 },
                    { 10, 1 },
                    { 11, 1 },
                    { 27, 1 },
                    { 9, 2 },
                    { 28, 2 },
                    { 29, 2 },
                    { 30, 3 },
                    { 31, 3 },
                    { 32, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FilmGenres_GenreId",
                table: "FilmGenres",
                column: "GenreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmGenres");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}
