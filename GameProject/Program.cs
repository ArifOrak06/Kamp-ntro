using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer { Id= 1, BirthYear=1991, FirstName="ARİF", LastName="ORAK", IdentityNumber=12345 };
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer1);

            // Oyun Satışının Oyuncu İle İlişkilendirimesi

            GameOrder game1 = new GameOrder { GameId = 1, GameCompanyName = "War Craft", GamePrice = 123 };
            GameOrderManager gameOrderManager = new GameOrderManager();
            //gameOrderManager.Selling(game1, gamer1, campaing1);

            // Kampanya Ekleme, Silme, Güncelleme

            Campaing campaing1 = new Campaing
            { 
            CompaingId = 1, 
            CampaingContent ="Tüm ürünlerde indirim zamanı",
            CompanyTime="2 ay",
            Discont=100
            };

            gameOrderManager.Selling(game1, gamer1, campaing1);
        }
    }
}
