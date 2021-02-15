using GameProject.Business.Abstract;
using GameProject.Entitites.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business.Concrete
{
    public class UserManager : IUserService
    {
        public void Add(User user)
        {
            Console.WriteLine("Kullanıcı eklendi.");
        }

        public void Delete(User user)
        {
            Console.WriteLine("Kullanıcı silindi.");
        }

        public void Update(User user)
        {
            Console.WriteLine("Kullanıcı güncellendi.");
        }
    }
}
