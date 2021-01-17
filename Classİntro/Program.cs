using System;

namespace Classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Arif ORAK";
            kurs1.İzlenmeOrani = 75;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.Egitmen = "Arif ORAK";
            kurs2.İzlenmeOrani = 60;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "JAVA";
            kurs3.Egitmen = "Arif ORAK";
            kurs3.İzlenmeOrani = 100;

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3};

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ": " + kurs.Egitmen);
            }

        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int İzlenmeOrani { get; set; }
    }   
}
