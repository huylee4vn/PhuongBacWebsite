using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhuongBac.Data.Entities;
using PhuongBac.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhuongBac.Data.Configurations
{
    public class InsurancePartnerConfiguration : IEntityTypeConfiguration<InsurancePartner>
    {
        public void Configure(EntityTypeBuilder<InsurancePartner> builder)
        {
            builder.ToTable("InsurancePartners");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Logo).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Alt).HasMaxLength(200);
            builder.Property(x => x.Status).IsRequired().HasDefaultValue(Status.Active);
        }
    }
}
