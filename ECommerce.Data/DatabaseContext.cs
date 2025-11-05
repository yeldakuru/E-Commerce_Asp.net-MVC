using ECommerce.Core.Entities;
using ECommerce.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Data
{
   public class DatabaseContext:DbContext
    {
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=YELDA\SQLEXPRESS;Database=ECommerceDb;Trusted_Connection=True;TrustServerCertificate=True;");
           optionsBuilder.ConfigureWarnings(warnings=>warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
            base.OnConfiguring(optionsBuilder);
          
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // modelBuilder.ApplyConfiguration(new AppUserConfiguration()); //ya da böyle teker teker eklenmeli
           modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());//bütün configurationları tek seferde ekler
            base.OnModelCreating(modelBuilder);
        }
    }
}
