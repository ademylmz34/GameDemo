using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    class CheckPlayerManager : ICheckPlayerService
    {
        public bool CheckIfRealPerson(Player player)
        {
            return true;
        }
    }
}
