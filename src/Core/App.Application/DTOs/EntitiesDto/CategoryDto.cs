namespace App.Application.DTOs.EntitiesDto
{
    public class CategoryDto : BaseDto<int>
    {
        public string Name { get; set; }
        public string Desciption { get; set; }
    }
}
