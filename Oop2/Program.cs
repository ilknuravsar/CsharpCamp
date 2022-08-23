using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "İlknur";
            //musteri1.Soyadi = "AVŞAR";
            //musteri1.Id = 1;
            //musteri1.TcNo = "22222222222";
            //musteri1.MusteriNo = "12345";
            //musteri1.SirketAdi = "??";

            //gerçek ve tüzel müşteri,  birbirlerinin yerine kullanılamaz 
            //soLid inheritance yapma

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "İlknur";
            musteri1.Soyadi = "Avşar";
            musteri1.TcNo = "12345678912";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "12346";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567896";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
        }
    }
}
