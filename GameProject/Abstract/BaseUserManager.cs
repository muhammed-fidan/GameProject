using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    public class BaseUserManager : IUserService
    {
        public virtual void Add(User user)
        {
            Console.WriteLine("Sayın: " + user.FirstName + " " + user.LastName + " " + "başarıyla kayıt oldunuz!");
        }

        public virtual void Delete(User user)
        {
            Console.WriteLine("Sayın: " + user.FirstName + " " + user.LastName + " " + "kaydınız silindi.");
        }

        public virtual void Update(User user)
        {
            Console.WriteLine("Sayın: " + user.FirstName + " " + user.LastName + " " + "kaydınız güncellendi.");
        }
    }
}
