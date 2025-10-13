using ECommerce.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce.Data.Configurations
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Surname).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Email).HasMaxLength(40);
            builder.Property(x => x.Phone).HasColumnType("nvarchar(15)").HasMaxLength(15);
            builder.Property(x => x.Message).IsRequired().HasMaxLength(500);


        }
    }
}
