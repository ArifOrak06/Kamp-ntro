using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagementProject.Abstract
{
    interface IGameManagementService
    {
        void Add(IGameService gameService);
        void Update(int ıd, IGameService gameService);
        void Delete(IGameService gameService);
        void List();
    }
}
