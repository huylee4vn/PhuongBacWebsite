using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhuongBac.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongBac.Data.Configurations
{
    public class PostInCategoryConfiguration : IEntityTypeConfiguration<PostInCategory>
    {
        public void Configure(EntityTypeBuilder<PostInCategory> builder)
        {
            builder.ToTable("PostInCategories");
            builder.HasKey(x => new { x.PostId, x.CategoryId });
            builder.HasOne(p => p.Post).WithMany(pc => pc.PostInCategories).HasForeignKey(p => p.PostId);
            builder.HasOne(p => p.Category).WithMany(pc => pc.PostInCategories).HasForeignKey(p => p.CategoryId);
        }
    }
}
