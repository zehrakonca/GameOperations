using GameOperations.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOperations.Property;

namespace GameOperations.Services
{
    class OrderServices : IOrderServices
    {
        public void Buy(User user,Game game)
        {
            Console.WriteLine("{0} {1} adlı kişi, {2} oyununu satın aldı.", user.FirstName, user.LastName,game.gameName);
        }

        public void Rebate(User user, Game game)
        {
            return;
        }
    }
}
