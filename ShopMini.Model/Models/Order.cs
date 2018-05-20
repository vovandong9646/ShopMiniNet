﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMini.Model.Models
{
    [Table("Orders")]
    class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(256)]
        public string CustomerName { get; set; }

        [Required]
        [MaxLength(256)]
        public string CustomerAddress { get; set; }

        [Required]
        [MaxLength(256)]
        public string CustomerEmail { get; set; }

        [Required]
        [MaxLength(50)]
        public string CustomerMobile { get; set; }

        [Required]
        [MaxLength(256)]
        public string CustomerMessage { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        [MaxLength(256)]
        public string PaymentMethod { get; set; }

        public string PaymentStatus { get; set; }
       
        public bool Status { get; set; }

        // foreign key
        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }
    }
}
