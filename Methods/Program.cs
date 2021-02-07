using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //eğer classlar ile çalışmasak her ürün için aşağıdaki gibi
            //tek tek değişkenler tanımlamak zorunda kalırdık.
            //Sonu gelmeyen bir süreç olurdu.
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            // Yukarıdaki gibi bir sürü değişken tanımlarsak
            // aşağıdaki gibi array tanımlamız gerekir.
            // Ancak aşağıdaki örnekteki gibi array oluşturunca 
            // bunun içinde sadecestring tutabiliyoruz. Ama
            // yukarıda double da tanımladık. Belki int ya da 
            // başka bir veri tipi tutmak isteyeceğiz. 
            // İşte bu nedenle aşağıdaki gibi array bize yetersiz 
            // geldiğinden classlar ile çalışmamız gerekiyor.
            string[] meyveler = new string[] { }; //array oluşturduk

            Urun urun1 = new Urun(); //class tanımlamak için bunu yapmak gerekiyor. Buna örnek denir.
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 8;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun urun3 = new Urun();
            urun3.Adi = "Armut";
            urun3.Fiyati = 12;
            urun3.Aciklama = "Ankara Armudu";

            // Yukarıdaki 24. satırdaki gibi string array oluşturabildiğimiz gibi 
            // aşağıda görüleceği üzere urun array de oluşturabiliriz.
            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            // type-safe -- tip güvenli
            foreach (Urun urun in urunler) //parantez içindeki kısmı (var xxx in urunler) şeklinde yazsak da çalışır.
            {
                Console.WriteLine("Ürün Adı\t: " + urun.Adi);
                Console.WriteLine("Ürün Fiyatı\t: " + urun.Fiyati + " TL");
                Console.WriteLine("Ürün Ayrıntısı\t: " + urun.Aciklama);
                Console.WriteLine("-------------");
            }
            Console.WriteLine("\n\n--------------Metotlar----------------");

            //class çağırırken örneğini öncelikle oluştururuz.
            //encapsulation
            SepetManager sepetManager = new SepetManager();    //instance - örnek
            sepetManager.Ekle(urun1); //sepetManager. dediğimiz anda intellisense açar menüyü
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);

            //Aşağıdaki gibi kodlama hatalı olur. Programda güncelleme olunca yüzlerce kodu güncellemek gerekir. 
            //Bu nedenle yukarıdaki gibi kodlanmalı. Ve tabi her kod güncellemede Urun.cs'ye gerekli güncelleme yapılmalı. 
            Console.WriteLine("\n-----Yapılmaması Gereken Kodlama Örneği-----"); ;
            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 9);

        }
    }
}
