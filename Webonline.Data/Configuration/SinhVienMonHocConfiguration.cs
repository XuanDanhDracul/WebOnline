using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using Webonline.Data.Entities;
using Webonline.Data.EF;


namespace Webonline.Data.Configuration
{
    class SinhVienMonHocConfiguration : IEntityTypeConfiguration<Sinh_Mon>
    {
        public void Configure(EntityTypeBuilder<Sinh_Mon> builder)
        {
            builder.ToTable("MonHocSinhVien");
            builder.HasKey(t => new { t.Id_Mon, t.SinhvienId });
            builder.HasOne(t => t.SinhVien)
                .WithMany(t => t.SinhMon)
                .HasForeignKey(pc => pc.SinhvienId);
            builder.HasOne(t => t.MonHoc)
                .WithMany(t => t.SinhMon)
                .HasForeignKey(t => t.Id_Mon);
        }
    }
}
