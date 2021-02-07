using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        // Bir yerde normal parantez varsa anlayın ki orada bir metot çalışıyordur.
        // Neyi eklemek istediğimizi de metoda vermemiz lazım. Buna parametre denir.
        // Parantezin içindeki kısım parametre. Urun: tipi -- urun: parametre
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi: " + urun.Adi);
        }

        //Yukarıdaki bir metot idi. Aşağıdaki de başka bir metot.
        //Yani bir class içerisinde birden fazla metot olabilir.
        public void Ekle2(string urunAdi, string Aciklama, double Fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi: " + urunAdi);

        }
    }
}
