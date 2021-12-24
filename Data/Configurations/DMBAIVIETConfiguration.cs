using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;               

namespace Data.Configurations
{
    public class DMBAIVIETConfiguration : IEntityTypeConfiguration<DMBAIVIET>
    {
        public void Configure(EntityTypeBuilder<DMBAIVIET> builder)
        {
            builder.ToTable("DMBAIVIETs");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.TENBAI).HasMaxLength(250);
        }
    }
}
