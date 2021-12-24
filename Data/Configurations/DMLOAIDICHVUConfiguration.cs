using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    public class DMLOAIDICHVUConfiguration : IEntityTypeConfiguration<DMLOAIDICHVU>
    {
        public void Configure(EntityTypeBuilder<DMLOAIDICHVU> builder)
        {
            builder.ToTable("DMLOAIDICHVUs");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.TENDICHVU).HasMaxLength(250);
        }
    }
}
