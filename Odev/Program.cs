using System;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[]
            {
                "c#", ".net" , "java"
            };

            for(int i = 0; i<= kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
          
            Console.WriteLine("Hello World!");
        }
    }
}
