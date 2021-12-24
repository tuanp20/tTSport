using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    public class MESSAGEConfiguration : IEntityTypeConfiguration<MESSAGE>
    {
        public void Configure(EntityTypeBuilder<MESSAGE> builder)
        {
            builder.ToTable("MESSAGEs");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.SUBJECT).HasMaxLength(250);
        }
    }
}
