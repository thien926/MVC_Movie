using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Movie.Controllers
{
    public class QuyenController : Controller
    {
        private readonly IQuyenService quyenService;
        public QuyenController(IQuyenService quyenService) {
            this.quyenService = quyenService;
        }
    }
}