using System.Collections.Generic;
using Application.DTOs;
using Domain.Entities;

namespace Application.Mappings
{
    public static class MappingNhanVienProfile
    {
        public static NhanVienDto MappingNhanVienDto(this NhanVien NV) {
            return new NhanVienDto {
                nhanvienId = NV.nhanvienId,

                user = NV.user,
                password = NV.password,
                repass = NV.password,
                full_name = NV.full_name,
                phone = NV.phone,
                mail = NV.mail,
                address = NV.address,
                gender = NV.gender,
                dateborn = NV.dateborn,
                QuyenId = NV.QuyenId,
                status_active = NV.status_active
            };
        }

        public static NhanVien MappingNhanVien(this NhanVienDto NVDto) {
            return new NhanVien {
                nhanvienId = NVDto.nhanvienId,

                user = NVDto.user,
                password = NVDto.password,
                full_name = NVDto.full_name,
                phone = NVDto.phone,
                mail = NVDto.mail,
                address = NVDto.address,
                gender = NVDto.gender,
                dateborn = NVDto.dateborn,
                QuyenId = NVDto.QuyenId,
                status_active = NVDto.status_active
            };
        }

        public static void MappingNhanVien(this NhanVienDto NVDto, NhanVien NV) {
            NV.user = NVDto.user;

            NV.password = NVDto.password;
            NV.full_name = NVDto.full_name;
            NV.phone = NVDto.phone;
            NV.mail = NVDto.mail;
            NV.address = NVDto.address;
            NV.gender = NVDto.gender;
            NV.dateborn = NVDto.dateborn;
            NV.QuyenId = NVDto.QuyenId;
            NV.status_active = NVDto.status_active;
        }

        public static IEnumerable<NhanVienDto> MappingNhanVienDtos(this IEnumerable<NhanVien> quyens) {
            foreach(var q in quyens) {
                yield return q.MappingNhanVienDto();
            }
        }
    }
}