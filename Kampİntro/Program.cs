using System;

namespace Kampİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sınırsız metin verisi string ile tanımlanır " " içerisine yazılır.
            string kategoriEtiketi = "Kategori";

            //tam sayıları tutar ancak limiti var
            int ogrenciSayisi = 32000;

            //double veri tipi
            double faizOrani = 1.25;

            //boolean veraibles  True or False durumunu kontrol etmemizi sağlar.
            bool sistemeGirisYapmisMi = true;

            // Şart parantez içerisine yazılır. Şart geçerli ise al süslü parantez bloğu çalışır.
            if(sistemeGirisYapmisMi == true) 
            {
                Console.WriteLine("Sisteme Hoşgeldiniz");
            }
            else 
            {
                Console.WriteLine("Giriş Yapınız.");
            }

          



        }
    }
}
