using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace ShopNuocHoa.Models.EF
{
    [Table("tb_Banner")]
    public class Banner : CommonAbstract
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(150)]
        public string Title{ get; set; }
        public string Description{ get; set; }
        public string Image {  get; set; }
    }
}