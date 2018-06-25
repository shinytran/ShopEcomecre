using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopEcomecre.Model.Models
{
    [Table("SystemConfigs")]
    internal class SystemConfig
    {
        [Key]
        public int ID { get; set; }

        public string Code { get; set; }
        public string ValueString { get; set; }
        public string ValueInt { get; set; }
    }
}