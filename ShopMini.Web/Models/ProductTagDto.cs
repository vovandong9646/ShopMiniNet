using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopMini.Web.Mappings
{
    public class ProductTagDto
    {
        public int ProductID { get; set; }
        
        public string TagID { get; set; }
        
        public virtual TagDto TagDto { get; set; }
        
        public virtual ProductDto ProductDto { get; set; }
    }
}