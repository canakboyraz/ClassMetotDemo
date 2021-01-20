using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void Ekle(Musteri musteri
           ) {

            Console.WriteLine("Ekleme Operasyonu");

            Console.WriteLine(musteri.adi + "  " + musteri.soyadi + "  " + " Eklendi ");
            Console.WriteLine("  ");
        }

        public void Listele(Musteri musteri,Musteri musteri2)
        {

            Console.WriteLine("Listeleme Operasyonu");
            Console.WriteLine(musteri.adi + "  " + musteri.soyadi + "  " + " Listelendi ");
            Console.WriteLine(musteri2.adi + "  " + musteri2.soyadi + "  " + " Listelendi");
            Console.WriteLine("  ");
        }

    


        public void Silme(Musteri musteri)
        {

            Console.WriteLine("Silme Operasyonu");
            Console.WriteLine(musteri.adi + "  " + musteri.soyadi + "  " + " Silindi ");
            Console.WriteLine("  ");
    }
    }

}
