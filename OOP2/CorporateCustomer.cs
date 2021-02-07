using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class CorporateCustomer:Customer //inheritance yaptık. Türkçesi miras.Tüzel müşteri de müşteridir demek istiyoruz.
    {
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
    }
}
