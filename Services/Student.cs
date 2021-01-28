using GameOperations.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOperations.Property;

namespace GameOperations.Campaign
{
    class Student : ICampaignService
    {
        public void CalculateCampaign(ICampaignService campaign, Game game)
        {
            game.gamePriceAfter = game.gamePrice - game.gamePrice * (0.50);
            Console.WriteLine("{0} isimli oyuna Öğrenci kampanyası uygulandı.\n" +
                              "Ürünün Eski Fiyatı : {1} TRY\n" +
                              "Ürünün Yeni fiyatı : {2} TRY", game.gameName, game.gamePrice, game.gamePriceAfter);
        }
    }
}
