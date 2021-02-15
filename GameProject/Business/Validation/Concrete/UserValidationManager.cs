using GameProject.Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Validation.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName.Length+gamer.LastName.Length>3&&gamer.BirthYear>1920)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
