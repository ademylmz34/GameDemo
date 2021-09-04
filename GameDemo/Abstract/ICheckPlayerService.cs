using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo
{
    interface ICheckPlayerService
    {
        bool CheckIfRealPerson(Player player); 
    }
}
