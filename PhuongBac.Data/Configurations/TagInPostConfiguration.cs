using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhuongBac.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongBac.Data.Configurations
{
    public class TagInPostConfiguration : IEntityTypeConfiguration<TagInPost>
    {
        public void Configure(EntityTypeBuilder<TagInPost> builder)
        {
            builder.ToTable("TagInPosts");
            builder.HasKey(x => new { x.TagId, x.PostId });
            builder.HasOne(p => p.Tag).WithMany(pc => pc.TagInPosts).HasForeignKey(p => p.TagId);
            builder.HasOne(p => p.Post).WithMany(pc => pc.TagInPosts).HasForeignKey(p => p.PostId);
        }
    }
}
