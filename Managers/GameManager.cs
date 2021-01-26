using GameOperations.Interfaces;
using GameOperations.Property;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOperations.Managers
{
    class GameManager
    {
        List<IGame> games = new List<IGame>() { };
        Game game = new Game();
        public void Add(Game game, string gameName)
        {
            games.Add(game);
            Console.WriteLine("{1} adlı oyun sisteme eklendi.", game.ID, game.Name);
        }

        public void Delete(int ID)
        {

            Console.WriteLine("{0} adlı oyun sistemden silinmiştir.", game.Name);
        }
        public void Update(int ID)
        {
            Console.WriteLine("{0} adlı oyunun özellikleri güncellendi.", game.Name);
        }
        public void ShowGame()
        {
            int i = 1;
            foreach (IGame game in games)
            {
                Console.WriteLine("_____________________");
                Console.WriteLine("{0} . Oyunun Adı: {1}\n"
                                 +"Oyunun Yayıncısı: {2}\n" +
                                  "Oyunun Türü : {3}\n" +
                                  "Oyunun fiyatı : {4} TRY",
                                  i,game.Name,game.Publisher,
                                  game.Type,game.Price);
                Console.WriteLine("_____________________");
                i += 1;
            } 
        }
        public void GetGame(string gameName,ICampaignService campaign)
        {
            foreach (var game in games)
            {
                if (game.Name == gameName)
                {
                    campaign.CalculateCampaign(game);
                }
                else
                {
                    Console.WriteLine("İndirimi hesaplarken sorun oluştu.Tekrar deneyin.");
                }
            }
        }
    }
}
