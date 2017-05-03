using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace MigrationsDemo.DataAccessLayer
{
    interface IRespository<TEntity> : IDisposable where TEntity : class
    {
        IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "");
        IEnumerable<TEntity> GetAll();
        TEntity GetByID(object id);
        void Insert(TEntity entity);
        void Delete(object id);
        void Delete(TEntity entityToDelete);
        void Update(TEntity entityToUpdate);
        void AddOrUpdate(TEntity entityToUpdate);
    }
}
