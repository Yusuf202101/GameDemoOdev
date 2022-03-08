using System;

namespace GameDemo
{
    class SaleManager : ISaleService
    {
        public void SaleService(Gamer gamer, Campaign campaign, Game game)
        {
            Console.WriteLine(gamer.FirstName+ "adlı oyuncu"+campaign.CampaignName+ "adlı kampanyayı kullanarak"+ (game.GamePrice-(campaign.Discount*game.GamePrice)) +"liraya satın aldı...");
        }
    }
}
