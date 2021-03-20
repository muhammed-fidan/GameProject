using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    public interface IGameService
    {
        void SellToUser(User user, Game game);
        void SellToUserWithCampaign(User user, Game game, Campaign campaign);
    }
}
