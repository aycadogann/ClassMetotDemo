using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        List<Musteri> musteriler = new List<Musteri>();
        public void MusteriEkle(Musteri musteri)
        {
            musteriler.Add(musteri);
            Console.WriteLine("{0} {1} müşterilere eklendi.", musteri.Ad,musteri.Soyad);
        }

        public void MusteriListele()
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Adı: {0}  Soyadı : {1}    Adresi : {2}    E-mail : {3} ",musteri.Ad,musteri.Soyad,musteri.Adres,musteri.Mail);
            }
        }


        public void MusteriSil(Musteri musteri)
        {
            musteriler.Remove(musteri);
            Console.WriteLine("{0} {1} silindi", musteri.Ad,musteri.Soyad);
        }
    }
}
