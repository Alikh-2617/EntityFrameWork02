using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameWork02.Migrations
{
    public partial class AddCountry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Register = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Name);
                });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Name",
                keyValue: "Järpen",
                column: "Register",
                value: new DateTime(2022, 11, 22, 10, 48, 22, 892, DateTimeKind.Local).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Name",
                keyValue: "Åre",
                column: "Register",
                value: new DateTime(2022, 11, 22, 10, 48, 22, 892, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Name",
                keyValue: "Östersund",
                column: "Register",
                value: new DateTime(2022, 11, 22, 10, 48, 22, 892, DateTimeKind.Local).AddTicks(8075));

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "Age", "EfterName", "Name", "PhoneNumer", "Register" },
                values: new object[,]
                {
                    { "264c11c4-86aa-46c5-9c13-fede88b2420f", 23, "klhpioj", "Ali01", "123546", new DateTime(2022, 11, 22, 10, 48, 22, 892, DateTimeKind.Local).AddTicks(8012) },
                    { "6cfee36d-bdf1-46df-9184-913b925d1c70", 32, "Khokho", "Ali", "123456", new DateTime(2022, 11, 22, 10, 48, 22, 892, DateTimeKind.Local).AddTicks(7952) },
                    { "e22e1ae9-e8dd-401f-8793-af4c6b03f7d8", 23, "klhpioj", "Ali02", "123546", new DateTime(2022, 11, 22, 10, 48, 22, 892, DateTimeKind.Local).AddTicks(8025) },
                    { "e4d7943c-8975-4ca6-9a1f-25c2e5c54dcc", 23, "klhpioj", "Ali03", "123546", new DateTime(2022, 11, 22, 10, 48, 22, 892, DateTimeKind.Local).AddTicks(8038) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "264c11c4-86aa-46c5-9c13-fede88b2420f");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "6cfee36d-bdf1-46df-9184-913b925d1c70");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "e22e1ae9-e8dd-401f-8793-af4c6b03f7d8");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "e4d7943c-8975-4ca6-9a1f-25c2e5c54dcc");

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Name",
                keyValue: "Järpen",
                column: "Register",
                value: new DateTime(2022, 11, 22, 10, 14, 15, 383, DateTimeKind.Local).AddTicks(8981));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Name",
                keyValue: "Åre",
                column: "Register",
                value: new DateTime(2022, 11, 22, 10, 14, 15, 383, DateTimeKind.Local).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Name",
                keyValue: "Östersund",
                column: "Register",
                value: new DateTime(2022, 11, 22, 10, 14, 15, 383, DateTimeKind.Local).AddTicks(8991));

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
    }
}
