using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameWork02.Migrations
{
    public partial class SeedingLanguage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "1cf34e97-79ad-4557-be41-b998c8ecd2ed");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "1fb64e2f-150e-4d23-823a-3e3de2b74bd7");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "c7924601-d8d3-4a4c-8da9-6c04a11aa5be");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "dd1990e3-527b-4f5e-af17-7d1a070b746f");

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.Name);
                });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Name",
                keyValue: "Järpen",
                column: "Register",
                value: new DateTime(2022, 11, 22, 11, 11, 23, 749, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Name",
                keyValue: "Åre",
                column: "Register",
                value: new DateTime(2022, 11, 22, 11, 11, 23, 749, DateTimeKind.Local).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Name",
                keyValue: "Östersund",
                column: "Register",
                value: new DateTime(2022, 11, 22, 11, 11, 23, 749, DateTimeKind.Local).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Name",
                keyValue: "Danmark",
                column: "Register",
                value: new DateTime(2022, 11, 22, 11, 11, 23, 749, DateTimeKind.Local).AddTicks(2415));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Name",
                keyValue: "Norway",
                column: "Register",
                value: new DateTime(2022, 11, 22, 11, 11, 23, 749, DateTimeKind.Local).AddTicks(2367));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Name",
                keyValue: "Sweden",
                column: "Register",
                value: new DateTime(2022, 11, 22, 11, 11, 23, 749, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.InsertData(
                table: "Language",
                column: "Name",
                values: new object[]
                {
                    "Norske",
                    "Periska",
                    "Svenska"
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "Age", "EfterName", "Name", "PhoneNumer", "Register" },
                values: new object[,]
                {
                    { "38d71696-a732-4296-bb45-b49c72b1acb1", 23, "klhpioj", "Ali02", "123546", new DateTime(2022, 11, 22, 11, 11, 23, 749, DateTimeKind.Local).AddTicks(2289) },
                    { "43725d4f-4066-45be-9399-91b2fb0fcd27", 23, "klhpioj", "Ali03", "123546", new DateTime(2022, 11, 22, 11, 11, 23, 749, DateTimeKind.Local).AddTicks(2300) },
                    { "b514fd11-e586-47cf-9beb-d821a39f8b6d", 23, "klhpioj", "Ali01", "123546", new DateTime(2022, 11, 22, 11, 11, 23, 749, DateTimeKind.Local).AddTicks(2276) },
                    { "cb9cb5a4-ce7b-49c0-b60d-b0a5fee79750", 32, "Khokho", "Ali", "123456", new DateTime(2022, 11, 22, 11, 11, 23, 749, DateTimeKind.Local).AddTicks(2209) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "38d71696-a732-4296-bb45-b49c72b1acb1");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "43725d4f-4066-45be-9399-91b2fb0fcd27");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "b514fd11-e586-47cf-9beb-d821a39f8b6d");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "cb9cb5a4-ce7b-49c0-b60d-b0a5fee79750");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Name",
                keyValue: "Järpen",
                column: "Register",
                value: new DateTime(2022, 11, 22, 11, 8, 37, 470, DateTimeKind.Local).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Name",
                keyValue: "Åre",
                column: "Register",
                value: new DateTime(2022, 11, 22, 11, 8, 37, 470, DateTimeKind.Local).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Name",
                keyValue: "Östersund",
                column: "Register",
                value: new DateTime(2022, 11, 22, 11, 8, 37, 470, DateTimeKind.Local).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Name",
                keyValue: "Danmark",
                column: "Register",
                value: new DateTime(2022, 11, 22, 11, 8, 37, 470, DateTimeKind.Local).AddTicks(3789));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Name",
                keyValue: "Norway",
                column: "Register",
                value: new DateTime(2022, 11, 22, 11, 8, 37, 470, DateTimeKind.Local).AddTicks(3781));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Name",
                keyValue: "Sweden",
                column: "Register",
                value: new DateTime(2022, 11, 22, 11, 8, 37, 470, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "Age", "EfterName", "Name", "PhoneNumer", "Register" },
                values: new object[,]
                {
                    { "1cf34e97-79ad-4557-be41-b998c8ecd2ed", 23, "klhpioj", "Ali02", "123546", new DateTime(2022, 11, 22, 11, 8, 37, 470, DateTimeKind.Local).AddTicks(3706) },
                    { "1fb64e2f-150e-4d23-823a-3e3de2b74bd7", 23, "klhpioj", "Ali03", "123546", new DateTime(2022, 11, 22, 11, 8, 37, 470, DateTimeKind.Local).AddTicks(3718) },
                    { "c7924601-d8d3-4a4c-8da9-6c04a11aa5be", 32, "Khokho", "Ali", "123456", new DateTime(2022, 11, 22, 11, 8, 37, 470, DateTimeKind.Local).AddTicks(3344) },
                    { "dd1990e3-527b-4f5e-af17-7d1a070b746f", 23, "klhpioj", "Ali01", "123546", new DateTime(2022, 11, 22, 11, 8, 37, 470, DateTimeKind.Local).AddTicks(3594) }
                });
        }
    }
}
