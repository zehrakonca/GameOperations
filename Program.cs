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

            userServices.Add(user1);
            gameServices.Add(game1);
            ICampaignService campaign = new BlackFriday();
            campaign.CalculateCampaign(campaign,game1);


            OrderServices orderService = new OrderServices();
            orderService.Buy(user1, game1);

            userServices.ShowUser();
            gameServices.ShowGame();
            Console.ReadKey();

        }
    }
}
