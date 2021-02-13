using GameManagementProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagementProject.Entities
{
    class Game:IGameService
    {
        public int Id { get; set; }
        public string GameCompanyName { get; set; }
        public double GamePrice { get; set; }

    }
}
