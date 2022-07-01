using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Repositories
{
    public interface INhanVienRepository : IRepository<NhanVien>
    {
        Task<NhanVien> GetByUser(string user);
        Task<NhanVien> DeleteByUser(string user);
        IEnumerable<NhanVien> Filter(int typeQuyen, string searchString, string sortString, int pageIndex, int pageSize, out int count);
        Task<NhanVien> UpdateByUser(NhanVien entity);
    }
}