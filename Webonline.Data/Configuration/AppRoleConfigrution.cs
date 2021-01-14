﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webonline.Data.Entities;

namespace Webonline.Data.Configuration
{
    public class AppRoleConfigrution : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.ToTable("AppRole");
            builder.Property(c=>c.Description).HasMaxLength(50).IsRequired();
        }
    }
}
