using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    class PlayerCheckManager : IPlayerCheckService
    {
        public bool CheckIfRealPlayer(Player player)
        {
            return true;
        }
    }
}
