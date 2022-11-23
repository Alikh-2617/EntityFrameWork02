using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameWork02.Migrations
{
    public partial class ConnectionsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "43f1abec-60b3-4ac0-b098-8f477c528b93");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "db6c953f-5806-4c04-a525-dbc8e74331e1");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "dc0771c6-9216-466c-8f77-2d888a51b9fa");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "fdb1103d-f232-44cd-81d6-29809bab5b45");

            migrationBuilder.CreateTable(
                name: "CityCountry",
                columns: table => new
                {
                    CityName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CountryName = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityCountry", x => new { x.CityName, x.CountryName });
                    table.ForeignKey(
                        name: "FK_CityCountry_City_CityName",
                        column: x => x.CityName,
                        principalTable: "City",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CityCountry_Country_CountryName",
                        column: x => x.CountryName,
                        principalTable: "Country",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CityPerson",
                columns: table => new
                {
                    CitysName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PeopleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityPerson", x => new { x.CitysName, x.PeopleId });
                    table.ForeignKey(
                        name: "FK_CityPerson_City_CitysName",
                        column: x => x.CitysName,
                        principalTable: "City",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CityPerson_Person_PeopleId",
                        column: x => x.PeopleId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CountryPerson",
                columns: table => new
                {
                    CountrysName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PersonId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryPerson", x => new { x.CountrysName, x.PersonId });
                    table.ForeignKey(
                        name: "FK_CountryPerson_Country_CountrysName",
                        column: x => x.CountrysName,
                        principalTable: "Country",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CountryPerson_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_CityCountry_CountryName",
                table: "CityCountry",
                column: "CountryName");

            migrationBuilder.CreateIndex(
                name: "IX_CityPerson_PeopleId",
                table: "CityPerson",
                column: "PeopleId");

            migrationBuilder.CreateIndex(
                name: "IX_CountryPerson_PersonId",
                table: "CountryPerson",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CityCountry");

            migrationBuilder.DropTable(
                name: "CityPerson");

            migrationBuilder.DropTable(
                name: "CountryPerson");

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
                value: new DateTime(2022, 11, 22, 10, 52, 54, 635, DateTimeKind.Local).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Name",
                keyValue: "Åre",
                column: "Register",
                value: new DateTime(2022, 11, 22, 10, 52, 54, 635, DateTimeKind.Local).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Name",
                keyValue: "Östersund",
                column: "Register",
                value: new DateTime(2022, 11, 22, 10, 52, 54, 635, DateTimeKind.Local).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Name",
                keyValue: "Danmark",
                column: "Register",
                value: new DateTime(2022, 11, 22, 10, 52, 54, 635, DateTimeKind.Local).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Name",
                keyValue: "Norway",
                column: "Register",
                value: new DateTime(2022, 11, 22, 10, 52, 54, 635, DateTimeKind.Local).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Name",
                keyValue: "Sweden",
                column: "Register",
                value: new DateTime(2022, 11, 22, 10, 52, 54, 635, DateTimeKind.Local).AddTicks(4013));

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "Age", "EfterName", "Name", "PhoneNumer", "Register" },
                values: new object[,]
                {
                    { "43f1abec-60b3-4ac0-b098-8f477c528b93", 32, "Khokho", "Ali", "123456", new DateTime(2022, 11, 22, 10, 52, 54, 635, DateTimeKind.Local).AddTicks(3888) },
                    { "db6c953f-5806-4c04-a525-dbc8e74331e1", 23, "klhpioj", "Ali03", "123546", new DateTime(2022, 11, 22, 10, 52, 54, 635, DateTimeKind.Local).AddTicks(3970) },
                    { "dc0771c6-9216-466c-8f77-2d888a51b9fa", 23, "klhpioj", "Ali01", "123546", new DateTime(2022, 11, 22, 10, 52, 54, 635, DateTimeKind.Local).AddTicks(3947) },
                    { "fdb1103d-f232-44cd-81d6-29809bab5b45", 23, "klhpioj", "Ali02", "123546", new DateTime(2022, 11, 22, 10, 52, 54, 635, DateTimeKind.Local).AddTicks(3959) }
                });
        }
    }
}
