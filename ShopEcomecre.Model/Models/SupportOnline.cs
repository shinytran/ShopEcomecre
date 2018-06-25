using ShopEcomecre.Model.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopEcomecre.Model.Models
{
    [Table("SupportOnlines")]
    public class SupportOnline : Auditable
    {
        [Key]
        public int ID { get; set; }

        public string Department { get; set; }
        public string Name { get; set; }
        public string Skype { get; set; }
        public string Facebook { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
    }
}