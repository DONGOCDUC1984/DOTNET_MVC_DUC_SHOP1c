﻿// <auto-generated />
using System;
using DOTNET_MVC_DUC_SHOP1c.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DOTNET_MVC_DUC_SHOP1c.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DOTNET_MVC_DUC_SHOP1c.Models.AnnualProfit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Month")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("MonthlyProfit")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("AnnualProfits");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Month = "January",
                            MonthlyProfit = 500.0
                        },
                        new
                        {
                            Id = 2,
                            Month = "February",
                            MonthlyProfit = 300.0
                        },
                        new
                        {
                            Id = 3,
                            Month = "March",
                            MonthlyProfit = 600.0
                        },
                        new
                        {
                            Id = 4,
                            Month = "April",
                            MonthlyProfit = 800.0
                        },
                        new
                        {
                            Id = 5,
                            Month = "May",
                            MonthlyProfit = 700.0
                        },
                        new
                        {
                            Id = 6,
                            Month = "June",
                            MonthlyProfit = 200.0
                        });
                });

            modelBuilder.Entity("DOTNET_MVC_DUC_SHOP1c.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("DOTNET_MVC_DUC_SHOP1c.Models.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CartId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("DOTNET_MVC_DUC_SHOP1c.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Fruit and vegetable"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Bread and cake"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Milk"
                        });
                });

            modelBuilder.Entity("DOTNET_MVC_DUC_SHOP1c.Models.District", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProvinceCityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProvinceCityId");

                    b.ToTable("Districts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Ba Dinh",
                            ProvinceCityId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Cau Giay",
                            ProvinceCityId = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "Hoan Kiem",
                            ProvinceCityId = 1
                        },
                        new
                        {
                            Id = 4,
                            Name = "Go Vap",
                            ProvinceCityId = 2
                        },
                        new
                        {
                            Id = 5,
                            Name = "Phu Nhuan",
                            ProvinceCityId = 2
                        },
                        new
                        {
                            Id = 6,
                            Name = "Tan Binh",
                            ProvinceCityId = 2
                        },
                        new
                        {
                            Id = 7,
                            Name = "Do Son",
                            ProvinceCityId = 3
                        },
                        new
                        {
                            Id = 8,
                            Name = "Hong Bang",
                            ProvinceCityId = 3
                        },
                        new
                        {
                            Id = 9,
                            Name = "Le Chan",
                            ProvinceCityId = 3
                        },
                        new
                        {
                            Id = 10,
                            Name = "Ngo Quyen",
                            ProvinceCityId = 3
                        });
                });

            modelBuilder.Entity("DOTNET_MVC_DUC_SHOP1c.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserTel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("totalCost")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DOTNET_MVC_DUC_SHOP1c.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("DOTNET_MVC_DUC_SHOP1c.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DistrictId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProvinceCityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("DistrictId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Sweet.Made in Germany",
                            DistrictId = 1,
                            ImageUrl = "\\images\\product\\Apple1.jpg",
                            Name = "Apple 1",
                            Price = 3.0,
                            ProvinceCityId = 1
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Good.Made in Sweden",
                            DistrictId = 2,
                            ImageUrl = "\\images\\product\\Apple2.jpg",
                            Name = "Apple 2",
                            Price = 8.0,
                            ProvinceCityId = 1
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Sweet.Made in Vietnam",
                            DistrictId = 3,
                            ImageUrl = "\\images\\product\\Apricot.jpg",
                            Name = "Apricot",
                            Price = 6.0,
                            ProvinceCityId = 1
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "Sweet.Made in Vietnam",
                            DistrictId = 4,
                            ImageUrl = "\\images\\product\\Banana.jpg",
                            Name = "Banana",
                            Price = 2.0,
                            ProvinceCityId = 2
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = "Made in Vietnam",
                            DistrictId = 5,
                            ImageUrl = "\\images\\product\\Bell Pepper.jpg",
                            Name = "Bell Pepper",
                            Price = 5.0,
                            ProvinceCityId = 2
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Description = "Sweet.Made in Germany",
                            DistrictId = 6,
                            ImageUrl = "\\images\\product\\Bread1.jpg",
                            Name = "Bread 1",
                            Price = 4.0,
                            ProvinceCityId = 2
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 1,
                            Description = "Made in Vietnam",
                            DistrictId = 7,
                            ImageUrl = "\\images\\product\\Broccoli.jpg",
                            Name = "Broccoli",
                            Price = 6.0,
                            ProvinceCityId = 3
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 1,
                            Description = "High quality, made in Germany",
                            DistrictId = 8,
                            ImageUrl = "\\images\\product\\Cabbage.jpg",
                            Name = "Cabbage",
                            Price = 9.0,
                            ProvinceCityId = 3
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 1,
                            Description = "Delicious, made in Britain",
                            DistrictId = 9,
                            ImageUrl = "\\images\\product\\Carrot.jpg",
                            Name = "Carrot",
                            Price = 2.0,
                            ProvinceCityId = 3
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 1,
                            Description = "High quality, made in Denmark",
                            DistrictId = 10,
                            ImageUrl = "\\images\\product\\Cauliflower.jpg",
                            Name = "Cauliflower",
                            Price = 11.0,
                            ProvinceCityId = 3
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 1,
                            Description = "High quality.Made in Denmark",
                            DistrictId = 1,
                            ImageUrl = "\\images\\product\\Cherry.jpg",
                            Name = "Cherry",
                            Price = 12.0,
                            ProvinceCityId = 1
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 3,
                            Description = "With sugar.Made in Germany",
                            DistrictId = 2,
                            ImageUrl = "\\images\\product\\Cow Milk.jpg",
                            Name = "Cow Milk",
                            Price = 8.0,
                            ProvinceCityId = 1
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 2,
                            Description = "Made in Finland",
                            DistrictId = 3,
                            ImageUrl = "\\images\\product\\Croissant.jpg",
                            Name = "Croissant",
                            Price = 3.0,
                            ProvinceCityId = 1
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 1,
                            Description = "Made in Germany",
                            DistrictId = 4,
                            ImageUrl = "\\images\\product\\Cucumber1.jpg",
                            Name = "Cucumber 1",
                            Price = 2.0,
                            ProvinceCityId = 2
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 1,
                            Description = "Made in Laos",
                            DistrictId = 5,
                            ImageUrl = "\\images\\product\\Cucumber2.jpg",
                            Name = "Cucumber 2",
                            Price = 4.0,
                            ProvinceCityId = 2
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 2,
                            Description = "Made in Vietnam",
                            DistrictId = 6,
                            ImageUrl = "\\images\\product\\French loaf.jpg",
                            Name = "French loaf",
                            Price = 5.0,
                            ProvinceCityId = 2
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 1,
                            Description = "Made in Poland",
                            DistrictId = 7,
                            ImageUrl = "\\images\\product\\Ginger.jpg",
                            Name = "Ginger",
                            Price = 1.0,
                            ProvinceCityId = 3
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 1,
                            Description = "High quality, made in Sweden",
                            DistrictId = 8,
                            ImageUrl = "\\images\\product\\Grapefruit.jpg",
                            Name = "Grapefruit",
                            Price = 4.0,
                            ProvinceCityId = 3
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 1,
                            Description = "Good.Made in Finland",
                            DistrictId = 9,
                            ImageUrl = "\\images\\product\\Grapes1.jpg",
                            Name = "Grapes 1",
                            Price = 3.0,
                            ProvinceCityId = 3
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 1,
                            Description = "Good.Made in Norway",
                            DistrictId = 10,
                            ImageUrl = "\\images\\product\\Grapes2.jpg",
                            Name = "Grapes 2",
                            Price = 7.0,
                            ProvinceCityId = 3
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 3,
                            Description = "Good.Made in Poland",
                            DistrictId = 1,
                            ImageUrl = "\\images\\product\\Soy Milk.jpg",
                            Name = "Soy Milk",
                            Price = 5.0,
                            ProvinceCityId = 1
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 2,
                            Description = "Good.Made in Norway",
                            DistrictId = 2,
                            ImageUrl = "\\images\\product\\Tommaso.jpg",
                            Name = "Tommaso",
                            Price = 2.0,
                            ProvinceCityId = 1
                        });
                });

            modelBuilder.Entity("DOTNET_MVC_DUC_SHOP1c.Models.ProvinceCity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProvinceCities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Ha Noi"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Sai Gon"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Hai Phong"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("DOTNET_MVC_DUC_SHOP1c.Models.CartItem", b =>
                {
                    b.HasOne("DOTNET_MVC_DUC_SHOP1c.Models.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartId");

                    b.HasOne("DOTNET_MVC_DUC_SHOP1c.Models.Product", "Product")
                        .WithMany("CartItem")
                        .HasForeignKey("ProductId");

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DOTNET_MVC_DUC_SHOP1c.Models.District", b =>
                {
                    b.HasOne("DOTNET_MVC_DUC_SHOP1c.Models.ProvinceCity", "ProvinceCity")
                        .WithMany("Districts")
                        .HasForeignKey("ProvinceCityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProvinceCity");
                });

            modelBuilder.Entity("DOTNET_MVC_DUC_SHOP1c.Models.OrderItem", b =>
                {
                    b.HasOne("DOTNET_MVC_DUC_SHOP1c.Models.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DOTNET_MVC_DUC_SHOP1c.Models.Product", "Product")
                        .WithMany("OrderItem")
                        .HasForeignKey("ProductId");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DOTNET_MVC_DUC_SHOP1c.Models.Product", b =>
                {
                    b.HasOne("DOTNET_MVC_DUC_SHOP1c.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DOTNET_MVC_DUC_SHOP1c.Models.District", "District")
                        .WithMany()
                        .HasForeignKey("DistrictId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("District");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DOTNET_MVC_DUC_SHOP1c.Models.Cart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("DOTNET_MVC_DUC_SHOP1c.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("DOTNET_MVC_DUC_SHOP1c.Models.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("DOTNET_MVC_DUC_SHOP1c.Models.Product", b =>
                {
                    b.Navigation("CartItem");

                    b.Navigation("OrderItem");
                });

            modelBuilder.Entity("DOTNET_MVC_DUC_SHOP1c.Models.ProvinceCity", b =>
                {
                    b.Navigation("Districts");
                });
#pragma warning restore 612, 618
        }
    }
}
