using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("sepete eklendi:  "+urun.Adi);
        }

        public void Ekle2(string Adi, string Aciklama, double Fiyat, int StokAdedi)
        {
            Console.WriteLine("tebrikler, sepete eklendi :" + Adi);
        }

        public void Ekle3()
        {
            Console.WriteLine("Ürün sepete eklendi.");
        }


    }
}
