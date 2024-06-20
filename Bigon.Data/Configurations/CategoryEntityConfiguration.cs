﻿using Bigon.Data.Configurations;
using Bigon.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bigon.Data.Persistance.Configuration
{
    public class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnType("int");
            builder.Property(x => x.Name).HasColumnType("nvarchar").HasMaxLength(200).IsRequired();
            builder.Property(x => x.Description).HasColumnType("nvarchar(Max)");
            builder.ConfigureAsAuditable();
            builder.Property(x => x.ParentId).HasColumnType("int");
        }
    }
}