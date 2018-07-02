using ShopEcomecre.Model.Abstract;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopEcomecre.Model.Models
{
    [Table("VisiterStatitics")]
    public class VisiterStatitic 
    {
        [Key]
        public Guid ID { set; get; }
        [Required]
        public DateTime VisitDate { get; set; }

        [MaxLength(50)]
        public string IPAddress { get; set; }
    }
}