using GameOperations.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOperations.Property;

namespace GameOperations.Campaign
{
    class BlackFriday : ICampaignService
    {
        public void CalculateCampaign(Game game)
        {
            game.gamePriceAfter = game.gamePrice - game.gamePrice * (0.70);
            Console.WriteLine("{0} isimli oyuna Black Friday kampanyası uygulandı.\n"+
                              "Ürünün Eski Fiyatı : {1} TRY"+
                              "Ürünün Yeni fiyatı : {2} TRY", game.gameName, game.gamePrice,game.gamePriceAfter);
        }
    }
}
