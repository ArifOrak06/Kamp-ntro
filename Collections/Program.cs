using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[]
            //{
            //    "Arif", "Kübra", "Emir"
            //};
            //// Array indexleri 0'dan başlar.
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            // Eğer arrayi genişletmek isteyip veri eklerseniz  isimler = new string[5] ancak bir önceki liste yok olup yeni değer 5 indexli yeni bir array oluşturmuş oluruz. 
            // Listeler ve oluşturmak = Biz listeleri arraylari genişletemediğimiz için kullanırız. Daha kullanışlıdır.
            List<string> isimler2 = new List<string> { "Arif", "Kübra", "Emir"};

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);

            // String olarak oluşturulan  Listeye string veri eklemek

            isimler2.Add("Alparslan");
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[0]);

        }
    }
}
