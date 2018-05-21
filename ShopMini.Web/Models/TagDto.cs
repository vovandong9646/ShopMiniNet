using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopMini.Web.Mappings
{
    public class TagDto
    {
        public string ID { get; set; }
        
        public string Name { get; set; }
        
        public string Type { get; set; }
        
        public virtual IEnumerable<PostTagDto> PostTagDtos { get; set; }

        public virtual IEnumerable<ProductTagDto> ProductTagDtos { get; set; }
    }
}