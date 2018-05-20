﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMini.Model.Models
{
    [Table("ProductTags")]
    class ProductTag
    {
        [Key]
        public int ProductID { get; set; }

        [Key]
        [Column(TypeName ="varchar")]
        [MaxLength(50)]
        public string TagID { get; set; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }
    }
}