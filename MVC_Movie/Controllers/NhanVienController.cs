using System;
using System.Threading.Tasks;
using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_Movie.Helpers;
using MVC_Movie.ViewModels;

namespace MVC_Movie.Controllers
{
    public class NhanVienController : Controller
    {
        private readonly INhanVienService nhanVienService;
        private readonly IQuyenService quyenService;
        public NhanVienController(INhanVienService nhanVienService, IQuyenService quyenService) {
            this.nhanVienService = nhanVienService;
            this.quyenService = quyenService;
        }

        public async Task<IActionResult> Index(string sortString, string typeQuyen, string searchString, int pageIndex = 1) {
            int pageSize = 3;
            int count;
            var TypeQuyens = quyenService.GetNameAll();
            var idquyen = quyenService.GetIdByName(typeQuyen);
            var nhanviens = nhanVienService.Filter(idquyen, searchString, sortString, pageIndex, pageSize, out count);

            var NhanVienVM = new NhanVienViewModel() {
                NhanViens = new PaginatedList<NhanVienDto>(nhanviens, count, pageIndex, pageSize),
                Quyens = new SelectList(TypeQuyens),
                TypeQuyen = typeQuyen,
                SearchString = searchString,
                SortString = sortString
            };

            return View(NhanVienVM);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id) {
            var NV = await nhanVienService.GetBy(id);
            return View(NV);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id, bool notUsed) {
            await nhanVienService.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Create() {
            var IndexModel = new NhanVienCreateModel();
            IndexModel.Quyens = await quyenService.GetAll();
            return View(IndexModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(NhanVienCreateModel IndexModel) {
            IndexModel.Quyens = await quyenService.GetAll();
            if (ModelState.IsValid)
            {
                try
                {
                    // var nv = await nhanVienService.GetByUser(IndexModel.NV.user);
                    // if(nv != null) {
                    //     ModelState.AddModelError("", "Tài khoản đã tồn tại!");
                    //     return View(IndexModel);
                        
                    // }
                    // else {
                    //     var result = await nhanVienService.Add(IndexModel.NV);
                    //     return RedirectToAction("Index");
                    // }
                    var result = await nhanVienService.Add(IndexModel.NV);
                        return RedirectToAction("Index");
                }
                catch (Exception e)
                {
                    if(e.ToString().Contains("UNIQUE constraint failed: NhanViens.user")) {
                        // ModelState.AddModelError("", "Tài khoản đã tồn tại!");
                        ModelState.AddModelError("", e.ToString());
                    }else {
                        ModelState.AddModelError("", e.ToString());
                    }
                    return View(IndexModel);
                }
            }

            return View(IndexModel);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id) {
            var IndexModel = new NhanVienCreateModel();
            try{
                IndexModel.Quyens = await quyenService.GetAll();
                IndexModel.NV = await nhanVienService.GetBy(id);
                if(IndexModel.NV == null) {
                    ModelState.AddModelError("", "Không tồn tại nhân viên cần sửa");
                }
                return View(IndexModel);
            }
            catch(Exception e) {
                ModelState.AddModelError("", e.ToString());
                return View(IndexModel);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(NhanVienCreateModel IndexModel) {
            IndexModel.Quyens = await quyenService.GetAll();
            if(ModelState.IsValid) {
                try{
                    var nv = nhanVienService.GetBy(IndexModel.NV.nhanvienId);
                    if(nv == null) {
                        ModelState.AddModelError("", $"Không tồn tại ID = {IndexModel.NV.nhanvienId}");
                        return View(IndexModel);
                    }
                    
                    var result = await nhanVienService.UpdateByUser(IndexModel.NV);
                    if(result == null) {
                        ModelState.AddModelError("", "Update thất bại");
                        return View(IndexModel);
                    }
                    // await nhanVienService.Update(IndexModel.NV);
                    return RedirectToAction("Index");
                }
                catch(Exception e) {
                    ModelState.AddModelError("", e.ToString());
                    return View(IndexModel);
                }
            }
            return View(IndexModel);
        }
    }
}