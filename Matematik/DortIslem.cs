using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    //Örneğin matematiksel işlem yapan bir program yazacağız.
    //Sürekli aynı işlemleri yapmaktansa, işlemin classını oluşturup
    //gerektikçe bu classı çağırırız ve kendimizi tekrar etmemiş oluruz.
    class DortIslem
    {
        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç= " + toplam);
        }
    }
}
