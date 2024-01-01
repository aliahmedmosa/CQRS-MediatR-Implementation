﻿namespace App.Application.MappingProfiles
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
            CreateMap<Product,ProductDto>().ReverseMap();
        }
    }
}
