using ECommerce.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Data.Configurations
{
    public class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Logo).HasMaxLength(50);

            builder.HasData(
              new Brand { Id = 1, Name = "Asus" },
              new Brand { Id = 2, Name = "HP" },
              new Brand { Id = 3, Name = "Sony" },
              new Brand { Id = 4, Name = "MSI" },
              new Brand { Id = 5, Name = "Logitech" },
               new Brand { Id = 6, Name = "Apple" },
              new Brand { Id = 7, Name = "Samsung" },
              new Brand { Id = 8, Name = "Dell" },
               new Brand { Id = 9, Name = "Canon" }
             );

        }
    }
}
