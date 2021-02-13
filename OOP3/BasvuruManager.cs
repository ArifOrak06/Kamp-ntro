using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(ICreditManager creditManager, ILoggerService loggerService)
        {
            //Başvuran bilgilerini değerlendirmek
            //
            // Aşağıdaki hesaplama yanlış bir kullanımdır. Çünkü Vatandaşın başvurduğu kredi başka bir kredi olabilir.
            // Örneğin başvurulan kredi taşıt kredisi olsa bile gidip konut kredisinin hesaplama methodunu kullanacak buda büyük bir hataya sebep olacaktı.
            
            //KonutCreditManager konutCreditManager = new KonutCreditManager();
            //konutCreditManager.Hesapla();

            // // Ancak Argüman olarak belleğinde bütün kredilerin referansını tutan iterfacemiz olan ICreditManager'i verirsek,
            // bu sefer başvuruyap voidine argüman oalrak taşıt kredisi  de verseniz, konut kredisi veya ihtiyaç kredisi de verseniz,
            // Belleğinde hepsinin referansını tuttuğu için ona göre algılayıp doğru hesaplama yapacaktır.Aşağıdaki gibi kullanmalıyız.
            creditManager.Hesapla();

            //Loglama
            loggerService.Log();

        }
        public void KrediOnBilgilendirmesiYap(List<ICreditManager> krediler)
        {
            // Kullanıcıdan gelen veri birden fazla veriyi içerisinde barındıran bir liste olacağı için direk ulaşamıyoruz.
            // O yüzden for döngüsü ile listenin içerisinde gezerek her bir veriyi ayrı ayrı hesaplıyoruz.
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();

            }
        }


    }
}
