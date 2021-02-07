using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsumerCreditManager ihtiyacKrediManager = new ConsumerCreditManager(); //Şöyle yazsak da çalışı. Yani tümünün başına ICreditManager şeklinde/// ==> ICreditBaseManager ihtiyacKrediManager = new ConsumerCreditManager();
            VehicleCreditManager tasitKrediManager = new VehicleCreditManager();
            MortgageManager konutKrediManager = new MortgageManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            ApplicationManager basvuruManager = new ApplicationManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager, fileLoggerService); //burada ihtiyaç, taşıt veya konuttan hangisini gönderirsek onu hesaplar. Çıktıyı ona göre alırız.

            List<ICreditBaseManager> credits = new List<ICreditBaseManager>() { ihtiyacKrediManager, tasitKrediManager};
            
            //basvuruManager.KrediInBilgilendirmesiYap(credits);
        }
    }
}
