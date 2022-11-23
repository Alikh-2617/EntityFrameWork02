using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameWork02.Migrations
{
    public partial class AddCity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PostNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Register = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Name);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "City");

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
    }
}
