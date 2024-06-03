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
                name: "Libri",
                columns: table => new
                {
                    Titolo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Autore = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genere = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Anno = table.Column<int>(type: "int", nullable: false),
                    Isbn = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libri", x => x.Titolo);
                });

            migrationBuilder.InsertData(
                table: "Libri",
                columns: new[] { "Titolo", "Anno", "Autore", "Genere", "Img", "Isbn" },
                values: new object[,]
                {
                    { "Assassinio sull'Orient Express", 1934, "Agatha Christie", "Giallo", "https://m.media-amazon.com/images/I/71-n8WO0HFL._AC_UF1000,1000_QL80_.jpg", "9783161484122" },
                    { "Dune", 1965, "Frank Herbert", "Fantascienza", "https://m.media-amazon.com/images/I/511suynbMfL._AC_UF1000,1000_QL80_.jpg", "9783161484100" },
                    { "Dune: The Battle of Corrin", 2004, "Brian Herbert", "Fantascienza", "https://m.media-amazon.com/images/I/81tNTZMlczL._AC_UF1000,1000_QL80_.jpg", "9783161484106" },
                    { "Gli eretici di Dune", 1984, "Frank Herbert", "Fantascienza", "https://m.media-amazon.com/images/I/71yxc8fLNgL._AC_UF1000,1000_QL80_.jpg", "9783161484104" },
                    { "Harry Potter e i doni della morte", 2007, "J. K. Rowling", "Fantasy", "https://m.media-amazon.com/images/I/51Qr0XQQPXL.jpg", "9783161484115" },
                    { "Harry Potter e il calice di fuoco", 2000, "J. K. Rowling", "Fantasy", "https://m.media-amazon.com/images/I/71WfG8FffsL._AC_UF1000,1000_QL80_.jpg", "9783161484112" },
                    { "Harry Potter e il prigioniero di Azkaban", 1999, "J. K. Rowling", "Fantasy", "https://m.media-amazon.com/images/I/71LUEWuecxL._AC_UF1000,1000_QL80_.jpg", "9783161484111" },
                    { "Harry Potter e il Principe Mezzosangue", 2005, "J. K. Rowling", "Fantasy", "https://m.media-amazon.com/images/I/710OqzcvPML._AC_UF1000,1000_QL80_.jpg", "9783161484114" },
                    { "Harry Potter e l'Ordine dellaFenice", 2003, "J. K. Rowling", "Fantasy", "https://m.media-amazon.com/images/I/81GfdgEiHyL._AC_UF1000,1000_QL80_.jpg", "9783161484113" },
                    { "Harry Potter e la camera dei segreti", 1998, "J. K. Rowling", "Fantasy", "https://m.media-amazon.com/images/I/51KHFmcWGxL.jpg", "9783161484110" },
                    { "Harry Potter e la maledizione dell'erede", 2016, "J. K. Rowling", "Fantasy", "https://m.media-amazon.com/images/I/81pwzk0tilL._AC_UF1000,1000_QL80_.jpg", "9783161484116" },
                    { "Harry Potter e la pietra filosofale", 1997, "J. K. Rowling", "Fantasy", "https://m.media-amazon.com/images/I/51CgZFxNQ0L.jpg", "9783161484109" },
                    { "I cacciatori di Dune", 2006, "Brian Herbert", "Fantascienza", "https://www.ibs.it/images/9788834740378_0_424_0_75.jpg", "9783161484107" },
                    { "I figli di Dune", 1976, "Frank Herbert", "Fantascienza", "https://m.media-amazon.com/images/I/412FZmYY0sL.jpg", "9783161484102" },
                    { "I promessi sposi", 1842, "Alessandro Manzoni", "Storico", "https://upload.wikimedia.org/wikipedia/commons/thumb/3/36/I_promessi_sposi_-_2nd_edition_cover.jpg/643px-I_promessi_sposi_-_2nd_edition_cover.jpg", "9783161484123" },
                    { "I vermi della sabbia di Dune", 2007, "Brian Herbert", "Fantascienza", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQXpiuDCTdxqD3xwJgKUbl3NYk0tl3Xd3QEmA&s", "9783161484108" },
                    { "Il nome della rosa", 1980, "Umberto Eco", "Giallo", "https://m.media-amazon.com/images/I/61Aa9Yic8AL._AC_UF1000,1000_QL80_.jpg", "9783161484119" },
                    { "Il ritorno di Sherlock Holmes", 1905, "Arthur Conan Doyle", "Giallo", "https://m.media-amazon.com/images/I/51L6qiJg1BL.jpg", "9783161484121" },
                    { "Jurassic Park", 1990, "Michael Crichton", "Fantascienza", "https://m.media-amazon.com/images/I/51KDF4N3J5L._AC_UF1000,1000_QL80_.jpg", "9783161484117" },
                    { "L'imperatore-dio di Dune", 1981, "Frank Herbert", "Fantascienza", "https://m.media-amazon.com/images/I/41R38uCEyGL.jpg", "9783161484103" },
                    { "La rifondazione di Dune", 1985, "Frank Herbert", "Fantascienza", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTfYGgvx44ivyiIuNymh8hWpBMpRBWI0HbrQg&s", "9783161484105" },
                    { "Le avventure di Sherlock Holmes", 1892, "Arthur Conan Doyle", "Giallo", "https://m.media-amazon.com/images/I/51yGQ7QMW8L.jpg", "9783161484120" },
                    { "Le grandi battaglie di Roma antica", 2002, "Andrea Frediani", "Storico", "https://www.ibs.it/images/9788854144026_0_536_0_75.jpg", "9783161484124" },
                    { "Messia di Dune", 1969, "Frank Herbert", "Fantascienza", "https://m.media-amazon.com/images/I/41dbYUr0rUL.jpg", "9783161484101" },
                    { "V for vendetta", 1982, "Alan Moore", "Distopia", "https://m.media-amazon.com/images/I/81Aw7JnvLTL._AC_UF1000,1000_QL80_.jpg", "9783161484118" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Libri");
        }
    }
}
