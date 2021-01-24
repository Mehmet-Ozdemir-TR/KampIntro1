using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gerçek Müşteri 
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Mehmet";
            musteri1.Soyadi = "Özdemir";
            musteri1.TcNo = "12365897";

            //tuzel Müşteri
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "4558";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "89632547";

            //SOLID } yazılım geliştirme prensipleri !

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
        }
    }
}
