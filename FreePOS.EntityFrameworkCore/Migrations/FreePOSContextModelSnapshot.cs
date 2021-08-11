﻿// <auto-generated />
using FreePOS.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FreePOS.EntityFrameworkCore.Migrations
{
    [DbContext(typeof(FreePOSContext))]
    partial class FreePOSContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("FreePOS.EntityFrameworkCore.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("address")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("password")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("phone")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("phone2")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("role")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("username")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
