﻿using ShopMini.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMini.Model.Models
{
    [Table("ProductCategories")]
    class ProductCategory :AudiTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        [Required]
        [MaxLength(256)]
        [Column(TypeName ="varchar")]
        public string Alias { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public int? ParentID { get; set; }

        [MaxLength(256)]
        public string Image { get; set; }

        public int? DisplayOrder { get; set; }

        // foreign key
        public virtual IEnumerable<Product> Products { get; set; }
    }
}
