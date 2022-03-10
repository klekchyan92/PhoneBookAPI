using Microsoft.EntityFrameworkCore;
using PhoneBookAPI.BLL.Interfaces;
using PhoneBookAPI.DAL;
using PhoneBookAPI.DAL.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBookAPI.BLL.Services
{
    public class UserService : Repository<User>, IUserService
    {

        public UserService(PhoneBookContext context) : base(context)
        {
           
        }

        public  User Add(User user)
        {
            _phoneBookContext.Users.Add(user);
            _phoneBookContext.SaveChanges();
            return user;
        }

        public  void Delete(User user)
        {
            var existingUser = _phoneBookContext.Users.FirstOrDefault(u => u.Id == user.Id);

            if (existingUser is null)
                throw new Exception("User Not Found");

            _phoneBookContext.Users.Remove(existingUser);
            _phoneBookContext.SaveChanges();
        }

        public  void Update(User user)
        {
            var existingUser = _phoneBookContext.Users.FirstOrDefault(u => u.Id == user.Id);

            if (existingUser is null)
                throw new Exception("User Not Found");

            SetData(user, existingUser);

            _phoneBookContext.Users.Update(existingUser);
            _phoneBookContext.SaveChanges();
        }

        public async Task<User> GetAsync(int id)
        {
            var existingUser = await _phoneBookContext.Users.FirstOrDefaultAsync(u => u.Id == id);

            if (existingUser is null)
                throw new Exception("User Not Found");

            return existingUser;
        }

        public void SetData(User user,User existingUser)
        {
            existingUser.FirstName = user.FirstName;
            existingUser.LastName = user.LastName;
            existingUser.MiddleName = user.MiddleName;
            existingUser.OrganizationName = user.OrganizationName;
            existingUser.Phones = user.Phones;
            existingUser.Emails = user.Emails;
        }
    }
}
