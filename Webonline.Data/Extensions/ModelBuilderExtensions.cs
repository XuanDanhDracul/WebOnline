using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webonline.Data.EF;
using Webonline.Data.Entities;

namespace Webonline.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Khoa>().HasData(
                new Khoa() { IdKhoa = 123, TenKhoa = "KhoaCNTT" },
                new Khoa() { IdKhoa = 124, TenKhoa = "KhoaCNSinhHoc" },
                new Khoa() { IdKhoa = 125, TenKhoa = "KhoaHoa" }
                );
            modelBuilder.Entity<MonHoc>().HasData(
                new MonHoc() { ID_Mon = 345, Ten_MH = "Toan" },
                new MonHoc() { ID_Mon = 245, Ten_MH = "Van"  },
                new MonHoc() { ID_Mon = 145, Ten_MH = "Hoa" }
                );
            modelBuilder.Entity<SinhVien>().HasData(
                new SinhVien() { id = 1, MaSV = "12345", Name = "Danh", IdKhoa = 123 ,viewCout = 1 },
                new SinhVien() { id = 2, MaSV = "123456", Name = "Nam", IdKhoa = 124 ,viewCout = 2},
                new SinhVien() { id = 3, MaSV = "1234", Name = "Hung", IdKhoa = 123 ,viewCout = 3}
                );
            modelBuilder.Entity<Sinh_Mon>().HasData(
                 new Sinh_Mon() { Id_Mon = 345, SinhvienId = 1 },
                 new Sinh_Mon() { Id_Mon = 345, SinhvienId = 2 },
                 new Sinh_Mon() { Id_Mon = 345, SinhvienId = 3 }
                );

            var ADMIN_ID = new Guid("EA0E744C-D96D-4FC3-ACD2-19D3EB7F5533") ;
            var ADMIN_Role = new Guid("5E848D75-9A0E-40C3-A1CE-E7D0116482B3");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = ADMIN_Role,
                Name = "admin",
                NormalizedName = "admin",
                Description ="Adminstrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = ADMIN_ID,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "XuanDanh@gmail.com",
                NormalizedEmail = "xuandanh@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "abc1234$"),
                SecurityStamp = string.Empty,
                firstname = "Xuan",
                lastname = "Danh",
                Dob = new DateTime(2020,01,31)
                
            });;

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = ADMIN_Role,
                UserId = ADMIN_ID
            });
        }
    }
}
