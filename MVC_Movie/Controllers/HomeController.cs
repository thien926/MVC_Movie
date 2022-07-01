using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_Movie.Models;

namespace MVC_Movie.Controllers
{
    public class HomeController : Controller
    {
        private readonly IQuyenService quyenService;

        public HomeController(IQuyenService quyenService)
        {
            this.quyenService = quyenService;
        }

        public async Task<IActionResult> Index()
        {
            var quyens = await quyenService.GetAll();
            return View(quyens);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id) {
            var result = await quyenService.GetBy(id);
            try{
                if(result == null) {
                    ModelState.AddModelError("", "Không tồn tại quyền cần sửa");
                }
                return View(result);
            }
            catch(Exception e) {
                ModelState.AddModelError("", e.ToString());
                return View(result);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(QuyenDto quyenDto) {
            if(ModelState.IsValid) {
                try {
                    await quyenService.Update(quyenDto);
                    return RedirectToAction("Index");
                }
                catch(Exception e) {
                    ModelState.AddModelError("", e.ToString());
                    return View(quyenDto);
                }
            }
            return View(quyenDto);
        }

        // public IActionResult Privacy()
        // {
        //     return View();
        // }

        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        // }
    }
}
