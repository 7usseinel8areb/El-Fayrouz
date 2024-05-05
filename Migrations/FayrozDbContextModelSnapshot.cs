﻿// <auto-generated />
using System;
using Fayroz.ContextDbConfig;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Fayroz.Migrations
{
    [DbContext(typeof(FayrozDbContext))]
    partial class FayrozDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Fayroz.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DeliveryPrice")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityName = "Damietta",
                            DeliveryPrice = 20
                        },
                        new
                        {
                            Id = 2,
                            CityName = "New Damietta",
                            DeliveryPrice = 20
                        },
                        new
                        {
                            Id = 3,
                            CityName = "Ras El Bar",
                            DeliveryPrice = 20
                        },
                        new
                        {
                            Id = 4,
                            CityName = "Kafr Saad",
                            DeliveryPrice = 20
                        },
                        new
                        {
                            Id = 5,
                            CityName = "Faraskur",
                            DeliveryPrice = 10
                        },
                        new
                        {
                            Id = 6,
                            CityName = "Zarqa",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 7,
                            CityName = "Kafr El-Battikh",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 8,
                            CityName = "El-Zarka",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 9,
                            CityName = "El-Sherbin",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 10,
                            CityName = "Azbet El-Borg",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 11,
                            CityName = "El-Zarka El Hamra",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 12,
                            CityName = "El-Nawawra",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 13,
                            CityName = "El-Shata",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 14,
                            CityName = "El-Tabloul",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 15,
                            CityName = "Kafr El-Dawwar",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 16,
                            CityName = "El-Bana",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 17,
                            CityName = "El-Sheikhy",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 18,
                            CityName = "Al-Galala",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 19,
                            CityName = "El-Azab",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 20,
                            CityName = "El-Haraqia",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 21,
                            CityName = "El-Negaila",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 22,
                            CityName = "El-Rahmaniya",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 23,
                            CityName = "Kafr El-Batikh El-Bahary",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 24,
                            CityName = "El-Qarya El-Bayda",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 25,
                            CityName = "El-Safha",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 26,
                            CityName = "El-Maghara",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 27,
                            CityName = "El-Harath",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 28,
                            CityName = "El-Sameil",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 29,
                            CityName = "El-Qasrayn",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 30,
                            CityName = "El-Mahgoubin",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 31,
                            CityName = "Kafr El-Meselha",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 32,
                            CityName = "El-Athar",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 33,
                            CityName = "El-Khashab",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 34,
                            CityName = "El-Seyouf",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 35,
                            CityName = "El-Gendi",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 36,
                            CityName = "El-Saadat",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 37,
                            CityName = "El-Hanout",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 38,
                            CityName = "El-Safira",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 39,
                            CityName = "El-Rouda",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 40,
                            CityName = "El-Mahamid",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 41,
                            CityName = "El-Dammara",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 42,
                            CityName = "El-Ameriya",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 43,
                            CityName = "El-Manshiya",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 44,
                            CityName = "El-Dahab",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 45,
                            CityName = "El-Katiba",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 46,
                            CityName = "El-Qasas",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 47,
                            CityName = "El-Sawalha",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 48,
                            CityName = "El-Matareya",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 49,
                            CityName = "El-Qawafeer",
                            DeliveryPrice = 25
                        },
                        new
                        {
                            Id = 50,
                            CityName = "El-Berkit",
                            DeliveryPrice = 25
                        });
                });

            modelBuilder.Entity("Fayroz.Models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RecipeId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("Fayroz.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Cake"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Pie"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Biscuit"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Sable"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Kunafa"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Pancake"
                        });
                });

            modelBuilder.Entity("Fayroz.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("RecipeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RecipeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Fayroz.Models.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal?>("Price")
                        .IsRequired()
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("isSpecial")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("Fayroz.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

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

                    b.ToTable("AspNetUsers", (string)null);
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

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Fayroz.Models.Recipe", b =>
                {
                    b.HasOne("Fayroz.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
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
                    b.HasOne("Fayroz.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Fayroz.Models.User", null)
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

                    b.HasOne("Fayroz.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Fayroz.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
