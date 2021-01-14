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
    public class KhoaConfiguration : IEntityTypeConfiguration<Khoa>
    {
        public void Configure(EntityTypeBuilder<Khoa> builder)
        {
            builder.ToTable("Khoa");
            builder.HasKey(x => x.IdKhoa);
            builder.Property(x => x.TenKhoa).IsRequired().HasMaxLength(200);
            builder.Property(x => x.KhoaID).IsRequired().HasDefaultValue(0);
        }
    }
}
