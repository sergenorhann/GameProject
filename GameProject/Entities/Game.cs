using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;

namespace GameProject.Entities
{
    class Game : IEntity
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public Double Price { get; set; }
    }
}
