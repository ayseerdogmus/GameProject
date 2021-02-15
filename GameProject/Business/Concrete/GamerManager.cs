using GameProject.Business.Abstract;
using GameProject.Business.Validation;
using GameProject.Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Concrete
{
    public class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Oyuncu eklendi.");
            }
            else
            {
                Console.WriteLine("Oyuncu eklenemedi.");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu güncellendi.");
        }
    }
}
