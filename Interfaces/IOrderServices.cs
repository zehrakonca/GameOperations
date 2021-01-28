using GameOperations.Property;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOperations.Interfaces
{
    interface IOrderServices
    {
        void Buy(User user,Game game);
        void Rebate(User user,Game game);
    }
}
