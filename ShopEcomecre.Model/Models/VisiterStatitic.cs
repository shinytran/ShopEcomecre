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
    [Table("VisiterStatitics")]
    public class VisiterStatitic : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        public DateTime? VisitDate { get; set; }
        public string IPAddress { get; set; }
    }
}
