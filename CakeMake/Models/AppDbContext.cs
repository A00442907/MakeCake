using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeMake.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options)
        {
        }

        public DbSet<Cake> Cakes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShopppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Payment> Payments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Chocolate Cake" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Fruit Cake" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Jelly Cake" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "DarkChocolate Cake" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 5, CategoryName = "Vanilla Cake" });

            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 1,
                Name = "Chocolate Cake 1",
                Price = 4.95M,
                Description = "Cake Description 1",
                CategoryId = 1,
                ImageUrl="\\Images\\chocolateCake.jpg",
                ImageThumbnailUrl= "\\Images\\thumbnails\\chocolateCake-small.jpg",
                IsInStock=true,
                IsOnSale=false
            });
            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 2,
                Name = "Chocolate Cake 2",
                Price = 3.95M,
                Description = "Cake Description 2",
                CategoryId = 1,
                ImageUrl = "\\Images\\chocolateCake2.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\chocolateCake2-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 3,
                Name = "Chocolate Cake 3",
                Price = 5.75M,
                Description = "Cake Description 3",
                CategoryId = 1,
                ImageUrl = "\\Images\\chocolateCake3.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\chocolateCake3-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 4,
                Name = "Fruit Cake 1",
                Price = 3.95M,
                Description = "Fruit Cake Description 1",
                CategoryId = 2,
                ImageUrl = "\\Images\\fruitCake.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\fruitCake-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 5,
                Name = "Fruit Cake 2",
                Price = 7.00M,
                Description = "Fruit Cake Description 2",
                CategoryId = 2,
                ImageUrl = "\\Images\\fruitCake2.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\fruitCake2-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 6,
                Name = "Fruit Cake 3",
                Price = 11.25M,
                Description = "Fruit Cake Description 3",
                CategoryId = 2,
                ImageUrl = "\\Images\\fruitCake3.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\fruitCake3-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 7,
                Name = "Jelly Cake 1",
                Price = 3.95M,
                Description = "Jelly Cake Description 1",
                CategoryId = 3,
                ImageUrl = "\\Images\\JellyCake.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\JellyCake-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 8,
                Name = "Jelly Cake 2",
                Price = 1.95M,
                Description = "Jelly Cake Description 2",
                CategoryId = 3,
                ImageUrl = "\\Images\\JellyCake2.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\JellyCake2-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 9,
                Name = "Jelly Cake 3",
                Price = 13.95M,
                Description = "Jelly Cake Description 3",
                CategoryId = 3,
                ImageUrl = "\\Images\\JellyCake3.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\JellyCake3-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 10,
                Name = "DarkChocolate Cake 1",
                Price = 1.95M,
                Description = "DarkChocolate Description Cake 1",
                CategoryId = 4,
                ImageUrl = "\\Images\\DarkChocolateCake.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\DarkChocolateCake-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 11,
                Name = "DarkChocolate Cake 2",
                Price = 12.95M,
                Description = "DarkChocolate Description Cake 2",
                CategoryId = 4,
                ImageUrl = "\\Images\\DarkChocolateCake2.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\DarkChocolateCake2-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 12,
                Name = "DarkChocolate Cake 3",
                Price = 21.95M,
                Description = "DarkChocolate Description Cake 3",
                CategoryId = 4,
                ImageUrl = "\\Images\\DarkChocolateCake3.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\DarkChocolateCake3-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 13,
                Name = "Vanilla Cake 1",
                Price = 6.95M,
                Description = "Vanilla Cake Description 1",
                CategoryId = 5,
                ImageUrl = "\\Images\\VanillaCake.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\VanillaCake-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 14,
                Name = "Vanilla Cake 2",
                Price = 2.95M,
                Description = "Vanilla Cake Description 2",
                CategoryId = 5,
                ImageUrl = "\\Images\\VanillaCake2.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\VanillaCake2-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Cake>().HasData(new Cake
            {
                CakeId = 15,
                Name = "Vanilla Cake 3",
                Price = 16.95M,
                Description = "Vanilla Cake Description 3",
                CategoryId = 5,
                ImageUrl = "\\Images\\VanillaCake3.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\VanillaCake3-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
        }
    }
}
