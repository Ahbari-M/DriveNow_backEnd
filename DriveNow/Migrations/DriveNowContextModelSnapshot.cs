﻿// <auto-generated />
using System;
using DriveNow.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DriveNow.Migrations
{
    [DbContext(typeof(DriveNowContext))]
    partial class DriveNowContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DriveNow.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FuelType")
                        .HasColumnType("int");

                    b.Property<int>("Km")
                        .HasColumnType("int");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("ProductionYear")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Car");
                });

            modelBuilder.Entity("DriveNow.Models.ReservationPeriod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("ReservationPeriods");
                });

            modelBuilder.Entity("DriveNow.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("DriveNow.Models.Admin", b =>
                {
                    b.HasBaseType("DriveNow.Models.User");

                    b.ToTable("Admin", (string)null);
                });

            modelBuilder.Entity("DriveNow.Models.Owner", b =>
                {
                    b.HasBaseType("DriveNow.Models.User");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CIN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("HasAgancy")
                        .HasColumnType("bit");

                    b.ToTable("Owner", (string)null);
                });

            modelBuilder.Entity("DriveNow.Models.Tenant", b =>
                {
                    b.HasBaseType("DriveNow.Models.User");

                    b.Property<string>("CIN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Tenant", (string)null);
                });

            modelBuilder.Entity("DriveNow.Models.ReservationPeriod", b =>
                {
                    b.HasOne("DriveNow.Models.Car", "Car")
                        .WithMany("ReservationPeriods")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");
                });

            modelBuilder.Entity("DriveNow.Models.Admin", b =>
                {
                    b.HasOne("DriveNow.Models.User", null)
                        .WithOne()
                        .HasForeignKey("DriveNow.Models.Admin", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DriveNow.Models.Owner", b =>
                {
                    b.HasOne("DriveNow.Models.User", null)
                        .WithOne()
                        .HasForeignKey("DriveNow.Models.Owner", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DriveNow.Models.Tenant", b =>
                {
                    b.HasOne("DriveNow.Models.User", null)
                        .WithOne()
                        .HasForeignKey("DriveNow.Models.Tenant", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DriveNow.Models.Car", b =>
                {
                    b.Navigation("ReservationPeriods");
                });
#pragma warning restore 612, 618
        }
    }
}
