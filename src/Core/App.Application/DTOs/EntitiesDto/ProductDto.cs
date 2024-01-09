namespace App.Application.DTOs.EntitiesDto
{
    public class ProductDto : BaseDto<int>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
