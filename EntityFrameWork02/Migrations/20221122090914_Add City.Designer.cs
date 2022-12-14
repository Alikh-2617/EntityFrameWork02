// <auto-generated />
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
    [Migration("20221122090914_Add City")]
    partial class AddCity
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
                            Id = "017f0385-d4a6-4740-bb5d-dda497a3e52a",
                            Age = 32,
                            EfterName = "Khokho",
                            Name = "Ali",
                            PhoneNumer = "123456",
                            Register = new DateTime(2022, 11, 22, 10, 9, 13, 774, DateTimeKind.Local).AddTicks(1313)
                        },
                        new
                        {
                            Id = "a4163bae-7a4c-4c73-abff-2e7abf11e929",
                            Age = 23,
                            EfterName = "klhpioj",
                            Name = "Ali01",
                            PhoneNumer = "123546",
                            Register = new DateTime(2022, 11, 22, 10, 9, 13, 774, DateTimeKind.Local).AddTicks(1375)
                        },
                        new
                        {
                            Id = "5bc06464-25f0-4a61-9ed2-157cea84bab9",
                            Age = 23,
                            EfterName = "klhpioj",
                            Name = "Ali02",
                            PhoneNumer = "123546",
                            Register = new DateTime(2022, 11, 22, 10, 9, 13, 774, DateTimeKind.Local).AddTicks(1389)
                        },
                        new
                        {
                            Id = "24450063-ff35-45de-b299-2074e9115c74",
                            Age = 23,
                            EfterName = "klhpioj",
                            Name = "Ali03",
                            PhoneNumer = "123546",
                            Register = new DateTime(2022, 11, 22, 10, 9, 13, 774, DateTimeKind.Local).AddTicks(1401)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
