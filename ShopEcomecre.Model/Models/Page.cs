using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopEcomecre.Model.Models
{
    [Table("Pages")]
   public class Page
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
       
        public string Name { get; set; }

      
        public string Content { get; set; }
 
        public string MetaKeyword { get; set; }
        public string MetaDescription { get; set; }
        public bool? Status { get; set; }
    }
}
