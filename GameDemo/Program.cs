using System;


namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer();
            gamer.GamerId = 1;
            gamer.IdentityNumber = 123456789;
            gamer.FirstName = "Atalay";
            gamer.LastName = "Topçu";
            gamer.BirthdayDate = 1997;

            Campaign campaign = new Campaign();
            campaign.CampaignId = 484;
            campaign.CampaignName = "Sonbahar indirimleri";
            campaign.Discount = 0.1;
            campaign.CampaignDuration = " 3 Ay ";

            Game game = new Game();
            game.GameId = 1298;
            game.GameName = "Cities Skylines";
            game.GamePrice = 15;

            SaleManager saleManager = new SaleManager();
            saleManager.SaleService(gamer,campaign, game);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);

            GameManager gameManager = new GameManager();
            gameManager.Delete(game);

            GamerManager gamerManager = new GamerManager();
            gamerManager.Update(gamer);
            
        }
    }
}
