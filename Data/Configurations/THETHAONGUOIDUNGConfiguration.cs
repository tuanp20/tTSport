using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    public class THETHAONGUOIDUNGConfiguration : IEntityTypeConfiguration<THETHAONGUOIDUNG>
    {
        public void Configure(EntityTypeBuilder<THETHAONGUOIDUNG> builder)
        {
            builder.ToTable("THETHAONGUOIDUNGs");
            builder.HasKey(x => x.ID);
        }
    }
}
