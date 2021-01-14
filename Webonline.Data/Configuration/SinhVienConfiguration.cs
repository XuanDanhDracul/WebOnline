using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webonline.Data.EF;

namespace Webonline.Data.Configuration
{
    public class SinhVienConfiguration : IEntityTypeConfiguration<SinhVien>
    {
        public void Configure(EntityTypeBuilder<SinhVien> builder)
        {
            builder.ToTable("SinhVien");
            builder.HasKey(x => x.id);
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.MaSV).IsRequired();
            builder.Property(x => x.viewCout).IsRequired().HasDefaultValue(0);
        }
    }
}
