global using App.Application.Presistance.Contracts;
global using App.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace App.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AppDBContext _context;

        public GenericRepository(AppDBContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(T entity)
        {
            await _context.AddAsync(entity);
            await SaveChancesAsync();
        }

        public async Task DeleteAsync(int id)
        {

            _context.Set<T>().Remove(await GetAsync(id));
            await SaveChancesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        => await _context.Set<T>().AsNoTracking().ToListAsync();

        public async Task<T> GetAsync(int id)
        => await _context.Set<T>().FindAsync(id);

        public async Task SaveChancesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await SaveChancesAsync();
        }
    }
}
