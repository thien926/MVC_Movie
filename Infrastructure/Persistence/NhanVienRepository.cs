using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public class NhanVienRepository : EFRepository<NhanVien>, INhanVienRepository
    {
        public NhanVienRepository(MVCDbContext context) : base(context) {}

        public async Task<NhanVien> DeleteByUser(string user)
        {
            var result = await GetByUser(user);
            if(result != null) {
                _context.NhanViens.Remove(result);
                await _context.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<NhanVien> UpdateByUser(NhanVien entity) {
            // Console.WriteLine(entity.Id);
            var result = await _context.NhanViens.FirstOrDefaultAsync(e => e.nhanvienId == entity.nhanvienId);
            // Console.WriteLine(result.Id + " " + result.user);
            if(result != null) {
                result.password = entity.password;
                result.full_name = entity.full_name;
                result.phone = entity.phone;
                result.mail = entity.mail;
                result.address = entity.address;
                result.gender = entity.gender;
                result.dateborn = entity.dateborn;
                result.QuyenId = entity.QuyenId;
                result.status_active = entity.status_active;
                await _context.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public IEnumerable<NhanVien> Filter(int typeQuyen, string searchString, string sortString, int pageIndex, int pageSize, out int count)
        {
            var query = _context.NhanViens.AsQueryable();
            
            if(typeQuyen >= 0) {
                query = query.Where(m => m.QuyenId == typeQuyen);
            }

            if(!string.IsNullOrEmpty(searchString)) {
                searchString = searchString.ToLower();
                query = query.Where(m => m.full_name.ToLower().Contains(searchString));
            }

            SortNhanViens(sortString, ref query);
            count = query.Count();

            return query.Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize).ToList();
        }

        public async Task<NhanVien> GetByUser(string user)
        {
            return await _context.NhanViens.FirstOrDefaultAsync(e => e.user.Contains(user));
        }

        private static void SortNhanViens(string sortString, ref IQueryable<NhanVien> query)
        {
            switch (sortString)
            {
                case "id_desc":
                    query = query.OrderByDescending(m => m.nhanvienId);
                    break;
                case "id":
                    query = query.OrderBy(m => m.nhanvienId);
                    break;
                case "name_desc":
                    query = query.OrderByDescending(m => m.full_name);
                    break;
                case "name":
                    query = query.OrderBy(m => m.full_name);
                    break;
                case "user_desc":
                    query = query.OrderByDescending(m => m.user);
                    break;
                case "user":
                    query = query.OrderBy(m => m.user);
                    break;
                case "phone_desc":
                    query = query.OrderByDescending(m => m.phone);
                    break;
                case "phone":
                    query = query.OrderBy(m => m.phone);
                    break;
                case "gender_desc":
                    query = query.OrderByDescending(m => m.gender);
                    break;
                case "gender":
                    query = query.OrderBy(m => m.gender);
                    break;
                case "address_desc":
                    query = query.OrderByDescending(m => m.address);
                    break;
                case "address":
                    query = query.OrderBy(m => m.address);
                    break;
                case "dateborn_desc":
                    query = query.OrderByDescending(m => m.dateborn);
                    break;
                case "dateborn":
                    query = query.OrderBy(m => m.dateborn);
                    break;
                case "QuyenId_desc":
                    query = query.OrderByDescending(m => m.QuyenId);
                    break;
                case "QuyenId":
                    query = query.OrderBy(m => m.QuyenId);
                    break;
                case "status_active_desc":
                    query = query.OrderByDescending(m => m.status_active);
                    break;
                case "status_active":
                    query = query.OrderBy(m => m.status_active);
                    break;
            }
        }
    }
}