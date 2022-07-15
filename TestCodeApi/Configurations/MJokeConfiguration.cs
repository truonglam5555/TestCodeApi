using TestCodeApi.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestCodeApi.Data.Configurations
{
    public class MJokeConfiguration : IEntityTypeConfiguration<MJoke>
    {
        public void Configure(EntityTypeBuilder<MJoke> builder)
        {
            builder.ToTable("MJoke");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Content).HasMaxLength(100);
        }
    }
}
