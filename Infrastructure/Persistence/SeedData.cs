using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using System;

namespace Infrastructure.Persistence
{
    public class SeedData
    {
        public static void Initialize(MVCDbContext context) {
            context.Database.EnsureCreated();
            bool temp = false;

            if(!context.Blogs.Any()) {
                temp = true;
                context.Blogs.AddRange(new List<Blog>{
                    new Blog {
                        BlogId = 1,
                        Url = "Blog 1"
                    },
                    new Blog {
                        BlogId = 2,
                        Url = "Blog 2"
                    },
                    new Blog {
                        BlogId = 3,
                        Url = "Blog 3"
                    },
                    new Blog {
                        BlogId = 4,
                        Url = "Blog 4"
                    }
                });
            }

            if(!context.Posts.Any()) {
                temp = true;
                context.Posts.AddRange(new List<Post>{
                    new Post {
                        PostId = 1,
                        Title = "Post 1",
                        Content = "Content 1",
                        BlogId = 1
                    },
                    new Post {
                        PostId = 2,
                        Title = "Post 2",
                        Content = "Content 2",
                        BlogId = 2
                    },
                    new Post {
                        PostId = 3,
                        Title = "Post 3",
                        Content = "Content 3",
                        BlogId = 3
                    },
                    new Post {
                        PostId = 4,
                        Title = "Post 4",
                        Content = "Content 4",
                        BlogId = 4
                    }
                });
            }

            if(!context.Quyens.Any()) {
                temp = true;
                context.Quyens.AddRange(new List<Quyen>{
                    new Quyen{
                        QuyenId = 1,
                        name = "Admin",
                        detail = "qlNhapHang-qlNhanVien-qlSanPham-qlHoaDon-qlKhachHang-qlPhieuNhap-qlNCC-qlTaiKhoan-qlQuyen-qlThongKe-qlLoaiSanPham-qlThuongHieu"
                    },
                    new Quyen{
                        QuyenId = 2,
                        name = "Qu???n l??",
                        detail = "qlNhanVien-xemSanPham-xemHoaDon-qlKhachHang-xemPhieuNhap-xemNCC-qlTaiKhoan-qlThongKe-qlLoaiSanPham-qlThuongHieu"
                    },
                    new Quyen{
                        QuyenId = 3,
                        name = "Nh??n vi??n b??n h??ng",
                        detail = "xemSanPham-qlHoaDon-xemKhachHang-qlThongKe-xemThuongHieu"
                    },
                    new Quyen{
                        QuyenId = 4,
                        name = "Nh??n vi??n nh???p h??ng",
                        detail = "qlNhapHang-qlSanPham-qlPhieuNhap-qlNCC-qlThongKe-qlLoaiSanPham-qlThuongHieu"
                    },
                    new Quyen{
                        QuyenId = 5,
                        name = "Nh??n vi??n nh???p h??ng",
                        detail = ""
                    }
                });
            }

            if(!context.NhanViens.Any()) {
                temp = true;
                context.NhanViens.AddRange(new List<NhanVien>{
                    new NhanVien{
                        nhanvienId = 1,
                        user = "admin",
                        password = "admin",
                        full_name = "Nguy???n Ng???c Thi???n",
                        phone = "0364117408",
                        mail = "tructruong.070202@gmail.com",
                        address = "B??nh ?????nh",
                        gender = Gender.Nam,
                        dateborn = DateTime.Parse("2000-5-8"),
                        QuyenId = 1,
                        status_active = StatusActive.active
                    },
                    new NhanVien{
                        nhanvienId = 2,
                        user = "ql01",
                        password = "ql01",
                        full_name = "Nguy???n T???n Th??ng",
                        phone = "0364117408",
                        mail = "tanthong@gmail.com",
                        address = "H??? Ch?? Minh",
                        gender = Gender.Nam,
                        dateborn = DateTime.Parse("2000-5-8"),
                        QuyenId = 2,
                        status_active = StatusActive.active
                    },
                    new NhanVien{
                        nhanvienId = 3,
                        user = "bh01",
                        password = "bh01",
                        full_name = "Cung X????ng H???ng Thi??n",
                        phone = "0364117408",
                        mail = "cungthien@gmail.com",
                        address = "H??? Ch?? Minh",
                        gender = Gender.Nam,
                        dateborn = DateTime.Parse("2000-5-8"),
                        QuyenId = 3,
                        status_active = StatusActive.active
                    },
                    new NhanVien{
                        nhanvienId = 4,
                        user = "nh01",
                        password = "nh01",
                        full_name = "Nguy???n Tuy???n ?????t",
                        phone = "0364117408",
                        mail = "tuyendat@gmail.com",
                        address = "H??? Ch?? Minh",
                        gender = Gender.Nam,
                        dateborn = DateTime.Parse("2000-5-8"),
                        QuyenId = 2,
                        status_active = StatusActive.active
                    },
                    new NhanVien{
                        nhanvienId = 5,
                        user = "nh02",
                        password = "nh02",
                        full_name = "Nguy???n Tuy???n Trung",
                        phone = "0364117408",
                        mail = "tuyendat@gmail.com",
                        address = "H??? Ch?? Minh",
                        gender = Gender.Nam,
                        dateborn = DateTime.Parse("2000-5-8"),
                        QuyenId = 2,
                        status_active = StatusActive.active
                    },
                    new NhanVien{
                        nhanvienId = 6,
                        user = "nh03",
                        password = "nh03",
                        full_name = "Nguy???n Tuy???n Ba",
                        phone = "0364117408",
                        mail = "tuyendat@gmail.com",
                        address = "H??? Ch?? Minh",
                        gender = Gender.Nam,
                        dateborn = DateTime.Parse("2000-5-8"),
                        QuyenId = 2,
                        status_active = StatusActive.active
                    },
                    new NhanVien{
                        nhanvienId = 7,
                        user = "nh04",
                        password = "nh04",
                        full_name = "Nguy???n Tuy???n B???n",
                        phone = "0364117408",
                        mail = "tuyendat@gmail.com",
                        address = "H??? Ch?? Minh",
                        gender = Gender.Nam,
                        dateborn = DateTime.Parse("2000-5-8"),
                        QuyenId = 2,
                        status_active = StatusActive.active
                    },
                    new NhanVien{
                        nhanvienId = 8,
                        user = "nh08",
                        password = "nh08",
                        full_name = "Nguy???n Tuy???n T??m",
                        phone = "0364117408",
                        mail = "tuyendat@gmail.com",
                        address = "H??? Ch?? Minh",
                        gender = Gender.Nam,
                        dateborn = DateTime.Parse("2000-5-8"),
                        QuyenId = 2,
                        status_active = StatusActive.active
                    },
                    new NhanVien{
                        nhanvienId = 9,
                        user = "nh09",
                        password = "nh09",
                        full_name = "Nguy???n Tuy???n Ch??n",
                        phone = "0364117408",
                        mail = "tuyendat@gmail.com",
                        address = "H??? Ch?? Minh",
                        gender = Gender.Nam,
                        dateborn = DateTime.Parse("2000-5-8"),
                        QuyenId = 2,
                        status_active = StatusActive.active
                    },
                    new NhanVien{
                        nhanvienId = 10,
                        user = "nh10",
                        password = "nh10",
                        full_name = "Nguy???n Tuy???n M?????i",
                        phone = "0364117408",
                        mail = "tuyendat@gmail.com",
                        address = "H??? Ch?? Minh",
                        gender = Gender.Nam,
                        dateborn = DateTime.Parse("2000-5-8"),
                        QuyenId = 2,
                        status_active = StatusActive.active
                    },
                    new NhanVien{
                        nhanvienId = 11,
                        user = "nh11",
                        password = "nh11",
                        full_name = "Nguy???n Ng???c M???t",
                        phone = "0364117408",
                        mail = "tuyendat@gmail.com",
                        address = "H??? Ch?? Minh",
                        gender = Gender.Nam,
                        dateborn = DateTime.Parse("2000-5-8"),
                        QuyenId = 2,
                        status_active = StatusActive.active
                    },
                    new NhanVien{
                        nhanvienId = 12,
                        user = "nh12",
                        password = "nh12",
                        full_name = "Nguy???n Ng???c Hai",
                        phone = "0364117408",
                        mail = "tuyendat@gmail.com",
                        address = "H??? Ch?? Minh",
                        gender = Gender.Nam,
                        dateborn = DateTime.Parse("2000-5-8"),
                        QuyenId = 2,
                        status_active = StatusActive.active
                    },
                    new NhanVien{
                        nhanvienId = 13,
                        user = "nh13",
                        password = "nh13",
                        full_name = "Nguy???n Ng???c Ba",
                        phone = "0364117408",
                        mail = "tuyendat@gmail.com",
                        address = "H??? Ch?? Minh",
                        gender = Gender.Nam,
                        dateborn = DateTime.Parse("2000-5-8"),
                        QuyenId = 2,
                        status_active = StatusActive.active
                    },
                    new NhanVien{
                        nhanvienId = 14,
                        user = "nh14",
                        password = "nh14",
                        full_name = "Nguy???n Ng???c B???n",
                        phone = "0364117408",
                        mail = "tuyendat@gmail.com",
                        address = "H??? Ch?? Minh",
                        gender = Gender.Nam,
                        dateborn = DateTime.Parse("2000-5-8"),
                        QuyenId = 2,
                        status_active = StatusActive.active
                    },
                    new NhanVien{
                        nhanvienId = 15,
                        user = "nh15",
                        password = "nh15",
                        full_name = "Nguy???n Ng???c N??m",
                        phone = "0364117408",
                        mail = "tuyendat@gmail.com",
                        address = "H??? Ch?? Minh",
                        gender = Gender.Nam,
                        dateborn = DateTime.Parse("2000-5-8"),
                        QuyenId = 2,
                        status_active = StatusActive.active
                    },
                    new NhanVien{
                        nhanvienId = 16,
                        user = "nh16",
                        password = "nh16",
                        full_name = "Nguy???n Ng???c S??u",
                        phone = "0364117408",
                        mail = "tuyendat@gmail.com",
                        address = "H??? Ch?? Minh",
                        gender = Gender.Nam,
                        dateborn = DateTime.Parse("2000-5-8"),
                        QuyenId = 2,
                        status_active = StatusActive.active
                    },
                    new NhanVien{
                        nhanvienId = 17,
                        user = "nh17",
                        password = "nh17",
                        full_name = "Nguy???n Ng???c B???y",
                        phone = "0364117408",
                        mail = "tuyendat@gmail.com",
                        address = "H??? Ch?? Minh",
                        gender = Gender.Nam,
                        dateborn = DateTime.Parse("2000-5-8"),
                        QuyenId = 2,
                        status_active = StatusActive.active
                    },
                    new NhanVien{
                        nhanvienId = 18,
                        user = "nh18",
                        password = "nh18",
                        full_name = "Nguy???n Ng???c T??m",
                        phone = "0364117408",
                        mail = "tuyendat@gmail.com",
                        address = "H??? Ch?? Minh",
                        gender = Gender.Nam,
                        dateborn = DateTime.Parse("2000-5-8"),
                        QuyenId = 2,
                        status_active = StatusActive.active
                    },
                    new NhanVien{
                        nhanvienId = 19,
                        user = "nh19",
                        password = "nh19",
                        full_name = "Nguy???n Ng???c Ch??n",
                        phone = "0364117408",
                        mail = "tuyendat@gmail.com",
                        address = "H??? Ch?? Minh",
                        gender = Gender.Nam,
                        dateborn = DateTime.Parse("2000-5-8"),
                        QuyenId = 2,
                        status_active = StatusActive.active
                    },
                    new NhanVien{
                        nhanvienId = 20,
                        user = "nh20",
                        password = "nh20",
                        full_name = "Nguy???n Ng???c M?????i",
                        phone = "0364117408",
                        mail = "tuyendat@gmail.com",
                        address = "H??? Ch?? Minh",
                        gender = Gender.Nam,
                        dateborn = DateTime.Parse("2000-5-8"),
                        QuyenId = 2,
                        status_active = StatusActive.active
                    },
                    new NhanVien{
                        nhanvienId = 21,
                        user = "nh21",
                        password = "nh21",
                        full_name = "Nguy???n V??n M???t",
                        phone = "0364117408",
                        mail = "tuyendat@gmail.com",
                        address = "H??? Ch?? Minh",
                        gender = Gender.Nam,
                        dateborn = DateTime.Parse("2000-5-8"),
                        QuyenId = 2,
                        status_active = StatusActive.active
                    },
                    new NhanVien{
                        nhanvienId = 22,
                        user = "nh22",
                        password = "nh22",
                        full_name = "Nguy???n V??n Hai",
                        phone = "0364117408",
                        mail = "tuyendat@gmail.com",
                        address = "H??? Ch?? Minh",
                        gender = Gender.Nam,
                        dateborn = DateTime.Parse("2000-5-8"),
                        QuyenId = 2,
                        status_active = StatusActive.active
                    },
                    new NhanVien{
                        nhanvienId = 23,
                        user = "nh23",
                        password = "nh23",
                        full_name = "Nguy???n V??n Ba",
                        phone = "0364117408",
                        mail = "tuyendat@gmail.com",
                        address = "H??? Ch?? Minh",
                        gender = Gender.Nam,
                        dateborn = DateTime.Parse("2000-5-9"),
                        QuyenId = 2,
                        status_active = StatusActive.active
                    },
                    new NhanVien{
                        nhanvienId = 24,
                        user = "nh24",
                        password = "nh24",
                        full_name = "Nguy???n V??n B???n",
                        phone = "0364117408",
                        mail = "tuyendat@gmail.com",
                        address = "H??? Ch?? Minh",
                        gender = Gender.Nam,
                        dateborn = DateTime.Parse("2000-5-7"),
                        QuyenId = 2,
                        status_active = StatusActive.active
                    }
                });
            }

            if(temp) {
                context.SaveChanges();
            }
        }
    }
}