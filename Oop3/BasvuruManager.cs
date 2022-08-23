using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class BasvuruManager
    {

        //method injection
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            //başvuran bilgilerini değerlendirme


            //yanlış - tüm hesaplamalar konut kredisi üzerinden yapılmış olur
            KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();


            //parametre olarak hangi kredi türü gönderilirse o çalışır 
            krediManager.Hesapla();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmeYap(List<IKrediManager> krediler)
        {
            foreach(var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
