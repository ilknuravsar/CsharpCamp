using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "İlknur";
            int yas = 22;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.KursEgitmen = "engin";
            kurs1.IzlenmeOrani = 72;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.KursEgitmen = "engin";
            kurs2.IzlenmeOrani = 72;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "python";
            kurs3.KursEgitmen = "engin";
            kurs3.IzlenmeOrani = 72;

            Console.WriteLine(kurs1.KursAdi + "  "  +  kurs1.KursEgitmen);

           
            //Console.WriteLine("Hello World!");

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursEgitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
