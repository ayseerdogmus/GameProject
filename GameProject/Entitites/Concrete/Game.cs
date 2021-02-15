using GameProject.Entitites.Absract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entitites.Concrete
{
    public class Game:IEntity
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public string GameCompany { get; set; }
        public double GamePrice { get; set; }
    }
}
