using GameProject.Entitites.Absract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entitites.Concrete
{
    public class User:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public long IdentityNumber { get; set; }
    }
}
