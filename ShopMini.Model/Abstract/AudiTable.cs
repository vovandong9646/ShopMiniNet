using System;
using System.ComponentModel.DataAnnotations;

namespace ShopMini.Model.Abstract
{
    public class AudiTable : IAudiTable
    {
        [MaxLength(256)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public bool? HomeFlag { get; set; }

        [MaxLength(256)]
        public string MetaDescription { get; set; }

        [MaxLength(256)]
        public string MetaKeyword { get; set; }

        public bool Status { get; set; }

        [MaxLength(256)]
        public string UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}