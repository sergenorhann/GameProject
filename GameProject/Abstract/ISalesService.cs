using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Entities;

namespace GameProject.Abstract
{
    interface ISalesService
    {
        void Sall(Player player, Game game, Campaign campaign);
        void Sall(Player player, Game game);

    }
}
