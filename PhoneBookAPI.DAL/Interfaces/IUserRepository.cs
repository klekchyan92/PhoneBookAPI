using PhoneBookAPI.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookAPI.DAL.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        //User GetUserById(int id);
        //User Create(User user);
    }
}
