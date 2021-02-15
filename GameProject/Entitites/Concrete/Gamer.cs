using GameProject.Entitites.Absract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entitites.Concrete
{
    public class Gamer : User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string CreditCardNumber { get; set; }
     
    }
}
