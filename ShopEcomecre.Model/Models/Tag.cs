using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopEcomecre.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        public string ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Type { get; set; }

    }
}