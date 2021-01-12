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
    public class MonHocConfiguration : IEntityTypeConfiguration<MonHoc>
    {
        public void Configure(EntityTypeBuilder<MonHoc> builder)
        {
            builder.ToTable("MonHoc");
            builder.HasKey(x=>x.ID_Mon);
            builder.Property(y => y.Ten_MH).IsRequired().HasMaxLength(50).HasColumnName("TenMonHoc");
        }
    }
}
