using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopEcomecre.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        public int OrderID { get; set; }

        [Key]
        public int ProductID { get; set; }

        public int Quantity { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product Product { set; get; }

        [ForeignKey("OrderID")]
        public virtual Order Order { set; get; }
    }
}