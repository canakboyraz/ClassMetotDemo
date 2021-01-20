using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();

            musteri.adi = "Ayse";
            musteri.soyadi = "Ozer";
            musteri.tckn = "44832222222";
            musteri.yas = 27;

            Musteri musteri2 = new Musteri();

            musteri2.adi = "Can";
            musteri2.soyadi = "Akboyraz";
            musteri2.tckn = "1111111111";
            musteri2.yas = 27;

            MusteriManager manager = new MusteriManager();
            manager.Ekle(musteri);
            manager.Listele(musteri2,musteri);
            manager.Silme(musteri);
        }
    }
}
