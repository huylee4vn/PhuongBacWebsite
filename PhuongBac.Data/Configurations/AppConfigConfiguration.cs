using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhuongBac.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongBac.Data.Configurations
{
    public class AppConfigConfiguration : IEntityTypeConfiguration<AppConfig>
    {
        public void Configure(EntityTypeBuilder<AppConfig> builder)
        {
            builder.ToTable("AppConfigs");
            builder.HasKey(x => x.Key);
            builder.Property(x => x.Key).HasMaxLength(100);
            builder.Property(x => x.Value).IsRequired().HasMaxLength(200);
        }
    }
}
