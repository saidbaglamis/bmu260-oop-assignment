namespace AracKiralama.Entities.Vehicles
{
    public class Sedan : Arac
    {
        public override double KiraUcretiHesapla(int gun)
        {
            return GunlukUcret * gun;
        }
    }
}
