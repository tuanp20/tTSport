using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    public class DMLOAIBAIVIETConfiguration : IEntityTypeConfiguration<DMLOAIBAIVIET>
    {
        public void Configure(EntityTypeBuilder<DMLOAIBAIVIET> builder)
        {
            builder.ToTable("DMLOAIBAIVIETs");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.TENLOAI).HasMaxLength(250);
        }
    }
}
