using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    public class NGUOIDUNGConfiguration : IEntityTypeConfiguration<NGUOIDUNG>
    {
        public void Configure(EntityTypeBuilder<NGUOIDUNG> builder)
        {
            builder.ToTable("NGUOIDUNGs");
            builder.HasKey(x => x.ID);
            //builder.HasOne(x => x.DMKHACHHANGs).WithMany(x => x.DMBAIVIETs).
            //builder.HasOne(x => x.DMLOAIBAIVIET).WithMany(x => x.DMBAIVIET)
        }
    }
}
