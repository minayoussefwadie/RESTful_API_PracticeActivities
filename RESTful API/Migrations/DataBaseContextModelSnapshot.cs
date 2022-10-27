﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RESTful_API.Models;

namespace RESTful_API.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    partial class DataBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RESTful_API.Models.Category", b =>
                {
                    b.Property<int>("CatID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("CatID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CatID = 1,
                            Name = "Headphones"
                        },
                        new
                        {
                            CatID = 2,
                            Name = "Mobile Phones"
                        });
                });

            modelBuilder.Entity("RESTful_API.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CatID")
                        .HasColumnType("int");

                    b.Property<string>("ImgURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CatID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CatID = 1,
                            ImgURL = "https://images-eu.ssl-images-amazon.com/images/I/2110TEYPKnL._AC_SX368_.jpg",
                            Name = "Samsung Galaxy Buds2 Pro Bluetooth Earbuds",
                            Price = 1f,
                            Quantity = 1
                        },
                        new
                        {
                            ID = 2,
                            CatID = 1,
                            ImgURL = "https://images-eu.ssl-images-amazon.com/images/I/2110TEYPKnL._AC_SX368_.jpg",
                            Name = "Huawei Freebuds Pro 2, Dual Speaker True Sound, Pure Voice, Silver",
                            Price = 2f,
                            Quantity = 2
                        },
                        new
                        {
                            ID = 3,
                            CatID = 2,
                            ImgURL = "https://m.media-amazon.com/images/I/91GtFUXNGTL._AC_SX679_.jpg",
                            Name = "SAMSUNG Dual Sim 12GB RAM 256GB 5G Galaxy S22 Ultra - Phantom Black",
                            Price = 3f,
                            Quantity = 3
                        });
                });

            modelBuilder.Entity("RESTful_API.Models.Product", b =>
                {
                    b.HasOne("RESTful_API.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CatID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
