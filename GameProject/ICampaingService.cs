using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaingService
    {
        void CampaingAdd(Campaing campaing);
        void CampaingUpdate(Campaing campaing);
        void CampaingDelete(Campaing campaing);

    }
}
