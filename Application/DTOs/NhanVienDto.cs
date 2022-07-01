using System;
using System.ComponentModel.DataAnnotations;
using Domain.Entities;

namespace Application.DTOs
{
    public class NhanVienDto
    {
        public int nhanvienId { get; set; }
        
        [Required(ErrorMessage = "Tên đăng nhập là bắt buộc")]
        [StringLength(maximumLength: 25, MinimumLength = 3, ErrorMessage = "Tên đăng nhập từ 3 đến 25 kí tự")]
        [RegularExpression(pattern: @"^[a-zA-Z][\w]{1,}", ErrorMessage = "Tên đăng nhập phải bắt đầu bằng chữ")]
        public string user { get; set; }

        [Required(ErrorMessage = "Mật khẩu là bắt buộc")]
        public string password { get; set; }

        [Compare(otherProperty:"password", ErrorMessage ="Nhập lại mật khẩu không khớp với mật khẩu đã nhập")]
        public string repass { get; set; }

        [Required(ErrorMessage = "Họ tên là bắt buộc")]
        [StringLength(maximumLength: 100, MinimumLength = 4, ErrorMessage = "Họ tên từ 4 đến 100 kí tự")]
        public string full_name { get; set; }

        [Required(ErrorMessage = "Số điện thoại là bắt buộc")]
        [RegularExpression(pattern: @"^(09|03|07|08|05)+([0-9]{8})", ErrorMessage = "Số điện thoại không đúng")]
        public string phone { get; set; }

        [Required(ErrorMessage = "Thư điện tử là bắt buộc")]
        [EmailAddress(ErrorMessage = "Thư điện tử không hợp lệ")]
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

        // [Required(ErrorMessage = "Hình ảnh là bắt buộc")]
        // public string profile_picture { get; set; }

        [Required(ErrorMessage = "Trạng thái hoạt động là bắt buộc")]
        public StatusActive status_active { get; set; }
    }
}