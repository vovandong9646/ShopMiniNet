using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopMini.Web.Mappings
{
    public class PostDto
    {
        public int ID { get; set; }
        
        public string Name { get; set; }
        
        public string Alias { get; set; }
        
        public int CategoryID { get; set; }
        
        public string Image { get; set; }
        
        public string MoreImages { get; set; }
        
        public string Description { get; set; }

        public string Content { get; set; }

        public bool? HotFlag { get; set; }

        public int? ViewCount { get; set; }

        // foreign key
        public virtual IEnumerable<PostTagDto> PostTags { get; set; }
        
        public virtual PostCategoryDto PostCategoryDto { get; set; }
    }
}