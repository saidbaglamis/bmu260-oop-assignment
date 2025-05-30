namespace AracKiralama.Entities
{
    public class Suv : Arac
    {
        public override double KiraUcretiHesapla(int gun)
        {
            return GunlukUcret * gun * 1.10; // %10 fark
        }
    }

}
