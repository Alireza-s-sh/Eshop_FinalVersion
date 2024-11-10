﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyEshop.Data;

namespace WebApplication3.Migrations
{
    [DbContext(typeof(MyEshopContext))]
    [Migration("20240826192550_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyEshop.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "کلاه ، پیرهن، شلوار،...",
                            Name = "لباس"
                        },
                        new
                        {
                            Id = 2,
                            Description = "گردنبند، دستبند،...",
                            Name = "اکسسوری"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Asus, Hp, Apple, ...",
                            Name = "لپ تاپ"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Apple , samsung, ...",
                            Name = "موبایل"
                        });
                });

            modelBuilder.Entity("MyEshop.Models.CategoryToProduct", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("CategoryToProducts");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 2
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 3
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 4
                        });
                });

            modelBuilder.Entity("MyEshop.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Price")
                        .HasColumnType("Money");

                    b.Property<int>("QuantityInStock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Price = 500m,
                            QuantityInStock = 30
                        },
                        new
                        {
                            Id = 2,
                            Price = 60m,
                            QuantityInStock = 100
                        },
                        new
                        {
                            Id = 3,
                            Price = 2500m,
                            QuantityInStock = 15
                        },
                        new
                        {
                            Id = 4,
                            Price = 2000m,
                            QuantityInStock = 12
                        });
                });

            modelBuilder.Entity("MyEshop.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsFinaly")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("MyEshop.Models.OrderDetail", b =>
                {
                    b.Property<int>("DetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("DetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("MyEshop.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ItemId")
                        .IsUnique();

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "",
                            ItemId = 1,
                            Name = "کلاه1"
                        },
                        new
                        {
                            Id = 2,
                            Description = "",
                            ItemId = 2,
                            Name = "گردنبند1"
                        },
                        new
                        {
                            Id = 3,
                            Description = "",
                            ItemId = 3,
                            Name = "لپ تاپ1"
                        },
                        new
                        {
                            Id = 4,
                            Description = "",
                            ItemId = 4,
                            Name = "موبایل1"
                        });
                });

            modelBuilder.Entity("MyEshop.Models.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("datetime2");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MyEshop.Models.CategoryToProduct", b =>
                {
                    b.HasOne("MyEshop.Models.Category", "Category")
                        .WithMany("CategoryToProducts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyEshop.Models.Product", "Product")
                        .WithMany("CategoryToProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyEshop.Models.Order", b =>
                {
                    b.HasOne("MyEshop.Models.Users", "Users")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyEshop.Models.OrderDetail", b =>
                {
                    b.HasOne("MyEshop.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyEshop.Models.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyEshop.Models.Product", b =>
                {
                    b.HasOne("MyEshop.Models.Item", "Item")
                        .WithOne("Product")
                        .HasForeignKey("MyEshop.Models.Product", "ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
