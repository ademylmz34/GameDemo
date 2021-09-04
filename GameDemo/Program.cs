using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player()
            {
                FirstName="Adem",
                LastName="Yılmaz",
                DateOfBirth=new DateTime(1997,9,14),
                NationalityId="78966547124"
            };
            Player player2 = new Player()
            {
                FirstName = "Arif",
                LastName = "Göze",
                DateOfBirth = new DateTime(1998, 1, 22),
                NationalityId = "25308898785"
            };
            Player player3 = new Player()
            {
                FirstName = "Semih",
                LastName = "Gökdere",
                DateOfBirth = new DateTime(1997, 3, 16),
                NationalityId = "45677985214"
            };
            Campaign campaign = new Campaign()
            {
                CampaignName="Half Price",
                Date=DateTime.Now,
                Discount=20
            };
            
            PlayerManager player = new PlayerManager(new MernenServiceAdapter());//with mernis system
            player.Add(player1);

            PlayerManager fakeplayer = new PlayerManager(new Concrete.CheckPlayerManager());
            fakeplayer.Add(player1); //without mernis system

            fakeplayer.Delete(player2);
            fakeplayer.Update(player3);

            CampaignManager campaignService = new CampaignManager();
            campaignService.Add(campaign);

            SaleManager sale = new SaleManager();
            sale.Sell(player2,campaign);

            Console.ReadLine();
        }
    }
}
