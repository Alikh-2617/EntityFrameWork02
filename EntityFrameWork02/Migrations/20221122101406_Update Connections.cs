using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameWork02.Migrations
{
    public partial class UpdateConnections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "LanguageName",
                table: "Person",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CityLanguage",
                columns: table => new
                {
                    CityName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LanguageName = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityLanguage", x => new { x.CityName, x.LanguageName });
                    table.ForeignKey(
                        name: "FK_CityLanguage_City_CityName",
                        column: x => x.CityName,
                        principalTable: "City",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CityLanguage_Language_LanguageName",
                        column: x => x.LanguageName,
                        principalTable: "Language",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CountryLanguage",
                columns: table => new
                {
                    CountryName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LanguageName = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryLanguage", x => new { x.CountryName, x.LanguageName });
                    table.ForeignKey(
                        name: "FK_CountryLanguage_Country_CountryName",
                        column: x => x.CountryName,
                        principalTable: "Country",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CountryLanguage_Language_LanguageName",
                        column: x => x.LanguageName,
                        principalTable: "Language",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Person_LanguageName",
                table: "Person",
                column: "LanguageName");

            migrationBuilder.CreateIndex(
                name: "IX_CityLanguage_LanguageName",
                table: "CityLanguage",
                column: "LanguageName");

            migrationBuilder.CreateIndex(
                name: "IX_CountryLanguage_LanguageName",
                table: "CountryLanguage",
                column: "LanguageName");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Language_LanguageName",
                table: "Person",
                column: "LanguageName",
                principalTable: "Language",
                principalColumn: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_Language_LanguageName",
                table: "Person");

            migrationBuilder.DropTable(
                name: "CityLanguage");

            migrationBuilder.DropTable(
                name: "CountryLanguage");

            migrationBuilder.DropIndex(
                name: "IX_Person_LanguageName",
                table: "Person");

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

            migrationBuilder.DropColumn(
                name: "LanguageName",
                table: "Person");

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
    }
}
