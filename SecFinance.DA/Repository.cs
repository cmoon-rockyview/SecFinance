using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;

using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace SecFinance.DA
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _context;
        protected IEnumerable<TEntity> _entity;

        public Repository(DbContext context)
        {
            _context = context;
            _entity = _context.Set<TEntity>();
        }

        public async Task<TEntity> GetAsync(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public TEntity Get(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            var entities = await _context.Set<TEntity>().ToListAsync();
            return entities;
        }

        public async Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate)
        {
            var entities = await _context.Set<TEntity>().Where(predicate).ToListAsync();
            return entities;
        }

        public async Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            var entity = await _context.Set<TEntity>().FirstOrDefaultAsync(predicate);
            return entity;
        }

        public async Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            var entity = await _context.Set<TEntity>().SingleOrDefaultAsync(predicate);
            return entity;
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            try
            {
                await _context.Set<TEntity>().AddAsync(entity);
                return entity;
            }
            catch (Exception ex)
            {
                return null;
            }

           
        }

        public async Task UpdateAsync(TEntity entity)
        {
            await Task.Run(() =>
            {
                _context.Entry(entity).State = EntityState.Modified;

            });

        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _context.Set<TEntity>().AddRangeAsync(entities);
        }


        public void Update(TEntity entity)
        {
            try
            {
                var updatedEntity = _context.Set<TEntity>().Update(entity);
                _context.Entry(entity).State = EntityState.Modified;
            }

            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }

        }

        public void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);

        }

        public async Task RemoveAync(TEntity entity)
        {
            await Task.Run(() =>
            {
                _context.Set<TEntity>().Remove(entity);

            });

        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().RemoveRange(entities);
        }




    }


}
