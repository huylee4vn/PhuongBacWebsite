using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhuongBac.Data.Entities;
using PhuongBac.Data.Enums;
using System.Collections.Generic;
using System.Text;

namespace PhuongBac.Data.Configurations
{
    public class TypeConfiguration : IEntityTypeConfiguration<Type>
    {
        public void Configure(EntityTypeBuilder<Type> builder)
        {
            builder.ToTable("Types");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Status).HasDefaultValue(Status.Active);
        }
    }
}
