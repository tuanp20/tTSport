using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    public class DMBAIVIETConfiguration : IEntityTypeConfiguration<DMBAIVIET>
    {
        public void Configure(EntityTypeBuilder<DMBAIVIET> builder)
        {
            builder.ToTable("DMBAIVIETs");
            builder.HasKey(x => x.ID);
            //builder.HasOne(x => x.DMKHACHHANGs).WithMany(x => x.DMBAIVIETs).
            //builder.HasOne(x => x.DMLOAIBAIVIET).WithMany(x => x.DMBAIVIET)
        }
    }
}
