using System;

namespace ShopMini.Model.Abstract
{
    internal interface IAudiTable
    {
        string MetaKeyword { get; set; }
        string MetaDescription { get; set; }
        DateTime? CreatedDate { get; set; }
        string CreatedBy { get; set; }
        DateTime? UpdatedDate { get; set; }
        string UpdatedBy { get; set; }
        bool Status { get; set; }
        bool? HomeFlag { set; get; }
    }
}