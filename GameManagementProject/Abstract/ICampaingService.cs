using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagementProject.Abstract
{
    interface ICampaingService
    {
        int Id { get; set; }
        string CompanyName { get; set; }
        int Discont { get; set; }

    }
}
