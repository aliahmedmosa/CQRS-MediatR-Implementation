using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Persistence.Repositories
{
    internal class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly AppDBContext _context;

        public ProductRepository(AppDBContext context) : base(context)
        {
            _context = context;
        }

        public Task<List<Product>> GetAllAsyncWithInclude()
        =>_context.Products.AsNoTracking().Include(x => x.Category).ToListAsync();
            
    }
}
