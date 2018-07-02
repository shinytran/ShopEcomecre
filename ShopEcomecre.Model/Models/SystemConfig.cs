using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopEcomecre.Model.Models
{
    [Table("SystemConfigs")]
    public class SystemConfig
    {
        [Key, Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(TypeName = "varchar",Order =1)]
        [MaxLength(50)]
        public string Code { get; set; }

        [MaxLength(50)]
        public string ValueString { get; set; }

        public int? ValueInt { get; set; }
    }
}