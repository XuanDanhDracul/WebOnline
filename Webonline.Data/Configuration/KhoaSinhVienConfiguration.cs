using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Webonline.Data.EF;

namespace Webonline.Data.Configuration
{
    public class KhoaSinhVienConfiguration : IEntityTypeConfiguration<Khoa>
    {
        public void Configure(EntityTypeBuilder<Khoa> builder)
        {
            builder.ToTable("KhoaSinhVien");
            builder.HasMany(c => c.SinhViens)
                .WithOne(c => c.Khoa)
                .HasForeignKey(t => t.IdKhoa);
        }
    }
}
