using Data.Entities;
using Data.Enums;
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
            builder.Property(x => x.USERNAME).IsRequired();
            builder.Property(x => x.PASSWORD).IsRequired();
            builder.Property(x => x.SEX).HasDefaultValue(Sex.Nam);
        }
    }
}
