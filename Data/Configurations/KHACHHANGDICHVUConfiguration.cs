using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    public class KHACHHANGDICHVUConfiguration : IEntityTypeConfiguration<KHACHHANGDICHVU>
    {
        public void Configure(EntityTypeBuilder<KHACHHANGDICHVU> builder)
        {
            builder.ToTable("KHACHHANGDICHVUs");
            builder.HasKey(x => x.ID);
        }
    }
}
