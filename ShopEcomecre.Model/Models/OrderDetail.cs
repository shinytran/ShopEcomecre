using ShopEcomecre.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopEcomecre.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail: Auditable
    {
        [Key]
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("ProductID")]
        public virtual ProductCategory ProductCategory { set; get; }
        public virtual Order Order { set; get; }
    }
}
