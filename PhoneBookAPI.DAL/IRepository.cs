using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookAPI.DAL
{
    public interface IRepository<TEntity> where TEntity : IEntity
    {
        public IQueryable<TEntity> DbSet { get; }
        TEntity Add(TEntity entity);
        Task<TEntity> GetAsync(int id);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
