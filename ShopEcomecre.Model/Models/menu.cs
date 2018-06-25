using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopEcomecre.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [MaxLength(256)]
        public string URL { get; set; }

        public int? DisplayOrder { get; set; }

        [Required]
        public string GroupID { get; set; }

        [ForeignKey("GroupID")]
        public virtual MenuGroup Menugroup { set; get; }

        public string Target { get; set; }

        [Required]
        public bool Status { set; get; }
    }
}