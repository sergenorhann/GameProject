using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Abstract
{
    abstract class  BasePlayerManager : IPlayerService
    {
        public virtual void Add(Player player)
        {
            Console.WriteLine("Player Added : " + player.UserName);
        }

        public virtual void Delete(Player player)
        {
            Console.WriteLine("Player Deleted : " + player.UserName);
        }

        public virtual void Update(Player player)
        {
            Console.WriteLine("Player Updated : " + player.UserName);
        }
    }
}
