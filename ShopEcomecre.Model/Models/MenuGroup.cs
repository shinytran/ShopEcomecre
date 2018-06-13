using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopEcomecre.Model.Models
{
    [Table("MenuGroups")]
    public class MenuGroup
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual IEnumerable<Menu> Menus { set; get; }
    }
}
