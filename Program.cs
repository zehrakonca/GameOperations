using GameOperations.Campaign;
using GameOperations.Interfaces;
using GameOperations.Property;
using GameOperations.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            UserServices userServices = new UserServices(new UserValidationService());
            User user1 = new User()
            {
                ID = 1,
                FirstName = "ZEHRA",
                LastName = "KONCA",
                BirthYear = 1996,
                IdentityNumber = 12345611111

            };
            GameService gameServices = new GameService();
            Game game1 = new Game()
            {
                ID = 1,
                gameName = "Baby Shark In Danger",
                gamePrice = 100,
                gamePublisher = "Shark Games"
            };
            Game game2 = new Game()
            {
                ID = 2,
                gameName = "PUBG Desktop",
                gamePrice = 45,
                gamePublisher = "PUBG Corporation, Krafton, xFAIRx"
            };
            Game game3 = new Game()
            {
                ID = 3,
                gameName = "Assassin's Creed Valhalla",
                gamePrice = 223.27,
                gamePublisher = "UBISOFT"
            };


            userServices.Add(user1);
            gameServices.Add(game1);
            gameServices.Add(game2);
            gameServices.Add(game3);
            ICampaignService campaign = new BlackFriday();
            campaign.CalculateCampaign(campaign,game3);


            OrderServices orderService = new OrderServices();
            orderService.Buy(user1, game1);

            userServices.ShowUser();
            gameServices.ShowGame();
            Console.ReadKey();

        }
    }
}
