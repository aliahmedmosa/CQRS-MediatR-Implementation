namespace App.Domain.Entities
{
    public class Category : BaseEntity<int>
    {
        public Category()
        {

        }
        public Category(int id, string name, string desciption)
        {
            Id = id;
            Name = name;
            Desciption = desciption;
        }
        public string Name { get; set; } = string.Empty;
        public string Desciption { get; set; } = string.Empty;
        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();
    }
}
