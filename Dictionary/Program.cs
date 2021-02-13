using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, string> Ogrenciler = new Dictionary<int, string>();
            //Ogrenciler.Add(1, "Arif ORAK");
            //Ogrenciler.Add(2, "Kübra ORAK");
            //Ogrenciler.Add(3, "Emir ORAK");
            //Ogrenciler.Add(4, "Arda ARDAHANLIOĞLU");
            //foreach (var dict in Ogrenciler)
            //{
            //    Console.WriteLine(dict);
            //}

            MyDictionary<int, string> Sozluk1 = new MyDictionary<int, string>();
            Sozluk1.Add(1,"Arif ORAK");
            Sozluk1.Add(2,"Kübra ORAK");
            Sozluk1.Add(3,"Emir ORAK");

            Console.WriteLine(Sozluk1);



        }

       
    }

   
}
