using GameProject.Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Validation
{
    public interface IUserValidationService
    {
        public bool Validate(Gamer gamer);

    }
}
