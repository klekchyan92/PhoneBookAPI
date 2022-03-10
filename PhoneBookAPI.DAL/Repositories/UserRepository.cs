using PhoneBookAPI.DAL.Entities;
using PhoneBookAPI.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookAPI.DAL.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly PhoneBookContext _context;

        public UserRepository(PhoneBookContext context) : base(context)
        {
            _context = context;
        }
    }
}
