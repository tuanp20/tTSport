using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    public class KETBANConfiguration : IEntityTypeConfiguration<KETBAN>
    {
        public void Configure(EntityTypeBuilder<KETBAN> builder)
        {
            builder.ToTable("KETBANs");
            builder.HasKey(x => x.ID);
        }
    }
}
