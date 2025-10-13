﻿using ECommerce.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Configuration;

namespace ECommerce.Data.Configurations
{
    public class SliderConfiguration : IEntityTypeConfiguration<Slider>
    {
        public void Configure(EntityTypeBuilder<Slider> builder)
        {
            builder.Property(x => x.Title).HasMaxLength(250);
            builder.Property(x => x.Description).HasMaxLength(500);
            builder.Property(x => x.Image).HasMaxLength(100);
            builder.Property(x => x.Link).HasMaxLength(100);
        }
    }
}
