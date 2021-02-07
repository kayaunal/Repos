using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class IndividualCustomer:Customer //inheritance //Gerçek müşteri de müşteridir demek istiyoruz.
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TCKN { get; set; }
    }
}
