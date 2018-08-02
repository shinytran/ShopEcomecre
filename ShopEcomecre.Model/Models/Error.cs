using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopEcomecre.Model.Models
{
    [Table("Errors")]
    public class Error
    {
       [Key]
        public int ID { get; set; }
        public string Message { get; set; }
        public string Stacktrace { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
