using AutoMapper;
using Laptops.Domain.Entites;
using Laptops.Shared.DTOs.Categories;
using Laptops.Shared.DTOs.LaptopImage;
using Laptops.Shared.DTOs.Laptops;
using Laptops.Shared.DTOs.Reviews;

namespace Laptops.BLL.Mappers;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // CATEGORY
        CreateMap<Category, CategoryForCreateDto>().ReverseMap();

        CreateMap<Category, CategoryForUpdateDto>().ReverseMap();

        CreateMap<Category, CategoryForResultDto>().ReverseMap();

        CreateMap<Category, CategoryForShortResultDto>().ReverseMap();

        // LAPTOP
        CreateMap<Laptop, LaptopForCreateDto>().ReverseMap();

        CreateMap<Laptop, LaptopForUpdateDto>().ReverseMap();

        CreateMap<Laptop, LaptopForResultDto>().ReverseMap();

        CreateMap<Laptop, LaptopForShortResultDto>().ReverseMap();

        // REVIEW
        CreateMap<Review, ReviewForCreateDto>().ReverseMap();

        CreateMap<Review, ReviewForUpdateDto>().ReverseMap();

        CreateMap<Review, ReviewForResultDto>().ReverseMap();

        CreateMap<Review, ReviewForShortResultDto>().ReverseMap();

        // LAPTOP IMAGE
        CreateMap<LaptopImage, LaptopImageForCreateDto>().ReverseMap();

        CreateMap<LaptopImage, LaptopImageForUpdateDto>().ReverseMap();

        CreateMap<LaptopImage, LaptopImageForResultDto>().ReverseMap();

        CreateMap<LaptopImage, LaptopImageForShortResultDto>().ReverseMap();
    }
}