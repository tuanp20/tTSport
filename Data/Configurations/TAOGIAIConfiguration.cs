using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
    public class TAOGIAIConfiguration : IEntityTypeConfiguration<TAOGIAI>
    {
        public void Configure(EntityTypeBuilder<TAOGIAI> builder)
        {
            builder.ToTable("TAOGIAIs");
            builder.HasKey(x => x.ID);
        }
    }
}
