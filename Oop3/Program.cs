using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ıhtıyacKrediManager = new IhtıyacKrediManager();

            IKrediManager İ2 = new IhtıyacKrediManager();
            //ıhtıyacKrediManager.Hesapla();

            IKrediManager tkmanager = new TasıtKrediManager();
            // tkmanager.Hesapla();

            IKrediManager kkmanager = new KonutKrediManager();
            //kkmanager.Hesapla();
            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService loggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tkmanager, loggerService);
            //basvuruManager.BasvuruYap(ıhtıyacKrediManager);

            List<IKrediManager> krediler = new List<IKrediManager>() { ıhtıyacKrediManager };
            //basvuruManager.KrediOnBilgilendirmeYap(krediler);
        }
    }
}
