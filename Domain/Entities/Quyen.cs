using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Entities.Common;

namespace Domain.Entities
{
    // [Table("Quyen")]            : Tạo 1 table Quyen (bình thường table mặc định là Quyens)
    public class Quyen
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int QuyenId { get; set; }
        // // [Key]
        // // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // // public int permission_id { get; set; }

        // [Required(ErrorMessage = "Tên quyền là bắt buộc")]
        // public string name { get; set; }

        // [Required(ErrorMessage = "Chi tiết quyền là bắt buộc")]
        // // [Column("Description")]
        // public string detail { get; set; }
        // // Tạo khóa ngoại với nhân viên - 1 quyen có nhiều nhân viên
        // public ICollection<NhanVien> nhanvien { get; set; }




        // TypeName là Text hay nvarchar cug như nhau, nên phải có [MaxLength(5)] 
        // [Column("name", Order = 2, TypeName = "NVARCHAR(10)")]      // Cột là NAME, vị trí 2, kiểu dữ liệu NVARCHAR(10)
        // [Required]                                                  // Kiểu dữ liệu là bắt buộc
        // [MaxLength(50)]                                              // Độ dài tối đa chuỗi là 50
        public string name { get; set; }
        
        public string detail { get; set; }

        
        public ICollection<NhanVien> nhanvien { get; set; }
    }
}