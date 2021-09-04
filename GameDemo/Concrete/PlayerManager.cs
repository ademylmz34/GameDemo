using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo
{
    class PlayerManager : IPlayerService
    {
        private ICheckPlayerService _checkPlayerService;
        public PlayerManager(ICheckPlayerService checkPlayerService)
        {
            _checkPlayerService = checkPlayerService;
        }

        public void Add(Player player)
        {
            if(_checkPlayerService.CheckIfRealPerson(player))
            {
                Console.WriteLine(player.FirstName+ " Added");
            }
            else
            {
                Console.WriteLine("Not a Valid Person");
            }
        }

        public void Delete(Player player)
        {

            if (_checkPlayerService.CheckIfRealPerson(player))
            {
                Console.WriteLine(player.FirstName + " Deleted");
            }
            else
            {
                Console.WriteLine("Not a Valid Person");
            }

        }

        public void Update(Player player)
        {

            if (_checkPlayerService.CheckIfRealPerson(player))
            {
                Console.WriteLine(player.FirstName + " Updated");
            }
            else
            {
                Console.WriteLine("Not a Valid Person");
            }


        }
    }
}
