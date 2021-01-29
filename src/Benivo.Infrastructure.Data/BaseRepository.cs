using BenivoProject.Domain.Core;
using BenivoProject.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Benivo.Infrastructure.Data
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly DataContext context;
        private readonly DbSet<T> entities;

        public BaseRepository(DataContext context)
        {
            this.context = context;
            entities = context.Set<T>();
        }
        public IQueryable<T> GetAll()
        {
            return entities.AsQueryable();
        }

        public IQueryable<T> GetAllNoTracking()
        {
            return context.Set<T>().AsNoTracking();
        }
        public IQueryable<T> GetNoTracking(Expression<Func<T, Boolean>> predicate, params String[] includes)
        {
            IQueryable<T> set = context.Set<T>().AsNoTracking();

            for (Int32 i = 0; i < includes.Length; i++)
            {
                set = set.Include(includes[i]);
            }

            if (predicate == null)
            {
                return set;
            }
            else
            {
                return set.Where(predicate);
            }
        }

        public async Task<T> Get(long id)
        {
            return await entities.SingleOrDefaultAsync(s => s.Id == id);
        }
        public async Task Insert(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }        
            await entities.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            await context.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            await context.SaveChangesAsync();
        }       

        public async Task SaveChanges()
        {
            await context.SaveChangesAsync();
        }

    }
}
