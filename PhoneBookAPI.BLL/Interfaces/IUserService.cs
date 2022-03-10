using PhoneBookAPI.DAL;
using PhoneBookAPI.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookAPI.BLL.Interfaces
{
    public interface IUserService : IRepository<User>
    {

    }
}
