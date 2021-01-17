using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            // Daha önce oluşturduğumuz ürün classından yeni bir ürün türettik.
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Portakal";
            urun2.Fiyati = 25;
            urun2.Aciklama = "Finike Portakalı";


            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Ürün Adı : " + urun.Adi + " : " + "Ürün Fiyatı :" + urun.Fiyati);
            }

            Console.WriteLine("---------------Metotlar------------------");

            //İnstance  -- Class ÖRNEĞİ
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Kiraz", "Kırmızı Kiraz", 15, 3);




        }

    }
}
