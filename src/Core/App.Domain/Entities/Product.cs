using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain.Entities
{
    public class Product : BaseEntity<int>
    {
        public Product(string name, string desciption
                       ,decimal price,int categoryId)
        {
            Name = name;
            Description = desciption;
            Price = price;
            CategoryId= categoryId;
        }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }

        //Navigational prop
        public virtual Category Category { get; set; }
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }

    }
}
