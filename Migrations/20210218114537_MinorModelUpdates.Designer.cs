﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication2021.Models;

namespace WebApplication2021.Migrations
{
    [DbContext(typeof(WebAppDbContext))]
    [Migration("20210218114537_MinorModelUpdates")]
    partial class MinorModelUpdates
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication2021.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClientName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("WebApplication2021.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("ProductCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ProductSalePrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("WebApplication2021.Models.Sale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClientSoldToId")
                        .HasColumnType("int");

                    b.Property<int?>("ProductSoldId")
                        .HasColumnType("int");

                    b.Property<int>("UnitsSold")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientSoldToId");

                    b.HasIndex("ProductSoldId");

                    b.ToTable("Sales");
                });

            modelBuilder.Entity("WebApplication2021.Models.Sale", b =>
                {
                    b.HasOne("WebApplication2021.Models.Client", "ClientSoldTo")
                        .WithMany("Sales")
                        .HasForeignKey("ClientSoldToId");

                    b.HasOne("WebApplication2021.Models.Product", "ProductSold")
                        .WithMany("SalesOfProduct")
                        .HasForeignKey("ProductSoldId");

                    b.Navigation("ClientSoldTo");

                    b.Navigation("ProductSold");
                });

            modelBuilder.Entity("WebApplication2021.Models.Client", b =>
                {
                    b.Navigation("Sales");
                });

            modelBuilder.Entity("WebApplication2021.Models.Product", b =>
                {
                    b.Navigation("SalesOfProduct");
                });
#pragma warning restore 612, 618
        }
    }
}
