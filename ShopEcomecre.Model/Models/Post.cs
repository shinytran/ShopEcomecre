using ShopEcomecre.Model.Abstract;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopEcomecre.Model.Models
{
    [Table("Posts")]
    public class Post : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        [Column(TypeName = "varchar")]
        [Required]
        [MaxLength(256)]
        public string Alias { get; set; }

        [Required]
        public int CategoryID { get; set; }

        public int? ParrentID { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        public int? Content { get; set; }

        [MaxLength(256)]
        public string Image { get; set; }

        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }

        [Required]
        public new bool Status { get; set; }

        public bool? HomeFlag { get; set; }
        public bool? HotFlag { get; set; }
        public int? ViewCount { get; set; }

        [ForeignKey("CategoryID")]
        public virtual PostCategory PostCategory { set; get; }
    }
}