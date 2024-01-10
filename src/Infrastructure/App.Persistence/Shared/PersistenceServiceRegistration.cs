using App.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace App.Persistence.Shared
{
    public static class PersistenceServiceRegistration
    {
        public static void ConfigurePersistenceService(this IServiceCollection services,IConfiguration configuration)
        {
            //Configure AppDBContext
            services.AddDbContext<AppDBContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            //Configure Service
            services.AddScoped(typeof(IGenericRepository<>),typeof(IGenericRepository<>));
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
