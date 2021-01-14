using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using Webonline.Data.Configuration;
using Webonline.Data.Entities;
using Webonline.Data.Extensions;

namespace Webonline.Data.EF
{
    public class SchoolDbConnect : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public SchoolDbConnect(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppConfiguration());
            modelBuilder.ApplyConfiguration(new KhoaSinhVienConfiguration());
            modelBuilder.ApplyConfiguration(new MonHocConfiguration());
            modelBuilder.ApplyConfiguration(new MonHocKhoaConfiguration());
            modelBuilder.ApplyConfiguration(new SinhVienMonHocConfiguration());
            modelBuilder.ApplyConfiguration(new AppRoleConfigrution());
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new SinhVienConfiguration());
            modelBuilder.ApplyConfiguration(new KhoaConfiguration());
            modelBuilder.ApplyConfiguration(new ProductImageConfiguration());

            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaim");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);
            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaim");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserToken").HasKey(x => x.UserId); 
            modelBuilder.Seed();
        }

        public DbSet<Khoa> Khoas { set; get; }
        public DbSet<MonHoc> MonHocs { set; get; }
        public DbSet<SinhVien> SinhViens { set; get; }
        public DbSet<Sinh_Mon> sinh_Mons { set; get; }
        public DbSet<MonHocKhoa> MonHocKhoas { set; get; }
        public DbSet<AppUser> AppUsers { set; get; }
        public DbSet<AppRole> AppRoles { set; get; }
        public DbSet<ProductImage> ProductImages { set; get; }
    }
}
