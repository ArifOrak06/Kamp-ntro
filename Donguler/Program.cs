using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";

            //array - dizi
            // bir değişkjeni değil birden fazla değişkeni liste içerisinde tutmak/kullanmak
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya Başlangıç İçin Temel Kurs",
                "Java" };

            // i++ - birer birer artır demektir.
            for(int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For Bitti");
            // Yukarıda ki döngüde sayacımızı 0 dan başlattık, çünkü programlama dilleri her zaman 0'dan başlar,
            // Ayrıca  şartımızı ise array içerisinde 3 elemanımız olduğu için 3'ten küçük olduğu müddetçe dön dedik.
            // Ancak halen bir dinamizm yok eğer yeni bir kurs eklersek bu sefer o kursu ekrana dönemeyeceğiz çünkü şartımıza 3 rakamı var
            // dinamizim kazandırmak için .Length fonksiyonundan yararlanırız.
            // Şimdi DÖngülerin bir diğer kullanımını öğrenelim pythona benzer for döngüsü. 
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa Sonu");
        }
    }
}
