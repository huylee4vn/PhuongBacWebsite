using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhuongBac.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongBac.Data.Configurations
{
    public class VideoInCategoryConfiguration : IEntityTypeConfiguration<VideoInCategory>
    {
        public void Configure(EntityTypeBuilder<VideoInCategory> builder)
        {
            builder.ToTable("VideoInCategories");
            builder.HasKey(x => new { x.VideoId, x.CategoryId });
            builder.HasOne(p => p.Video).WithMany(pc => pc.VideoInCategories).HasForeignKey(p => p.VideoId);
            builder.HasOne(p => p.Category).WithMany(pc => pc.VideoInCategories).HasForeignKey(p => p.CategoryId);
        }
    }
}
