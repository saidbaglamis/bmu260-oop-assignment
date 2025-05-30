namespace AracKiralama.Entities
{
    public class Musteri
    {
        public int Id { get; set; }
        public required string Ad { get; set; }
        public required string Soyad { get; set; }
        public required string TC { get; set; }
        public required string Telefon { get; set; }
    }

}
