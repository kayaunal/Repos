using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] {"Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            isimler = new string[5];
            isimler[4] = "İlker";
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);
            // Yukarıdaki son kod ile ekrana Engin yazması gerekirken boş geldi.
            // Çünkü 4 elemanlı oluşturduğumuz diziye bir eleman daha eklemek için
            // 5 elemanlı hale getirdik. Bu sayede 5. elemanı ekleyebildik ancak
            // daha önceki 4 elemanı kaybettik bu hareketle.

            // Yukarıdaki sıkıntıyı yaşamamak için aşağıdaki gibi List komutu ile
            // koleksiyon oluştururuz. Bunu yapınca en tepeye using System.Collections.Generic
            // ifadesinin eklendiğinden emin olmalıyız.
            Console.WriteLine("\nŞimdi Koleksiyona Geçelim.\n");
            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
