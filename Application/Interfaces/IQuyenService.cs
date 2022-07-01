using System.Collections.Generic;
using System.Threading.Tasks;
using Application.DTOs;

namespace Application.Interfaces
{
    public interface IQuyenService
    {
        Task<IEnumerable<QuyenDto>> GetAll();
        Task<QuyenDto> GetBy(int id);
        Task<QuyenDto> Add(QuyenDto entity);
        Task<QuyenDto> Update(QuyenDto entity);
        Task<QuyenDto> Delete(int id);
        IEnumerable<string> GetNameAll();
        int GetIdByName(string name);
    }
}