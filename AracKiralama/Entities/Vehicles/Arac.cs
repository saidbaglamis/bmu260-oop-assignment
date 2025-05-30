namespace AracKiralama.Entities.Vehicles
{
    public abstract class Arac
    {
        public required string Plaka { get; set; }
        public required string Marka { get; set; }
        public required string Model { get; set; }
        public double GunlukUcret { get; set; }
        public bool Musait { get; set; } = true;

        public abstract double KiraUcretiHesapla(int gun);

        public virtual string OzellikleriGoster()
        {
            return $"{Marka} {Model} - {GunlukUcret} TL/gün";
        }
    }

}
