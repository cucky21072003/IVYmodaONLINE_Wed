using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IVYmodaONLINE.Models.EF
{
    [Table("tb_Post")]
    public class Post:CommonAbstract
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Title { get; set; }
        public string Alias { get; set; }
        [StringLength(550)]
        public string Description { get; set; }
        [AllowHtml]
        [StringLength(4000)]
        public string Detail { get; set; }
        [StringLength(550)]
        public string Image { get; set; }
        public int CategoryId { get; set; }
        [StringLength(150)]
        public string Seotitle { get; set; }
        [StringLength(550)]
        public string SeoDescription { get; set; }
        [StringLength(150)]
        public string SeoKeyWords { get; set; }
        public bool IsActive { get; set; }

        public virtual Category Category { get; set; }
    }
}