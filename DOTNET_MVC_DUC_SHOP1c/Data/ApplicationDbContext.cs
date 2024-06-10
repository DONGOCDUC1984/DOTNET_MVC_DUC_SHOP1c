using DOTNET_MVC_DUC_SHOP1c.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DOTNET_MVC_DUC_SHOP1c.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProvinceCity> ProvinceCities { get; set; }
        public DbSet<AnnualProfit> AnnualProfits { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Fruit and vegetable" },
                new Category { Id = 2, Name = "Bread and cake" },
                new Category { Id = 3, Name = "Milk" }
            );

            modelBuilder.Entity<ProvinceCity>().HasData(
               new ProvinceCity { Id = 1, Name = "Ha Noi" },
               new ProvinceCity { Id = 2, Name = "Sai Gon" },
               new ProvinceCity { Id = 3, Name = "Hai Phong" }
            );

            modelBuilder.Entity<District>().HasData(
                new District { Id = 1, Name = "Ba Dinh", ProvinceCityId = 1 },
                new District { Id = 2, Name = "Cau Giay", ProvinceCityId = 1 },
                new District { Id = 3, Name = "Hoan Kiem", ProvinceCityId = 1 },
                new District { Id = 4, Name = "Go Vap", ProvinceCityId = 2 },
                new District { Id = 5, Name = "Phu Nhuan", ProvinceCityId = 2 },
                new District { Id = 6, Name = "Tan Binh", ProvinceCityId = 2 },
                new District { Id = 7, Name = "Do Son", ProvinceCityId = 3 },
                new District { Id = 8, Name = "Hong Bang", ProvinceCityId = 3 },
                new District { Id = 9, Name = "Le Chan", ProvinceCityId = 3 },
                new District { Id = 10, Name = "Ngo Quyen", ProvinceCityId = 3 }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Apple 1", Description = "Sweet.Made in Germany", Price = 3, CategoryId = 1, ProvinceCityId = 1, DistrictId = 1, ImageUrl = "\\images\\product\\Apple1.jpg" },
                new Product { Id = 2, Name = "Apple 2", Description = "Good.Made in Sweden", Price = 8, CategoryId = 1, ProvinceCityId = 1, DistrictId = 2, ImageUrl = "\\images\\product\\Apple2.jpg" },
                new Product { Id = 3, Name = "Apricot", Description = "Sweet.Made in Vietnam", Price = 6, CategoryId = 1, ProvinceCityId = 1, DistrictId = 3, ImageUrl = "\\images\\product\\Apricot.jpg" },
                new Product { Id = 4, Name = "Banana", Description = "Sweet.Made in Vietnam", Price = 2, CategoryId = 1, ProvinceCityId = 2, DistrictId = 4, ImageUrl = "\\images\\product\\Banana.jpg" },
                new Product { Id = 5, Name = "Bell Pepper", Description = "Made in Vietnam", Price = 5, CategoryId = 1, ProvinceCityId = 2, DistrictId = 5, ImageUrl = "\\images\\product\\Bell Pepper.jpg" },
                new Product { Id = 6, Name = "Bread 1", Description = "Sweet.Made in Germany", Price = 4, CategoryId = 2, ProvinceCityId = 2, DistrictId = 6, ImageUrl = "\\images\\product\\Bread1.jpg" },
                new Product { Id = 7, Name = "Broccoli", Description = "Made in Vietnam", Price = 6, CategoryId = 1, ProvinceCityId = 3, DistrictId = 7, ImageUrl = "\\images\\product\\Broccoli.jpg" },
                new Product { Id = 8, Name = "Cabbage", Description = "High quality, made in Germany", Price = 9, CategoryId = 1, ProvinceCityId = 3, DistrictId = 8, ImageUrl = "\\images\\product\\Cabbage.jpg" },
                new Product { Id = 9, Name = "Carrot", Description = "Delicious, made in Britain", Price = 2, CategoryId = 1, ProvinceCityId = 3, DistrictId = 9, ImageUrl = "\\images\\product\\Carrot.jpg" },
                new Product { Id = 10, Name = "Cauliflower", Description = "High quality, made in Denmark", Price = 11, CategoryId = 1, ProvinceCityId = 3, DistrictId = 10, ImageUrl = "\\images\\product\\Cauliflower.jpg" },
                new Product { Id = 11, Name = "Cherry", Description = "High quality.Made in Denmark", Price = 12, CategoryId = 1, ProvinceCityId = 1, DistrictId = 1, ImageUrl = "\\images\\product\\Cherry.jpg" },
                new Product { Id = 12, Name = "Cow Milk", Description = "With sugar.Made in Germany", Price = 8, CategoryId = 3, ProvinceCityId = 1, DistrictId = 2, ImageUrl = "\\images\\product\\Cow Milk.jpg" },
                new Product { Id = 13, Name = "Croissant", Description = "Made in Finland", Price = 3, CategoryId = 2, ProvinceCityId = 1, DistrictId = 3, ImageUrl = "\\images\\product\\Croissant.jpg" },
                new Product { Id = 14, Name = "Cucumber 1", Description = "Made in Germany", Price = 2, CategoryId = 1, ProvinceCityId = 2, DistrictId = 4, ImageUrl = "\\images\\product\\Cucumber1.jpg" },
                new Product { Id = 15, Name = "Cucumber 2", Description = "Made in Laos", Price = 4, CategoryId = 1, ProvinceCityId = 2, DistrictId = 5, ImageUrl = "\\images\\product\\Cucumber2.jpg" },
                new Product { Id = 16, Name = "French loaf", Description = "Made in Vietnam", Price = 5, CategoryId = 2, ProvinceCityId = 2, DistrictId = 6, ImageUrl = "\\images\\product\\French loaf.jpg" },
                new Product { Id = 17, Name = "Ginger", Description = "Made in Poland", Price = 1, CategoryId = 1, ProvinceCityId = 3, DistrictId = 7, ImageUrl = "\\images\\product\\Ginger.jpg" },
                new Product { Id = 18, Name = "Grapefruit", Description = "High quality, made in Sweden", Price = 4, CategoryId = 1, ProvinceCityId = 3, DistrictId = 8, ImageUrl = "\\images\\product\\Grapefruit.jpg" },
                new Product { Id = 19, Name = "Grapes 1", Description = "Good.Made in Finland", Price = 3, CategoryId = 1, ProvinceCityId = 3, DistrictId = 9, ImageUrl = "\\images\\product\\Grapes1.jpg" },
                new Product { Id = 20, Name = "Grapes 2", Description = "Good.Made in Norway", Price = 7, CategoryId = 1, ProvinceCityId = 3, DistrictId = 10, ImageUrl = "\\images\\product\\Grapes2.jpg" },
                new Product { Id = 21, Name = "Soy Milk", Description = "Good.Made in Poland", Price = 5, CategoryId = 3, ProvinceCityId = 1, DistrictId = 1, ImageUrl = "\\images\\product\\Soy Milk.jpg" },
                new Product { Id = 22, Name = "Tommaso", Description = "Good.Made in Norway", Price = 2, CategoryId = 2, ProvinceCityId = 1, DistrictId = 2, ImageUrl = "\\images\\product\\Tommaso.jpg" }
            );

            modelBuilder.Entity<AnnualProfit>().HasData(
              new AnnualProfit { Id = 1, Month = "January", MonthlyProfit = 500 },
              new AnnualProfit { Id = 2, Month = "February", MonthlyProfit = 300 },
              new AnnualProfit { Id = 3, Month = "March", MonthlyProfit = 600 },
              new AnnualProfit { Id = 4, Month = "April", MonthlyProfit = 800 },
              new AnnualProfit { Id = 5, Month = "May", MonthlyProfit = 700 },
              new AnnualProfit { Id = 6, Month = "June", MonthlyProfit = 200 }
            );

        }
     }
}
