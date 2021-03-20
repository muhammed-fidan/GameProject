using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Adapters
{
    public class MernisServiceAdapterForFalse : IUserCheckService
    {
        public bool CheckIfRealPerson(User user)
        {
            return false;
        }
    }
}
