using ECommerce.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ECommerce.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.Name).HasMaxLength(150);
            builder.Property(x => x.Image).HasMaxLength(100);
            builder.Property(x => x.ProductCode).HasMaxLength(50);
            builder.HasData(
    new Product
    {
        Id = 1,
        Name = "Asus TUF Gaming Laptop",
        Description = "15.6 inç Full HD, Ryzen 7 işlemci, 16 GB RAM, 512 GB SSD",
        Price = 32999.90m,
        ProductCode = "ASUS-TUF-01",
        Stock = 25,
        IsActive = true,
        IsHome = true,
        CategoryId = 2, // Bilgisayar
        BrandId = 1, // Asus
        OrderNo = 1
    },
    new Product
    {
        Id = 2,
        Name = "HP Pavilion Laptop",
        Description = "13.3 inç, Intel i5, 8 GB RAM, 256 GB SSD",
        Price = 21499.50m,
        ProductCode = "HP-PAV-02",
        Stock = 18,
        IsActive = true,
        IsHome = false,
        CategoryId = 2, // Bilgisayar
        BrandId = 2, // HP
        OrderNo = 2
    },
    new Product
    {
        Id = 3,
        Name = "Sony PlayStation 5",
        Description = "825 GB SSD, DualSense kumanda dahil",
        Price = 25999.00m,
        ProductCode = "SONY-PS5",
        Stock = 10,
        IsActive = true,
        IsHome = true,
        CategoryId = 5, // Konsol
        BrandId = 3, // Sony
        OrderNo = 3
    },
    new Product
    {
        Id = 4,
        Name = "MSI Optix Monitör",
        Description = "27 inç, 165Hz, 1ms, kavisli oyun monitörü",
        Price = 8999.99m,
        ProductCode = "MSI-MON-04",
        Stock = 15,
        IsActive = true,
        IsHome = false,
        CategoryId = 3, // Monitör
        BrandId = 4, // MSI
        OrderNo = 4
    },
    new Product
    {
        Id = 5,
        Name = "Logitech G213 Klavye",
        Description = "RGB aydınlatmalı, suya dayanıklı, oyun klavyesi",
        Price = 2499.90m,
        ProductCode = "LOGI-KLAV-05",
        Stock = 40,
        IsActive = true,
        IsHome = false,
        CategoryId = 4, // Klavye
        BrandId = 5, // Logitech
        OrderNo = 5
    },
    new Product
    {
        Id = 6,
        Name = "Apple MacBook Air",
        Description = "13.3 inç Retina, M1 çip, 8 GB RAM, 256 GB SSD",
        Price = 23999.00m,
        ProductCode = "APPLE-MBA-06",
        Stock = 12,
        IsActive = true,
        IsHome = true,
        CategoryId = 2, // Bilgisayar
        BrandId = 6, // Apple
        OrderNo = 6
    },
    new Product
    {
        Id = 7,
        Name = "Samsung Galaxy Tab S7",
        Description = "11 inç, Snapdragon 865+, 6 GB RAM, 128 GB depolama",
        Price = 10999.90m,
        ProductCode = "SAMSUNG-TAB-07",
        Stock = 20,
        IsActive = true,
        IsHome = false,
        CategoryId = 1, // Elektronik
        BrandId = 7, // Samsung
        OrderNo = 7
    },
    new Product
    {
        Id = 8,
        Name = "Dell XPS 13 Laptop",
        Description = "13.4 inç FHD+, Intel i7, 16 GB RAM, 512 GB SSD",
        Price = 27999.50m,
        ProductCode = "DELL-XPS13-08",
        Stock = 14,
        IsActive = true,
        IsHome = true,
        CategoryId = 2, // Bilgisayar
        BrandId = 8, // Dell
        OrderNo = 8
    },
    new Product
    {
        Id = 9,
        Name = "Canon EOS M50 Kamera",
        Description = "24.1 MP, 4K video, döndürülebilir ekran",
        Price = 7499.99m,
        ProductCode = "CANON-EOSM50-09",
        Stock = 22,
        IsActive = true,
        IsHome = false,
        CategoryId = 1, // Elektronik
        BrandId = 9, // Canon
        OrderNo = 9
    },
     new Product
     {
         Id = 10,
         Name = "Sony WH-1000XM5 Kulaklık",
         Description = "Gürültü engelleme, Bluetooth 5.3, 30 saat pil",
         Price = 9999.90m,
         ProductCode = "SONY-WH1000XM5",
         Stock = 25,
         IsActive = true,
         IsHome = false,
         CategoryId = 6,
         BrandId = 3,
         OrderNo = 10
     },
     new Product
     {
         Id = 11,
         Name = "Asus ROG Klavye",
         Description = "RGB mekanik oyun klavyesi, dayanıklı tuş yapısı",
         Price = 3499.99m,
         ProductCode = "ASUS-ROG-KLAV",
         Stock = 30,
         IsActive = true,
         IsHome = false,
         CategoryId = 4,
         BrandId = 1,
         OrderNo = 11
     },
    new Product
    {
        Id = 12,
        Name = "MSI Gaming Mouse",
        Description = "7200 DPI, ergonomik tasarım, RGB ışıklandırma",
        Price = 1599.50m,
        ProductCode = "MSI-MOUSE-12",
        Stock = 35,
        IsActive = true,
        IsHome = false,
        CategoryId = 6,
        BrandId = 4,
        OrderNo = 12
    }

);

        }

    }
}
