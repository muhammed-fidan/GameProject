using GameProject.Abstract;
using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User{Id=1, DateOfBirth = new DateTime(1997,3,22), FirstName="Muhammed",LastName="Fidan", NationalityNo = "15745841225" };
            
            BaseUserManager userManager = new UserManager(new MernisServiceAdapterForTrue()); //Yanlış doğrulama yapmak için False olan service kullanılmalı. Tamamen simule edilmiştir.
            
            userManager.Add(user);
            
            userManager.Delete(user);
            
            userManager.Update(user);
            
            CampaignManager campaignManager = new CampaignManager();
            
            Campaign campaign = new Campaign {CampaignId=2,CampaignName="NE ALIRSAN %10 İNDİRİM!", CampaignOfferPrice=30 };
            
            campaignManager.AddCampaign(campaign);
            
            campaignManager.DeleteCampaign(campaign);
            
            campaignManager.UpdateCampaign(campaign);
            
            Game game = new Game { GameId = 1, GameName = "CsGo", Price=200 };
            
            GameManager gameManager = new GameManager();
            
            gameManager.SellToUser(user, game);
            
            gameManager.SellToUserWithCampaign(user, game,campaign);

            Console.ReadLine();

        }
    }
}
