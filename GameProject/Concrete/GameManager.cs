using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GameManager : IGameService
    {
        public void SellToUser(User user, Game game)
        {
            Console.WriteLine(game.GameName + " "+ " oyunu " + " " + user.FirstName + " "+ user.LastName + " " + "tarafından başarıyla satın alındı.");
        }
        
        public void SellToUserWithCampaign(User user, Game game, Campaign campaign)
        {
            decimal discountedPrice = game.Price - campaign.CampaignOfferPrice;
            Console.WriteLine(game.GameName + " " + " oyunu " + campaign.CampaignName + " kampanyasi dahilinde " + discountedPrice + "TL'ye kampanyalı fiyatıyla " + user.FirstName + " " + user.LastName + " " + "tarafından başarıyla satın alındı.");
        }
    }
}
