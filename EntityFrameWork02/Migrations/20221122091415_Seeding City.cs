using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameWork02.Migrations
{
    public partial class SeedingCity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "017f0385-d4a6-4740-bb5d-dda497a3e52a");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "24450063-ff35-45de-b299-2074e9115c74");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "5bc06464-25f0-4a61-9ed2-157cea84bab9");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "a4163bae-7a4c-4c73-abff-2e7abf11e929");

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Name", "PostNumber", "Register" },
                values: new object[,]
                {
                    { "Järpen", "123 45", new DateTime(2022, 11, 22, 10, 14, 15, 383, DateTimeKind.Local).AddTicks(8981) },
                    { "Åre", "123 45", new DateTime(2022, 11, 22, 10, 14, 15, 383, DateTimeKind.Local).AddTicks(8968) },
                    { "Östersund", "123 88", new DateTime(2022, 11, 22, 10, 14, 15, 383, DateTimeKind.Local).AddTicks(8991) }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "Age", "EfterName", "Name", "PhoneNumer", "Register" },
                values: new object[,]
                {
                    { "11001f4b-7f96-4fd9-844d-704bb606abee", 23, "klhpioj", "Ali01", "123546", new DateTime(2022, 11, 22, 10, 14, 15, 383, DateTimeKind.Local).AddTicks(8919) },
                    { "7387f3ce-cc0e-4d1a-8b62-a735a7b78066", 23, "klhpioj", "Ali03", "123546", new DateTime(2022, 11, 22, 10, 14, 15, 383, DateTimeKind.Local).AddTicks(8956) },
                    { "f1caa874-28f1-4e77-877f-8fc32eb6f70f", 23, "klhpioj", "Ali02", "123546", new DateTime(2022, 11, 22, 10, 14, 15, 383, DateTimeKind.Local).AddTicks(8931) },
                    { "f4ecd0c6-2d86-40ed-a14d-8bfd37b32e49", 32, "Khokho", "Ali", "123456", new DateTime(2022, 11, 22, 10, 14, 15, 383, DateTimeKind.Local).AddTicks(8844) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Name",
                keyValue: "Järpen");

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Name",
                keyValue: "Åre");

            migrationBuilder.DeleteData(
                table: "City",
                keyColumn: "Name",
                keyValue: "Östersund");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "11001f4b-7f96-4fd9-844d-704bb606abee");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "7387f3ce-cc0e-4d1a-8b62-a735a7b78066");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "f1caa874-28f1-4e77-877f-8fc32eb6f70f");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "f4ecd0c6-2d86-40ed-a14d-8bfd37b32e49");

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "Age", "EfterName", "Name", "PhoneNumer", "Register" },
                values: new object[,]
                {
                    { "017f0385-d4a6-4740-bb5d-dda497a3e52a", 32, "Khokho", "Ali", "123456", new DateTime(2022, 11, 22, 10, 9, 13, 774, DateTimeKind.Local).AddTicks(1313) },
                    { "24450063-ff35-45de-b299-2074e9115c74", 23, "klhpioj", "Ali03", "123546", new DateTime(2022, 11, 22, 10, 9, 13, 774, DateTimeKind.Local).AddTicks(1401) },
                    { "5bc06464-25f0-4a61-9ed2-157cea84bab9", 23, "klhpioj", "Ali02", "123546", new DateTime(2022, 11, 22, 10, 9, 13, 774, DateTimeKind.Local).AddTicks(1389) },
                    { "a4163bae-7a4c-4c73-abff-2e7abf11e929", 23, "klhpioj", "Ali01", "123546", new DateTime(2022, 11, 22, 10, 9, 13, 774, DateTimeKind.Local).AddTicks(1375) }
                });
        }
    }
}
