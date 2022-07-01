using System.Collections.Generic;
using Application.DTOs;
using Domain.Entities;

namespace Application.Mappings
{
    public static class MappingQuyenProfile
    {
        public static QuyenDto MappingQuyenDto(this Quyen Q) {
            return new QuyenDto{
                QuyenId = Q.QuyenId,
                name = Q.name,
                detail = Q.detail
            };
        }

        public static Quyen MappingQuyen(this QuyenDto Qdto) {
            return new Quyen {
                QuyenId = Qdto.QuyenId,
                name = Qdto.name,
                detail = Qdto.detail
            };
        }

        public static void MappingQuyen(this QuyenDto Qdto, Quyen Q) {
            Q.name = Qdto.name;
            Q.detail = Qdto.detail;
        }

        public static IEnumerable<QuyenDto> MappingQuyenDtos(this IEnumerable<Quyen> quyens) {
            foreach(var q in quyens) {
                yield return q.MappingQuyenDto();
            }
        }
    }
}