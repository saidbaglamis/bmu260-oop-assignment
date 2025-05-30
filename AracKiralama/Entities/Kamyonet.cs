namespace AracKiralama.Entities
{
    public class Kamyonet : Arac
    {
        public override double KiraUcretiHesapla(int gun)
        {
            return GunlukUcret * gun * 1.20; // %20 fark
        }
    }

}
