using System;

namespace TernanyOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            // Şart blokları yerine tek satırda durumları kontrol etmemize yaramaktadır.
            // Kural olarak değişkene atamasını istediğimiz değer eğer değişkenin veri tipi string ise Operatörlerin döndüreceği tip de string olmalıdır..!
            bool medeniHal = true;
            string mesaj = medeniHal == true ? "Evlilere Kampanya" : "Bekarlara Kampanya";
            Console.WriteLine(mesaj);
        }
    }
}
