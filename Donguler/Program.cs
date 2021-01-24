using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamya Başlangıç İçin Temel Kurs", "Java " };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("**********************************");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu");
        }
    }
}
