using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Entities;


namespace GameProject.Abstract
{
    abstract class BaseGameManager : IGameService
    {
        public void GameAdd(Game game)
        {
            Console.WriteLine("Game Added : " + game.Name);
        }

        public void GameDelete(Game game)
        {
            Console.WriteLine("Game Deleted : " + game.Name);
        }
        public void GameUpdate(Game game)
        {
            Console.WriteLine("Game Updated : " + game.Name);
        }
    }
}
