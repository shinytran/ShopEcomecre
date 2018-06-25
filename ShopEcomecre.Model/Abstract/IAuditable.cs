using System;

namespace ShopEcomecre.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreatedDate { set; get; }

        string CreatedBy { set; get; }
        DateTime? UpdateDate { set; get; }

        string UpdateBy { set; get; }
        bool Status { set; get; }
    }
}