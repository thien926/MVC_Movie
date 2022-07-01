using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public class EFRepository<T> : IRepository<T> where T : class
    {
        protected readonly MVCDbContext _context;
        public EFRepository(MVCDbContext context) {
            _context = context;
        }
        public async Task<T> Add(T entity)
        {
            var result = await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<T> Delete(int id)
        {
            var result = await GetBy(id);
            if(result != null) {
                _context.Set<T>().Remove(result);
                await _context.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetBy(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<T> Update(T entity)
        {
            var result = _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
            return result.Entity;
        }
    }
}