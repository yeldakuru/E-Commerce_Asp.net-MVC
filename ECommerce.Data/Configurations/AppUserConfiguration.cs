using ECommerce.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Data.Configurations
{
    internal class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(x=>x.Name).IsRequired().HasColumnType("nvarchar(20)").HasMaxLength(20);
            builder.Property(x => x.Surname).IsRequired().HasColumnType("nvarchar(20)").HasMaxLength(20);
            builder.Property(x => x.Email).IsRequired().HasColumnType("nvarchar(40)").HasMaxLength(40);
            builder.Property(x => x.Phone).HasColumnType("nvarchar(15)").HasMaxLength(15);
            builder.Property(x => x.Password).IsRequired().HasColumnType("nvarchar(20)").HasMaxLength(20);
            builder.Property(x => x.UserName).HasColumnType("nvarchar(20)").HasMaxLength(20);

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

                });
        }
    }
}
