using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PhoneBookAPI.DAL;
using PhoneBookAPI.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookAPI.BLL
{
    public class UserBLL : IUserBLL
    {
        //readonly IMapper _mapper;
        readonly IUnitOfWork _uow;

        public UserBLL(Iuserservice uow)
        {
            //_mapper = mapper;
            _uow = uow;
        }

        public async Task Create(User model)
        {
            //var user = _mapper.Map<User>(model);

            //if (user.Emails.Count() > 0)
            //    user.Emails.First().IsMain = true;
            //else
            //    throw new Exception("Email is required");

            //if (user.Phones.Count() > 0)
            //    user.Phones.First().IsMain = true;
            //else
            //    throw new Exception("Email is required");

            _uow.Repository<User>().Add(model);
            await _uow.SaveAsync();
        }

        public async Task Delete(int id)
        {
            var user = await _uow.Repository<User>().DbSet.FirstOrDefaultAsync(u => u.Id == id);
            if (user is null)
                throw new Exception("User Not Found");

            _uow.Repository<User>().Delete(user);
            await _uow.SaveAsync();
        }

        public async Task<User> Get(int id)
        {
            var user = await _uow.Repository<User>().DbSet.FirstOrDefaultAsync(u => u.Id == id);
            if (user is null)
                throw new Exception("User not found");

            return user;
        }

        public async Task<List<User>> GetAll()
        {
            return await _uow.Repository<User>().DbSet.ToListAsync();
        }

        public async Task Update(User model)
        {
            var user = await _uow.Repository<User>().DbSet.FirstOrDefaultAsync(u => u.Id == model.Id);
            if (user is null)
                throw new Exception("User not found");

            //if (model.Emails.Count() > 0)
            //    model.Emails.First().IsMain = true;
            //else
            //    throw new Exception("Email is required");

            //if (model.Phones.Count() > 0)
            //    model.Phones.First().IsMain = true;
            //else
            //    throw new Exception("Email is required");

            
            _uow.Repository<User>().Update(model);
            await _uow.SaveAsync();
        }
    }
}
