using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaingManager : ICampaingService
    {
        public void CampaingAdd(Campaing campaing)
        {
            Console.WriteLine("Kampanya sisteme başarılı bir şekilde eklenilmiştir.");
        }

        public void CampaingDelete(Campaing campaing)
        {
            Console.WriteLine("Kampanya süresinin bitmesi nedeniyle silinmiştir.");     
        }

        public void CampaingUpdate(Campaing campaing)
        {
            Console.WriteLine("Sistemde kayıtlı bulunan kampanya güncellenmiştir.");
        }
    }
}
