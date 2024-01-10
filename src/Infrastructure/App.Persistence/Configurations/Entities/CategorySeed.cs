using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Persistence.Configurations.Entities
{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category(1,"Category One","Category description one"),
                new Category(2,"Category Two", "Category description Two"),
                new Category(3,"Category Three", "Category description Three")
                );
        }
    }
}
