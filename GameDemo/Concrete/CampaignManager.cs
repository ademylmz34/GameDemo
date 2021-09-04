using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign Named as a "+campaign.CampaignName +" has been added on "+campaign.Date);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Campaign Named as a " + campaign.CampaignName + " has been deleted");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign Named  as a " + campaign.CampaignName + " has been updated");
        }
    }
}
