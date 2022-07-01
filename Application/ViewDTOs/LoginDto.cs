using System.ComponentModel.DataAnnotations;

namespace Application.ViewDTOs
{
    public class LoginDto
    {
        [Key]
        [Required(ErrorMessage = "Tên đăng nhập bắt buộc")]
        [StringLength(maximumLength:25, MinimumLength = 3, ErrorMessage = "Tên đăng nhập từ 3 đến 25 kí tự")]
        [RegularExpression(pattern: @"^[a-zA-Z][\w]{1,}", ErrorMessage="Tên đăng nhập phải bắt đầu bằng chữ, kế đến là chữ hoặc số")]
        public string user { get; set; }

        [Required(ErrorMessage = "Mật khẩu là bắt buộc")]
        [StringLength(maximumLength:25, MinimumLength = 4, ErrorMessage = "Mật khẩu từ 4 đến 25 kí tự")]
        public string password { get; set; }
    }
}