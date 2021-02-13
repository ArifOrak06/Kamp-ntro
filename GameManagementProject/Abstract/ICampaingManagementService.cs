using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagementProject.Abstract
{
    interface ICampaingManagementService
    {
        void Add(ICampaingService campaingService);
        void Delete(ICampaingService campaingService);
        void List();
        void SellGame(IGameService gameService);
    }
}
