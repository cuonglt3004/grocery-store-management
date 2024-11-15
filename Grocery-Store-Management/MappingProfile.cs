using AutoMapper;
using Entities.DTOs;
using Entities.Models;

namespace Grocery_Store_Management
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryDTO>();
            CreateMap<CategoryDTO, Category>();
            CreateMap<Customer, CustomerDTO>();
            CreateMap<CustomerDTO, Customer>();
            CreateMap<CustomerPoint, CustomerPointDTO>();
            CreateMap<CustomerPointDTO, CustomerPoint>();
            CreateMap<Order, OrderDTO>();
            CreateMap<OrderDTO, Order>();
            CreateMap<OrderDetailDTO, OrderDetail>();
            CreateMap<OrderDetail, OrderDetailDTO>();
            CreateMap<Product, ProductDTO>();
            CreateMap<ProductDTO, Product>();
            CreateMap<Promotion, PromotionDTO>();
            CreateMap<PromotionDTO, Promotion>();
        }
    }
    
}
