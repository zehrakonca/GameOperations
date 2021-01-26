using GameOperations.Managers;
using GameOperations.Interfaces;
using GameOperations.Property;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOperations.Campaign;

namespace GameOperations
{
    class Program
    {
        static void Main(string[] args)
        {

            IPerson admin = new Admin()
            {
                ID = 1,
                Name = "Ron",
                Surname = "Weasley",
                Username = "kingWeasley",
                Password = "1234",
                BirthDay = "10/03/1980",
                IdentityNumber = "45678912345",
                MailAddres = "ron-weasley@hogwarts.edu",
                Telephone = "12345678911",
                Role = "Admin"
            };

            IPerson player1 = new Player()
            {
                ID = 1,
                Name = "Severus",
                Surname = "Snape",
                Username = "SeverusSnape",
                BirthDay = "01/03/1920",
                IdentityNumber = "78945612355",
                MailAddres = "severusSnape@hogwarts.edu",
                Telephone = "32178965471",
                Role = "Gamer"
            };

            PlayerManager playerManager = new PlayerManager();
            playerManager.Add(admin, admin.IdentityNumber);
            playerManager.Update(player1, player1.ID);
            playerManager.Delete(player1, player1.ID);
            playerManager.ShowPlayer();
            Game game1 = new Game() { ID = 1, Name = "League Of Legends",
                                      Publisher = "Riot Games",Type = "Action",
                                      Price = 50 };

            Game game2 = new Game(){ ID = 1, Name = "Baby Shark in Danger",
                                     Publisher = "Shark Games",Type = "Action,Mystery",
                                     Price = 24.49 };
            GameManager gameManager = new GameManager();
            gameManager.Add(game1, game1.Name);
            gameManager.Add(game2, game2.Name);
            gameManager.ShowGame();
            ICampaignService campaign = new Student();
            gameManager.GetGame(game1.Name, campaign);
            gameManager.GetGame(game2.Name, campaign);

            BuyGameManager buyG = new BuyGameManager();
            buyG.BuyGame(player1, game1);
            buyG.BuyGame(admin, game2);

            Console.ReadKey();
        }
    }
}
