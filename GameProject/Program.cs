using GameProject.Business.Concrete;
using GameProject.Business.Validation.Concrete;
using GameProject.Entitites.Concrete;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //GamerTest();
            //CampaignTest();
            //GameTest();
            //OrderTest();

        }

        private static void OrderTest()
        {
            OrderManager orderManager = new OrderManager();
            orderManager.Add(new Order { OrderId = 1, UserId = 1, GameId = 1, CampaignId = 1, OrderPrice = 3300, OrderDate = new DateTime(2020, 03, 26) });
            orderManager.Update(new Order { OrderId = 1, UserId = 1, GameId = 1, CampaignId = 1, OrderPrice = 3500, OrderDate = new DateTime(2020, 04, 04) });
            orderManager.Delete(new Order { OrderId = 1 });
        }

        private static void GameTest()
        {
            GameManager gameManager = new GameManager();
            gameManager.Add(new Game { GameId = 1, GameCompany = "EA GAMES", GameName = "FIFA 21", GamePrice = 350 });
            gameManager.Update(new Game { GameId = 1, GameCompany = "SEGA", GameName = "Alien: Isolation", GamePrice = 3300 });
            gameManager.Delete(new Game { GameId = 1 });
        }

        private static void CampaignTest()
        {
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign { CampaignId = 1, CampaignName = "Gaming Fest", DiscountRate = 20 });
            campaignManager.Update(new Campaign { CampaignId = 1, CampaignName = "Gaming Festival", DiscountRate = 40 });
            campaignManager.Delete(new Campaign { CampaignId = 1 });
        }

        private static void GamerTest()
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                FirstName = "Ayşe",
                LastName = "Ayşe",
                BirthYear = 1923,
                UserId = 1,
                UserName = "gamer"

            });
            gamerManager.Delete(new Gamer { Id = 1 });
            gamerManager.Update(new Gamer
            {
                Id = 1,
                FirstName = "Deniz",
                LastName = "Deniz",
                BirthYear = 1923,
                UserId = 1,
                UserName = "denizgamer"
            });
        }
    }
}
