using AutoMapper;
using RestaurantAPI.Data;
using RestaurantAPI.Models.Basket;
using RestaurantAPI.Models.Category;
using RestaurantAPI.Models.Products;
using System.Diagnostics.Metrics;

namespace RestaurantAPI.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, GetCategoryDto>().ReverseMap();

            CreateMap<Product, ProductDto>().ReverseMap();

            CreateMap<Basket, BasketDto>().ReverseMap();
            CreateMap<Basket, GetBasketDto>().ReverseMap();
            CreateMap<Basket, BasketPostDto>().ReverseMap();
        }
    }
}
