using GameManagementProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameManagementProject.Entities
{
    class Campaing:ICampaingService
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public int Discont { get; set; }

    }
}
