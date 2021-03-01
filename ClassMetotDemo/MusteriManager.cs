using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {   public void Ekleme(Musteri musteri)
        {
            Console.WriteLine("Tebrikler müşteri eklendi; \n Adı:"+musteri.Ad + "\n Soyadı: " + musteri.Soyad+"\n İletişim No: "+musteri.IletisimNo+ "\n Yaşı: " + musteri.Yasi+ "\n Email: " + musteri.EPosta);

        }
        public void Silme(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad+" "+musteri.Soyad+" "+"Müşterisi silindi");

        }
        public void Listeleme(Musteri musteri)
        {
          
                Console.WriteLine("Adı:"+musteri.Ad);
                Console.WriteLine("Soyadı:"+musteri.Soyad);
                Console.WriteLine("Yaşı:"+musteri.Yasi);
                Console.WriteLine("Email:"+musteri.EPosta);
                Console.WriteLine("İletişim No:"+musteri.IletisimNo);
                
           

        }

    }
}
