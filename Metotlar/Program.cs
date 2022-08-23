using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 5;
            urun1.Aciklama = "amasaya elmasi";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 15;
            urun2.Aciklama = "karpuz karpuz";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
            }
              
            Console.WriteLine("----Metotlar-----");
            //instance - örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);

            sepetManager.Ekle2("armut", "armutarmut", 12, 5);
            sepetManager.Ekle2("elma", "armutarmut", 12, 5);
            sepetManager.Ekle2("ayva", "armutarmut", 12, 5);



        }
    }
}
