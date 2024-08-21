using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri()
            {
                Id=1,
                Ad="İnanç",
                Soyad="Ozan",
                Adres="İstanbul"
            };

            Musteri musteri2 = new Musteri()
            {
                Id = 2,
                Ad = "Danla",
                Soyad = "Bilic",
                Mail="danlabilic@g.com"
            };

           
            Musteri musteri3 = new Musteri()
            {
                Id = 3,
                Ad = "Güneş",
                Soyad = "Arıcı"
            };

            MusteriManager musteriManager = new MusteriManager();
            
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);

            Console.WriteLine("-------------------------");

            musteriManager.MusteriListele();

            Console.WriteLine("-------------------------");

            musteriManager.MusteriSil(musteri3);
            Console.WriteLine("-------------------------");
            musteriManager.MusteriListele();



            Console.ReadKey();
        }
    }
}
