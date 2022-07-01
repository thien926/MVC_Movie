using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Entities.Common;

namespace Domain.Entities
{
    public class NhanVien
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int nhanvienId { get; set; }

        [Required(ErrorMessage = "Tên đăng nhập là bắt buộc")]
        [StringLength(maximumLength: 25, MinimumLength = 3, ErrorMessage = "Tên đăng nhập từ 3 đến 25 kí tự")]
        [RegularExpression(pattern: @"^[a-zA-Z][\w]{1,}", ErrorMessage = "Tên đăng nhập phải bắt đầu bằng chữ")]
        public string user { get; set; }

        [Required(ErrorMessage = "Mật khẩu là bắt buộc")]
        public string password { get; set; }

        [Required(ErrorMessage = "Họ tên là bắt buộc")]
        [StringLength(maximumLength: 100, MinimumLength = 4, ErrorMessage = "Họ tên từ 4 đến 100 kí tự")]
        public string full_name { get; set; }

        [Required(ErrorMessage = "Số điện thoại là bắt buộc")]
        [RegularExpression(pattern: @"^(09|03|07|08|05)+([0-9]{8})")]
        public string phone { get; set; }

        [Required(ErrorMessage = "Thư điện tử là bắt buộc")]
        [EmailAddress(ErrorMessage = "Thư điện tử không hợp lệ")]
        [StringLength(50)]   
        public string mail { get; set; }

        [Required(ErrorMessage = "Địa chỉ là bắt buộc")]
        public string address { get; set; }

        [Required(ErrorMessage = "Giới tính là bắt buộc")]
        public Gender gender { get; set; }

        [Required(ErrorMessage = "Ngày sinh là bắt buộc")]
        [DataType(DataType.Date)]
        public DateTime dateborn { get; set; }

        [Required(ErrorMessage = "Mã quyền là bắt buộc")]
        
        public int QuyenId { get; set; }

        [Required(ErrorMessage = "Trạng thái hoạt động là bắt buộc")]
        public StatusActive status_active { get; set; }

        // Tạo khóa ngoại với quyền - 1 nhân viên chỉ có 1 quyền
        // [ForeignKey("QuyenId")]
        public Quyen quyen { get; set; }
        public NhanVien() {
            this.status_active = 0;
        }
    }
}