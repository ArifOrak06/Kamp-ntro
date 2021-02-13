using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gerçek Müşteri
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.CustomerNumber = "123456";
            musteri1.FirstName = "Arif";
            musteri1.LastName = "ORAK";
            musteri1.TcNo = "123123123";


            //Tüzel Müşteri

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.CompanyName = "Kuari Blog";
            musteri2.CustomerNumber = "4321";
            musteri2.VergiNo = "654789";


            //

            Customer musteri3 = new GercekMusteri();
            Customer musteri4 = new TuzelMusteri();
            // Şimdi buraya dikkat ! Yukarıda oluşturmuş olduğumuz 3 farklı sınıftan objeler türettik.
            // Bu türetilen objelerden Tüzel ve gerçek müşteri objelerinden Customerdan miras aldık. 
            // Ancak CustomerManager class'ına argüman olarak sadece Custormer class'ını vermiştik.
            // ancak aşağıda da görüleceği üzere gerçek ve tüzel müşteri classlarından türetilen objeleri de
            // içerisine argüman oalrak verebiliyoruz, bunun sebebi ise her iki sınıf Customer class'ından miras alması nedeniyle
            // Customer class'ı hem Tüzel Müşterinin hemde Gerçek Müşterinin referanslarını tutmuş olduğundan dolayıdır.
            // İnheritance mantığı bu şekilde çalışmaktadır.


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
            customerManager.Add(musteri3);
            customerManager.Add(musteri4);


            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID

        }
    }
}
