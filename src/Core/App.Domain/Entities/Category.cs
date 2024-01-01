namespace App.Domain.Entities
{
    public class Category : BaseEntity<int>
    {
        public Category(string name, string desciption)
        {
            Name = name;
            Desciption = desciption;
        }
        public string Name { get; set; } = string.Empty;
        public string Desciption { get; set; } = string.Empty;
    }
}
