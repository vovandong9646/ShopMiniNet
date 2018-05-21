using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopMini.Web.Mappings
{
    public class OrderDto
    {
        public int ID { get; set; }
        
        public string CustomerName { get; set; }
        
        public string CustomerAddress { get; set; }
        
        public string CustomerEmail { get; set; }
        
        public string CustomerMobile { get; set; }
        
        public string CustomerMessage { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string CreatedBy { get; set; }
        
        public string PaymentMethod { get; set; }

        public string PaymentStatus { get; set; }

        public bool Status { get; set; }

        // foreign key
        public virtual IEnumerable<OrderDetailDto> OrderDetailDtos { get; set; }
    }
}