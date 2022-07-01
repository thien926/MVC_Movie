using System.Collections.Generic;
using System.Threading.Tasks;
using Application.DTOs;

namespace Application.Interfaces
{
    public interface INhanVienService
    {
        Task<IEnumerable<NhanVienDto>> GetAll();
        Task<NhanVienDto> GetBy(int id);
        Task<NhanVienDto> Add(NhanVienDto entity);
        Task<NhanVienDto> Update(NhanVienDto entity);
        Task<NhanVienDto> Delete(int id);
        Task<NhanVienDto> GetByUser(string user);
        Task<NhanVienDto> DeleteByUser(string user);
        IEnumerable<NhanVienDto> Filter(int typeQuyen, string searchString, string sortString, int pageIndex, int pageSize, out int count);
        Task<NhanVienDto> UpdateByUser(NhanVienDto entity);
    }
}