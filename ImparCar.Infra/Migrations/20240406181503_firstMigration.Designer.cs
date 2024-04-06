﻿// <auto-generated />
using System;
using ImparCar.Infra.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ImparCar.Infra.Migrations
{
    [DbContext(typeof(SqlContexts))]
    [Migration("20240406181503_firstMigration")]
    partial class firstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ImparCar.Domain.Entities.Car", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Nome");

                    b.Property<Guid>("PhotoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("1")
                        .HasColumnName("Status");

                    b.HasKey("Id");

                    b.HasIndex("PhotoId")
                        .IsUnique();

                    b.ToTable("Car", (string)null);
                });

            modelBuilder.Entity("ImparCar.Domain.Entities.Photo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<byte[]>("Base64")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("Photo", (string)null);
                });

            modelBuilder.Entity("ImparCar.Domain.Entities.Car", b =>
                {
                    b.HasOne("ImparCar.Domain.Entities.Photo", "Photo")
                        .WithOne("Car")
                        .HasForeignKey("ImparCar.Domain.Entities.Car", "PhotoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Photo");
                });

            modelBuilder.Entity("ImparCar.Domain.Entities.Photo", b =>
                {
                    b.Navigation("Car");
                });
#pragma warning restore 612, 618
        }
    }
}
