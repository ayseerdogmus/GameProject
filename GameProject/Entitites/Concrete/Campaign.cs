using GameProject.Entitites.Absract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entitites.Concrete
{
    public class Campaign:IEntity
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public int DiscountRate { get; set; }
    }
}
