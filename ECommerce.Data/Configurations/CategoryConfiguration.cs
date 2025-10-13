﻿
using ECommerce.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Image).HasMaxLength(50);

            builder.HasData(
               new Category
               {
                   Name = "Elektronik",
                   Id = 1,
                   IsActive = true,
                   IsTopMenu = true,
                   ParentId = 0,
                   OrderNo = 1,

               },
                new Category
                {
                    Name = "Bilgisayar",
                    Id = 2,
                    IsActive = true,
                    IsTopMenu = true,
                    ParentId = 0,
                    OrderNo = 2,

                }
               );



        }
    }
}
