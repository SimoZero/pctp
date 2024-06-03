using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pctp.Models
{
    public class Libro
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public required string Isbn { get; set; }
        public required string Titolo { get; set; }
        public required string Img { get; set; }
        public required string Autore { get; set; }
        public required string Genere { get; set; }
        public int Anno { get; set; }
    }
}
