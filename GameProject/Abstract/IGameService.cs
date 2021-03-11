using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Entities;

namespace GameProject.Abstract
{
    interface IGameService
    {
        void GameAdd(Game game);
        void GameDelete(Game game);
        void GameUpdate(Game game);
    }
}
