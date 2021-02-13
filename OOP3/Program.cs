using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager ihtiyacCreditManager = new IhtiyacCreditManager();
            ICreditManager carCreditManager = new CarCreditManager();
            ICreditManager konutCreditManager = new KonutCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();



            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(carCreditManager, fileLoggerService);

            List<ICreditManager> krediler = new List<ICreditManager>() { ihtiyacCreditManager, carCreditManager, konutCreditManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
