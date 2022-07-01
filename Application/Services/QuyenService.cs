using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.DTOs;
using Application.Interfaces;
using Application.Mappings;
using Domain.Repositories;

namespace Application.Services
{
    public class QuyenService : IQuyenService
    {
        private readonly IQuyenrepository quyenRepository;
        public QuyenService(IQuyenrepository quyenRepository) {
            this.quyenRepository = quyenRepository;
        }
        public async Task<QuyenDto> Add(QuyenDto entity)
        {
            try {
                var quyen = entity.MappingQuyen();
                var result = await quyenRepository.Add(quyen);
                return entity;
            }
            catch(Exception) {
                return null;
            }
        }

        public async Task<QuyenDto> Delete(int id)
        {
            try {
                var result = await quyenRepository.Delete(id);
                return result.MappingQuyenDto();
            }
            catch(Exception) {
                return null;
            }
        }

        public async Task<IEnumerable<QuyenDto>> GetAll()
        {
            try {
                var result = await quyenRepository.GetAll();
                return result.MappingQuyenDtos();
            }
            catch(Exception) {
                return null;
            }
        }

        public async Task<QuyenDto> GetBy(int id)
        {
            try {
                var result = await quyenRepository.GetBy(id);
                return result.MappingQuyenDto();
            }
            catch(Exception) {
                return null;
            }
        }

        public async Task<QuyenDto> Update(QuyenDto entity)
        {
            // try {
            //     var quyen = entity.MappingQuyen();
            //     var result = await quyenRepository.Update(quyen);
            //     return entity;
            // }
            // catch(Exception) {
            //     return null;
            // }
            var quyen = entity.MappingQuyen();
                var result = await quyenRepository.Update(quyen);
                return entity;
        }

        public IEnumerable<string> GetNameAll(){
            try
            {
                return quyenRepository.GetNameAll();
            }
            catch (System.Exception)
            {
                return null;
            }
        }

        public int GetIdByName(string name)
        {
            return quyenRepository.GetIdByName(name);
        }
    }
}