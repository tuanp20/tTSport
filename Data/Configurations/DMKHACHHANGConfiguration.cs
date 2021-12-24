using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    public class DMKHACHHANGConfiguration : IEntityTypeConfiguration<DMKHACHHANG>
    {
        public void Configure(EntityTypeBuilder<DMKHACHHANG> builder)
        {
            builder.ToTable("DMKHACHHANGs");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.TENKHACH).HasMaxLength(250);
           
        }
    }
}
