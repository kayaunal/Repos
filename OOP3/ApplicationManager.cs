using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        //method injection
        public void BasvuruYap(ICreditBaseManager creditBaseManager, ILoggerService loggerService)
        {
            //Başvuran bilgilerini değerlendirme
            //
            creditBaseManager.Hesapla();
            loggerService.Log();

        }
        
        public void KrediInBilgilendirmesiYap(List<ICreditBaseManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Hesapla();
            }
        }
    }
}
