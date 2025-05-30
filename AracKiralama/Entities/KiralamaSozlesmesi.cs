using AracKiralama.Entities.Vehicles;

namespace AracKiralama.Entities
{
    public class KiralamaSozlesmesi
    {
        public int Id { get; set; }
        public required Arac Arac { get; set; }
        public required Musteri Musteri { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public double ToplamUcret { get; set; }
    }

}
