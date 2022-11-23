using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameWork02.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "Age", "EfterName", "Name", "PhoneNumer", "Register" },
                values: new object[,]
                {
                    { "3e623a9d-8fb9-44d1-b2ae-90a5efc6a961", 23, "klhpioj", "Ali03", "123546", new DateTime(2022, 11, 22, 10, 1, 38, 241, DateTimeKind.Local).AddTicks(9748) },
                    { "986c95ba-dc2c-441f-b1a5-52e3467efec9", 23, "klhpioj", "Ali01", "123546", new DateTime(2022, 11, 22, 10, 1, 38, 241, DateTimeKind.Local).AddTicks(9712) },
                    { "ba235338-8ba3-485b-bfbf-838c6e56ffee", 23, "klhpioj", "Ali02", "123546", new DateTime(2022, 11, 22, 10, 1, 38, 241, DateTimeKind.Local).AddTicks(9737) },
                    { "cacac3c8-520b-46bc-88d0-eafa6a6029e4", 32, "Khokho", "Ali", "123456", new DateTime(2022, 11, 22, 10, 1, 38, 241, DateTimeKind.Local).AddTicks(9654) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "3e623a9d-8fb9-44d1-b2ae-90a5efc6a961");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "986c95ba-dc2c-441f-b1a5-52e3467efec9");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "ba235338-8ba3-485b-bfbf-838c6e56ffee");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "cacac3c8-520b-46bc-88d0-eafa6a6029e4");
        }
    }
}
