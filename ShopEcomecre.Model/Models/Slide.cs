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
    [Table("Slides")]
    public class Slide :Auditable
    {

        [Key]
        public string ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        public string Image { get; set; }
        public string URL { get; set; }
        public int DisplayOrder { get; set; }
        public bool Status { get; set; }

    }
}
