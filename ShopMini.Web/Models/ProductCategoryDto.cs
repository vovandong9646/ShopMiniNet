using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopMini.Web.Mappings
{
    public class ProductCategoryDto
    {
        public int ID { get; set; }
        
        public string Name { get; set; }
        
        public string Alias { get; set; }
        
        public string Description { get; set; }

        public int? ParentID { get; set; }
        
        public string Image { get; set; }

        public int? DisplayOrder { get; set; }
        
        public virtual IEnumerable<ProductDto> Products { get; set; }
    }
}