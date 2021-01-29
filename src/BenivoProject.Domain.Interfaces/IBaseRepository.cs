using BenivoProject.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BenivoProject.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<T> Get(long id);
        IQueryable<T> GetAll();
        IQueryable<T> GetAllNoTracking();
        IQueryable<T> GetNoTracking(Expression<Func<T, Boolean>> predicate, params String[] includes);
        Task Insert(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task SaveChanges();
    }
}
