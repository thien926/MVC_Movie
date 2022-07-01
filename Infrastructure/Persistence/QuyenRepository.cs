using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Repositories;

namespace Infrastructure.Persistence
{
    public class QuyenRepository : EFRepository<Quyen>, IQuyenrepository
    {
        public QuyenRepository(MVCDbContext context) : base(context) {}

        public int GetIdByName(string name)
        {
            var result = _context.Quyens.FirstOrDefault(m => m.name == name);
            if(result != null) {
                return result.QuyenId;
            }
            return -1;
        }

        public IEnumerable<string> GetNameAll()
        {
            var result = _context.Quyens
                .OrderBy(m => m.name)
                .Select(m => m.name)
                .Distinct();
            return result;
        }
    }
}