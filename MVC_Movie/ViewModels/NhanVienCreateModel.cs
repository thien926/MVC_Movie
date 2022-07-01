using System.Collections.Generic;
using Application.DTOs;

namespace MVC_Movie.ViewModels
{
    public class NhanVienCreateModel
    {
        public NhanVienDto NV { get; set; }
        public IEnumerable<QuyenDto> Quyens { get; set; }
        
    }
}