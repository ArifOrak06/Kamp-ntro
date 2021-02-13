using GameManagementProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagementProject.Concrete
{
    class PlayerManager : IPlayerManagementService
    {
        private List<IPlayerService> players = new List<IPlayerService>();
        public void Add(IPlayerService playerService)
        {
            players.Add(playerService);
            Console.WriteLine("Oyuncu Sisteme Eklenmiştir  = " + playerService.FirstName);
        }

        public void Delete(IPlayerService playerService)
        {
            players.Remove(playerService);
        }

        public void List()
        {
            foreach (var player in players)
            {
                Console.WriteLine("Sistemde Kayıtlı oyuncular : " + player.FirstName + player.LastName );

            }
        }

        public void Update(int Id, IPlayerService playerService)
        {
            foreach (var player in players)
            {
                player.FirstName = (player.Id == Id) ? playerService.FirstName : player.FirstName;
                player.LastName = (player.Id == Id) ? playerService.LastName : player.LastName;
                player.NationalityId = (player.Id == Id) ? playerService.NationalityId : player.NationalityId;
                player.YearOfBirth = (player.Id == Id) ? playerService.YearOfBirth : player.YearOfBirth;

                Console.WriteLine("Bilgileriniz Başarıyla Güncellenmiştir.");
            }
           
        }
    }
}
