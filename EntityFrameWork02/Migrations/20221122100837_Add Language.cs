using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameWork02.Migrations
{
    public partial class AddLanguage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "d3aee7c5-1f2e-4604-af71-1687ff76dd66");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "d3d38e11-13cd-44d1-8d3e-aa12ba7336a3");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "db2c1db3-afd3-438b-bc7c-85446c4305f2");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "f0b33d69-2162-4345-bc74-977533e403d5");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Name",
                keyValue: "Järpen",
                column: "Register",
                value: new DateTime(2022, 11, 22, 11, 0, 56, 442, DateTimeKind.Local).AddTicks(1475));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Name",
                keyValue: "Åre",
                column: "Register",
                value: new DateTime(2022, 11, 22, 11, 0, 56, 442, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Name",
                keyValue: "Östersund",
                column: "Register",
                value: new DateTime(2022, 11, 22, 11, 0, 56, 442, DateTimeKind.Local).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Name",
                keyValue: "Danmark",
                column: "Register",
                value: new DateTime(2022, 11, 22, 11, 0, 56, 442, DateTimeKind.Local).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Name",
                keyValue: "Norway",
                column: "Register",
                value: new DateTime(2022, 11, 22, 11, 0, 56, 442, DateTimeKind.Local).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Name",
                keyValue: "Sweden",
                column: "Register",
                value: new DateTime(2022, 11, 22, 11, 0, 56, 442, DateTimeKind.Local).AddTicks(1497));

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "Age", "EfterName", "Name", "PhoneNumer", "Register" },
                values: new object[,]
                {
                    { "d3aee7c5-1f2e-4604-af71-1687ff76dd66", 23, "klhpioj", "Ali03", "123546", new DateTime(2022, 11, 22, 11, 0, 56, 442, DateTimeKind.Local).AddTicks(1446) },
                    { "d3d38e11-13cd-44d1-8d3e-aa12ba7336a3", 23, "klhpioj", "Ali02", "123546", new DateTime(2022, 11, 22, 11, 0, 56, 442, DateTimeKind.Local).AddTicks(1433) },
                    { "db2c1db3-afd3-438b-bc7c-85446c4305f2", 32, "Khokho", "Ali", "123456", new DateTime(2022, 11, 22, 11, 0, 56, 442, DateTimeKind.Local).AddTicks(1357) },
                    { "f0b33d69-2162-4345-bc74-977533e403d5", 23, "klhpioj", "Ali01", "123546", new DateTime(2022, 11, 22, 11, 0, 56, 442, DateTimeKind.Local).AddTicks(1420) }
                });
        }
    }
}
