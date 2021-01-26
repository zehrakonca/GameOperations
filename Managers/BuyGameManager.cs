using GameOperations.Interfaces;
using GameOperations.Property;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOperations.Managers
{
    class BuyGameManager 
    {
        List<BuyerPerson> buyerPerson = new List<BuyerPerson>() { };
        public void BuyGame(IPerson player, IGame game)
        {
            Console.WriteLine("{0} adlı kişi, {1} oyununu satın aldı.",player.Username,game.Name);
        }
    }
}
