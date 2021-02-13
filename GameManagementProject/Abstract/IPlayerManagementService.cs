using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagementProject.Abstract
{
    interface IPlayerManagementService
    {
        void Add(IPlayerService playerService);
        void Update(int Id, IPlayerService playerService);
        void Delete(IPlayerService playerService);
        void List();

    }
}
