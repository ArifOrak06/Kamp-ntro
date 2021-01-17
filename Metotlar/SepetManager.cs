using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention  -- Fonksiyon = Metot
        public void Ekle(Urun urun) 
        {
            Console.WriteLine("Tebrikler..Sepete Eklendi : " + urun.Adi);        
        }
        public void Ekle2(string urunAdi, string urunAciklamasi, int urunFiyati, int stokAdedi) 
        {
            Console.WriteLine("Sepete Eklendi!" + urunAdi);
        }    
}
