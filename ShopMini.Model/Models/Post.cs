﻿using ShopMini.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ShopMini.Model.Models
{
    [Table("Posts")]
    class Post : AudiTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        [Required]
        [MaxLength(256)]
        [Column(TypeName = "varchar")]
        public string Alias { get; set; }

        [Required]
        public int CategoryID { get; set; }

        [MaxLength(256)]
        public string Image { get; set; }

        public XElement MoreImages { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }
        
        public string Content { get; set; }

        public bool? HotFlag { get; set; }

        public int? ViewCount { get; set; }

        // foreign key
        public virtual IEnumerable<PostTag> PostTags { get; set; }

        [ForeignKey("CategoryID")]
        public virtual PostCategory PostCategory { get; set; }
    }
}
