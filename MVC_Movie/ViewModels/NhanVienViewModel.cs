using Application.DTOs;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_Movie.Helpers;

namespace MVC_Movie.ViewModels
{
    public class NhanVienViewModel
    {
        public PaginatedList<NhanVienDto> NhanViens { get; set; } 
        public SelectList Quyens { get; set; }
        public string TypeQuyen { get; set; }
        public string SearchString { get; set; }
        public string SortString { get; set; }
    }
}