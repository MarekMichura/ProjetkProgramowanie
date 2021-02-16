﻿// <auto-generated />
using System;
using DBconnectShop;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DBconnectShop.Migrations
{
    [DbContext(typeof(Shop))]
    partial class ShopModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DBconnectShop.Table.Address", b =>
                {
                    b.Property<int>("Address_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address_building_number")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)");

                    b.Property<string>("Address_city")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)");

                    b.Property<string>("Address_country")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nchar(25)");

                    b.Property<string>("Address_street")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)");

                    b.Property<string>("Address_zip_code")
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)");

                    b.HasKey("Address_id");

                    b.HasIndex("Address_city", "Address_country", "Address_street", "Address_building_number", "Address_zip_code")
                        .IsUnique()
                        .HasFilter("[Address_zip_code] IS NOT NULL");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            Address_id = 1,
                            Address_building_number = "54",
                            Address_city = "Krakow",
                            Address_country = "Polska",
                            Address_street = "Komandora Wrońskiego Bohdana",
                            Address_zip_code = "30-852"
                        });
                });

            modelBuilder.Entity("DBconnectShop.Table.Product", b =>
                {
                    b.Property<int>("Product_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Product_aviable")
                        .HasColumnType("bit");

                    b.Property<int>("Product_category_id")
                        .HasColumnType("int");

                    b.Property<string>("Product_name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nchar(50)");

                    b.HasKey("Product_id");

                    b.HasIndex("Product_category_id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Product_id = 1,
                            Product_aviable = false,
                            Product_category_id = 1,
                            Product_name = "Przykład"
                        });
                });

            modelBuilder.Entity("DBconnectShop.Table.Product_categori", b =>
                {
                    b.Property<int>("Product_category_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Product_category_name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nchar(25)");

                    b.Property<int?>("Product_sub_category")
                        .HasColumnType("int");

                    b.HasKey("Product_category_id");

                    b.HasIndex("Product_sub_category");

                    b.ToTable("Product_categories");

                    b.HasData(
                        new
                        {
                            Product_category_id = 1,
                            Product_category_name = "Przykład"
                        });
                });

            modelBuilder.Entity("DBconnectShop.Table.Product_image", b =>
                {
                    b.Property<int>("Product_image_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Product_Image")
                        .IsRequired()
                        .HasColumnType("varBinary(max)");

                    b.Property<int>("Product_id")
                        .HasColumnType("int");

                    b.Property<bool>("Product_image_active")
                        .HasColumnType("bit");

                    b.HasKey("Product_image_id");

                    b.HasIndex("Product_id");

                    b.ToTable("Product_images");
                });

            modelBuilder.Entity("DBconnectShop.Table.Product_opinion", b =>
                {
                    b.Property<int>("Product_opinion_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Product_Opinion")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nchar(200)");

                    b.Property<int>("Product_id")
                        .HasColumnType("int");

                    b.Property<int>("User_id")
                        .HasColumnType("int");

                    b.HasKey("Product_opinion_id");

                    b.HasIndex("Product_id");

                    b.HasIndex("User_id");

                    b.ToTable("Product_opinions");
                });

            modelBuilder.Entity("DBconnectShop.Table.Product_rating", b =>
                {
                    b.Property<int>("Product_id")
                        .HasColumnType("int");

                    b.Property<int>("User_id")
                        .HasColumnType("int");

                    b.Property<byte>("Product_Rating")
                        .HasColumnType("tinyint");

                    b.HasKey("Product_id", "User_id");

                    b.ToTable("Product_ratings");
                });

            modelBuilder.Entity("DBconnectShop.Table.Product_specification", b =>
                {
                    b.Property<int>("Product_specification_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Product_id")
                        .HasColumnType("int");

                    b.Property<string>("Product_specification_name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nchar(30)");

                    b.Property<string>("Product_specification_value")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nchar(25)");

                    b.HasKey("Product_specification_id");

                    b.HasIndex("Product_id");

                    b.ToTable("Product_specifications");
                });

            modelBuilder.Entity("DBconnectShop.Table.Products_price", b =>
                {
                    b.Property<int>("Product_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Product_price_date")
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("SYSDATETIME()");

                    b.Property<decimal>("Product_price")
                        .HasColumnType("smallmoney");

                    b.HasKey("Product_id", "Product_price_date");

                    b.ToTable("Products_price");

                    b.HasData(
                        new
                        {
                            Product_id = 1,
                            Product_price_date = new DateTime(2021, 2, 16, 12, 34, 2, 656, DateTimeKind.Local).AddTicks(6064),
                            Product_price = 100m
                        });
                });

            modelBuilder.Entity("DBconnectShop.Table.User", b =>
                {
                    b.Property<int>("User_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("User_active")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<int>("User_group_id")
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<string>("User_name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nchar(25)");

                    b.Property<string>("User_password")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nchar(25)");

                    b.HasKey("User_id");

                    b.HasIndex("User_group_id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            User_id = 1,
                            User_active = true,
                            User_group_id = 3,
                            User_name = "Admin",
                            User_password = "admin"
                        });
                });

            modelBuilder.Entity("DBconnectShop.Table.User_address", b =>
                {
                    b.Property<int>("User_Address_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Address_id")
                        .HasColumnType("int");

                    b.Property<int>("User_id")
                        .HasColumnType("int");

                    b.HasKey("User_Address_id");

                    b.HasIndex("User_id");

                    b.HasIndex("Address_id", "User_id")
                        .IsUnique();

                    b.ToTable("User_Addresses");
                });

            modelBuilder.Entity("DBconnectShop.Table.User_data", b =>
                {
                    b.Property<int>("User_id")
                        .HasColumnType("int");

                    b.Property<byte[]>("User_avatar")
                        .HasColumnType("varBinary(max)");

                    b.Property<string>("User_family_name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nchar(25)");

                    b.Property<string>("User_first_name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nchar(25)");

                    b.Property<string>("User_second_name")
                        .HasMaxLength(25)
                        .HasColumnType("nchar(25)");

                    b.HasKey("User_id");

                    b.ToTable("Users_data");
                });

            modelBuilder.Entity("DBconnectShop.Table.User_group", b =>
                {
                    b.Property<int>("User_group_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("User_group_name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nchar(25)");

                    b.HasKey("User_group_id");

                    b.ToTable("User_groups");

                    b.HasData(
                        new
                        {
                            User_group_id = 1,
                            User_group_name = "Klient"
                        },
                        new
                        {
                            User_group_id = 2,
                            User_group_name = "Pracownik"
                        },
                        new
                        {
                            User_group_id = 3,
                            User_group_name = "Administrator"
                        });
                });

            modelBuilder.Entity("DBconnectShop.Table.User_order", b =>
                {
                    b.Property<int>("User_order_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("User_Address_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("User_order_date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smalldatetime")
                        .HasDefaultValueSql("SYSDATETIME()");

                    b.Property<int>("User_order_status_id")
                        .HasColumnType("int");

                    b.HasKey("User_order_id");

                    b.HasIndex("User_Address_id");

                    b.HasIndex("User_order_status_id");

                    b.ToTable("User_orders");
                });

            modelBuilder.Entity("DBconnectShop.Table.User_order_product", b =>
                {
                    b.Property<int>("User_order_Products_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Product_id")
                        .HasColumnType("int");

                    b.Property<decimal>("User_order_Product_price")
                        .HasColumnType("smallmoney");

                    b.Property<int>("User_order_id")
                        .HasColumnType("int");

                    b.HasKey("User_order_Products_id");

                    b.HasIndex("Product_id");

                    b.HasIndex("User_order_id");

                    b.ToTable("User_order_Products");
                });

            modelBuilder.Entity("DBconnectShop.Table.User_order_status", b =>
                {
                    b.Property<int>("User_order_status_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("User_order_status_name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nchar(25)");

                    b.HasKey("User_order_status_id");

                    b.ToTable("User_order_status");

                    b.HasData(
                        new
                        {
                            User_order_status_id = 1,
                            User_order_status_name = "Złożone"
                        },
                        new
                        {
                            User_order_status_id = 2,
                            User_order_status_name = "Wykonane"
                        },
                        new
                        {
                            User_order_status_id = 3,
                            User_order_status_name = "Zrealizowane"
                        },
                        new
                        {
                            User_order_status_id = 4,
                            User_order_status_name = "Zwrucone"
                        });
                });

            modelBuilder.Entity("DBconnectShop.Table.Product", b =>
                {
                    b.HasOne("DBconnectShop.Table.Product_categori", "Product_Categori")
                        .WithMany("Products")
                        .HasForeignKey("Product_category_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product_Categori");
                });

            modelBuilder.Entity("DBconnectShop.Table.Product_categori", b =>
                {
                    b.HasOne("DBconnectShop.Table.Product_categori", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("Product_sub_category");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("DBconnectShop.Table.Product_image", b =>
                {
                    b.HasOne("DBconnectShop.Table.Product", "Product")
                        .WithMany("Product_Images")
                        .HasForeignKey("Product_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DBconnectShop.Table.Product_opinion", b =>
                {
                    b.HasOne("DBconnectShop.Table.Product", "Product")
                        .WithMany("Product_Opinions")
                        .HasForeignKey("Product_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DBconnectShop.Table.User", "User")
                        .WithMany("Product_Opinions")
                        .HasForeignKey("User_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DBconnectShop.Table.Product_rating", b =>
                {
                    b.HasOne("DBconnectShop.Table.Product", "Product")
                        .WithMany("Product_Ratings")
                        .HasForeignKey("Product_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DBconnectShop.Table.User", "User")
                        .WithMany("Product_Ratings")
                        .HasForeignKey("Product_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DBconnectShop.Table.Product_specification", b =>
                {
                    b.HasOne("DBconnectShop.Table.Product", "Product")
                        .WithMany("Product_Specifications")
                        .HasForeignKey("Product_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DBconnectShop.Table.Products_price", b =>
                {
                    b.HasOne("DBconnectShop.Table.Product", "Product")
                        .WithMany("Products_Prices")
                        .HasForeignKey("Product_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DBconnectShop.Table.User", b =>
                {
                    b.HasOne("DBconnectShop.Table.User_group", "User_Group")
                        .WithMany("Users")
                        .HasForeignKey("User_group_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User_Group");
                });

            modelBuilder.Entity("DBconnectShop.Table.User_address", b =>
                {
                    b.HasOne("DBconnectShop.Table.Address", "Address")
                        .WithMany("User_Addresses")
                        .HasForeignKey("Address_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DBconnectShop.Table.User", "User")
                        .WithMany("User_Address")
                        .HasForeignKey("User_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DBconnectShop.Table.User_data", b =>
                {
                    b.HasOne("DBconnectShop.Table.User", "User")
                        .WithOne("User_Data")
                        .HasForeignKey("DBconnectShop.Table.User_data", "User_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DBconnectShop.Table.User_order", b =>
                {
                    b.HasOne("DBconnectShop.Table.User_address", "Address")
                        .WithMany("User_Orders")
                        .HasForeignKey("User_Address_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DBconnectShop.Table.User_order_status", "Order_Status")
                        .WithMany("User_Orders")
                        .HasForeignKey("User_order_status_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Order_Status");
                });

            modelBuilder.Entity("DBconnectShop.Table.User_order_product", b =>
                {
                    b.HasOne("DBconnectShop.Table.Product", "Product")
                        .WithMany("Order_Products")
                        .HasForeignKey("Product_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DBconnectShop.Table.User_order", "Order")
                        .WithMany("Products")
                        .HasForeignKey("User_order_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DBconnectShop.Table.Address", b =>
                {
                    b.Navigation("User_Addresses");
                });

            modelBuilder.Entity("DBconnectShop.Table.Product", b =>
                {
                    b.Navigation("Order_Products");

                    b.Navigation("Product_Images");

                    b.Navigation("Product_Opinions");

                    b.Navigation("Product_Ratings");

                    b.Navigation("Product_Specifications");

                    b.Navigation("Products_Prices");
                });

            modelBuilder.Entity("DBconnectShop.Table.Product_categori", b =>
                {
                    b.Navigation("Children");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("DBconnectShop.Table.User", b =>
                {
                    b.Navigation("Product_Opinions");

                    b.Navigation("Product_Ratings");

                    b.Navigation("User_Address");

                    b.Navigation("User_Data");
                });

            modelBuilder.Entity("DBconnectShop.Table.User_address", b =>
                {
                    b.Navigation("User_Orders");
                });

            modelBuilder.Entity("DBconnectShop.Table.User_group", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("DBconnectShop.Table.User_order", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("DBconnectShop.Table.User_order_status", b =>
                {
                    b.Navigation("User_Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
