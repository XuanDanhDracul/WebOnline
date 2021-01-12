using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webonline.Data.Entities;

namespace Webonline.Data.Configuration
{
    public class MonHocKhoaConfiguration : IEntityTypeConfiguration<MonHocKhoa>
    {
        public void Configure(EntityTypeBuilder<MonHocKhoa> builder)
        {
            builder.ToTable("MonHocKhoa");
            builder.HasKey(t => new { t.KhoaID, t.MonhocID });
            builder.HasOne(t => t.Khoa)
                .WithMany(t => t.MonHocKhoa)
                .HasForeignKey(t => t.KhoaID);
            builder.HasOne(t => t.monHoc)
                .WithMany(t => t.MonHocKhoa)
                .HasForeignKey(t => t.MonhocID);
        }
    }
}
