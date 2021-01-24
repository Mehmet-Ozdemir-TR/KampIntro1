using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKrediManager();

            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService dataLoggerService = new DatabaseLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKrediManager, smsLoggerService);


            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };
         
            // basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
