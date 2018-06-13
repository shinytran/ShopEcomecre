using System;
using System.ComponentModel.DataAnnotations;

namespace ShopEcomecre.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreatedDate { set; get; }

        [MaxLength(256)]
        string CreatedBy { set; get; }
        DateTime? UpdateDate { set; get; }

        [MaxLength(256)]
        string UpdateBy { set; get; }
        bool status { set; get; }

        [MaxLength(256)]
        string MetaKeyword { set; get; }

        [MaxLength(256)]
        string MetaDescription { set; get; }
    }
}