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
    class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable("AppUser");
            builder.Property(c => c.firstname).HasMaxLength(200).IsRequired();
            builder.Property(c => c.lastname).HasMaxLength(200).IsRequired();
            builder.Property(c => c.Dob).IsRequired();
        }
    }
}
