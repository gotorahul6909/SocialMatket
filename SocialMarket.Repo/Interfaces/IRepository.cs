using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SocialMarket.Repo.Interfaces
{
    public interface IRepository<TEntity>
        where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate);
        Task<TEntity> Find(int id);
        Task Add(TEntity entity);
        Task Delete(TEntity entity);
        Task UpdateState(TEntity entity);
        Task Delete(int entityId);
        Task Delete(IEnumerable<TEntity> entities);
        Task<TEntity> AddAsync(TEntity entity);
    }
}
