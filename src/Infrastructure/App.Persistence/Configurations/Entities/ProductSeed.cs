using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Persistence.Configurations.Entities
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product(1, "Product 1", "Description 1", 1000, 1),
                new Product(2, "Product 2", "Description 2", 3000, 2),
                new Product(3, "Product 3", "Description 3", 1200, 1));
        }
    }
}
