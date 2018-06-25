using ShopEcomecre.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopEcomecre.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

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
        [MaxLength(256)]
        public string CustomerMobile { get; set; }

        [Required]
        [MaxLength(256)]
        public string CustomerMessege { get; set; }

        [Required]
        [MaxLength(256)]
        public string PaymentMethod { get; set; }

        [Required]
        [MaxLength(256)]
        public string PaymentStatus { get; set; }

        [Required]
        public bool Status { get; set; }

        public virtual IEnumerable<OrderDetail> OrderDetails { set; get; }
    }
}