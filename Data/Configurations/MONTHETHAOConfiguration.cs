using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    public class MONTHETHAOConfiguration : IEntityTypeConfiguration<MONTHETHAO>
    {
        public void Configure(EntityTypeBuilder<MONTHETHAO> builder)
        {
            builder.ToTable("MONTHETHAOs");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.SPORT_NAME).HasMaxLength(250);
        }
    }
}
