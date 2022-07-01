using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Repositories
{
    public interface IQuyenrepository : IRepository<Quyen>
    {
        IEnumerable<string> GetNameAll();
        int GetIdByName(string name);
    }
}