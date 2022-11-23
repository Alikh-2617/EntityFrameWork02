using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFrameWork02.Migrations
{
    public partial class ID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CityCountry_City_CityName",
                table: "CityCountry");

            migrationBuilder.DropForeignKey(
                name: "FK_CityCountry_Country_CountryName",
                table: "CityCountry");

            migrationBuilder.DropForeignKey(
                name: "FK_CityLanguage_City_CityName",
                table: "CityLanguage");

            migrationBuilder.DropForeignKey(
                name: "FK_CityLanguage_Language_LanguageName",
                table: "CityLanguage");

            migrationBuilder.DropForeignKey(
                name: "FK_CityPerson_City_CitysName",
                table: "CityPerson");

            migrationBuilder.DropForeignKey(
                name: "FK_CountryLanguage_Country_CountryName",
                table: "CountryLanguage");

            migrationBuilder.DropForeignKey(
                name: "FK_CountryLanguage_Language_LanguageName",
                table: "CountryLanguage");

            migrationBuilder.DropForeignKey(
                name: "FK_CountryPerson_Country_CountrysName",
                table: "CountryPerson");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_Language_LanguageName",
                table: "Person");

            migrationBuilder.DropIndex(
                name: "IX_Person_LanguageName",
                table: "Person");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Language",
                table: "Language");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Country",
                table: "Country");

            migrationBuilder.DropPrimaryKey(
                name: "PK_City",
                table: "City");

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
                table: "Country",
                keyColumn: "Name",
                keyValue: "Danmark");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Name",
                keyValue: "Norway");

            migrationBuilder.DeleteData(
                table: "Country",
                keyColumn: "Name",
                keyValue: "Sweden");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Name",
                keyValue: "Norske");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Name",
                keyValue: "Periska");

            migrationBuilder.DeleteData(
                table: "Language",
                keyColumn: "Name",
                keyValue: "Svenska");

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

            migrationBuilder.DropColumn(
                name: "EfterName",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "LanguageName",
                table: "Person");

            migrationBuilder.RenameColumn(
                name: "PhoneNumer",
                table: "Person",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "CountrysName",
                table: "CountryPerson",
                newName: "CountrysId");

            migrationBuilder.RenameColumn(
                name: "LanguageName",
                table: "CountryLanguage",
                newName: "LanguageId");

            migrationBuilder.RenameColumn(
                name: "CountryName",
                table: "CountryLanguage",
                newName: "CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_CountryLanguage_LanguageName",
                table: "CountryLanguage",
                newName: "IX_CountryLanguage_LanguageId");

            migrationBuilder.RenameColumn(
                name: "CitysName",
                table: "CityPerson",
                newName: "CitysId");

            migrationBuilder.RenameColumn(
                name: "LanguageName",
                table: "CityLanguage",
                newName: "LanguageId");

            migrationBuilder.RenameColumn(
                name: "CityName",
                table: "CityLanguage",
                newName: "CityId");

            migrationBuilder.RenameIndex(
                name: "IX_CityLanguage_LanguageName",
                table: "CityLanguage",
                newName: "IX_CityLanguage_LanguageId");

            migrationBuilder.RenameColumn(
                name: "CountryName",
                table: "CityCountry",
                newName: "CountryId");

            migrationBuilder.RenameColumn(
                name: "CityName",
                table: "CityCountry",
                newName: "CityId");

            migrationBuilder.RenameIndex(
                name: "IX_CityCountry_CountryName",
                table: "CityCountry",
                newName: "IX_CityCountry_CountryId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Person",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Language",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Language",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Country",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Country",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "PostNumber",
                table: "City",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "City",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "City",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Language",
                table: "Language",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Country",
                table: "Country",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_City",
                table: "City",
                column: "Id");

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
                    { "5bcb6dd3-ab87-4800-b027-628666104204", "Åre", "123 45", new DateTime(2022, 11, 23, 13, 56, 9, 587, DateTimeKind.Local).AddTicks(1360) },
                    { "e0c28688-f4cb-4949-83fc-70fa54cf7bf6", "Järpen", "123 45", new DateTime(2022, 11, 23, 13, 56, 9, 587, DateTimeKind.Local).AddTicks(1378) },
                    { "edba7e92-0b2e-4355-865c-99ddb86303ac", "Östersund", "123 88", new DateTime(2022, 11, 23, 13, 56, 9, 587, DateTimeKind.Local).AddTicks(1390) }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "Name", "Register" },
                values: new object[,]
                {
                    { "58c93865-582b-445d-9395-572f41e89201", "Norway", new DateTime(2022, 11, 23, 13, 56, 9, 587, DateTimeKind.Local).AddTicks(1421) },
                    { "cb0322aa-a99c-47d7-93d8-dff5e0edf9d1", "Sweden", new DateTime(2022, 11, 23, 13, 56, 9, 587, DateTimeKind.Local).AddTicks(1406) },
                    { "d8984e28-5631-4f60-bdb9-f1b5ed32170b", "Danmark", new DateTime(2022, 11, 23, 13, 56, 9, 587, DateTimeKind.Local).AddTicks(1432) }
                });

            migrationBuilder.InsertData(
                table: "Language",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "08de0cdf-11f3-4944-bb34-ddedb5c8267d", "Svenska" },
                    { "39c60245-1026-4029-b435-9bb83ef59b75", "Norske" },
                    { "7cd221c6-cda6-4e1b-b001-953b6776fd85", "Periska" }
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "Age", "Name", "PhoneNumber", "Register" },
                values: new object[,]
                {
                    { "2946a19e-a97e-468a-aece-07b028f4f1a3", 23, "Ali03", "123546", new DateTime(2022, 11, 23, 13, 56, 9, 587, DateTimeKind.Local).AddTicks(1318) },
                    { "69e9e4a6-90a7-4113-82a3-a896d4edf08a", 23, "Ali02", "123546", new DateTime(2022, 11, 23, 13, 56, 9, 587, DateTimeKind.Local).AddTicks(1303) },
                    { "76e07371-5b7f-4747-bfc4-f9525fbf213e", 32, "Ali", "123456", new DateTime(2022, 11, 23, 13, 56, 9, 587, DateTimeKind.Local).AddTicks(1223) },
                    { "78e76443-9115-45b3-b7e2-557ecc2fb08c", 23, "Ali01", "123546", new DateTime(2022, 11, 23, 13, 56, 9, 587, DateTimeKind.Local).AddTicks(1289) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LanguagePerson_PersonId",
                table: "LanguagePerson",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_CityCountry_City_CityId",
                table: "CityCountry",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CityCountry_Country_CountryId",
                table: "CityCountry",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CityLanguage_City_CityId",
                table: "CityLanguage",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CityLanguage_Language_LanguageId",
                table: "CityLanguage",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CityPerson_City_CitysId",
                table: "CityPerson",
                column: "CitysId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CountryLanguage_Country_CountryId",
                table: "CountryLanguage",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CountryLanguage_Language_LanguageId",
                table: "CountryLanguage",
                column: "LanguageId",
                principalTable: "Language",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CountryPerson_Country_CountrysId",
                table: "CountryPerson",
                column: "CountrysId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CityCountry_City_CityId",
                table: "CityCountry");

            migrationBuilder.DropForeignKey(
                name: "FK_CityCountry_Country_CountryId",
                table: "CityCountry");

            migrationBuilder.DropForeignKey(
                name: "FK_CityLanguage_City_CityId",
                table: "CityLanguage");

            migrationBuilder.DropForeignKey(
                name: "FK_CityLanguage_Language_LanguageId",
                table: "CityLanguage");

            migrationBuilder.DropForeignKey(
                name: "FK_CityPerson_City_CitysId",
                table: "CityPerson");

            migrationBuilder.DropForeignKey(
                name: "FK_CountryLanguage_Country_CountryId",
                table: "CountryLanguage");

            migrationBuilder.DropForeignKey(
                name: "FK_CountryLanguage_Language_LanguageId",
                table: "CountryLanguage");

            migrationBuilder.DropForeignKey(
                name: "FK_CountryPerson_Country_CountrysId",
                table: "CountryPerson");

            migrationBuilder.DropTable(
                name: "LanguagePerson");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Language",
                table: "Language");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Country",
                table: "Country");

            migrationBuilder.DropPrimaryKey(
                name: "PK_City",
                table: "City");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "2946a19e-a97e-468a-aece-07b028f4f1a3");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "69e9e4a6-90a7-4113-82a3-a896d4edf08a");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "76e07371-5b7f-4747-bfc4-f9525fbf213e");

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: "78e76443-9115-45b3-b7e2-557ecc2fb08c");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Language");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "City");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Person",
                newName: "PhoneNumer");

            migrationBuilder.RenameColumn(
                name: "CountrysId",
                table: "CountryPerson",
                newName: "CountrysName");

            migrationBuilder.RenameColumn(
                name: "LanguageId",
                table: "CountryLanguage",
                newName: "LanguageName");

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "CountryLanguage",
                newName: "CountryName");

            migrationBuilder.RenameIndex(
                name: "IX_CountryLanguage_LanguageId",
                table: "CountryLanguage",
                newName: "IX_CountryLanguage_LanguageName");

            migrationBuilder.RenameColumn(
                name: "CitysId",
                table: "CityPerson",
                newName: "CitysName");

            migrationBuilder.RenameColumn(
                name: "LanguageId",
                table: "CityLanguage",
                newName: "LanguageName");

            migrationBuilder.RenameColumn(
                name: "CityId",
                table: "CityLanguage",
                newName: "CityName");

            migrationBuilder.RenameIndex(
                name: "IX_CityLanguage_LanguageId",
                table: "CityLanguage",
                newName: "IX_CityLanguage_LanguageName");

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "CityCountry",
                newName: "CountryName");

            migrationBuilder.RenameColumn(
                name: "CityId",
                table: "CityCountry",
                newName: "CityName");

            migrationBuilder.RenameIndex(
                name: "IX_CityCountry_CountryId",
                table: "CityCountry",
                newName: "IX_CityCountry_CountryName");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Person",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "EfterName",
                table: "Person",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LanguageName",
                table: "Person",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Language",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Country",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PostNumber",
                table: "City",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "City",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Language",
                table: "Language",
                column: "Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Country",
                table: "Country",
                column: "Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_City",
                table: "City",
                column: "Name");

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

            migrationBuilder.CreateIndex(
                name: "IX_Person_LanguageName",
                table: "Person",
                column: "LanguageName");

            migrationBuilder.AddForeignKey(
                name: "FK_CityCountry_City_CityName",
                table: "CityCountry",
                column: "CityName",
                principalTable: "City",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CityCountry_Country_CountryName",
                table: "CityCountry",
                column: "CountryName",
                principalTable: "Country",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CityLanguage_City_CityName",
                table: "CityLanguage",
                column: "CityName",
                principalTable: "City",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CityLanguage_Language_LanguageName",
                table: "CityLanguage",
                column: "LanguageName",
                principalTable: "Language",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CityPerson_City_CitysName",
                table: "CityPerson",
                column: "CitysName",
                principalTable: "City",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CountryLanguage_Country_CountryName",
                table: "CountryLanguage",
                column: "CountryName",
                principalTable: "Country",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CountryLanguage_Language_LanguageName",
                table: "CountryLanguage",
                column: "LanguageName",
                principalTable: "Language",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CountryPerson_Country_CountrysName",
                table: "CountryPerson",
                column: "CountrysName",
                principalTable: "Country",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Language_LanguageName",
                table: "Person",
                column: "LanguageName",
                principalTable: "Language",
                principalColumn: "Name");
        }
    }
}
