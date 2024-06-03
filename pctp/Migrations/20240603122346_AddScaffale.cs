using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace pctp.Migrations
{
    /// <inheritdoc />
    public partial class AddScaffale : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SetBooks",
                columns: table => new
                {
                    Titolo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Autore = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genere = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Anno = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SetBooks", x => x.Titolo);
                });

            migrationBuilder.InsertData(
                table: "SetBooks",
                columns: new[] { "Titolo", "Anno", "Autore", "Genere", "Img" },
                values: new object[,]
                {
                    { "Assassinio sull'Orient Express", 1934, "Agatha Christie", "Giallo", "https://m.media-amazon.com/images/I/71-n8WO0HFL._AC_UF1000,1000_QL80_.jpg" },
                    { "Dune", 1965, "Frank Herbert", "Fantascienza", "https://m.media-amazon.com/images/I/511suynbMfL._AC_UF1000,1000_QL80_.jpg" },
                    { "Dune: The Battle of Corrin", 2004, "Brian Herbert", "Fantascienza", "https://m.media-amazon.com/images/I/81tNTZMlczL._AC_UF1000,1000_QL80_.jpg" },
                    { "Gli eretici di Dune", 1984, "Frank Herbert", "Fantascienza", "https://m.media-amazon.com/images/I/71yxc8fLNgL._AC_UF1000,1000_QL80_.jpg" },
                    { "Harry Potter e i doni della morte", 2007, "J. K. Rowling", "Fantasy", "https://m.media-amazon.com/images/I/51Qr0XQQPXL.jpg" },
                    { "Harry Potter e il calice di fuoco", 2000, "J. K. Rowling", "Fantasy", "https://m.media-amazon.com/images/I/71WfG8FffsL._AC_UF1000,1000_QL80_.jpg" },
                    { "Harry Potter e il prigioniero di Azkaban", 1999, "J. K. Rowling", "Fantasy", "https://m.media-amazon.com/images/I/71LUEWuecxL._AC_UF1000,1000_QL80_.jpg" },
                    { "Harry Potter e il Principe Mezzosangue", 2005, "J. K. Rowling", "Fantasy", "https://m.media-amazon.com/images/I/710OqzcvPML._AC_UF1000,1000_QL80_.jpg" },
                    { "Harry Potter e l'Ordine dellaFenice", 2003, "J. K. Rowling", "Fantasy", "https://m.media-amazon.com/images/I/81GfdgEiHyL._AC_UF1000,1000_QL80_.jpg" },
                    { "Harry Potter e la camera dei segreti", 1998, "J. K. Rowling", "Fantasy", "https://m.media-amazon.com/images/I/51KHFmcWGxL.jpg" },
                    { "Harry Potter e la maledizione dell'erede", 2016, "J. K. Rowling", "Fantasy", "https://m.media-amazon.com/images/I/81pwzk0tilL._AC_UF1000,1000_QL80_.jpg" },
                    { "Harry Potter e la pietra filosofale", 1997, "J. K. Rowling", "Fantasy", "https://m.media-amazon.com/images/I/51CgZFxNQ0L.jpg" },
                    { "I cacciatori di Dune", 2006, "Brian Herbert", "Fantascienza", "https://www.ibs.it/images/9788834740378_0_424_0_75.jpg" },
                    { "I figli di Dune", 1976, "Frank Herbert", "Fantascienza", "https://m.media-amazon.com/images/I/412FZmYY0sL.jpg" },
                    { "I promessi sposi", 1842, "Alessandro Manzoni", "Storico", "https://upload.wikimedia.org/wikipedia/commons/thumb/3/36/I_promessi_sposi_-_2nd_edition_cover.jpg/643px-I_promessi_sposi_-_2nd_edition_cover.jpg" },
                    { "I vermi della sabbia di Dune", 2007, "Brian Herbert", "Fantascienza", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQXpiuDCTdxqD3xwJgKUbl3NYk0tl3Xd3QEmA&s" },
                    { "Il nome della rosa", 1980, "Umberto Eco", "Giallo", "https://m.media-amazon.com/images/I/61Aa9Yic8AL._AC_UF1000,1000_QL80_.jpg" },
                    { "Il ritorno di Sherlock Holmes", 1905, "Arthur Conan Doyle", "Giallo", "https://m.media-amazon.com/images/I/51L6qiJg1BL.jpg" },
                    { "Jurassic Park", 1990, "Michael Crichton", "Fantascienza", "https://m.media-amazon.com/images/I/51KDF4N3J5L._AC_UF1000,1000_QL80_.jpg" },
                    { "L'imperatore-dio di Dune", 1981, "Frank Herbert", "Fantascienza", "https://m.media-amazon.com/images/I/41R38uCEyGL.jpg" },
                    { "La rifondazione di Dune", 1985, "Frank Herbert", "Fantascienza", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTfYGgvx44ivyiIuNymh8hWpBMpRBWI0HbrQg&s" },
                    { "Le avventure di Sherlock Holmes", 1892, "Arthur Conan Doyle", "Giallo", "https://m.media-amazon.com/images/I/51yGQ7QMW8L.jpg" },
                    { "Le grandi battaglie di Roma antica", 2002, "Andrea Frediani", "Storico", "https://www.ibs.it/images/9788854144026_0_536_0_75.jpg" },
                    { "Messia di Dune", 1969, "Frank Herbert", "Fantascienza", "https://m.media-amazon.com/images/I/41dbYUr0rUL.jpg" },
                    { "V for vendetta", 1982, "Alan Moore", "Distopia", "https://m.media-amazon.com/images/I/81Aw7JnvLTL._AC_UF1000,1000_QL80_.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SetBooks");
        }
    }
}
