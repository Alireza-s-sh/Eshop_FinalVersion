using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyEshop.Models;

namespace MyEshop.Data
{
    public class MyEshopContext : DbContext
    {
        public MyEshopContext(DbContextOptions<MyEshopContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryToProduct> CategoryToProducts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryToProduct>()
                .HasKey(t => new { t.ProductId, t.CategoryId });

            modelBuilder.Entity<Item>(i =>
            {
                i.Property(w => w.Price).HasColumnType("Money");
                i.HasKey(w => w.Id);
            });

            #region Seed Data Category

            modelBuilder.Entity<Category>().HasData(new Category()
            {
                Id = 1,
                Name = "لباس",
                Description = "کلاه ، پیرهن، شلوار،..."
            },
                new Category()
                {
                    Id = 2,
                    Name = "اکسسوری",
                    Description = "گردنبند، دستبند،..."
                },
                new Category()
                {
                    Id = 3,
                    Name = "لپ تاپ",
                    Description = "Asus, Hp, Apple, ..."
                },
                new Category()
                {
                    Id = 4,
                    Name = "موبایل",
                    Description = "Apple , samsung, ..."
                }
            );

            modelBuilder.Entity<Item>().HasData(
                new Item()
                {
                    Id = 1,
                    Price = 500,
                    QuantityInStock = 30
                },
            new Item()
            {
                Id = 2,
                Price = 60,
                QuantityInStock = 100
            },
            new Item()
            {
                Id = 3,
                Price = 2500,
                QuantityInStock = 15
            },
            new Item()
            {
                Id = 4,
                Price = 2000,
                QuantityInStock = 12
            }
            );

            modelBuilder.Entity<Product>().HasData(new Product()
                {
                    Id = 1,
                    ItemId = 1,
                    Name = "کلاه1",
                    Description = "",
                    
                       
                },
                new Product()
                {
                    Id = 2,
                    ItemId = 2,
                    Name = "گردنبند1",
                    Description = ""                        
                },
                new Product()
                {
                    Id = 3,
                    ItemId = 3,
                    Name = "لپ تاپ1",
                    Description = ""
                },
                new Product()
                {
                    Id = 4,
                    ItemId = 4,
                    Name = "موبایل1",
                    Description = ""
                });

            modelBuilder.Entity<CategoryToProduct>().HasData(
                new CategoryToProduct() { CategoryId = 1,ProductId = 1},
                new CategoryToProduct() { CategoryId = 2,ProductId = 2},
                new CategoryToProduct() { CategoryId = 3,ProductId = 3},
                new CategoryToProduct() { CategoryId = 4,ProductId = 4}
                );
            #endregion
            base.OnModelCreating(modelBuilder);
        }
    }
}
