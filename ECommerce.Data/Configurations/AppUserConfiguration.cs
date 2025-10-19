using ECommerce.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Data.Configurations
{
    internal class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasColumnType("varchar(50)").HasMaxLength(50);
            builder.Property(x => x.Surname).IsRequired().HasColumnType("varchar(50)").HasMaxLength(50);
            builder.Property(x => x.Email).IsRequired().HasColumnType("varchar(50)").HasMaxLength(50);
            builder.Property(x => x.Phone).HasColumnType("varchar(15)").HasMaxLength(15);
            builder.Property(x => x.Password).IsRequired().HasColumnType("nvarchar(50)").HasMaxLength(50);
            builder.Property(x => x.UserName).HasColumnType("varchar(50)").HasMaxLength(50);

            //seed data,admin kaydı için
            builder.HasData(
                new AppUser
                {
                    Id = 1,
                    UserName= "admin",
                    Email="admin@gmail.com",
                    IsActive=true,
                    IsAdmin=true,
                    Name="test",
                    Password="123456",
                    Surname="user"

                }, new AppUser
                {
                    Id = 2,
                    UserName = "yelda",
                    Email = "yelda@example.com",
                    IsActive = true,
                    IsAdmin = false,
                    Name = "Yelda",
                    Surname = "Kuru",
                    Password = "123456"
                },
            new AppUser
            {
                Id = 3,
                UserName = "ahmet",
                Email = "ahmet@example.com",
                IsActive = true,
                IsAdmin = false,
                Name = "Ahmet",
                Surname = "Demir",
                Password = "654321"
            },
            new AppUser
            {
                Id = 4,
                UserName = "elif",
                Email = "elif@example.com",
                IsActive = true,
                IsAdmin = false,
                Name = "Elif",
                Surname = "Yılmaz",
                Password = "123123"
            });
        }
    }
}
