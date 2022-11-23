using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameWork02.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "0c9455e0-e43d-48f1-a943-931ff4598e6c");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "691ec217-0238-46be-bafc-9c32ed95862f");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "9d04ed08-6d18-4f18-aa0c-53fd61f69467");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "f77fe778-6577-4833-88a9-088380302e8c");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Name",
                keyValue: "Järpen",
                column: "Register",
                value: new DateTime(2022, 11, 22, 11, 29, 39, 277, DateTimeKind.Local).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Name",
                keyValue: "Åre",
                column: "Register",
                value: new DateTime(2022, 11, 22, 11, 29, 39, 277, DateTimeKind.Local).AddTicks(956));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Name",
                keyValue: "Östersund",
                column: "Register",
                value: new DateTime(2022, 11, 22, 11, 29, 39, 277, DateTimeKind.Local).AddTicks(977));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Name",
                keyValue: "Danmark",
                column: "Register",
                value: new DateTime(2022, 11, 22, 11, 29, 39, 277, DateTimeKind.Local).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Name",
                keyValue: "Norway",
                column: "Register",
                value: new DateTime(2022, 11, 22, 11, 29, 39, 277, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Name",
                keyValue: "Sweden",
                column: "Register",
                value: new DateTime(2022, 11, 22, 11, 29, 39, 277, DateTimeKind.Local).AddTicks(993));

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "Age", "EfterName", "LanguageName", "Name", "PhoneNumer", "Register" },
                values: new object[,]
                {
                    { "0424b0ce-3972-44db-9228-392b58448b9f", 32, "Khokho", null, "Ali", "123456", new DateTime(2022, 11, 22, 11, 29, 39, 277, DateTimeKind.Local).AddTicks(843) },
                    { "1359bfff-9d45-4d5a-ab9a-6adb14c06f1e", 23, "klhpioj", null, "Ali01", "123546", new DateTime(2022, 11, 22, 11, 29, 39, 277, DateTimeKind.Local).AddTicks(909) },
                    { "7638f0af-24c4-4672-a370-1ec52123687c", 23, "klhpioj", null, "Ali03", "123546", new DateTime(2022, 11, 22, 11, 29, 39, 277, DateTimeKind.Local).AddTicks(935) },
                    { "fe2c3087-1d9b-4d8b-af0a-1e0cf7551c2f", 23, "klhpioj", null, "Ali02", "123546", new DateTime(2022, 11, 22, 11, 29, 39, 277, DateTimeKind.Local).AddTicks(922) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "0424b0ce-3972-44db-9228-392b58448b9f");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "1359bfff-9d45-4d5a-ab9a-6adb14c06f1e");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "7638f0af-24c4-4672-a370-1ec52123687c");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "fe2c3087-1d9b-4d8b-af0a-1e0cf7551c2f");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Name",
                keyValue: "Järpen",
                column: "Register",
                value: new DateTime(2022, 11, 22, 11, 14, 5, 950, DateTimeKind.Local).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Name",
                keyValue: "Åre",
                column: "Register",
                value: new DateTime(2022, 11, 22, 11, 14, 5, 950, DateTimeKind.Local).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Name",
                keyValue: "Östersund",
                column: "Register",
                value: new DateTime(2022, 11, 22, 11, 14, 5, 950, DateTimeKind.Local).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Name",
                keyValue: "Danmark",
                column: "Register",
                value: new DateTime(2022, 11, 22, 11, 14, 5, 950, DateTimeKind.Local).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Name",
                keyValue: "Norway",
                column: "Register",
                value: new DateTime(2022, 11, 22, 11, 14, 5, 950, DateTimeKind.Local).AddTicks(5599));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Name",
                keyValue: "Sweden",
                column: "Register",
                value: new DateTime(2022, 11, 22, 11, 14, 5, 950, DateTimeKind.Local).AddTicks(5587));

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "Age", "EfterName", "LanguageName", "Name", "PhoneNumer", "Register" },
                values: new object[,]
                {
                    { "0c9455e0-e43d-48f1-a943-931ff4598e6c", 32, "Khokho", null, "Ali", "123456", new DateTime(2022, 11, 22, 11, 14, 5, 950, DateTimeKind.Local).AddTicks(5386) },
                    { "691ec217-0238-46be-bafc-9c32ed95862f", 23, "klhpioj", null, "Ali01", "123546", new DateTime(2022, 11, 22, 11, 14, 5, 950, DateTimeKind.Local).AddTicks(5448) },
                    { "9d04ed08-6d18-4f18-aa0c-53fd61f69467", 23, "klhpioj", null, "Ali03", "123546", new DateTime(2022, 11, 22, 11, 14, 5, 950, DateTimeKind.Local).AddTicks(5486) },
                    { "f77fe778-6577-4833-88a9-088380302e8c", 23, "klhpioj", null, "Ali02", "123546", new DateTime(2022, 11, 22, 11, 14, 5, 950, DateTimeKind.Local).AddTicks(5461) }
                });
        }
    }
}
