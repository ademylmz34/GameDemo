using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo
{
    interface ISaleService
    {
        void Sell(Player player,Campaign campaign);
    }
}
