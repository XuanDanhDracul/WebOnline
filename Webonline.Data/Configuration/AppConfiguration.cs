using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Webonline.Data.EF;

namespace Webonline.Data.Configuration
{
    class AppConfiguration : IEntityTypeConfiguration<Khoa>
    {
        public void Configure(EntityTypeBuilder<Khoa> builder)
        {
            builder.ToTable("Khoa");
            builder.HasKey(x => x.IdKhoa);
            builder.Property(y => y.TenKhoa).IsRequired().HasMaxLength(50).HasColumnName("TenKhoa");
        }
    }
}
