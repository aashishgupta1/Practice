using AutoMapper;
using OrderServiceDesign.Domain.DTO;
using OrderServiceDesign.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OrderServiceDesign.DataAccessLayer.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<OrderDetails, CreateOrderDetailDTO>().ReverseMap();
            CreateMap<Address, AddressDTO>().ReverseMap();
            CreateMap<BasketItem, BasketItemDTO>().ReverseMap();
            CreateMap<ShippingDetails, ShippingDetailsDTO>().ReverseMap();
            CreateMap<CustomerCart, CustomerCartDTO>().ReverseMap();
        }
    }
}
