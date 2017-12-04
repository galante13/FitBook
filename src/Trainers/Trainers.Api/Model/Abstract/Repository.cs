using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Trainers.Api.Infrastructure;
using Trainers.Api.Model.Context;

namespace Trainers.Api.Model.Abstract
{
    public interface IRepository<T>
    {
        IQueryable<T> Query();
        Task<T> GetAsync(int id);
        Task AddAsync(T entity);
        Task EditAsync(T entity);
        Task DeleteAsync(int id);
        Task DeleteAsync(T entity);
    }

    public class Repository<T> : IRepository<T>
        where T : class, IEntity
    {
        private readonly TrainersContext _context;

        public Repository(TrainersContext context)
        {
            _context = context;

        }

        public IQueryable<T> Query()
        {
            return _context.Set<T>();
        }

        public async Task<T> GetAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task AddAsync(T entity)
        {
            Assert.ArgumentIsNull(entity, nameof(entity));

            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task EditAsync(T entity)
        {
            Assert.ArgumentIsNull(entity, nameof(entity));

            if (!_context.Set<T>().Local.Any(e => e == entity))
            {
                throw new ArgumentException(
                    "Cannot edit entity, which is not attached to the current context.",
                    nameof(entity));
            }


            var contextEntry = _context.Entry(entity);
            contextEntry.State = EntityState.Modified;

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetAsync(id);
            await DeleteAsync(entity);
        }

        public async Task DeleteAsync(T entity)
        {
            Assert.ArgumentIsNull(entity, nameof(entity));

            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}