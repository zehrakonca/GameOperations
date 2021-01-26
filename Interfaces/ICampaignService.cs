using GameOperations.Property;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOperations.Interfaces
{
    interface ICampaignService
    {
        void CalculateCampaign(IGame name);
    }
}
