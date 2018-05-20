﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMini.Model.Models
{
    [Table("Tags")]
    class Tag
    {
        [Key]
        [MaxLength(50)]
        public string ID { get; set; }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [MaxLength(50)]
        [Required]
        public string Type { get; set; }

        // foreign key
        public virtual IEnumerable<PostTag> PostTags { get; set; }

        public virtual IEnumerable<ProductTag> ProductTags { get; set; }
    }
}