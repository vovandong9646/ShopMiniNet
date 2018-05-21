using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopMini.Web.Mappings
{
    public class OrderDetailDto
    {
        public int OrderID { get; set; }
        
        public int ProductID { get; set; }

        public int Quantity { get; set; }
        
        public virtual ProductDto ProductDto { get; set; }
        
        public virtual OrderDto OrderDto { get; set; }
    }
}