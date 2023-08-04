using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWebMVC.Models
{
    [Table("LopHoc")]
    public class LopHoc
    {
        [Key]
        public String MaLop { get; set; }
        public string TenLop { get; set; }
    }
}