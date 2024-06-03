using Microsoft.EntityFrameworkCore;
using pctp.Models;
using pctp.Data;
namespace pctp.Data
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Libro> SetBooks { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var lines = System.IO.File.ReadAllLines("Libri.csv");
            var allBooks = lines.Skip(1)
                                .Select(line => line.Split(';'))
                                .Select(parts => new Libro
                                {
                                    Titolo = parts[0],
                                    Autore = parts[1],
                                    Genere = parts[2],
                                    Anno = int.Parse(parts[3]),
                                    Img = parts[4]
                                })
                                .ToList();

            modelBuilder.Entity<Libro>().HasData(allBooks.ToArray());
        }
    }

}
