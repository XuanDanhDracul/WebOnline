using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webonline.Data.Configuration;
using Webonline.Data.Entities;

namespace Webonline.Data.EF
{
    public class SchoolDbConnect : DbContext
    {
        public SchoolDbConnect( DbContextOptions options) :base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppConfiguration());
            modelBuilder.ApplyConfiguration(new KhoaSinhVienConfiguration());
            modelBuilder.ApplyConfiguration(new MonHocConfiguration());
            modelBuilder.ApplyConfiguration(new MonHocKhoaConfiguration());
            modelBuilder.ApplyConfiguration(new SinhVienMonHocConfiguration());
        }

        DbSet<Khoa> Khoas { set; get; }
        DbSet<MonHoc> MonHocs { set; get; }
        DbSet<SinhVien> SinhViens { set; get; }
        DbSet<Sinh_Mon> sinh_Mons { set; get; }
    }
}
