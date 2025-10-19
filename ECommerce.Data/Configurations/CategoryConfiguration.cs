
using ECommerce.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
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

                },
               new Category
               {
                   Id = 3,
                   Name = "Monitör",
                   IsActive = true,
                   IsTopMenu = false,
                   ParentId = 1, // Elektronik altında
                   OrderNo = 3
               },
                new Category
                {
                    Id = 4,
                    Name = "Klavye",
                    IsActive = true,
                    IsTopMenu = false,
                    ParentId = 2, // Bilgisayar altında
                    OrderNo = 4
                },
                  new Category
                  {
                      Id = 5,
                      Name = "Konsol",
                      IsActive = true,
                      IsTopMenu = false,
                      ParentId = 1, // Elektronik altında
                      OrderNo = 5
                  },
                   new Category
                   {
                       Id = 6,
                       Name = "Aksesuar",
                       IsActive = true,
                       IsTopMenu = false,
                       ParentId = 0, // Elektronik altında
                       OrderNo = 6
                   }



               );



        }
    }
}
