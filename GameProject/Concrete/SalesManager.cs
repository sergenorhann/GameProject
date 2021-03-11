using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    class SalesManager : ISalesService
    {
        public void Sall(Player player, Game game, Campaign campaign)
        {
            game.Price = game.Price * campaign.Amount / 100;
            Console.WriteLine($"{game.Name.ToUpper()} was sold to {player.FirstName.ToUpper()} for {Math.Round(game.Price, 2)} with the {campaign.Name}");

        }
        
        public void Sall(Player player, Game game)
        {
            Console.WriteLine($"{game.Name.ToUpper()} was sold to {player.FirstName.ToUpper()} for {Math.Round(game.Price,2)}");
        }
    }
}
