namespace App.Application.MappingProfiles
{
    public class CategoryMappingProfile : Profile
    {
        public CategoryMappingProfile()
        {
            CreateMap<Category,CategoryDto>().ReverseMap();
        }
    }
}
