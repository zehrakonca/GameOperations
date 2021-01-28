using GameOperations.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOperations.Property;

namespace GameOperations.Services
{
    class GameService : IGameService
    {
        List<Game> games = new List<Game>() { };
        public void Add(Game game)
        {
            games.Add(game);
            Console.WriteLine("{1} adlı oyun sisteme eklendi.", game.ID, game.gameName);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("{0} adlı oyun sistemden silinmiştir.", game.gameName);
        }

        public void Update(Game game)
        {
            Console.WriteLine("{0} adlı oyunun özellikleri güncellendi.", game.gameName);
        }
        public void ShowGame()
        {
            int i = 1;
            foreach (Game game in games)
            {
                Console.WriteLine("______________________________");
                Console.WriteLine("{0} . Oyunun Adı: {1}\n" +
                                  "Oyunun Yayıncısı: {2}\n" +
                                  "Oyunun fiyatı   : {3} TRY" ,
                                  i, game.gameName, game.gamePublisher,
                                  game.gamePrice);
                Console.WriteLine("______________________________");
                i += 1;
            }
        }

    }
}
