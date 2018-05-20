﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMini.Model.Models
{
    [Table("OrderDetails")]
    class OrderDetail
    {
        [Key]
        public int OrderID { get; set; }

        [Key]
        public int ProductID { get; set; }

        public int Quantity { get; set; }

        // foreign key
        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }

        [ForeignKey("OrderID")]
        public virtual Order Order { get; set; }
    }
}