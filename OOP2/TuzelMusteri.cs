using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Coorporate = Tüzel 
    // Miras = İnheritance 
    // Aşağıda da gördüğünüz gibi manager classından Tüzel ve Gerçek Müşteri sınıflarınında
    // faydalanmasını istediğimiz için Customer classından miras aldık :Customer. Yani özetle 
    // Sen bir müşterisin demiş olduk.

    class TuzelMusteri:Customer
    {

        public string CompanyName { get; set; }
        public string VergiNo { get; set; }
    }
}
