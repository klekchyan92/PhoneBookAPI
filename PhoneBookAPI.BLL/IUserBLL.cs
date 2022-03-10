using PhoneBookAPI.BLL.Interfaces;
using PhoneBookAPI.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookAPI.BLL
{
    public interface IUserBLL
    {
        public IUserService UserService { get; }

        Task Create(User model);
        Task Update(User model);
        Task Delete(int id);
        Task<User> Get(int id);
        Task<List<User>> GetAll();
    }
}
