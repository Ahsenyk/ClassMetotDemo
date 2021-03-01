using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Ahsen";
            musteri1.Soyad = "Kalkan";
            musteri1.IletisimNo = "0535452566";
            musteri1.EPosta = "ahsen@gmail.com";
            musteri1.Yasi = 28;
     

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Yağmur";
            musteri2.Soyad = "Aslan";
            musteri2.IletisimNo = "053565566";
            musteri2.EPosta = "yagmur@gmail.com";
            musteri2.Yasi = 36;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekleme(musteri1);
            Console.WriteLine("*********************************");
            musteriManager.Silme(musteri2);
            Console.WriteLine("**************Listeleme*****************");
            musteriManager.Listeleme(musteri1);
            Console.WriteLine("**************Listeleme*****************");
            musteriManager.Listeleme(musteri2);



        }
    }
}
