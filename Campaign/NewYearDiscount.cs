using GameOperations.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOperations.Property;

namespace GameOperations.Campaign
{
    class NewYearDiscount : ICampaignService
    {
        public void CalculateCampaign(IGame game)
        {
            game.PriceAfter = game.Price - game.Price * (0.60);
            Console.WriteLine("{0} isimli oyuna Yeni Yıl kampanyası uygulandı.\n" +
                             "Ürünün Eski Fiyatı {1} ----" +
                             "Ürünün Yeni fiyatı : {2} TRY", game.Name, game.Price, game.PriceAfter);
        }
    }
}
