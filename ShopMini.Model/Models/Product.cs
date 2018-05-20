using ShopMini.Model.Abstract;
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
    [Table("Products")]
    public class Product : AudiTable
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

        [Required]
        public int CategoryID { get; set; }

        [MaxLength(256)]
        public string Image { get; set; }

        [Column(TypeName = "xml")]
        public string MoreImages { get; set; }

        [Required]
        public decimal Price { get; set; }

        public decimal? Promotion { get; set; }

        public int? Warranty { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        [MaxLength(500)]
        public string Content { get; set; }

        public bool? HotFlag { get; set; }

        public int? ViewCount { get; set; }

        // foreign key
        public virtual IEnumerable<ProductTag> ProductTags { get; set; }

        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory { get; set; }

        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }
    }
}
