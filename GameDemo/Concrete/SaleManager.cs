using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo
{
    class SaleManager : ISaleService
    {
        public void Sell(Player player, Campaign campaign)
        {
            Console.WriteLine("User Named as "+player.FirstName+" has sold his/her game with a discount of " + campaign.Discount+" TL");
        }
    }
}
