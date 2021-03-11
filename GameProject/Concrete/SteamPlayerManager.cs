using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
     class SteamPlayerManager : BasePlayerManager
    {
        private IPlayerCheckService _playerCheckService;

        public SteamPlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public override void Add(Player player)
        {
            if (_playerCheckService.CheckIfRealPlayer(player))
            {
                base.Add(player);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }
    }
}
