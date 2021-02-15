using GameProject.Entitites.Absract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entitites.Concrete
{
    public class Order:IEntity
    {
        public int OrderId { get; set; }
        public int CampaignId { get; set; }
        public int UserId { get; set; }
        public int GameId { get; set; }
        public DateTime OrderDate { get; set; }
        public double OrderPrice { get; set; }
    }
}
