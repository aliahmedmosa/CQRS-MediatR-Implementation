namespace App.Domain.Entities
{
    public class Product : BaseEntity<int>
    {
        public Product(string name, string desciption, decimal price)
        {
            Name = name;
            Description = desciption;
            Price = price;
        }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }

    }
}
