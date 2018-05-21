using AutoMapper;
using ShopMini.Model.Models;

namespace ShopMini.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<OrderDetail, OrderDetailDto>();
        }
    }
}