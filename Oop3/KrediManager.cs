using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    //önce class olarak tanımladım fakat farklı kredi türlerinde farklı hesaplamalar yapılacağı için
    // interface dönüştürdüm 
    interface IKrediManager
    {
        void Hesapla();
        void BirseyYap();
    }
}
