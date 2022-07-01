using System.Collections.Generic;
using System.Threading.Tasks;
using Application.DTOs;
using Application.Interfaces;
using Domain.Repositories;
using Application.Mappings;
using System;

namespace Application.Services
{
    public class NhanVIenService : INhanVienService
    {
        private readonly INhanVienRepository nhanVienRepository;
        public NhanVIenService(INhanVienRepository nhanVienRepository) {
            this.nhanVienRepository = nhanVienRepository;
        }
        public async Task<NhanVienDto> Add(NhanVienDto entity)
        {
            var nhanvien = entity.MappingNhanVien();
            var result = await nhanVienRepository.Add(nhanvien);
            return entity;
        }

        public async Task<NhanVienDto> Delete(int id)
        {
            try {
                var result = await nhanVienRepository.Delete(id);
                return result.MappingNhanVienDto();
            }
            catch(Exception) {
                return null;
            }
        }

        public async Task<NhanVienDto> DeleteByUser(string user)
        {
            try {
                var result = await nhanVienRepository.DeleteByUser(user);
                return result.MappingNhanVienDto();
            }
            catch(Exception) {
                return null;
            }
        }

        public IEnumerable<NhanVienDto> Filter(int typeQuyen, string searchString, string sortString, int pageIndex, int pageSize, out int count)
        {
            try
            {   
                var nhanviens = nhanVienRepository.Filter(typeQuyen, searchString, sortString, pageIndex, pageSize, out count);
                return nhanviens.MappingNhanVienDtos();
            }
            catch (Exception)
            {
                count = 0;
                return null;
            }
        }

        public async Task<IEnumerable<NhanVienDto>> GetAll()
        {
            try {
                var result = await nhanVienRepository.GetAll();
                return result.MappingNhanVienDtos();
            }
            catch(Exception) {
                return null;
            }
        }

        public async Task<NhanVienDto> GetBy(int id)
        {
            try{
                var result = await nhanVienRepository.GetBy(id);
                return result.MappingNhanVienDto();
            }
            catch(Exception) {
                return null;
            }
        }

        public async Task<NhanVienDto> GetByUser(string user)
        {
            try {
                var result = await nhanVienRepository.GetByUser(user);
                return result.MappingNhanVienDto();
            }
            catch(Exception) {
                return null;
            }
        }

        public async Task<NhanVienDto> Update(NhanVienDto entity)
        {
            // try {
            //     var nhanvien = entity.MappingNhanVien();
            //     var result = await nhanVienRepository.Update(nhanvien);
            //     return entity;
            // }
            // catch(Exception) {
            //     return null;
            // }

            var nhanvien = entity.MappingNhanVien();
            var result = await nhanVienRepository.Update(nhanvien);
            return result.MappingNhanVienDto();
        }

        public async Task<NhanVienDto> UpdateByUser(NhanVienDto entity)
        {
            var nv = entity.MappingNhanVien();
            // Console.WriteLine(nv.Id);
            var result = await nhanVienRepository.UpdateByUser(nv);
            if(result != null) {
                return result.MappingNhanVienDto();
            }
            return null;
        }   
    }
}