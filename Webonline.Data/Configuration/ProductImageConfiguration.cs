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
    class ProductImageConfiguration : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.ToTable("Images");
            builder.HasKey(x => x.id);
            builder.Property(x => x.Isdefault).IsRequired();
            builder.Property(x => x.path).IsRequired().HasMaxLength(200);
            builder.Property(x => x.SortImage).IsRequired().HasMaxLength(200);
            builder.Property(x => x.FileSize).IsRequired().HasMaxLength(200);
            builder.Property(x => x.CreateIma).IsRequired();
            builder.Property(x => x.Caption).IsRequired().HasMaxLength(200);
            builder.HasOne(c => c.sinhVien).WithMany(c => c.productImages).HasForeignKey(c => c.productID);
        }
    }
}
