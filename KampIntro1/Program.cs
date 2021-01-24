using System;

namespace KampIntro1
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //Do not repaet yourself = Kendini tekrarlama !
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("azalış butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("artış butonu");
            }
            else
            {
                Console.WriteLine("eşittir butonu");
            }

            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("Ayarlar Butonu ");
            }

            else
            {
                Console.WriteLine("Giris Yap");
            }

            Console.WriteLine(kategoriEtiketi);

        }
    }

}
