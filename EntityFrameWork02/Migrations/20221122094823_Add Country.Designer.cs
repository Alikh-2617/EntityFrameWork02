﻿// <auto-generated />
using System;
using EntityFrameWork02.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityFrameWork02.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221122094823_Add Country")]
    partial class AddCountry
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EntityFrameWork02.Models.City", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PostNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("Register")
                        .HasColumnType("datetime2");

                    b.HasKey("Name");

                    b.ToTable("City");

                    b.HasData(
                        new
                        {
                            Name = "Åre",
                            PostNumber = "123 45",
                            Register = new DateTime(2022, 11, 22, 10, 48, 22, 892, DateTimeKind.Local).AddTicks(8052)
                        },
                        new
                        {
                            Name = "Järpen",
                            PostNumber = "123 45",
                            Register = new DateTime(2022, 11, 22, 10, 48, 22, 892, DateTimeKind.Local).AddTicks(8066)
                        },
                        new
                        {
                            Name = "Östersund",
                            PostNumber = "123 88",
                            Register = new DateTime(2022, 11, 22, 10, 48, 22, 892, DateTimeKind.Local).AddTicks(8075)
                        });
                });

            modelBuilder.Entity("EntityFrameWork02.Models.Country", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Register")
                        .HasColumnType("datetime2");

                    b.HasKey("Name");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("EntityFrameWork02.Models.Person", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("EfterName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Register")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Person");

                    b.HasData(
                        new
                        {
                            Id = "6cfee36d-bdf1-46df-9184-913b925d1c70",
                            Age = 32,
                            EfterName = "Khokho",
                            Name = "Ali",
                            PhoneNumer = "123456",
                            Register = new DateTime(2022, 11, 22, 10, 48, 22, 892, DateTimeKind.Local).AddTicks(7952)
                        },
                        new
                        {
                            Id = "264c11c4-86aa-46c5-9c13-fede88b2420f",
                            Age = 23,
                            EfterName = "klhpioj",
                            Name = "Ali01",
                            PhoneNumer = "123546",
                            Register = new DateTime(2022, 11, 22, 10, 48, 22, 892, DateTimeKind.Local).AddTicks(8012)
                        },
                        new
                        {
                            Id = "e22e1ae9-e8dd-401f-8793-af4c6b03f7d8",
                            Age = 23,
                            EfterName = "klhpioj",
                            Name = "Ali02",
                            PhoneNumer = "123546",
                            Register = new DateTime(2022, 11, 22, 10, 48, 22, 892, DateTimeKind.Local).AddTicks(8025)
                        },
                        new
                        {
                            Id = "e4d7943c-8975-4ca6-9a1f-25c2e5c54dcc",
                            Age = 23,
                            EfterName = "klhpioj",
                            Name = "Ali03",
                            PhoneNumer = "123546",
                            Register = new DateTime(2022, 11, 22, 10, 48, 22, 892, DateTimeKind.Local).AddTicks(8038)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
