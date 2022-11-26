using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhuongBac.Data.Entities;
using PhuongBac.Data.Enums;
using System.Collections.Generic;
using System.Text;

namespace PhuongBac.Data.Configurations
{
    public class VideoConfiguration : IEntityTypeConfiguration<Video>
    {
        public void Configure(EntityTypeBuilder<Video> builder)
        {
            builder.ToTable("Videos");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Description).HasMaxLength(200);
            builder.Property(x => x.Path).IsRequired().HasMaxLength(500);
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
        }
    }
}
