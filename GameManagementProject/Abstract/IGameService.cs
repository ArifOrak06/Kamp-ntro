using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagementProject.Abstract
{
    interface IGameService
    {
        int Id { get; set; }
        string GameCompanyName { get; set; }
        double GamePrice { get; set; }
    }
}
