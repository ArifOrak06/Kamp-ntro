using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteriler musteri01 = new Musteriler();
            musteri01.İd = 1;
            musteri01.AdSoyad = "Arif ORAK";
            musteri01.HesapTuru = "Vadeli Hesap";
            musteri01.TckNo = 123123123;

            Musteriler musteri02 = new Musteriler();
            musteri02.İd = 2;
            musteri02.AdSoyad = "Kübra ORAK";
            musteri02.HesapTuru = "Vadesiz Hesap";
            musteri02.TckNo = 123456123;

            Musteriler musteri03 = new Musteriler();
            musteri03.İd = 3;
            musteri03.AdSoyad = "Emir ORAK";
            musteri03.HesapTuru = "Vadesiz Hesap";
            musteri03.TckNo = 321654789;

            Musteriler[] musteriler = new Musteriler[] { musteri01, musteri02, musteri03 };
            //foreach (Musteriler musteri in musteriler) 
            //{
             //   Console.WriteLine(" Müşteri Adı ve Soyadı : " + musteri.AdSoyad);
               // Console.WriteLine(" Müşteri Hesap Türü : " + musteri.HesapTuru);
            //}

            MüsterilerManager musteriManager = new MüsterilerManager();
            musteriManager.Ekle(musteri01);
            musteriManager.Sil(musteri02);
            musteriManager.Listele(musteri03);

        }
    }
}
