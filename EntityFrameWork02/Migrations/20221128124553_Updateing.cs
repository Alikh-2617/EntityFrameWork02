using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameWork02.Migrations
{
    public partial class Updateing : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Register = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Register = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Register = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CityCountry",
                columns: table => new
                {
                    CityId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CountryId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityCountry", x => new { x.CityId, x.CountryId });
                    table.ForeignKey(
                        name: "FK_CityCountry_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CityCountry_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CityLanguage",
                columns: table => new
                {
                    CityId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LanguageId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityLanguage", x => new { x.CityId, x.LanguageId });
                    table.ForeignKey(
                        name: "FK_CityLanguage_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CityLanguage_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CountryLanguage",
                columns: table => new
                {
                    CountryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LanguageId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryLanguage", x => new { x.CountryId, x.LanguageId });
                    table.ForeignKey(
                        name: "FK_CountryLanguage_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CountryLanguage_Language_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "Language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CityPerson",
                columns: table => new
                {
                    CitysId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PeopleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityPerson", x => new { x.CitysId, x.PeopleId });
                    table.ForeignKey(
                        name: "FK_CityPerson_City_CitysId",
                        column: x => x.CitysId,
                        principalTable: "City",
                        principalColumn: "Id",
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
                    CountrysId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PersonId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryPerson", x => new { x.CountrysId, x.PersonId });
                    table.ForeignKey(
                        name: "FK_CountryPerson_Country_CountrysId",
                        column: x => x.CountrysId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CountryPerson_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LanguagePerson",
                columns: table => new
                {
                    LanguagesId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PersonId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguagePerson", x => new { x.LanguagesId, x.PersonId });
                    table.ForeignKey(
                        name: "FK_LanguagePerson_Language_LanguagesId",
                        column: x => x.LanguagesId,
                        principalTable: "Language",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LanguagePerson_Person_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "Name", "PostNumber", "Register" },
                values: new object[,]
                {
                    { "4296ab28-83a1-4d9a-9fcd-534b66826c5d", "Åre", "123 45", new DateTime(2022, 11, 28, 13, 45, 53, 84, DateTimeKind.Local).AddTicks(1153) },
                    { "a05a284b-c11b-4c4b-9204-085af4f02919", "Järpen", "123 45", new DateTime(2022, 11, 28, 13, 45, 53, 84, DateTimeKind.Local).AddTicks(1169) },
                    { "b625580c-f586-4931-b768-bb598907935e", "Östersund", "123 88", new DateTime(2022, 11, 28, 13, 45, 53, 84, DateTimeKind.Local).AddTicks(1180) }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "Name", "Register" },
                values: new object[,]
                {
                    { "1dac1216-c371-4116-945a-557a8f7e898a", "Sweden", new DateTime(2022, 11, 28, 13, 45, 53, 84, DateTimeKind.Local).AddTicks(1196) },
                    { "a9f85dc3-cd7a-4d7e-b7d8-378db736b24b", "Danmark", new DateTime(2022, 11, 28, 13, 45, 53, 84, DateTimeKind.Local).AddTicks(1222) },
                    { "e5248d30-8efa-4033-b6cb-f9bd4e30ca29", "Norway", new DateTime(2022, 11, 28, 13, 45, 53, 84, DateTimeKind.Local).AddTicks(1211) }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "6aec7ffb-9dc7-4534-b36e-0c2b1e229c0d", "Svenska" },
                    { "76d2b0db-3898-4601-9dc6-77a0a5a9a21f", "Norske" },
                    { "a38e2959-5642-4481-8376-71a3c56454b7", "Swedish" },
                    { "e67552fd-e74f-4a4e-a13a-e161d8a346a0", "Periska" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "Age", "Name", "PhoneNumber", "Register" },
                values: new object[,]
                {
                    { "0188ef56-fdea-491f-9eab-5f745718df52", 32, "Ali", "123456", new DateTime(2022, 11, 28, 13, 45, 53, 84, DateTimeKind.Local).AddTicks(246) },
                    { "bc272863-ad60-4a0c-9195-cbc34df791e2", 23, "Ali02", "123546", new DateTime(2022, 11, 28, 13, 45, 53, 84, DateTimeKind.Local).AddTicks(1110) },
                    { "ce69d98b-ab1e-4bfb-a02b-634dded72a3d", 23, "Ali01", "123546", new DateTime(2022, 11, 28, 13, 45, 53, 84, DateTimeKind.Local).AddTicks(1091) },
                    { "dbf7e291-7929-4fc6-99e7-22ecf46aeeda", 23, "Ali03", "123546", new DateTime(2022, 11, 28, 13, 45, 53, 84, DateTimeKind.Local).AddTicks(1135) }
                });

            migrationBuilder.InsertData(
                table: "LanguagePerson",
                columns: new[] { "LanguagesId", "PersonId" },
                values: new object[] { "6aec7ffb-9dc7-4534-b36e-0c2b1e229c0d", "0188ef56-fdea-491f-9eab-5f745718df52" });

            migrationBuilder.CreateIndex(
                name: "IX_CityCountry_CountryId",
                table: "CityCountry",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_CityLanguage_LanguageId",
                table: "CityLanguage",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_CityPerson_PeopleId",
                table: "CityPerson",
                column: "PeopleId");

            migrationBuilder.CreateIndex(
                name: "IX_CountryLanguage_LanguageId",
                table: "CountryLanguage",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_CountryPerson_PersonId",
                table: "CountryPerson",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguagePerson_PersonId",
                table: "LanguagePerson",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CityCountry");

            migrationBuilder.DropTable(
                name: "CityLanguage");

            migrationBuilder.DropTable(
                name: "CityPerson");

            migrationBuilder.DropTable(
                name: "CountryLanguage");

            migrationBuilder.DropTable(
                name: "CountryPerson");

            migrationBuilder.DropTable(
                name: "LanguagePerson");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
