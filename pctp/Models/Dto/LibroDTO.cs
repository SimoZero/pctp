namespace pctp.Models.Dto
{
    public class LibroDTO   
    {
        public required string Isbn { get; set; }
        public string Titolo { get; set; }
        public required string Img { get; set; }
        public required string Autore { get; set; }
        public required string Genere { get; set; }
        public int Anno { get; set; }
    
    }
}