using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PhoneBookAPI.DAL
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        protected PhoneBookContext _phoneBookContext;

        public Repository(PhoneBookContext context) => _phoneBookContext = context;

        public IQueryable<TEntity> DbSet => _phoneBookContext.Set<TEntity>();

        public TEntity Add(TEntity entity) => _phoneBookContext.Set<TEntity>().Add(entity).Entity;

        public void Delete(TEntity entity) => _phoneBookContext.Remove(entity);


        public Task<TEntity> GetAsync(int id) => DbSet.AsNoTracking().FirstOrDefaultAsync(x=>x.Id == id);

        public void Update(TEntity entity)
        {
            _phoneBookContext.Set<TEntity>().Attach(entity);
            _phoneBookContext.Set<TEntity>().Update(entity);
        }
    }
}
