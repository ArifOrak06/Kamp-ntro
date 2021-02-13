using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameOrderManager : IGameOrderService
    {
        public void Selling(GameOrder gameOrder, Gamer gamer, Campaing campaing)
        {
            Console.WriteLine(gamer.FirstName + " isimli oyuncu tarafından " + gameOrder.GameCompanyName + " isimli oyun " + campaing.CampaingContent + " kampanyasının indiriminden faydalanılarak " + gameOrder.GamePrice + " Türk Lirası bedel ile satın alınmıştır.");
        }
    }
}
