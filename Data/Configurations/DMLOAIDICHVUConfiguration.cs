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
            //builder.HasOne(x => x.DMKHACHHANGs).WithMany(x => x.DMBAIVIETs).
            //builder.HasOne(x => x.DMLOAIBAIVIET).WithMany(x => x.DMBAIVIET)
        }
    }
}
