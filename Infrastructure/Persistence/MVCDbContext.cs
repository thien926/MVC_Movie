using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Persistence
{
    public class MVCDbContext : DbContext
    {
        public MVCDbContext(DbContextOptions<MVCDbContext> options) : base(options) {}
        
        public DbSet<Quyen> Quyens { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            // Tạo cho NhanViens có trường user là duy nhất
            modelBuilder.Entity<NhanVien>().HasIndex(u => u.user).IsUnique();

            // Cái này là tạo khóa chính
            // modelBuilder.Entity<NhanVien>().HasKey(t => t.Id);
            // modelBuilder.Entity<Quyen>().HasKey(t => t.Id);

            // HasMaxLength éo có tác dụng
            // modelBuilder.Entity<Quyen>().Property(t => t.name)
            //     .IsRequired().HasMaxLength(10);

            // modelBuilder.Entity<NhanVien>(entity => {
            //     entity.HasKey(e => e.nhanvienId);

            //     entity.HasOne<Quyen>(s => s.quyen)
            //         .WithMany(g => g.nhanvien)
            //         .HasForeignKey(s => s.QuyenId);
            // });

            modelBuilder.Entity<NhanVien>()
                .HasOne(e => e.quyen)
                .WithMany(c => c.nhanvien)
                .HasForeignKey(e => e.QuyenId);



            modelBuilder.Entity<Blog>().HasKey(e => e.BlogId);
            modelBuilder.Entity<Post>().HasKey(e => e.PostId);

            modelBuilder.Entity<Post>()
            .HasOne(p => p.Blog)
            .WithMany(b => b.Posts)
            .HasForeignKey(p => p.BlogId);


            Console.WriteLine("Thiện");
        }
    }
}