using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IGameOrderService
    {
        void Selling(GameOrder gamerOrder,Gamer gamer,Campaing campaing);
    }
}
