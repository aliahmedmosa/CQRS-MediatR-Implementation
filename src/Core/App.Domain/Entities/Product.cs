using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain.Entities
{
    public class Product : BaseEntity<int>
    {
        public Product()
        {
            
        }
        public Product(int id,string name, string desciption
                       ,decimal price,int categoryId)
        {
            Id=id;
            Name = name;
            Description = desciption;
            Price = price;
            CategoryId= categoryId;
        }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        [Column(TypeName ="decimal(18,2)")]
        public decimal Price { get; set; }

        //Navigational prop
        public virtual Category Category { get; set; }
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }

    }
}
