using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MüsterilerManager
    {
        public void  Ekle(Musteriler musteri)
        {
            
            Console.WriteLine(musteri.AdSoyad + "başarıyla sisteme eklenmiştir.");
        }
        public void Sil(Musteriler musteri)
        {
            Console.WriteLine(musteri.AdSoyad + "başarıyla sistemden silinmiştir.");
        }
        public void Listele(Musteriler musteri)
        {
            Console.WriteLine("Müşteri Ad Soyad = " + musteri.AdSoyad + "T.C.Kimlik NO = " + musteri.TckNo + "Hesap Türü = " + musteri.HesapTuru);
        }
    }
}
