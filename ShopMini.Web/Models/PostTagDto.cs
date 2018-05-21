using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopMini.Web.Mappings
{
    public class PostTagDto
    {
        public int PostID { get; set; }
        
        public string TagID { get; set; }
        
        public virtual PostDto PostDto { get; set; }
        
        public virtual TagDto TagDto { get; set; }
    }
}