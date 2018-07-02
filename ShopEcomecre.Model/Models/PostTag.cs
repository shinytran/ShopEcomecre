using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopEcomecre.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key,Column(Order = 0)]
        public int PostID { get; set; }

        [Key]
        [Column(TypeName = "varchar", Order =1)]
        [MaxLength(50)]
        public string TagID { get; set; }

        [ForeignKey("PostID")]
        public virtual Post Post { set; get; }

        [ForeignKey("TagID")]
        public virtual Tag Tag { get; set; }
    }
}